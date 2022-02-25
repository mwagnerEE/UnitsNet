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
    /// Test of Ratio.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class RatioTestsBase : QuantityTestsBase
    {
        protected abstract double DecimalFractionsInOneDecimalFraction { get; }
        protected abstract double PartsPerBillionInOneDecimalFraction { get; }
        protected abstract double PartsPerMillionInOneDecimalFraction { get; }
        protected abstract double PartsPerThousandInOneDecimalFraction { get; }
        protected abstract double PartsPerTrillionInOneDecimalFraction { get; }
        protected abstract double PercentInOneDecimalFraction { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DecimalFractionsTolerance { get { return 1e-5; } }
        protected virtual double PartsPerBillionTolerance { get { return 1e-5; } }
        protected virtual double PartsPerMillionTolerance { get { return 1e-5; } }
        protected virtual double PartsPerThousandTolerance { get { return 1e-5; } }
        protected virtual double PartsPerTrillionTolerance { get { return 1e-5; } }
        protected virtual double PercentTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(RatioUnit unit)
        {
            return unit switch
            {
                RatioUnit.DecimalFraction => (DecimalFractionsInOneDecimalFraction, DecimalFractionsTolerance),
                RatioUnit.PartPerBillion => (PartsPerBillionInOneDecimalFraction, PartsPerBillionTolerance),
                RatioUnit.PartPerMillion => (PartsPerMillionInOneDecimalFraction, PartsPerMillionTolerance),
                RatioUnit.PartPerThousand => (PartsPerThousandInOneDecimalFraction, PartsPerThousandTolerance),
                RatioUnit.PartPerTrillion => (PartsPerTrillionInOneDecimalFraction, PartsPerTrillionTolerance),
                RatioUnit.Percent => (PercentInOneDecimalFraction, PercentTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { RatioUnit.DecimalFraction },
            new object[] { RatioUnit.PartPerBillion },
            new object[] { RatioUnit.PartPerMillion },
            new object[] { RatioUnit.PartPerThousand },
            new object[] { RatioUnit.PartPerTrillion },
            new object[] { RatioUnit.Percent },
        };

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Ratio((QuantityValue)0.0, RatioUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new Ratio();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(RatioUnit.DecimalFraction, quantity.Unit);
        }


        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Ratio(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new Ratio(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (Ratio) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void Ratio_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new Ratio(1, RatioUnit.DecimalFraction);

            QuantityInfo<RatioUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(Ratio.Zero, quantityInfo.Zero);
            Assert.Equal("Ratio", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<RatioUnit>().Except(new[] {RatioUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

        }

        [Fact]
        public void DecimalFractionToRatioUnits()
        {
            Ratio decimalfraction = Ratio.FromDecimalFractions(1);
            AssertEx.EqualTolerance(DecimalFractionsInOneDecimalFraction, decimalfraction.DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(PartsPerBillionInOneDecimalFraction, decimalfraction.PartsPerBillion, PartsPerBillionTolerance);
            AssertEx.EqualTolerance(PartsPerMillionInOneDecimalFraction, decimalfraction.PartsPerMillion, PartsPerMillionTolerance);
            AssertEx.EqualTolerance(PartsPerThousandInOneDecimalFraction, decimalfraction.PartsPerThousand, PartsPerThousandTolerance);
            AssertEx.EqualTolerance(PartsPerTrillionInOneDecimalFraction, decimalfraction.PartsPerTrillion, PartsPerTrillionTolerance);
            AssertEx.EqualTolerance(PercentInOneDecimalFraction, decimalfraction.Percent, PercentTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = Ratio.From(1, RatioUnit.DecimalFraction);
            AssertEx.EqualTolerance(1, quantity00.DecimalFractions, DecimalFractionsTolerance);
            Assert.Equal(RatioUnit.DecimalFraction, quantity00.Unit);

            var quantity01 = Ratio.From(1, RatioUnit.PartPerBillion);
            AssertEx.EqualTolerance(1, quantity01.PartsPerBillion, PartsPerBillionTolerance);
            Assert.Equal(RatioUnit.PartPerBillion, quantity01.Unit);

            var quantity02 = Ratio.From(1, RatioUnit.PartPerMillion);
            AssertEx.EqualTolerance(1, quantity02.PartsPerMillion, PartsPerMillionTolerance);
            Assert.Equal(RatioUnit.PartPerMillion, quantity02.Unit);

            var quantity03 = Ratio.From(1, RatioUnit.PartPerThousand);
            AssertEx.EqualTolerance(1, quantity03.PartsPerThousand, PartsPerThousandTolerance);
            Assert.Equal(RatioUnit.PartPerThousand, quantity03.Unit);

            var quantity04 = Ratio.From(1, RatioUnit.PartPerTrillion);
            AssertEx.EqualTolerance(1, quantity04.PartsPerTrillion, PartsPerTrillionTolerance);
            Assert.Equal(RatioUnit.PartPerTrillion, quantity04.Unit);

            var quantity05 = Ratio.From(1, RatioUnit.Percent);
            AssertEx.EqualTolerance(1, quantity05.Percent, PercentTolerance);
            Assert.Equal(RatioUnit.Percent, quantity05.Unit);

        }

        [Fact]
        public void As()
        {
            var decimalfraction = Ratio.FromDecimalFractions(1);
            AssertEx.EqualTolerance(DecimalFractionsInOneDecimalFraction, decimalfraction.As(RatioUnit.DecimalFraction), DecimalFractionsTolerance);
            AssertEx.EqualTolerance(PartsPerBillionInOneDecimalFraction, decimalfraction.As(RatioUnit.PartPerBillion), PartsPerBillionTolerance);
            AssertEx.EqualTolerance(PartsPerMillionInOneDecimalFraction, decimalfraction.As(RatioUnit.PartPerMillion), PartsPerMillionTolerance);
            AssertEx.EqualTolerance(PartsPerThousandInOneDecimalFraction, decimalfraction.As(RatioUnit.PartPerThousand), PartsPerThousandTolerance);
            AssertEx.EqualTolerance(PartsPerTrillionInOneDecimalFraction, decimalfraction.As(RatioUnit.PartPerTrillion), PartsPerTrillionTolerance);
            AssertEx.EqualTolerance(PercentInOneDecimalFraction, decimalfraction.As(RatioUnit.Percent), PercentTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new Ratio(value: 1, unit: Ratio.BaseUnit);
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
        public void ToUnit(RatioUnit unit)
        {
            var inBaseUnits = Ratio.From(1.0, Ratio.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(RatioUnit unit)
        {
            var quantity = Ratio.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(RatioUnit unit)
        {
            // See if there is a unit available that is not the base unit.
            var fromUnit = Ratio.Units.FirstOrDefault(u => u != Ratio.BaseUnit && u != RatioUnit.Undefined);

            // If there is only one unit for the quantity, we must use the base unit.
            if (fromUnit == RatioUnit.Undefined)
                fromUnit = Ratio.BaseUnit;

            var quantity = Ratio.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Ratio decimalfraction = Ratio.FromDecimalFractions(1);
            AssertEx.EqualTolerance(1, Ratio.FromDecimalFractions(decimalfraction.DecimalFractions).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(1, Ratio.FromPartsPerBillion(decimalfraction.PartsPerBillion).DecimalFractions, PartsPerBillionTolerance);
            AssertEx.EqualTolerance(1, Ratio.FromPartsPerMillion(decimalfraction.PartsPerMillion).DecimalFractions, PartsPerMillionTolerance);
            AssertEx.EqualTolerance(1, Ratio.FromPartsPerThousand(decimalfraction.PartsPerThousand).DecimalFractions, PartsPerThousandTolerance);
            AssertEx.EqualTolerance(1, Ratio.FromPartsPerTrillion(decimalfraction.PartsPerTrillion).DecimalFractions, PartsPerTrillionTolerance);
            AssertEx.EqualTolerance(1, Ratio.FromPercent(decimalfraction.Percent).DecimalFractions, PercentTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Ratio v = Ratio.FromDecimalFractions(1);
            AssertEx.EqualTolerance(-1, -v.DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(2, (Ratio.FromDecimalFractions(3)-v).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(2, (v + v).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(10, (v*10).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(10, (10*v).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(2, (Ratio.FromDecimalFractions(10)/5).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(2, Ratio.FromDecimalFractions(10)/Ratio.FromDecimalFractions(5), DecimalFractionsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Ratio oneDecimalFraction = Ratio.FromDecimalFractions(1);
            Ratio twoDecimalFractions = Ratio.FromDecimalFractions(2);

            Assert.True(oneDecimalFraction < twoDecimalFractions);
            Assert.True(oneDecimalFraction <= twoDecimalFractions);
            Assert.True(twoDecimalFractions > oneDecimalFraction);
            Assert.True(twoDecimalFractions >= oneDecimalFraction);

            Assert.False(oneDecimalFraction > twoDecimalFractions);
            Assert.False(oneDecimalFraction >= twoDecimalFractions);
            Assert.False(twoDecimalFractions < oneDecimalFraction);
            Assert.False(twoDecimalFractions <= oneDecimalFraction);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Ratio decimalfraction = Ratio.FromDecimalFractions(1);
            Assert.Equal(0, decimalfraction.CompareTo(decimalfraction));
            Assert.True(decimalfraction.CompareTo(Ratio.Zero) > 0);
            Assert.True(Ratio.Zero.CompareTo(decimalfraction) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Ratio decimalfraction = Ratio.FromDecimalFractions(1);
            Assert.Throws<ArgumentException>(() => decimalfraction.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Ratio decimalfraction = Ratio.FromDecimalFractions(1);
            Assert.Throws<ArgumentNullException>(() => decimalfraction.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = Ratio.FromDecimalFractions(1);
            var b = Ratio.FromDecimalFractions(2);

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
            var a = Ratio.FromDecimalFractions(1);
            var b = Ratio.FromDecimalFractions(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = Ratio.FromDecimalFractions(1);
            object b = Ratio.FromDecimalFractions(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = Ratio.FromDecimalFractions(1);
            Assert.True(v.Equals(Ratio.FromDecimalFractions(1), DecimalFractionsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Ratio.Zero, DecimalFractionsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = Ratio.FromDecimalFractions(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(Ratio.FromDecimalFractions(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Ratio decimalfraction = Ratio.FromDecimalFractions(1);
            Assert.False(decimalfraction.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Ratio decimalfraction = Ratio.FromDecimalFractions(1);
            Assert.False(decimalfraction.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(RatioUnit.Undefined, Ratio.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(RatioUnit)).Cast<RatioUnit>();
            foreach(var unit in units)
            {
                if (unit == RatioUnit.Undefined)
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
                Assert.Equal("1", new Ratio(1, RatioUnit.DecimalFraction).ToString());
                Assert.Equal("1 ppb", new Ratio(1, RatioUnit.PartPerBillion).ToString());
                Assert.Equal("1 ppm", new Ratio(1, RatioUnit.PartPerMillion).ToString());
                Assert.Equal("1 ‰", new Ratio(1, RatioUnit.PartPerThousand).ToString());
                Assert.Equal("1 ppt", new Ratio(1, RatioUnit.PartPerTrillion).ToString());
                Assert.Equal("1 %", new Ratio(1, RatioUnit.Percent).ToString());
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

            Assert.Equal("1", new Ratio(1, RatioUnit.DecimalFraction).ToString(swedishCulture));
            Assert.Equal("1 ppb", new Ratio(1, RatioUnit.PartPerBillion).ToString(swedishCulture));
            Assert.Equal("1 ppm", new Ratio(1, RatioUnit.PartPerMillion).ToString(swedishCulture));
            Assert.Equal("1 ‰", new Ratio(1, RatioUnit.PartPerThousand).ToString(swedishCulture));
            Assert.Equal("1 ppt", new Ratio(1, RatioUnit.PartPerTrillion).ToString(swedishCulture));
            Assert.Equal("1 %", new Ratio(1, RatioUnit.Percent).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1", new Ratio(0.123456, RatioUnit.DecimalFraction).ToString("s1"));
                Assert.Equal("0.12", new Ratio(0.123456, RatioUnit.DecimalFraction).ToString("s2"));
                Assert.Equal("0.123", new Ratio(0.123456, RatioUnit.DecimalFraction).ToString("s3"));
                Assert.Equal("0.1235", new Ratio(0.123456, RatioUnit.DecimalFraction).ToString("s4"));
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
            Assert.Equal("0.1", new Ratio(0.123456, RatioUnit.DecimalFraction).ToString("s1", culture));
            Assert.Equal("0.12", new Ratio(0.123456, RatioUnit.DecimalFraction).ToString("s2", culture));
            Assert.Equal("0.123", new Ratio(0.123456, RatioUnit.DecimalFraction).ToString("s3", culture));
            Assert.Equal("0.1235", new Ratio(0.123456, RatioUnit.DecimalFraction).ToString("s4", culture));
        }

/*
        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }
*/

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
           Assert.Equal((byte)quantity.Value.Real, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
            Assert.Equal((decimal)quantity.Value.Real, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
            Assert.Equal((double)quantity.Value.Real, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
            Assert.Equal((short)quantity.Value.Real, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
            Assert.Equal((int)quantity.Value.Real, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
            Assert.Equal((long)quantity.Value.Real, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
            Assert.Equal((sbyte)quantity.Value.Real, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
            Assert.Equal((float)quantity.Value.Real, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
            Assert.Equal((ushort)quantity.Value.Real, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
            Assert.Equal((uint)quantity.Value.Real, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
            Assert.Equal((ulong)quantity.Value.Real, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(Ratio)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(RatioUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
            Assert.Equal(Ratio.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
            Assert.Equal(Ratio.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = Ratio.FromDecimalFractions(1.0);
            Assert.Equal(new {Ratio.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = Ratio.FromDecimalFractions(value);
            Assert.Equal(Ratio.FromDecimalFractions(-value), -quantity);
        }
    }
}
