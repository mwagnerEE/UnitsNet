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
    ///     The SpecificWeight, or more precisely, the volumetric weight density, of a substance is its weight per unit volume.
    /// </summary>
    /// <remarks>
    ///     http://en.wikipedia.org/wiki/Specificweight
    /// </remarks>
    public struct  SpecificWeight
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly QuantityValue _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly SpecificWeightUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public QuantityValue Value => _value;

        /// <inheritdoc />
        public SpecificWeightUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public SpecificWeight(QuantityValue value, SpecificWeightUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static SpecificWeightUnit BaseUnit { get; } = SpecificWeightUnit.NewtonPerCubicMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static SpecificWeight MaxValue { get; } = new SpecificWeight(QuantityValue.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static SpecificWeight MinValue { get; } = new SpecificWeight(QuantityValue.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static SpecificWeight Zero { get; } = new SpecificWeight(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpecificWeightUnit.KilogramForcePerCubicCentimeter"/>
        /// </summary>
        public QuantityValue KilogramsForcePerCubicCentimeter => As(SpecificWeightUnit.KilogramForcePerCubicCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpecificWeightUnit.KilogramForcePerCubicMeter"/>
        /// </summary>
        public QuantityValue KilogramsForcePerCubicMeter => As(SpecificWeightUnit.KilogramForcePerCubicMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpecificWeightUnit.KilogramForcePerCubicMillimeter"/>
        /// </summary>
        public QuantityValue KilogramsForcePerCubicMillimeter => As(SpecificWeightUnit.KilogramForcePerCubicMillimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpecificWeightUnit.KilonewtonPerCubicCentimeter"/>
        /// </summary>
        public QuantityValue KilonewtonsPerCubicCentimeter => As(SpecificWeightUnit.KilonewtonPerCubicCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpecificWeightUnit.KilonewtonPerCubicMeter"/>
        /// </summary>
        public QuantityValue KilonewtonsPerCubicMeter => As(SpecificWeightUnit.KilonewtonPerCubicMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpecificWeightUnit.KilonewtonPerCubicMillimeter"/>
        /// </summary>
        public QuantityValue KilonewtonsPerCubicMillimeter => As(SpecificWeightUnit.KilonewtonPerCubicMillimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpecificWeightUnit.KilopoundForcePerCubicFoot"/>
        /// </summary>
        public QuantityValue KilopoundsForcePerCubicFoot => As(SpecificWeightUnit.KilopoundForcePerCubicFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpecificWeightUnit.KilopoundForcePerCubicInch"/>
        /// </summary>
        public QuantityValue KilopoundsForcePerCubicInch => As(SpecificWeightUnit.KilopoundForcePerCubicInch);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpecificWeightUnit.MeganewtonPerCubicMeter"/>
        /// </summary>
        public QuantityValue MeganewtonsPerCubicMeter => As(SpecificWeightUnit.MeganewtonPerCubicMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpecificWeightUnit.NewtonPerCubicCentimeter"/>
        /// </summary>
        public QuantityValue NewtonsPerCubicCentimeter => As(SpecificWeightUnit.NewtonPerCubicCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpecificWeightUnit.NewtonPerCubicMeter"/>
        /// </summary>
        public QuantityValue NewtonsPerCubicMeter => As(SpecificWeightUnit.NewtonPerCubicMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpecificWeightUnit.NewtonPerCubicMillimeter"/>
        /// </summary>
        public QuantityValue NewtonsPerCubicMillimeter => As(SpecificWeightUnit.NewtonPerCubicMillimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpecificWeightUnit.PoundForcePerCubicFoot"/>
        /// </summary>
        public QuantityValue PoundsForcePerCubicFoot => As(SpecificWeightUnit.PoundForcePerCubicFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpecificWeightUnit.PoundForcePerCubicInch"/>
        /// </summary>
        public QuantityValue PoundsForcePerCubicInch => As(SpecificWeightUnit.PoundForcePerCubicInch);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpecificWeightUnit.TonneForcePerCubicCentimeter"/>
        /// </summary>
        public QuantityValue TonnesForcePerCubicCentimeter => As(SpecificWeightUnit.TonneForcePerCubicCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpecificWeightUnit.TonneForcePerCubicMeter"/>
        /// </summary>
        public QuantityValue TonnesForcePerCubicMeter => As(SpecificWeightUnit.TonneForcePerCubicMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="SpecificWeightUnit.TonneForcePerCubicMillimeter"/>
        /// </summary>
        public QuantityValue TonnesForcePerCubicMillimeter => As(SpecificWeightUnit.TonneForcePerCubicMillimeter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.KilogramForcePerCubicCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromKilogramsForcePerCubicCentimeter(QuantityValue kilogramsforcepercubiccentimeter) => new SpecificWeight(kilogramsforcepercubiccentimeter, SpecificWeightUnit.KilogramForcePerCubicCentimeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.KilogramForcePerCubicMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromKilogramsForcePerCubicMeter(QuantityValue kilogramsforcepercubicmeter) => new SpecificWeight(kilogramsforcepercubicmeter, SpecificWeightUnit.KilogramForcePerCubicMeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.KilogramForcePerCubicMillimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromKilogramsForcePerCubicMillimeter(QuantityValue kilogramsforcepercubicmillimeter) => new SpecificWeight(kilogramsforcepercubicmillimeter, SpecificWeightUnit.KilogramForcePerCubicMillimeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.KilonewtonPerCubicCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromKilonewtonsPerCubicCentimeter(QuantityValue kilonewtonspercubiccentimeter) => new SpecificWeight(kilonewtonspercubiccentimeter, SpecificWeightUnit.KilonewtonPerCubicCentimeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.KilonewtonPerCubicMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromKilonewtonsPerCubicMeter(QuantityValue kilonewtonspercubicmeter) => new SpecificWeight(kilonewtonspercubicmeter, SpecificWeightUnit.KilonewtonPerCubicMeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.KilonewtonPerCubicMillimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromKilonewtonsPerCubicMillimeter(QuantityValue kilonewtonspercubicmillimeter) => new SpecificWeight(kilonewtonspercubicmillimeter, SpecificWeightUnit.KilonewtonPerCubicMillimeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.KilopoundForcePerCubicFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromKilopoundsForcePerCubicFoot(QuantityValue kilopoundsforcepercubicfoot) => new SpecificWeight(kilopoundsforcepercubicfoot, SpecificWeightUnit.KilopoundForcePerCubicFoot);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.KilopoundForcePerCubicInch"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromKilopoundsForcePerCubicInch(QuantityValue kilopoundsforcepercubicinch) => new SpecificWeight(kilopoundsforcepercubicinch, SpecificWeightUnit.KilopoundForcePerCubicInch);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.MeganewtonPerCubicMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromMeganewtonsPerCubicMeter(QuantityValue meganewtonspercubicmeter) => new SpecificWeight(meganewtonspercubicmeter, SpecificWeightUnit.MeganewtonPerCubicMeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.NewtonPerCubicCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromNewtonsPerCubicCentimeter(QuantityValue newtonspercubiccentimeter) => new SpecificWeight(newtonspercubiccentimeter, SpecificWeightUnit.NewtonPerCubicCentimeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.NewtonPerCubicMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromNewtonsPerCubicMeter(QuantityValue newtonspercubicmeter) => new SpecificWeight(newtonspercubicmeter, SpecificWeightUnit.NewtonPerCubicMeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.NewtonPerCubicMillimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromNewtonsPerCubicMillimeter(QuantityValue newtonspercubicmillimeter) => new SpecificWeight(newtonspercubicmillimeter, SpecificWeightUnit.NewtonPerCubicMillimeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.PoundForcePerCubicFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromPoundsForcePerCubicFoot(QuantityValue poundsforcepercubicfoot) => new SpecificWeight(poundsforcepercubicfoot, SpecificWeightUnit.PoundForcePerCubicFoot);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.PoundForcePerCubicInch"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromPoundsForcePerCubicInch(QuantityValue poundsforcepercubicinch) => new SpecificWeight(poundsforcepercubicinch, SpecificWeightUnit.PoundForcePerCubicInch);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.TonneForcePerCubicCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromTonnesForcePerCubicCentimeter(QuantityValue tonnesforcepercubiccentimeter) => new SpecificWeight(tonnesforcepercubiccentimeter, SpecificWeightUnit.TonneForcePerCubicCentimeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.TonneForcePerCubicMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromTonnesForcePerCubicMeter(QuantityValue tonnesforcepercubicmeter) => new SpecificWeight(tonnesforcepercubicmeter, SpecificWeightUnit.TonneForcePerCubicMeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.TonneForcePerCubicMillimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromTonnesForcePerCubicMillimeter(QuantityValue tonnesforcepercubicmillimeter) => new SpecificWeight(tonnesforcepercubicmillimeter, SpecificWeightUnit.TonneForcePerCubicMillimeter);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="SpecificWeightUnit" /> to <see cref="SpecificWeight" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>SpecificWeight unit value.</returns>
        public static SpecificWeight From(QuantityValue value, SpecificWeightUnit fromUnit)
        {
            return new SpecificWeight(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public QuantityValue As(SpecificWeightUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public SpecificWeight ToUnit(SpecificWeightUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new SpecificWeight(convertedValue, unit);
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
                SpecificWeightUnit.KilogramForcePerCubicCentimeter => _value * 9.80665e6,
                SpecificWeightUnit.KilogramForcePerCubicMeter => _value * 9.80665,
                SpecificWeightUnit.KilogramForcePerCubicMillimeter => _value * 9.80665e9,
                SpecificWeightUnit.KilonewtonPerCubicCentimeter => (_value * 1000000) * 1e3d,
                SpecificWeightUnit.KilonewtonPerCubicMeter => (_value) * 1e3d,
                SpecificWeightUnit.KilonewtonPerCubicMillimeter => (_value * 1000000000) * 1e3d,
                SpecificWeightUnit.KilopoundForcePerCubicFoot => (_value * 1.570874638462462e2) * 1e3d,
                SpecificWeightUnit.KilopoundForcePerCubicInch => (_value * 2.714471375263134e5) * 1e3d,
                SpecificWeightUnit.MeganewtonPerCubicMeter => (_value) * 1e6d,
                SpecificWeightUnit.NewtonPerCubicCentimeter => _value * 1000000,
                SpecificWeightUnit.NewtonPerCubicMeter => _value,
                SpecificWeightUnit.NewtonPerCubicMillimeter => _value * 1000000000,
                SpecificWeightUnit.PoundForcePerCubicFoot => _value * 1.570874638462462e2,
                SpecificWeightUnit.PoundForcePerCubicInch => _value * 2.714471375263134e5,
                SpecificWeightUnit.TonneForcePerCubicCentimeter => _value * 9.80665e9,
                SpecificWeightUnit.TonneForcePerCubicMeter => _value * 9.80665e3,
                SpecificWeightUnit.TonneForcePerCubicMillimeter => _value * 9.80665e12,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private QuantityValue GetValueAs(SpecificWeightUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                SpecificWeightUnit.KilogramForcePerCubicCentimeter => baseUnitValue / 9.80665e6,
                SpecificWeightUnit.KilogramForcePerCubicMeter => baseUnitValue / 9.80665,
                SpecificWeightUnit.KilogramForcePerCubicMillimeter => baseUnitValue / 9.80665e9,
                SpecificWeightUnit.KilonewtonPerCubicCentimeter => (baseUnitValue * 0.000001) / 1e3d,
                SpecificWeightUnit.KilonewtonPerCubicMeter => (baseUnitValue) / 1e3d,
                SpecificWeightUnit.KilonewtonPerCubicMillimeter => (baseUnitValue * 0.000000001) / 1e3d,
                SpecificWeightUnit.KilopoundForcePerCubicFoot => (baseUnitValue / 1.570874638462462e2) / 1e3d,
                SpecificWeightUnit.KilopoundForcePerCubicInch => (baseUnitValue / 2.714471375263134e5) / 1e3d,
                SpecificWeightUnit.MeganewtonPerCubicMeter => (baseUnitValue) / 1e6d,
                SpecificWeightUnit.NewtonPerCubicCentimeter => baseUnitValue * 0.000001,
                SpecificWeightUnit.NewtonPerCubicMeter => baseUnitValue,
                SpecificWeightUnit.NewtonPerCubicMillimeter => baseUnitValue * 0.000000001,
                SpecificWeightUnit.PoundForcePerCubicFoot => baseUnitValue / 1.570874638462462e2,
                SpecificWeightUnit.PoundForcePerCubicInch => baseUnitValue / 2.714471375263134e5,
                SpecificWeightUnit.TonneForcePerCubicCentimeter => baseUnitValue / 9.80665e9,
                SpecificWeightUnit.TonneForcePerCubicMeter => baseUnitValue / 9.80665e3,
                SpecificWeightUnit.TonneForcePerCubicMillimeter => baseUnitValue / 9.80665e12,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion

    }
}
