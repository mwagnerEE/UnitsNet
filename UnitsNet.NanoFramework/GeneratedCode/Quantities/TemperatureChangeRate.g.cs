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
    ///     Temperature change rate is the ratio of the temperature change to the time during which the change occurred (value of temperature changes per unit time).
    /// </summary>
    public struct  TemperatureChangeRate
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly QuantityValue _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly TemperatureChangeRateUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public QuantityValue Value => _value;

        /// <inheritdoc />
        public TemperatureChangeRateUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public TemperatureChangeRate(QuantityValue value, TemperatureChangeRateUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static TemperatureChangeRateUnit BaseUnit { get; } = TemperatureChangeRateUnit.DegreeCelsiusPerSecond;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static TemperatureChangeRate MaxValue { get; } = new TemperatureChangeRate(QuantityValue.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static TemperatureChangeRate MinValue { get; } = new TemperatureChangeRate(QuantityValue.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static TemperatureChangeRate Zero { get; } = new TemperatureChangeRate(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond"/>
        /// </summary>
        public QuantityValue CentidegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond"/>
        /// </summary>
        public QuantityValue DecadegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond"/>
        /// </summary>
        public QuantityValue DecidegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureChangeRateUnit.DegreeCelsiusPerMinute"/>
        /// </summary>
        public QuantityValue DegreesCelsiusPerMinute => As(TemperatureChangeRateUnit.DegreeCelsiusPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureChangeRateUnit.DegreeCelsiusPerSecond"/>
        /// </summary>
        public QuantityValue DegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.DegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond"/>
        /// </summary>
        public QuantityValue HectodegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond"/>
        /// </summary>
        public QuantityValue KilodegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond"/>
        /// </summary>
        public QuantityValue MicrodegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond"/>
        /// </summary>
        public QuantityValue MillidegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond"/>
        /// </summary>
        public QuantityValue NanodegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="TemperatureChangeRate"/> from <see cref="TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromCentidegreesCelsiusPerSecond(QuantityValue centidegreescelsiuspersecond) => new TemperatureChangeRate(centidegreescelsiuspersecond, TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond);

        /// <summary>
        ///     Creates a <see cref="TemperatureChangeRate"/> from <see cref="TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromDecadegreesCelsiusPerSecond(QuantityValue decadegreescelsiuspersecond) => new TemperatureChangeRate(decadegreescelsiuspersecond, TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond);

        /// <summary>
        ///     Creates a <see cref="TemperatureChangeRate"/> from <see cref="TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromDecidegreesCelsiusPerSecond(QuantityValue decidegreescelsiuspersecond) => new TemperatureChangeRate(decidegreescelsiuspersecond, TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond);

        /// <summary>
        ///     Creates a <see cref="TemperatureChangeRate"/> from <see cref="TemperatureChangeRateUnit.DegreeCelsiusPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromDegreesCelsiusPerMinute(QuantityValue degreescelsiusperminute) => new TemperatureChangeRate(degreescelsiusperminute, TemperatureChangeRateUnit.DegreeCelsiusPerMinute);

        /// <summary>
        ///     Creates a <see cref="TemperatureChangeRate"/> from <see cref="TemperatureChangeRateUnit.DegreeCelsiusPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromDegreesCelsiusPerSecond(QuantityValue degreescelsiuspersecond) => new TemperatureChangeRate(degreescelsiuspersecond, TemperatureChangeRateUnit.DegreeCelsiusPerSecond);

        /// <summary>
        ///     Creates a <see cref="TemperatureChangeRate"/> from <see cref="TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromHectodegreesCelsiusPerSecond(QuantityValue hectodegreescelsiuspersecond) => new TemperatureChangeRate(hectodegreescelsiuspersecond, TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond);

        /// <summary>
        ///     Creates a <see cref="TemperatureChangeRate"/> from <see cref="TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromKilodegreesCelsiusPerSecond(QuantityValue kilodegreescelsiuspersecond) => new TemperatureChangeRate(kilodegreescelsiuspersecond, TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond);

        /// <summary>
        ///     Creates a <see cref="TemperatureChangeRate"/> from <see cref="TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromMicrodegreesCelsiusPerSecond(QuantityValue microdegreescelsiuspersecond) => new TemperatureChangeRate(microdegreescelsiuspersecond, TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond);

        /// <summary>
        ///     Creates a <see cref="TemperatureChangeRate"/> from <see cref="TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromMillidegreesCelsiusPerSecond(QuantityValue millidegreescelsiuspersecond) => new TemperatureChangeRate(millidegreescelsiuspersecond, TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond);

        /// <summary>
        ///     Creates a <see cref="TemperatureChangeRate"/> from <see cref="TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromNanodegreesCelsiusPerSecond(QuantityValue nanodegreescelsiuspersecond) => new TemperatureChangeRate(nanodegreescelsiuspersecond, TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="TemperatureChangeRateUnit" /> to <see cref="TemperatureChangeRate" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>TemperatureChangeRate unit value.</returns>
        public static TemperatureChangeRate From(QuantityValue value, TemperatureChangeRateUnit fromUnit)
        {
            return new TemperatureChangeRate(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public QuantityValue As(TemperatureChangeRateUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public TemperatureChangeRate ToUnit(TemperatureChangeRateUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new TemperatureChangeRate(convertedValue, unit);
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
                TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond => (_value) * 1e-2d,
                TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond => (_value) * 1e1d,
                TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond => (_value) * 1e-1d,
                TemperatureChangeRateUnit.DegreeCelsiusPerMinute => _value / 60,
                TemperatureChangeRateUnit.DegreeCelsiusPerSecond => _value,
                TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond => (_value) * 1e2d,
                TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond => (_value) * 1e3d,
                TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond => (_value) * 1e-6d,
                TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond => (_value) * 1e-3d,
                TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond => (_value) * 1e-9d,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private QuantityValue GetValueAs(TemperatureChangeRateUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond => (baseUnitValue) / 1e-2d,
                TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond => (baseUnitValue) / 1e1d,
                TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond => (baseUnitValue) / 1e-1d,
                TemperatureChangeRateUnit.DegreeCelsiusPerMinute => baseUnitValue * 60,
                TemperatureChangeRateUnit.DegreeCelsiusPerSecond => baseUnitValue,
                TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond => (baseUnitValue) / 1e2d,
                TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond => (baseUnitValue) / 1e3d,
                TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond => (baseUnitValue) / 1e-6d,
                TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond => (baseUnitValue) / 1e-3d,
                TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond => (baseUnitValue) / 1e-9d,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion

    }
}

