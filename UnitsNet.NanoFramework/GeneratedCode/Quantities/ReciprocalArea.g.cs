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
    ///     Reciprocal area (Inverse-square) quantity is used to specify a physical quantity inversely proportional to the square of the distance.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Inverse-square_law
    /// </remarks>
    public struct  ReciprocalArea
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly QuantityValue _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ReciprocalAreaUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public QuantityValue Value => _value;

        /// <inheritdoc />
        public ReciprocalAreaUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ReciprocalArea(QuantityValue value, ReciprocalAreaUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static ReciprocalAreaUnit BaseUnit { get; } = ReciprocalAreaUnit.InverseSquareMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static ReciprocalArea MaxValue { get; } = new ReciprocalArea(QuantityValue.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static ReciprocalArea MinValue { get; } = new ReciprocalArea(QuantityValue.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ReciprocalArea Zero { get; } = new ReciprocalArea(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReciprocalAreaUnit.InverseSquareCentimeter"/>
        /// </summary>
        public QuantityValue InverseSquareCentimeters => As(ReciprocalAreaUnit.InverseSquareCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReciprocalAreaUnit.InverseSquareDecimeter"/>
        /// </summary>
        public QuantityValue InverseSquareDecimeters => As(ReciprocalAreaUnit.InverseSquareDecimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReciprocalAreaUnit.InverseSquareFoot"/>
        /// </summary>
        public QuantityValue InverseSquareFeet => As(ReciprocalAreaUnit.InverseSquareFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReciprocalAreaUnit.InverseSquareInch"/>
        /// </summary>
        public QuantityValue InverseSquareInches => As(ReciprocalAreaUnit.InverseSquareInch);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReciprocalAreaUnit.InverseSquareKilometer"/>
        /// </summary>
        public QuantityValue InverseSquareKilometers => As(ReciprocalAreaUnit.InverseSquareKilometer);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReciprocalAreaUnit.InverseSquareMeter"/>
        /// </summary>
        public QuantityValue InverseSquareMeters => As(ReciprocalAreaUnit.InverseSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReciprocalAreaUnit.InverseSquareMicrometer"/>
        /// </summary>
        public QuantityValue InverseSquareMicrometers => As(ReciprocalAreaUnit.InverseSquareMicrometer);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReciprocalAreaUnit.InverseSquareMile"/>
        /// </summary>
        public QuantityValue InverseSquareMiles => As(ReciprocalAreaUnit.InverseSquareMile);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReciprocalAreaUnit.InverseSquareMillimeter"/>
        /// </summary>
        public QuantityValue InverseSquareMillimeters => As(ReciprocalAreaUnit.InverseSquareMillimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReciprocalAreaUnit.InverseSquareYard"/>
        /// </summary>
        public QuantityValue InverseSquareYards => As(ReciprocalAreaUnit.InverseSquareYard);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReciprocalAreaUnit.InverseUsSurveySquareFoot"/>
        /// </summary>
        public QuantityValue InverseUsSurveySquareFeet => As(ReciprocalAreaUnit.InverseUsSurveySquareFoot);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ReciprocalArea"/> from <see cref="ReciprocalAreaUnit.InverseSquareCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalArea FromInverseSquareCentimeters(QuantityValue inversesquarecentimeters) => new ReciprocalArea(inversesquarecentimeters, ReciprocalAreaUnit.InverseSquareCentimeter);

        /// <summary>
        ///     Creates a <see cref="ReciprocalArea"/> from <see cref="ReciprocalAreaUnit.InverseSquareDecimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalArea FromInverseSquareDecimeters(QuantityValue inversesquaredecimeters) => new ReciprocalArea(inversesquaredecimeters, ReciprocalAreaUnit.InverseSquareDecimeter);

        /// <summary>
        ///     Creates a <see cref="ReciprocalArea"/> from <see cref="ReciprocalAreaUnit.InverseSquareFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalArea FromInverseSquareFeet(QuantityValue inversesquarefeet) => new ReciprocalArea(inversesquarefeet, ReciprocalAreaUnit.InverseSquareFoot);

        /// <summary>
        ///     Creates a <see cref="ReciprocalArea"/> from <see cref="ReciprocalAreaUnit.InverseSquareInch"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalArea FromInverseSquareInches(QuantityValue inversesquareinches) => new ReciprocalArea(inversesquareinches, ReciprocalAreaUnit.InverseSquareInch);

        /// <summary>
        ///     Creates a <see cref="ReciprocalArea"/> from <see cref="ReciprocalAreaUnit.InverseSquareKilometer"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalArea FromInverseSquareKilometers(QuantityValue inversesquarekilometers) => new ReciprocalArea(inversesquarekilometers, ReciprocalAreaUnit.InverseSquareKilometer);

        /// <summary>
        ///     Creates a <see cref="ReciprocalArea"/> from <see cref="ReciprocalAreaUnit.InverseSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalArea FromInverseSquareMeters(QuantityValue inversesquaremeters) => new ReciprocalArea(inversesquaremeters, ReciprocalAreaUnit.InverseSquareMeter);

        /// <summary>
        ///     Creates a <see cref="ReciprocalArea"/> from <see cref="ReciprocalAreaUnit.InverseSquareMicrometer"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalArea FromInverseSquareMicrometers(QuantityValue inversesquaremicrometers) => new ReciprocalArea(inversesquaremicrometers, ReciprocalAreaUnit.InverseSquareMicrometer);

        /// <summary>
        ///     Creates a <see cref="ReciprocalArea"/> from <see cref="ReciprocalAreaUnit.InverseSquareMile"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalArea FromInverseSquareMiles(QuantityValue inversesquaremiles) => new ReciprocalArea(inversesquaremiles, ReciprocalAreaUnit.InverseSquareMile);

        /// <summary>
        ///     Creates a <see cref="ReciprocalArea"/> from <see cref="ReciprocalAreaUnit.InverseSquareMillimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalArea FromInverseSquareMillimeters(QuantityValue inversesquaremillimeters) => new ReciprocalArea(inversesquaremillimeters, ReciprocalAreaUnit.InverseSquareMillimeter);

        /// <summary>
        ///     Creates a <see cref="ReciprocalArea"/> from <see cref="ReciprocalAreaUnit.InverseSquareYard"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalArea FromInverseSquareYards(QuantityValue inversesquareyards) => new ReciprocalArea(inversesquareyards, ReciprocalAreaUnit.InverseSquareYard);

        /// <summary>
        ///     Creates a <see cref="ReciprocalArea"/> from <see cref="ReciprocalAreaUnit.InverseUsSurveySquareFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalArea FromInverseUsSurveySquareFeet(QuantityValue inverseussurveysquarefeet) => new ReciprocalArea(inverseussurveysquarefeet, ReciprocalAreaUnit.InverseUsSurveySquareFoot);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ReciprocalAreaUnit" /> to <see cref="ReciprocalArea" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ReciprocalArea unit value.</returns>
        public static ReciprocalArea From(QuantityValue value, ReciprocalAreaUnit fromUnit)
        {
            return new ReciprocalArea(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public QuantityValue As(ReciprocalAreaUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public ReciprocalArea ToUnit(ReciprocalAreaUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new ReciprocalArea(convertedValue, unit);
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
                ReciprocalAreaUnit.InverseSquareCentimeter => _value / 1e-4,
                ReciprocalAreaUnit.InverseSquareDecimeter => _value / 1e-2,
                ReciprocalAreaUnit.InverseSquareFoot => _value / 0.092903,
                ReciprocalAreaUnit.InverseSquareInch => _value / 0.00064516,
                ReciprocalAreaUnit.InverseSquareKilometer => _value / 1e6,
                ReciprocalAreaUnit.InverseSquareMeter => _value,
                ReciprocalAreaUnit.InverseSquareMicrometer => _value / 1e-12,
                ReciprocalAreaUnit.InverseSquareMile => _value / 2.59e6,
                ReciprocalAreaUnit.InverseSquareMillimeter => _value / 1e-6,
                ReciprocalAreaUnit.InverseSquareYard => _value / 0.836127,
                ReciprocalAreaUnit.InverseUsSurveySquareFoot => _value / 0.09290341161,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private QuantityValue GetValueAs(ReciprocalAreaUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                ReciprocalAreaUnit.InverseSquareCentimeter => baseUnitValue * 1e-4,
                ReciprocalAreaUnit.InverseSquareDecimeter => baseUnitValue * 1e-2,
                ReciprocalAreaUnit.InverseSquareFoot => baseUnitValue * 0.092903,
                ReciprocalAreaUnit.InverseSquareInch => baseUnitValue * 0.00064516,
                ReciprocalAreaUnit.InverseSquareKilometer => baseUnitValue * 1e6,
                ReciprocalAreaUnit.InverseSquareMeter => baseUnitValue,
                ReciprocalAreaUnit.InverseSquareMicrometer => baseUnitValue * 1e-12,
                ReciprocalAreaUnit.InverseSquareMile => baseUnitValue * 2.59e6,
                ReciprocalAreaUnit.InverseSquareMillimeter => baseUnitValue * 1e-6,
                ReciprocalAreaUnit.InverseSquareYard => baseUnitValue * 0.836127,
                ReciprocalAreaUnit.InverseUsSurveySquareFoot => baseUnitValue * 0.09290341161,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion

    }
}

