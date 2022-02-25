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
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of HeatTransferCoefficient.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class HeatTransferCoefficientTestsBase : QuantityTestsBase
    {
        protected abstract double BtusPerSquareFootDegreeFahrenheitInOneWattPerSquareMeterKelvin { get; }
        protected abstract double WattsPerSquareMeterCelsiusInOneWattPerSquareMeterKelvin { get; }
        protected abstract double WattsPerSquareMeterKelvinInOneWattPerSquareMeterKelvin { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double BtusPerSquareFootDegreeFahrenheitTolerance { get { return 1e-5; } }
        protected virtual double WattsPerSquareMeterCelsiusTolerance { get { return 1e-5; } }
        protected virtual double WattsPerSquareMeterKelvinTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(HeatTransferCoefficientUnit unit)
        {
            return unit switch
            {
                HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit => (BtusPerSquareFootDegreeFahrenheitInOneWattPerSquareMeterKelvin, BtusPerSquareFootDegreeFahrenheitTolerance),
                HeatTransferCoefficientUnit.WattPerSquareMeterCelsius => (WattsPerSquareMeterCelsiusInOneWattPerSquareMeterKelvin, WattsPerSquareMeterCelsiusTolerance),
                HeatTransferCoefficientUnit.WattPerSquareMeterKelvin => (WattsPerSquareMeterKelvinInOneWattPerSquareMeterKelvin, WattsPerSquareMeterKelvinTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit },
            new object[] { HeatTransferCoefficientUnit.WattPerSquareMeterCelsius },
            new object[] { HeatTransferCoefficientUnit.WattPerSquareMeterKelvin },
        };

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new HeatTransferCoefficient((QuantityValue)0.0, HeatTransferCoefficientUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new HeatTransferCoefficient();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(HeatTransferCoefficientUnit.WattPerSquareMeterKelvin, quantity.Unit);
        }


        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new HeatTransferCoefficient(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new HeatTransferCoefficient(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (HeatTransferCoefficient) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void HeatTransferCoefficient_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new HeatTransferCoefficient(1, HeatTransferCoefficientUnit.WattPerSquareMeterKelvin);

            QuantityInfo<HeatTransferCoefficientUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(HeatTransferCoefficient.Zero, quantityInfo.Zero);
            Assert.Equal("HeatTransferCoefficient", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<HeatTransferCoefficientUnit>().Except(new[] {HeatTransferCoefficientUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

        }

        [Fact]
        public void WattPerSquareMeterKelvinToHeatTransferCoefficientUnits()
        {
            HeatTransferCoefficient wattpersquaremeterkelvin = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1);
            AssertEx.EqualTolerance(BtusPerSquareFootDegreeFahrenheitInOneWattPerSquareMeterKelvin, wattpersquaremeterkelvin.BtusPerSquareFootDegreeFahrenheit, BtusPerSquareFootDegreeFahrenheitTolerance);
            AssertEx.EqualTolerance(WattsPerSquareMeterCelsiusInOneWattPerSquareMeterKelvin, wattpersquaremeterkelvin.WattsPerSquareMeterCelsius, WattsPerSquareMeterCelsiusTolerance);
            AssertEx.EqualTolerance(WattsPerSquareMeterKelvinInOneWattPerSquareMeterKelvin, wattpersquaremeterkelvin.WattsPerSquareMeterKelvin, WattsPerSquareMeterKelvinTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = HeatTransferCoefficient.From(1, HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit);
            AssertEx.EqualTolerance(1, quantity00.BtusPerSquareFootDegreeFahrenheit, BtusPerSquareFootDegreeFahrenheitTolerance);
            Assert.Equal(HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit, quantity00.Unit);

            var quantity01 = HeatTransferCoefficient.From(1, HeatTransferCoefficientUnit.WattPerSquareMeterCelsius);
            AssertEx.EqualTolerance(1, quantity01.WattsPerSquareMeterCelsius, WattsPerSquareMeterCelsiusTolerance);
            Assert.Equal(HeatTransferCoefficientUnit.WattPerSquareMeterCelsius, quantity01.Unit);

            var quantity02 = HeatTransferCoefficient.From(1, HeatTransferCoefficientUnit.WattPerSquareMeterKelvin);
            AssertEx.EqualTolerance(1, quantity02.WattsPerSquareMeterKelvin, WattsPerSquareMeterKelvinTolerance);
            Assert.Equal(HeatTransferCoefficientUnit.WattPerSquareMeterKelvin, quantity02.Unit);

        }

        [Fact]
        public void As()
        {
            var wattpersquaremeterkelvin = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1);
            AssertEx.EqualTolerance(BtusPerSquareFootDegreeFahrenheitInOneWattPerSquareMeterKelvin, wattpersquaremeterkelvin.As(HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit), BtusPerSquareFootDegreeFahrenheitTolerance);
            AssertEx.EqualTolerance(WattsPerSquareMeterCelsiusInOneWattPerSquareMeterKelvin, wattpersquaremeterkelvin.As(HeatTransferCoefficientUnit.WattPerSquareMeterCelsius), WattsPerSquareMeterCelsiusTolerance);
            AssertEx.EqualTolerance(WattsPerSquareMeterKelvinInOneWattPerSquareMeterKelvin, wattpersquaremeterkelvin.As(HeatTransferCoefficientUnit.WattPerSquareMeterKelvin), WattsPerSquareMeterKelvinTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new HeatTransferCoefficient(value: 1, unit: HeatTransferCoefficient.BaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = (QuantityValue) AsWithSIUnitSystem();
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(HeatTransferCoefficientUnit unit)
        {
            var inBaseUnits = HeatTransferCoefficient.From(1.0, HeatTransferCoefficient.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(HeatTransferCoefficientUnit unit)
        {
            var quantity = HeatTransferCoefficient.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(HeatTransferCoefficientUnit unit)
        {
            // See if there is a unit available that is not the base unit.
            var fromUnit = HeatTransferCoefficient.Units.FirstOrDefault(u => u != HeatTransferCoefficient.BaseUnit && u != HeatTransferCoefficientUnit.Undefined);

            // If there is only one unit for the quantity, we must use the base unit.
            if (fromUnit == HeatTransferCoefficientUnit.Undefined)
                fromUnit = HeatTransferCoefficient.BaseUnit;

            var quantity = HeatTransferCoefficient.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            HeatTransferCoefficient wattpersquaremeterkelvin = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1);
            AssertEx.EqualTolerance(1, HeatTransferCoefficient.FromBtusPerSquareFootDegreeFahrenheit(wattpersquaremeterkelvin.BtusPerSquareFootDegreeFahrenheit).WattsPerSquareMeterKelvin, BtusPerSquareFootDegreeFahrenheitTolerance);
            AssertEx.EqualTolerance(1, HeatTransferCoefficient.FromWattsPerSquareMeterCelsius(wattpersquaremeterkelvin.WattsPerSquareMeterCelsius).WattsPerSquareMeterKelvin, WattsPerSquareMeterCelsiusTolerance);
            AssertEx.EqualTolerance(1, HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(wattpersquaremeterkelvin.WattsPerSquareMeterKelvin).WattsPerSquareMeterKelvin, WattsPerSquareMeterKelvinTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            HeatTransferCoefficient v = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1);
            AssertEx.EqualTolerance(-1, -v.WattsPerSquareMeterKelvin, WattsPerSquareMeterKelvinTolerance);
            AssertEx.EqualTolerance(2, (HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(3)-v).WattsPerSquareMeterKelvin, WattsPerSquareMeterKelvinTolerance);
            AssertEx.EqualTolerance(2, (v + v).WattsPerSquareMeterKelvin, WattsPerSquareMeterKelvinTolerance);
            AssertEx.EqualTolerance(10, (v*10).WattsPerSquareMeterKelvin, WattsPerSquareMeterKelvinTolerance);
            AssertEx.EqualTolerance(10, (10*v).WattsPerSquareMeterKelvin, WattsPerSquareMeterKelvinTolerance);
            AssertEx.EqualTolerance(2, (HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(10)/5).WattsPerSquareMeterKelvin, WattsPerSquareMeterKelvinTolerance);
            AssertEx.EqualTolerance(2, HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(10)/HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(5), WattsPerSquareMeterKelvinTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            HeatTransferCoefficient oneWattPerSquareMeterKelvin = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1);
            HeatTransferCoefficient twoWattsPerSquareMeterKelvin = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(2);

            Assert.True(oneWattPerSquareMeterKelvin < twoWattsPerSquareMeterKelvin);
            Assert.True(oneWattPerSquareMeterKelvin <= twoWattsPerSquareMeterKelvin);
            Assert.True(twoWattsPerSquareMeterKelvin > oneWattPerSquareMeterKelvin);
            Assert.True(twoWattsPerSquareMeterKelvin >= oneWattPerSquareMeterKelvin);

            Assert.False(oneWattPerSquareMeterKelvin > twoWattsPerSquareMeterKelvin);
            Assert.False(oneWattPerSquareMeterKelvin >= twoWattsPerSquareMeterKelvin);
            Assert.False(twoWattsPerSquareMeterKelvin < oneWattPerSquareMeterKelvin);
            Assert.False(twoWattsPerSquareMeterKelvin <= oneWattPerSquareMeterKelvin);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            HeatTransferCoefficient wattpersquaremeterkelvin = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1);
            Assert.Equal(0, wattpersquaremeterkelvin.CompareTo(wattpersquaremeterkelvin));
            Assert.True(wattpersquaremeterkelvin.CompareTo(HeatTransferCoefficient.Zero) > 0);
            Assert.True(HeatTransferCoefficient.Zero.CompareTo(wattpersquaremeterkelvin) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            HeatTransferCoefficient wattpersquaremeterkelvin = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1);
            Assert.Throws<ArgumentException>(() => wattpersquaremeterkelvin.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            HeatTransferCoefficient wattpersquaremeterkelvin = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1);
            Assert.Throws<ArgumentNullException>(() => wattpersquaremeterkelvin.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1);
            var b = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(2);

#pragma warning disable CS8073
// ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
#pragma warning restore CS8073
        }

        [Fact]
        public void Equals_SameType_IsImplemented()
        {
            var a = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1);
            var b = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1);
            object b = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1);
            Assert.True(v.Equals(HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1), WattsPerSquareMeterKelvinTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(HeatTransferCoefficient.Zero, WattsPerSquareMeterKelvinTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            HeatTransferCoefficient wattpersquaremeterkelvin = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1);
            Assert.False(wattpersquaremeterkelvin.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            HeatTransferCoefficient wattpersquaremeterkelvin = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1);
            Assert.False(wattpersquaremeterkelvin.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(HeatTransferCoefficientUnit.Undefined, HeatTransferCoefficient.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(HeatTransferCoefficientUnit)).Cast<HeatTransferCoefficientUnit>();
            foreach(var unit in units)
            {
                if (unit == HeatTransferCoefficientUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 Btu/ft²·hr·°F", new HeatTransferCoefficient(1, HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit).ToString());
                Assert.Equal("1 W/m²·°C", new HeatTransferCoefficient(1, HeatTransferCoefficientUnit.WattPerSquareMeterCelsius).ToString());
                Assert.Equal("1 W/m²·K", new HeatTransferCoefficient(1, HeatTransferCoefficientUnit.WattPerSquareMeterKelvin).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 Btu/ft²·hr·°F", new HeatTransferCoefficient(1, HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit).ToString(swedishCulture));
            Assert.Equal("1 W/m²·°C", new HeatTransferCoefficient(1, HeatTransferCoefficientUnit.WattPerSquareMeterCelsius).ToString(swedishCulture));
            Assert.Equal("1 W/m²·K", new HeatTransferCoefficient(1, HeatTransferCoefficientUnit.WattPerSquareMeterKelvin).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 W/m²·K", new HeatTransferCoefficient(0.123456, HeatTransferCoefficientUnit.WattPerSquareMeterKelvin).ToString("s1"));
                Assert.Equal("0.12 W/m²·K", new HeatTransferCoefficient(0.123456, HeatTransferCoefficientUnit.WattPerSquareMeterKelvin).ToString("s2"));
                Assert.Equal("0.123 W/m²·K", new HeatTransferCoefficient(0.123456, HeatTransferCoefficientUnit.WattPerSquareMeterKelvin).ToString("s3"));
                Assert.Equal("0.1235 W/m²·K", new HeatTransferCoefficient(0.123456, HeatTransferCoefficientUnit.WattPerSquareMeterKelvin).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 W/m²·K", new HeatTransferCoefficient(0.123456, HeatTransferCoefficientUnit.WattPerSquareMeterKelvin).ToString("s1", culture));
            Assert.Equal("0.12 W/m²·K", new HeatTransferCoefficient(0.123456, HeatTransferCoefficientUnit.WattPerSquareMeterKelvin).ToString("s2", culture));
            Assert.Equal("0.123 W/m²·K", new HeatTransferCoefficient(0.123456, HeatTransferCoefficientUnit.WattPerSquareMeterKelvin).ToString("s3", culture));
            Assert.Equal("0.1235 W/m²·K", new HeatTransferCoefficient(0.123456, HeatTransferCoefficientUnit.WattPerSquareMeterKelvin).ToString("s4", culture));
        }

/*
        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }
*/

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
           Assert.Equal((byte)quantity.Value.Real, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
            Assert.Equal((decimal)quantity.Value.Real, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
            Assert.Equal((double)quantity.Value.Real, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
            Assert.Equal((short)quantity.Value.Real, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
            Assert.Equal((int)quantity.Value.Real, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
            Assert.Equal((long)quantity.Value.Real, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
            Assert.Equal((sbyte)quantity.Value.Real, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
            Assert.Equal((float)quantity.Value.Real, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
            Assert.Equal((ushort)quantity.Value.Real, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
            Assert.Equal((uint)quantity.Value.Real, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
            Assert.Equal((ulong)quantity.Value.Real, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(HeatTransferCoefficient)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(HeatTransferCoefficientUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
            Assert.Equal(HeatTransferCoefficient.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
            Assert.Equal(HeatTransferCoefficient.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(1.0);
            Assert.Equal(new {HeatTransferCoefficient.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(value);
            Assert.Equal(HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(-value), -quantity);
        }
    }
}
