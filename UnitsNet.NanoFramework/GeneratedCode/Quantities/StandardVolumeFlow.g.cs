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
    ///     The molar flow rate of a gas corrected to standardized conditions of temperature and pressure thus representing a fixed number of moles of gas regardless of composition and actual flow conditions.
    /// </summary>
    public struct  StandardVolumeFlow
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly QuantityValue _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly StandardVolumeFlowUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public QuantityValue Value => _value;

        /// <inheritdoc />
        public StandardVolumeFlowUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public StandardVolumeFlow(QuantityValue value, StandardVolumeFlowUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static StandardVolumeFlowUnit BaseUnit { get; } = StandardVolumeFlowUnit.StandardCubicMeterPerSecond;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static StandardVolumeFlow MaxValue { get; } = new StandardVolumeFlow(QuantityValue.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static StandardVolumeFlow MinValue { get; } = new StandardVolumeFlow(QuantityValue.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static StandardVolumeFlow Zero { get; } = new StandardVolumeFlow(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="StandardVolumeFlowUnit.StandardCubicCentimeterPerMinute"/>
        /// </summary>
        public QuantityValue StandardCubicCentimetersPerMinute => As(StandardVolumeFlowUnit.StandardCubicCentimeterPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="StandardVolumeFlowUnit.StandardCubicFootPerHour"/>
        /// </summary>
        public QuantityValue StandardCubicFeetPerHour => As(StandardVolumeFlowUnit.StandardCubicFootPerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="StandardVolumeFlowUnit.StandardCubicFootPerMinute"/>
        /// </summary>
        public QuantityValue StandardCubicFeetPerMinute => As(StandardVolumeFlowUnit.StandardCubicFootPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="StandardVolumeFlowUnit.StandardCubicFootPerSecond"/>
        /// </summary>
        public QuantityValue StandardCubicFeetPerSecond => As(StandardVolumeFlowUnit.StandardCubicFootPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="StandardVolumeFlowUnit.StandardCubicMeterPerDay"/>
        /// </summary>
        public QuantityValue StandardCubicMetersPerDay => As(StandardVolumeFlowUnit.StandardCubicMeterPerDay);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="StandardVolumeFlowUnit.StandardCubicMeterPerHour"/>
        /// </summary>
        public QuantityValue StandardCubicMetersPerHour => As(StandardVolumeFlowUnit.StandardCubicMeterPerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="StandardVolumeFlowUnit.StandardCubicMeterPerMinute"/>
        /// </summary>
        public QuantityValue StandardCubicMetersPerMinute => As(StandardVolumeFlowUnit.StandardCubicMeterPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="StandardVolumeFlowUnit.StandardCubicMeterPerSecond"/>
        /// </summary>
        public QuantityValue StandardCubicMetersPerSecond => As(StandardVolumeFlowUnit.StandardCubicMeterPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="StandardVolumeFlowUnit.StandardLiterPerMinute"/>
        /// </summary>
        public QuantityValue StandardLitersPerMinute => As(StandardVolumeFlowUnit.StandardLiterPerMinute);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="StandardVolumeFlow"/> from <see cref="StandardVolumeFlowUnit.StandardCubicCentimeterPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static StandardVolumeFlow FromStandardCubicCentimetersPerMinute(QuantityValue standardcubiccentimetersperminute) => new StandardVolumeFlow(standardcubiccentimetersperminute, StandardVolumeFlowUnit.StandardCubicCentimeterPerMinute);

        /// <summary>
        ///     Creates a <see cref="StandardVolumeFlow"/> from <see cref="StandardVolumeFlowUnit.StandardCubicFootPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static StandardVolumeFlow FromStandardCubicFeetPerHour(QuantityValue standardcubicfeetperhour) => new StandardVolumeFlow(standardcubicfeetperhour, StandardVolumeFlowUnit.StandardCubicFootPerHour);

        /// <summary>
        ///     Creates a <see cref="StandardVolumeFlow"/> from <see cref="StandardVolumeFlowUnit.StandardCubicFootPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static StandardVolumeFlow FromStandardCubicFeetPerMinute(QuantityValue standardcubicfeetperminute) => new StandardVolumeFlow(standardcubicfeetperminute, StandardVolumeFlowUnit.StandardCubicFootPerMinute);

        /// <summary>
        ///     Creates a <see cref="StandardVolumeFlow"/> from <see cref="StandardVolumeFlowUnit.StandardCubicFootPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static StandardVolumeFlow FromStandardCubicFeetPerSecond(QuantityValue standardcubicfeetpersecond) => new StandardVolumeFlow(standardcubicfeetpersecond, StandardVolumeFlowUnit.StandardCubicFootPerSecond);

        /// <summary>
        ///     Creates a <see cref="StandardVolumeFlow"/> from <see cref="StandardVolumeFlowUnit.StandardCubicMeterPerDay"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static StandardVolumeFlow FromStandardCubicMetersPerDay(QuantityValue standardcubicmetersperday) => new StandardVolumeFlow(standardcubicmetersperday, StandardVolumeFlowUnit.StandardCubicMeterPerDay);

        /// <summary>
        ///     Creates a <see cref="StandardVolumeFlow"/> from <see cref="StandardVolumeFlowUnit.StandardCubicMeterPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static StandardVolumeFlow FromStandardCubicMetersPerHour(QuantityValue standardcubicmetersperhour) => new StandardVolumeFlow(standardcubicmetersperhour, StandardVolumeFlowUnit.StandardCubicMeterPerHour);

        /// <summary>
        ///     Creates a <see cref="StandardVolumeFlow"/> from <see cref="StandardVolumeFlowUnit.StandardCubicMeterPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static StandardVolumeFlow FromStandardCubicMetersPerMinute(QuantityValue standardcubicmetersperminute) => new StandardVolumeFlow(standardcubicmetersperminute, StandardVolumeFlowUnit.StandardCubicMeterPerMinute);

        /// <summary>
        ///     Creates a <see cref="StandardVolumeFlow"/> from <see cref="StandardVolumeFlowUnit.StandardCubicMeterPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static StandardVolumeFlow FromStandardCubicMetersPerSecond(QuantityValue standardcubicmeterspersecond) => new StandardVolumeFlow(standardcubicmeterspersecond, StandardVolumeFlowUnit.StandardCubicMeterPerSecond);

        /// <summary>
        ///     Creates a <see cref="StandardVolumeFlow"/> from <see cref="StandardVolumeFlowUnit.StandardLiterPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static StandardVolumeFlow FromStandardLitersPerMinute(QuantityValue standardlitersperminute) => new StandardVolumeFlow(standardlitersperminute, StandardVolumeFlowUnit.StandardLiterPerMinute);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="StandardVolumeFlowUnit" /> to <see cref="StandardVolumeFlow" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>StandardVolumeFlow unit value.</returns>
        public static StandardVolumeFlow From(QuantityValue value, StandardVolumeFlowUnit fromUnit)
        {
            return new StandardVolumeFlow(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public QuantityValue As(StandardVolumeFlowUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public StandardVolumeFlow ToUnit(StandardVolumeFlowUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new StandardVolumeFlow(convertedValue, unit);
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
                StandardVolumeFlowUnit.StandardCubicCentimeterPerMinute => _value / 6e7,
                StandardVolumeFlowUnit.StandardCubicFootPerHour => _value * 7.8657907199999087346816086183876e-6,
                StandardVolumeFlowUnit.StandardCubicFootPerMinute => _value / 2118.88000326,
                StandardVolumeFlowUnit.StandardCubicFootPerSecond => _value / 35.314666721,
                StandardVolumeFlowUnit.StandardCubicMeterPerDay => _value / 86400,
                StandardVolumeFlowUnit.StandardCubicMeterPerHour => _value / 3600,
                StandardVolumeFlowUnit.StandardCubicMeterPerMinute => _value / 60,
                StandardVolumeFlowUnit.StandardCubicMeterPerSecond => _value,
                StandardVolumeFlowUnit.StandardLiterPerMinute => _value / 60000,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private QuantityValue GetValueAs(StandardVolumeFlowUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                StandardVolumeFlowUnit.StandardCubicCentimeterPerMinute => baseUnitValue * 6e7,
                StandardVolumeFlowUnit.StandardCubicFootPerHour => baseUnitValue / 7.8657907199999087346816086183876e-6,
                StandardVolumeFlowUnit.StandardCubicFootPerMinute => baseUnitValue * 2118.88000326,
                StandardVolumeFlowUnit.StandardCubicFootPerSecond => baseUnitValue * 35.314666721,
                StandardVolumeFlowUnit.StandardCubicMeterPerDay => baseUnitValue * 86400,
                StandardVolumeFlowUnit.StandardCubicMeterPerHour => baseUnitValue * 3600,
                StandardVolumeFlowUnit.StandardCubicMeterPerMinute => baseUnitValue * 60,
                StandardVolumeFlowUnit.StandardCubicMeterPerSecond => baseUnitValue,
                StandardVolumeFlowUnit.StandardLiterPerMinute => baseUnitValue * 60000,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion

    }
}
