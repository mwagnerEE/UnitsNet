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
    ///     Time is a dimension in which events can be ordered from the past through the present into the future, and also the measure of durations of events and the intervals between them.
    /// </summary>
    public struct  Duration
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly QuantityValue _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly DurationUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public QuantityValue Value => _value;

        /// <inheritdoc />
        public DurationUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Duration(QuantityValue value, DurationUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static DurationUnit BaseUnit { get; } = DurationUnit.Second;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static Duration MaxValue { get; } = new Duration(QuantityValue.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static Duration MinValue { get; } = new Duration(QuantityValue.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Duration Zero { get; } = new Duration(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DurationUnit.Day"/>
        /// </summary>
        public QuantityValue Days => As(DurationUnit.Day);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DurationUnit.Hour"/>
        /// </summary>
        public QuantityValue Hours => As(DurationUnit.Hour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DurationUnit.JulianYear"/>
        /// </summary>
        public QuantityValue JulianYears => As(DurationUnit.JulianYear);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DurationUnit.Microsecond"/>
        /// </summary>
        public QuantityValue Microseconds => As(DurationUnit.Microsecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DurationUnit.Millisecond"/>
        /// </summary>
        public QuantityValue Milliseconds => As(DurationUnit.Millisecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DurationUnit.Minute"/>
        /// </summary>
        public QuantityValue Minutes => As(DurationUnit.Minute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DurationUnit.Month30"/>
        /// </summary>
        public QuantityValue Months30 => As(DurationUnit.Month30);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DurationUnit.Nanosecond"/>
        /// </summary>
        public QuantityValue Nanoseconds => As(DurationUnit.Nanosecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DurationUnit.Second"/>
        /// </summary>
        public QuantityValue Seconds => As(DurationUnit.Second);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DurationUnit.Week"/>
        /// </summary>
        public QuantityValue Weeks => As(DurationUnit.Week);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DurationUnit.Year365"/>
        /// </summary>
        public QuantityValue Years365 => As(DurationUnit.Year365);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Duration"/> from <see cref="DurationUnit.Day"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromDays(QuantityValue days) => new Duration(days, DurationUnit.Day);

        /// <summary>
        ///     Creates a <see cref="Duration"/> from <see cref="DurationUnit.Hour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromHours(QuantityValue hours) => new Duration(hours, DurationUnit.Hour);

        /// <summary>
        ///     Creates a <see cref="Duration"/> from <see cref="DurationUnit.JulianYear"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromJulianYears(QuantityValue julianyears) => new Duration(julianyears, DurationUnit.JulianYear);

        /// <summary>
        ///     Creates a <see cref="Duration"/> from <see cref="DurationUnit.Microsecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromMicroseconds(QuantityValue microseconds) => new Duration(microseconds, DurationUnit.Microsecond);

        /// <summary>
        ///     Creates a <see cref="Duration"/> from <see cref="DurationUnit.Millisecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromMilliseconds(QuantityValue milliseconds) => new Duration(milliseconds, DurationUnit.Millisecond);

        /// <summary>
        ///     Creates a <see cref="Duration"/> from <see cref="DurationUnit.Minute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromMinutes(QuantityValue minutes) => new Duration(minutes, DurationUnit.Minute);

        /// <summary>
        ///     Creates a <see cref="Duration"/> from <see cref="DurationUnit.Month30"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromMonths30(QuantityValue months30) => new Duration(months30, DurationUnit.Month30);

        /// <summary>
        ///     Creates a <see cref="Duration"/> from <see cref="DurationUnit.Nanosecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromNanoseconds(QuantityValue nanoseconds) => new Duration(nanoseconds, DurationUnit.Nanosecond);

        /// <summary>
        ///     Creates a <see cref="Duration"/> from <see cref="DurationUnit.Second"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromSeconds(QuantityValue seconds) => new Duration(seconds, DurationUnit.Second);

        /// <summary>
        ///     Creates a <see cref="Duration"/> from <see cref="DurationUnit.Week"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromWeeks(QuantityValue weeks) => new Duration(weeks, DurationUnit.Week);

        /// <summary>
        ///     Creates a <see cref="Duration"/> from <see cref="DurationUnit.Year365"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Duration FromYears365(QuantityValue years365) => new Duration(years365, DurationUnit.Year365);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="DurationUnit" /> to <see cref="Duration" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Duration unit value.</returns>
        public static Duration From(QuantityValue value, DurationUnit fromUnit)
        {
            return new Duration(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public QuantityValue As(DurationUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public Duration ToUnit(DurationUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new Duration(convertedValue, unit);
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
                DurationUnit.Day => _value * 24 * 3600,
                DurationUnit.Hour => _value * 3600,
                DurationUnit.JulianYear => _value * 365.25 * 24 * 3600,
                DurationUnit.Microsecond => (_value) * 1e-6d,
                DurationUnit.Millisecond => (_value) * 1e-3d,
                DurationUnit.Minute => _value * 60,
                DurationUnit.Month30 => _value * 30 * 24 * 3600,
                DurationUnit.Nanosecond => (_value) * 1e-9d,
                DurationUnit.Second => _value,
                DurationUnit.Week => _value * 7 * 24 * 3600,
                DurationUnit.Year365 => _value * 365 * 24 * 3600,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private QuantityValue GetValueAs(DurationUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                DurationUnit.Day => baseUnitValue / (24 * 3600),
                DurationUnit.Hour => baseUnitValue / 3600,
                DurationUnit.JulianYear => baseUnitValue / (365.25 * 24 * 3600),
                DurationUnit.Microsecond => (baseUnitValue) / 1e-6d,
                DurationUnit.Millisecond => (baseUnitValue) / 1e-3d,
                DurationUnit.Minute => baseUnitValue / 60,
                DurationUnit.Month30 => baseUnitValue / (30 * 24 * 3600),
                DurationUnit.Nanosecond => (baseUnitValue) / 1e-9d,
                DurationUnit.Second => baseUnitValue,
                DurationUnit.Week => baseUnitValue / (7 * 24 * 3600),
                DurationUnit.Year365 => baseUnitValue / (365 * 24 * 3600),
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion

    }
}

