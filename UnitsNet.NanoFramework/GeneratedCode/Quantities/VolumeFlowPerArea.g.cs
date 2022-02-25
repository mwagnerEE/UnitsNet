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
    ///     The volumetric flow rate per area is the volume of fluid which passes through a given unit surface area per unit time.
    /// </summary>
    public struct  VolumeFlowPerArea
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly QuantityValue _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly VolumeFlowPerAreaUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public QuantityValue Value => _value;

        /// <inheritdoc />
        public VolumeFlowPerAreaUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public VolumeFlowPerArea(QuantityValue value, VolumeFlowPerAreaUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static VolumeFlowPerAreaUnit BaseUnit { get; } = VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static VolumeFlowPerArea MaxValue { get; } = new VolumeFlowPerArea(QuantityValue.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static VolumeFlowPerArea MinValue { get; } = new VolumeFlowPerArea(QuantityValue.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static VolumeFlowPerArea Zero { get; } = new VolumeFlowPerArea(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot"/>
        /// </summary>
        public QuantityValue CubicFeetPerMinutePerSquareFoot => As(VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter"/>
        /// </summary>
        public QuantityValue CubicMetersPerSecondPerSquareMeter => As(VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="VolumeFlowPerArea"/> from <see cref="VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlowPerArea FromCubicFeetPerMinutePerSquareFoot(QuantityValue cubicfeetperminutepersquarefoot) => new VolumeFlowPerArea(cubicfeetperminutepersquarefoot, VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot);

        /// <summary>
        ///     Creates a <see cref="VolumeFlowPerArea"/> from <see cref="VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlowPerArea FromCubicMetersPerSecondPerSquareMeter(QuantityValue cubicmeterspersecondpersquaremeter) => new VolumeFlowPerArea(cubicmeterspersecondpersquaremeter, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="VolumeFlowPerAreaUnit" /> to <see cref="VolumeFlowPerArea" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>VolumeFlowPerArea unit value.</returns>
        public static VolumeFlowPerArea From(QuantityValue value, VolumeFlowPerAreaUnit fromUnit)
        {
            return new VolumeFlowPerArea(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public QuantityValue As(VolumeFlowPerAreaUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public VolumeFlowPerArea ToUnit(VolumeFlowPerAreaUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new VolumeFlowPerArea(convertedValue, unit);
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
                VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot => _value / 196.850394,
                VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter => _value,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private QuantityValue GetValueAs(VolumeFlowPerAreaUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot => baseUnitValue * 196.850394,
                VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter => baseUnitValue,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion

    }
}

