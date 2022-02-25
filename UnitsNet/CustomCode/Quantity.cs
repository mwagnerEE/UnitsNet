﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using UnitsNet.InternalHelpers;

namespace UnitsNet
{
    public partial class Quantity
    {
        private static readonly Lazy<QuantityInfo[]> InfosLazy;
        private static readonly Lazy<Dictionary<(Type, string), UnitInfo>> UnitTypeAndNameToUnitInfoLazy;

        static Quantity()
        {
            ICollection<QuantityInfo> quantityInfos = ByName.Values;
            //Types = Enum.GetValues(typeof(QuantityType)).Cast<QuantityType>().Except(new[] { QuantityType.Undefined }).ToArray();
            Names = quantityInfos.Select(qt => qt.Name).ToArray();

            InfosLazy = new Lazy<QuantityInfo[]>(() => quantityInfos
                .OrderBy(quantityInfo => quantityInfo.Name)
                .ToArray());

            UnitTypeAndNameToUnitInfoLazy = new Lazy<Dictionary<(Type, string), UnitInfo>>(() =>
            {
                return Infos
                    .SelectMany(quantityInfo => quantityInfo.UnitInfos
                        .Select(unitInfo => new KeyValuePair<(Type, string), UnitInfo>(
                            (unitInfo.Value.GetType(), unitInfo.Name),
                            unitInfo)))
                    .ToDictionary(x => x.Key, x => x.Value);
            });
        }

        ///// <summary>
        ///// All enum values of <see cref="QuantityType"/>, such as <see cref="QuantityType.Length"/> and <see cref="QuantityType.Mass"/>.
        ///// </summary>
        //[Obsolete("QuantityType will be removed in the future. Use Infos property instead.")]
        //public static QuantityType[] Types { get; }

        /// <summary>
        /// All enum value names of <see cref="Infos"/>, such as "Length" and "Mass".
        /// </summary>
        public static string[] Names { get; }

        /// <summary>
        /// All quantity information objects, such as <see cref="Length.Info"/> and <see cref="Mass.Info"/>.
        /// </summary>
        public static QuantityInfo[] Infos => InfosLazy.Value;

        /// <summary>
        /// Get <see cref="UnitInfo"/> for a given unit enum value.
        /// </summary>
        public static UnitInfo GetUnitInfo(Enum unitEnum) => UnitTypeAndNameToUnitInfoLazy.Value[(unitEnum.GetType(), unitEnum.ToString())];

        /// <summary>
        /// Try to get <see cref="UnitInfo"/> for a given unit enum value.
        /// </summary>
        public static bool TryGetUnitInfo(Enum unitEnum, out UnitInfo unitInfo) =>
            UnitTypeAndNameToUnitInfoLazy.Value.TryGetValue((unitEnum.GetType(), unitEnum.ToString()), out unitInfo);

        /// <summary>
        ///     Dynamically construct a quantity.
        /// </summary>
        /// <param name="value">Numeric value.</param>
        /// <param name="unit">Unit enum value.</param>
        /// <returns>An <see cref="IQuantity"/> object.</returns>
        /// <exception cref="ArgumentException">Unit value is not a know unit enum type.</exception>
        public static IQuantity From(QuantityValue value, Enum unit)
        {
            if (TryFrom(value, unit, out IQuantity? quantity))
                return quantity!;

            throw new ArgumentException(
                $"Unit value {unit} of type {unit.GetType()} is not a known unit enum type. Expected types like UnitsNet.Units.LengthUnit. Did you pass in a third-party enum type defined outside UnitsNet library?");
        }

        /// <summary>
        ///     Dynamically construct a quantity. If a quantity with those base dimensions is not found a 'nameless' quantity will be returned.
        /// </summary>
        /// <param name="value">Numeric value.</param>
        /// <param name="dimensions">The base dimensions.</param>
        /// <returns>A named Quantity if one with matching dimensions exists, otherwise a 'nameless' <see cref="QuantityBase"/> with the given <paramref name="dimensions"/>.</returns>
        public static QuantityBase FromOrNameless(QuantityValue value, Dimensions dimensions)
        {
            if (TryFrom(value, dimensions, out IQuantity? quantity))
                return (QuantityBase)quantity!;
            return CreateNamelessQuantity(value, dimensions);
        }

        /// <summary>
        ///     Dynamically construct a nameless quantity.
        ///     A nameless quantity value must be in terms of base SI units.
        /// </summary>
        /// <param name="value">Numeric value.</param>
        /// <param name="dimensions">The base dimensions.</param>
        /// <returns>A 'nameless' <see cref="QuantityBase"/> with the given <paramref name="dimensions"/>.</returns>
        private static QuantityBase CreateNamelessQuantity(QuantityValue value, Dimensions dimensions)
        {
            return new QuantityBase(value, dimensions);
        }

        /// <inheritdoc cref="TryFrom(QuantityValue,System.Enum,out UnitsNet.IQuantity)"/>
        public static bool TryFrom(double value, Enum unit, out IQuantity? quantity)
        {
            // Implicit cast to QuantityValue would prevent TryFrom from being called,
            // so we need to explicitly check this here for double arguments.
            if (double.IsNaN(value) || double.IsInfinity(value))
            {
                quantity = default(IQuantity);
                return false;
            }

            return TryFrom((QuantityValue)value, unit, out quantity);
        }


        /// <inheritdoc cref="TryFrom(QuantityValue,System.Enum,out UnitsNet.IQuantity)"/>
        public static bool TryFrom(double value, Dimensions dimensions, out IQuantity? quantity)
        {
            // Implicit cast to QuantityValue would prevent TryFrom from being called,
            // so we need to explicitly check this here for double arguments.
            if (double.IsNaN(value) || double.IsInfinity(value))
            {
                quantity = default(IQuantity);
                return false;
            }

            return TryFrom((QuantityValue)value, dimensions, out quantity);
        }

        /// <inheritdoc cref="Parse(IFormatProvider, System.Type,string)"/>
        public static IQuantity Parse(Type quantityType, string quantityString) => Parse(null, quantityType, quantityString);

        /// <summary>
        ///     Dynamically parse a quantity string representation.
        /// </summary>
        /// <param name="formatProvider">The format provider to use for lookup. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        /// <param name="quantityType">Type of quantity, such as <see cref="Length"/>.</param>
        /// <param name="quantityString">Quantity string representation, such as "1.5 kg". Must be compatible with given quantity type.</param>
        /// <returns>The parsed quantity.</returns>
        /// <exception cref="ArgumentException">Type must be of type UnitsNet.IQuantity -or- Type is not a known quantity type.</exception>
        public static IQuantity Parse(IFormatProvider? formatProvider, Type quantityType, string quantityString)
        {
            if (!typeof(IQuantity).Wrap().IsAssignableFrom(quantityType))
                throw new ArgumentException($"Type {quantityType} must be of type UnitsNet.IQuantity.");

            if (TryParse(formatProvider, quantityType, quantityString, out IQuantity? quantity))
                return quantity!;

            throw new ArgumentException($"Quantity string could not be parsed to quantity {quantityType}.");
        }

        /// <inheritdoc cref="TryParse(IFormatProvider,System.Type,string,out UnitsNet.IQuantity)"/>
        public static bool TryParse(Type quantityType, string quantityString, out IQuantity? quantity) =>
            TryParse(null, quantityType, quantityString, out quantity);


        /// <summary>
        ///     Get a list of quantities that has the given base dimensions.
        /// </summary>
        /// <param name="baseDimensions">The base dimensions to match.</param>
        public static IEnumerable<QuantityInfo> GetQuantitiesWithBaseDimensions(BaseDimensions baseDimensions)
        {
            return InfosLazy.Value.Where(info => info.Dimensions.Equals(baseDimensions));
        }
    }
}
