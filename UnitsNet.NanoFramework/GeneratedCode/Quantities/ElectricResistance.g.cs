//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     The electrical resistance of an electrical conductor is the opposition to the passage of an electric current through that conductor.
    /// </summary>
    public struct  ElectricResistance
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly QuantityValue _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricResistanceUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public QuantityValue Value => _value;

        /// <inheritdoc />
        public ElectricResistanceUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ElectricResistance(QuantityValue value, ElectricResistanceUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static ElectricResistanceUnit BaseUnit { get; } = ElectricResistanceUnit.Ohm;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static ElectricResistance MaxValue { get; } = new ElectricResistance(QuantityValue.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static ElectricResistance MinValue { get; } = new ElectricResistance(QuantityValue.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ElectricResistance Zero { get; } = new ElectricResistance(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricResistanceUnit.Gigaohm"/>
        /// </summary>
        public QuantityValue Gigaohms => As(ElectricResistanceUnit.Gigaohm);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricResistanceUnit.Kiloohm"/>
        /// </summary>
        public QuantityValue Kiloohms => As(ElectricResistanceUnit.Kiloohm);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricResistanceUnit.Megaohm"/>
        /// </summary>
        public QuantityValue Megaohms => As(ElectricResistanceUnit.Megaohm);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricResistanceUnit.Microohm"/>
        /// </summary>
        public QuantityValue Microohms => As(ElectricResistanceUnit.Microohm);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricResistanceUnit.Milliohm"/>
        /// </summary>
        public QuantityValue Milliohms => As(ElectricResistanceUnit.Milliohm);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricResistanceUnit.Ohm"/>
        /// </summary>
        public QuantityValue Ohms => As(ElectricResistanceUnit.Ohm);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ElectricResistance"/> from <see cref="ElectricResistanceUnit.Gigaohm"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistance FromGigaohms(QuantityValue gigaohms) => new ElectricResistance(gigaohms, ElectricResistanceUnit.Gigaohm);

        /// <summary>
        ///     Creates a <see cref="ElectricResistance"/> from <see cref="ElectricResistanceUnit.Kiloohm"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistance FromKiloohms(QuantityValue kiloohms) => new ElectricResistance(kiloohms, ElectricResistanceUnit.Kiloohm);

        /// <summary>
        ///     Creates a <see cref="ElectricResistance"/> from <see cref="ElectricResistanceUnit.Megaohm"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistance FromMegaohms(QuantityValue megaohms) => new ElectricResistance(megaohms, ElectricResistanceUnit.Megaohm);

        /// <summary>
        ///     Creates a <see cref="ElectricResistance"/> from <see cref="ElectricResistanceUnit.Microohm"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistance FromMicroohms(QuantityValue microohms) => new ElectricResistance(microohms, ElectricResistanceUnit.Microohm);

        /// <summary>
        ///     Creates a <see cref="ElectricResistance"/> from <see cref="ElectricResistanceUnit.Milliohm"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistance FromMilliohms(QuantityValue milliohms) => new ElectricResistance(milliohms, ElectricResistanceUnit.Milliohm);

        /// <summary>
        ///     Creates a <see cref="ElectricResistance"/> from <see cref="ElectricResistanceUnit.Ohm"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistance FromOhms(QuantityValue ohms) => new ElectricResistance(ohms, ElectricResistanceUnit.Ohm);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricResistanceUnit" /> to <see cref="ElectricResistance" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricResistance unit value.</returns>
        public static ElectricResistance From(QuantityValue value, ElectricResistanceUnit fromUnit)
        {
            return new ElectricResistance(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public QuantityValue As(ElectricResistanceUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public ElectricResistance ToUnit(ElectricResistanceUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new ElectricResistance(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private QuantityValue GetValueInBaseUnit()
        {
            return Unit switch
            {
                ElectricResistanceUnit.Gigaohm => (_value) * 1e9d,
                ElectricResistanceUnit.Kiloohm => (_value) * 1e3d,
                ElectricResistanceUnit.Megaohm => (_value) * 1e6d,
                ElectricResistanceUnit.Microohm => (_value) * 1e-6d,
                ElectricResistanceUnit.Milliohm => (_value) * 1e-3d,
                ElectricResistanceUnit.Ohm => _value,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private QuantityValue GetValueAs(ElectricResistanceUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                ElectricResistanceUnit.Gigaohm => (baseUnitValue) / 1e9d,
                ElectricResistanceUnit.Kiloohm => (baseUnitValue) / 1e3d,
                ElectricResistanceUnit.Megaohm => (baseUnitValue) / 1e6d,
                ElectricResistanceUnit.Microohm => (baseUnitValue) / 1e-6d,
                ElectricResistanceUnit.Milliohm => (baseUnitValue) / 1e-3d,
                ElectricResistanceUnit.Ohm => baseUnitValue,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion

    }
}

