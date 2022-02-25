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
    ///     Power engineers measure apparent power as the magnitude of the vector sum of active and reactive power. Apparent power is the product of the root-mean-square of voltage and current.
    /// </summary>
    public struct  ApparentPower
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly QuantityValue _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ApparentPowerUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public QuantityValue Value => _value;

        /// <inheritdoc />
        public ApparentPowerUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ApparentPower(QuantityValue value, ApparentPowerUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static ApparentPowerUnit BaseUnit { get; } = ApparentPowerUnit.Voltampere;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static ApparentPower MaxValue { get; } = new ApparentPower(QuantityValue.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static ApparentPower MinValue { get; } = new ApparentPower(QuantityValue.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ApparentPower Zero { get; } = new ApparentPower(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ApparentPowerUnit.Gigavoltampere"/>
        /// </summary>
        public QuantityValue Gigavoltamperes => As(ApparentPowerUnit.Gigavoltampere);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ApparentPowerUnit.Kilovoltampere"/>
        /// </summary>
        public QuantityValue Kilovoltamperes => As(ApparentPowerUnit.Kilovoltampere);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ApparentPowerUnit.Megavoltampere"/>
        /// </summary>
        public QuantityValue Megavoltamperes => As(ApparentPowerUnit.Megavoltampere);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ApparentPowerUnit.Voltampere"/>
        /// </summary>
        public QuantityValue Voltamperes => As(ApparentPowerUnit.Voltampere);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ApparentPower"/> from <see cref="ApparentPowerUnit.Gigavoltampere"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ApparentPower FromGigavoltamperes(QuantityValue gigavoltamperes) => new ApparentPower(gigavoltamperes, ApparentPowerUnit.Gigavoltampere);

        /// <summary>
        ///     Creates a <see cref="ApparentPower"/> from <see cref="ApparentPowerUnit.Kilovoltampere"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ApparentPower FromKilovoltamperes(QuantityValue kilovoltamperes) => new ApparentPower(kilovoltamperes, ApparentPowerUnit.Kilovoltampere);

        /// <summary>
        ///     Creates a <see cref="ApparentPower"/> from <see cref="ApparentPowerUnit.Megavoltampere"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ApparentPower FromMegavoltamperes(QuantityValue megavoltamperes) => new ApparentPower(megavoltamperes, ApparentPowerUnit.Megavoltampere);

        /// <summary>
        ///     Creates a <see cref="ApparentPower"/> from <see cref="ApparentPowerUnit.Voltampere"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ApparentPower FromVoltamperes(QuantityValue voltamperes) => new ApparentPower(voltamperes, ApparentPowerUnit.Voltampere);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ApparentPowerUnit" /> to <see cref="ApparentPower" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ApparentPower unit value.</returns>
        public static ApparentPower From(QuantityValue value, ApparentPowerUnit fromUnit)
        {
            return new ApparentPower(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public QuantityValue As(ApparentPowerUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public ApparentPower ToUnit(ApparentPowerUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new ApparentPower(convertedValue, unit);
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
                ApparentPowerUnit.Gigavoltampere => (_value) * 1e9d,
                ApparentPowerUnit.Kilovoltampere => (_value) * 1e3d,
                ApparentPowerUnit.Megavoltampere => (_value) * 1e6d,
                ApparentPowerUnit.Voltampere => _value,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private QuantityValue GetValueAs(ApparentPowerUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                ApparentPowerUnit.Gigavoltampere => (baseUnitValue) / 1e9d,
                ApparentPowerUnit.Kilovoltampere => (baseUnitValue) / 1e3d,
                ApparentPowerUnit.Megavoltampere => (baseUnitValue) / 1e6d,
                ApparentPowerUnit.Voltampere => baseUnitValue,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion

    }
}

