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
    ///     In everyday use and in kinematics, the speed of an object is the magnitude of its velocity (the rate of change of its position); it is thus a scalar quantity.[1] The average speed of an object in an interval of time is the distance travelled by the object divided by the duration of the interval;[2] the instantaneous speed is the limit of the average speed as the duration of the time interval approaches zero.
    /// </summary>
    public struct  Speed
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly QuantityValue _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly SpeedUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public QuantityValue Value => _value;

        /// <inheritdoc />
        public SpeedUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Speed(QuantityValue value, SpeedUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static SpeedUnit BaseUnit { get; } = SpeedUnit.MeterPerSecond;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static Speed MaxValue { get; } = new Speed(QuantityValue.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static Speed MinValue { get; } = new Speed(QuantityValue.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Speed Zero { get; } = new Speed(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.CentimeterPerHour"/>
        /// </summary>
        public QuantityValue CentimetersPerHour => As(SpeedUnit.CentimeterPerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.CentimeterPerMinute"/>
        /// </summary>
        public QuantityValue CentimetersPerMinutes => As(SpeedUnit.CentimeterPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.CentimeterPerSecond"/>
        /// </summary>
        public QuantityValue CentimetersPerSecond => As(SpeedUnit.CentimeterPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.DecimeterPerMinute"/>
        /// </summary>
        public QuantityValue DecimetersPerMinutes => As(SpeedUnit.DecimeterPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.DecimeterPerSecond"/>
        /// </summary>
        public QuantityValue DecimetersPerSecond => As(SpeedUnit.DecimeterPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.FootPerHour"/>
        /// </summary>
        public QuantityValue FeetPerHour => As(SpeedUnit.FootPerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.FootPerMinute"/>
        /// </summary>
        public QuantityValue FeetPerMinute => As(SpeedUnit.FootPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.FootPerSecond"/>
        /// </summary>
        public QuantityValue FeetPerSecond => As(SpeedUnit.FootPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.InchPerHour"/>
        /// </summary>
        public QuantityValue InchesPerHour => As(SpeedUnit.InchPerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.InchPerMinute"/>
        /// </summary>
        public QuantityValue InchesPerMinute => As(SpeedUnit.InchPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.InchPerSecond"/>
        /// </summary>
        public QuantityValue InchesPerSecond => As(SpeedUnit.InchPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.KilometerPerHour"/>
        /// </summary>
        public QuantityValue KilometersPerHour => As(SpeedUnit.KilometerPerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.KilometerPerMinute"/>
        /// </summary>
        public QuantityValue KilometersPerMinutes => As(SpeedUnit.KilometerPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.KilometerPerSecond"/>
        /// </summary>
        public QuantityValue KilometersPerSecond => As(SpeedUnit.KilometerPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.Knot"/>
        /// </summary>
        public QuantityValue Knots => As(SpeedUnit.Knot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.MeterPerHour"/>
        /// </summary>
        public QuantityValue MetersPerHour => As(SpeedUnit.MeterPerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.MeterPerMinute"/>
        /// </summary>
        public QuantityValue MetersPerMinutes => As(SpeedUnit.MeterPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.MeterPerSecond"/>
        /// </summary>
        public QuantityValue MetersPerSecond => As(SpeedUnit.MeterPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.MicrometerPerMinute"/>
        /// </summary>
        public QuantityValue MicrometersPerMinutes => As(SpeedUnit.MicrometerPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.MicrometerPerSecond"/>
        /// </summary>
        public QuantityValue MicrometersPerSecond => As(SpeedUnit.MicrometerPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.MilePerHour"/>
        /// </summary>
        public QuantityValue MilesPerHour => As(SpeedUnit.MilePerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.MillimeterPerHour"/>
        /// </summary>
        public QuantityValue MillimetersPerHour => As(SpeedUnit.MillimeterPerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.MillimeterPerMinute"/>
        /// </summary>
        public QuantityValue MillimetersPerMinutes => As(SpeedUnit.MillimeterPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.MillimeterPerSecond"/>
        /// </summary>
        public QuantityValue MillimetersPerSecond => As(SpeedUnit.MillimeterPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.NanometerPerMinute"/>
        /// </summary>
        public QuantityValue NanometersPerMinutes => As(SpeedUnit.NanometerPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.NanometerPerSecond"/>
        /// </summary>
        public QuantityValue NanometersPerSecond => As(SpeedUnit.NanometerPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.UsSurveyFootPerHour"/>
        /// </summary>
        public QuantityValue UsSurveyFeetPerHour => As(SpeedUnit.UsSurveyFootPerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.UsSurveyFootPerMinute"/>
        /// </summary>
        public QuantityValue UsSurveyFeetPerMinute => As(SpeedUnit.UsSurveyFootPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.UsSurveyFootPerSecond"/>
        /// </summary>
        public QuantityValue UsSurveyFeetPerSecond => As(SpeedUnit.UsSurveyFootPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.YardPerHour"/>
        /// </summary>
        public QuantityValue YardsPerHour => As(SpeedUnit.YardPerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.YardPerMinute"/>
        /// </summary>
        public QuantityValue YardsPerMinute => As(SpeedUnit.YardPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpeedUnit.YardPerSecond"/>
        /// </summary>
        public QuantityValue YardsPerSecond => As(SpeedUnit.YardPerSecond);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.CentimeterPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromCentimetersPerHour(QuantityValue centimetersperhour) => new Speed(centimetersperhour, SpeedUnit.CentimeterPerHour);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.CentimeterPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromCentimetersPerMinutes(QuantityValue centimetersperminutes) => new Speed(centimetersperminutes, SpeedUnit.CentimeterPerMinute);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.CentimeterPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromCentimetersPerSecond(QuantityValue centimeterspersecond) => new Speed(centimeterspersecond, SpeedUnit.CentimeterPerSecond);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.DecimeterPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromDecimetersPerMinutes(QuantityValue decimetersperminutes) => new Speed(decimetersperminutes, SpeedUnit.DecimeterPerMinute);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.DecimeterPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromDecimetersPerSecond(QuantityValue decimeterspersecond) => new Speed(decimeterspersecond, SpeedUnit.DecimeterPerSecond);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.FootPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromFeetPerHour(QuantityValue feetperhour) => new Speed(feetperhour, SpeedUnit.FootPerHour);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.FootPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromFeetPerMinute(QuantityValue feetperminute) => new Speed(feetperminute, SpeedUnit.FootPerMinute);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.FootPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromFeetPerSecond(QuantityValue feetpersecond) => new Speed(feetpersecond, SpeedUnit.FootPerSecond);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.InchPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromInchesPerHour(QuantityValue inchesperhour) => new Speed(inchesperhour, SpeedUnit.InchPerHour);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.InchPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromInchesPerMinute(QuantityValue inchesperminute) => new Speed(inchesperminute, SpeedUnit.InchPerMinute);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.InchPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromInchesPerSecond(QuantityValue inchespersecond) => new Speed(inchespersecond, SpeedUnit.InchPerSecond);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.KilometerPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromKilometersPerHour(QuantityValue kilometersperhour) => new Speed(kilometersperhour, SpeedUnit.KilometerPerHour);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.KilometerPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromKilometersPerMinutes(QuantityValue kilometersperminutes) => new Speed(kilometersperminutes, SpeedUnit.KilometerPerMinute);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.KilometerPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromKilometersPerSecond(QuantityValue kilometerspersecond) => new Speed(kilometerspersecond, SpeedUnit.KilometerPerSecond);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.Knot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromKnots(QuantityValue knots) => new Speed(knots, SpeedUnit.Knot);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.MeterPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromMetersPerHour(QuantityValue metersperhour) => new Speed(metersperhour, SpeedUnit.MeterPerHour);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.MeterPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromMetersPerMinutes(QuantityValue metersperminutes) => new Speed(metersperminutes, SpeedUnit.MeterPerMinute);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.MeterPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromMetersPerSecond(QuantityValue meterspersecond) => new Speed(meterspersecond, SpeedUnit.MeterPerSecond);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.MicrometerPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromMicrometersPerMinutes(QuantityValue micrometersperminutes) => new Speed(micrometersperminutes, SpeedUnit.MicrometerPerMinute);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.MicrometerPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromMicrometersPerSecond(QuantityValue micrometerspersecond) => new Speed(micrometerspersecond, SpeedUnit.MicrometerPerSecond);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.MilePerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromMilesPerHour(QuantityValue milesperhour) => new Speed(milesperhour, SpeedUnit.MilePerHour);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.MillimeterPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromMillimetersPerHour(QuantityValue millimetersperhour) => new Speed(millimetersperhour, SpeedUnit.MillimeterPerHour);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.MillimeterPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromMillimetersPerMinutes(QuantityValue millimetersperminutes) => new Speed(millimetersperminutes, SpeedUnit.MillimeterPerMinute);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.MillimeterPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromMillimetersPerSecond(QuantityValue millimeterspersecond) => new Speed(millimeterspersecond, SpeedUnit.MillimeterPerSecond);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.NanometerPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromNanometersPerMinutes(QuantityValue nanometersperminutes) => new Speed(nanometersperminutes, SpeedUnit.NanometerPerMinute);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.NanometerPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromNanometersPerSecond(QuantityValue nanometerspersecond) => new Speed(nanometerspersecond, SpeedUnit.NanometerPerSecond);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.UsSurveyFootPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromUsSurveyFeetPerHour(QuantityValue ussurveyfeetperhour) => new Speed(ussurveyfeetperhour, SpeedUnit.UsSurveyFootPerHour);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.UsSurveyFootPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromUsSurveyFeetPerMinute(QuantityValue ussurveyfeetperminute) => new Speed(ussurveyfeetperminute, SpeedUnit.UsSurveyFootPerMinute);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.UsSurveyFootPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromUsSurveyFeetPerSecond(QuantityValue ussurveyfeetpersecond) => new Speed(ussurveyfeetpersecond, SpeedUnit.UsSurveyFootPerSecond);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.YardPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromYardsPerHour(QuantityValue yardsperhour) => new Speed(yardsperhour, SpeedUnit.YardPerHour);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.YardPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromYardsPerMinute(QuantityValue yardsperminute) => new Speed(yardsperminute, SpeedUnit.YardPerMinute);

        /// <summary>
        ///     Creates a <see cref="Speed"/> from <see cref="SpeedUnit.YardPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Speed FromYardsPerSecond(QuantityValue yardspersecond) => new Speed(yardspersecond, SpeedUnit.YardPerSecond);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="SpeedUnit" /> to <see cref="Speed" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Speed unit value.</returns>
        public static Speed From(QuantityValue value, SpeedUnit fromUnit)
        {
            return new Speed(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public QuantityValue As(SpeedUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public Speed ToUnit(SpeedUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new Speed(convertedValue, unit);
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
                SpeedUnit.CentimeterPerHour => (_value / 3600) * 1e-2d,
                SpeedUnit.CentimeterPerMinute => (_value / 60) * 1e-2d,
                SpeedUnit.CentimeterPerSecond => (_value) * 1e-2d,
                SpeedUnit.DecimeterPerMinute => (_value / 60) * 1e-1d,
                SpeedUnit.DecimeterPerSecond => (_value) * 1e-1d,
                SpeedUnit.FootPerHour => _value * 0.3048 / 3600,
                SpeedUnit.FootPerMinute => _value * 0.3048 / 60,
                SpeedUnit.FootPerSecond => _value * 0.3048,
                SpeedUnit.InchPerHour => (_value / 3600) * 2.54e-2,
                SpeedUnit.InchPerMinute => (_value / 60) * 2.54e-2,
                SpeedUnit.InchPerSecond => _value * 2.54e-2,
                SpeedUnit.KilometerPerHour => (_value / 3600) * 1e3d,
                SpeedUnit.KilometerPerMinute => (_value / 60) * 1e3d,
                SpeedUnit.KilometerPerSecond => (_value) * 1e3d,
                SpeedUnit.Knot => _value * 0.514444,
                SpeedUnit.MeterPerHour => _value / 3600,
                SpeedUnit.MeterPerMinute => _value / 60,
                SpeedUnit.MeterPerSecond => _value,
                SpeedUnit.MicrometerPerMinute => (_value / 60) * 1e-6d,
                SpeedUnit.MicrometerPerSecond => (_value) * 1e-6d,
                SpeedUnit.MilePerHour => _value * 0.44704,
                SpeedUnit.MillimeterPerHour => (_value / 3600) * 1e-3d,
                SpeedUnit.MillimeterPerMinute => (_value / 60) * 1e-3d,
                SpeedUnit.MillimeterPerSecond => (_value) * 1e-3d,
                SpeedUnit.NanometerPerMinute => (_value / 60) * 1e-9d,
                SpeedUnit.NanometerPerSecond => (_value) * 1e-9d,
                SpeedUnit.UsSurveyFootPerHour => (_value * 1200 / 3937) / 3600,
                SpeedUnit.UsSurveyFootPerMinute => (_value * 1200 / 3937) / 60,
                SpeedUnit.UsSurveyFootPerSecond => _value * 1200 / 3937,
                SpeedUnit.YardPerHour => _value * 0.9144 / 3600,
                SpeedUnit.YardPerMinute => _value * 0.9144 / 60,
                SpeedUnit.YardPerSecond => _value * 0.9144,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private QuantityValue GetValueAs(SpeedUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                SpeedUnit.CentimeterPerHour => (baseUnitValue * 3600) / 1e-2d,
                SpeedUnit.CentimeterPerMinute => (baseUnitValue * 60) / 1e-2d,
                SpeedUnit.CentimeterPerSecond => (baseUnitValue) / 1e-2d,
                SpeedUnit.DecimeterPerMinute => (baseUnitValue * 60) / 1e-1d,
                SpeedUnit.DecimeterPerSecond => (baseUnitValue) / 1e-1d,
                SpeedUnit.FootPerHour => baseUnitValue / 0.3048 * 3600,
                SpeedUnit.FootPerMinute => baseUnitValue / 0.3048 * 60,
                SpeedUnit.FootPerSecond => baseUnitValue / 0.3048,
                SpeedUnit.InchPerHour => (baseUnitValue / 2.54e-2) * 3600,
                SpeedUnit.InchPerMinute => (baseUnitValue / 2.54e-2) * 60,
                SpeedUnit.InchPerSecond => baseUnitValue / 2.54e-2,
                SpeedUnit.KilometerPerHour => (baseUnitValue * 3600) / 1e3d,
                SpeedUnit.KilometerPerMinute => (baseUnitValue * 60) / 1e3d,
                SpeedUnit.KilometerPerSecond => (baseUnitValue) / 1e3d,
                SpeedUnit.Knot => baseUnitValue / 0.514444,
                SpeedUnit.MeterPerHour => baseUnitValue * 3600,
                SpeedUnit.MeterPerMinute => baseUnitValue * 60,
                SpeedUnit.MeterPerSecond => baseUnitValue,
                SpeedUnit.MicrometerPerMinute => (baseUnitValue * 60) / 1e-6d,
                SpeedUnit.MicrometerPerSecond => (baseUnitValue) / 1e-6d,
                SpeedUnit.MilePerHour => baseUnitValue / 0.44704,
                SpeedUnit.MillimeterPerHour => (baseUnitValue * 3600) / 1e-3d,
                SpeedUnit.MillimeterPerMinute => (baseUnitValue * 60) / 1e-3d,
                SpeedUnit.MillimeterPerSecond => (baseUnitValue) / 1e-3d,
                SpeedUnit.NanometerPerMinute => (baseUnitValue * 60) / 1e-9d,
                SpeedUnit.NanometerPerSecond => (baseUnitValue) / 1e-9d,
                SpeedUnit.UsSurveyFootPerHour => (baseUnitValue * 3937 / 1200) * 3600,
                SpeedUnit.UsSurveyFootPerMinute => (baseUnitValue * 3937 / 1200) * 60,
                SpeedUnit.UsSurveyFootPerSecond => baseUnitValue * 3937 / 1200,
                SpeedUnit.YardPerHour => baseUnitValue / 0.9144 * 3600,
                SpeedUnit.YardPerMinute => baseUnitValue / 0.9144 * 60,
                SpeedUnit.YardPerSecond => baseUnitValue / 0.9144,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion

    }
}
