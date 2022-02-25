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
    /// Test of Level.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class LevelTestsBase : QuantityTestsBase
    {
        protected abstract double DecibelsInOneDecibel { get; }
        protected abstract double NepersInOneDecibel { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DecibelsTolerance { get { return 1e-5; } }
        protected virtual double NepersTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(LevelUnit unit)
        {
            return unit switch
            {
                LevelUnit.Decibel => (DecibelsInOneDecibel, DecibelsTolerance),
                LevelUnit.Neper => (NepersInOneDecibel, NepersTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { LevelUnit.Decibel },
            new object[] { LevelUnit.Neper },
        };

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Level((QuantityValue)0.0, LevelUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new Level();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(LevelUnit.Decibel, quantity.Unit);
        }


        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Level(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new Level(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (Level) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void Level_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new Level(1, LevelUnit.Decibel);

            QuantityInfo<LevelUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(Level.Zero, quantityInfo.Zero);
            Assert.Equal("Level", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<LevelUnit>().Except(new[] {LevelUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

        }

        [Fact]
        public void DecibelToLevelUnits()
        {
            Level decibel = Level.FromDecibels(1);
            AssertEx.EqualTolerance(DecibelsInOneDecibel, decibel.Decibels, DecibelsTolerance);
            AssertEx.EqualTolerance(NepersInOneDecibel, decibel.Nepers, NepersTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = Level.From(1, LevelUnit.Decibel);
            AssertEx.EqualTolerance(1, quantity00.Decibels, DecibelsTolerance);
            Assert.Equal(LevelUnit.Decibel, quantity00.Unit);

            var quantity01 = Level.From(1, LevelUnit.Neper);
            AssertEx.EqualTolerance(1, quantity01.Nepers, NepersTolerance);
            Assert.Equal(LevelUnit.Neper, quantity01.Unit);

        }

        [Fact]
        public void As()
        {
            var decibel = Level.FromDecibels(1);
            AssertEx.EqualTolerance(DecibelsInOneDecibel, decibel.As(LevelUnit.Decibel), DecibelsTolerance);
            AssertEx.EqualTolerance(NepersInOneDecibel, decibel.As(LevelUnit.Neper), NepersTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new Level(value: 1, unit: Level.BaseUnit);
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
        public void ToUnit(LevelUnit unit)
        {
            var inBaseUnits = Level.From(1.0, Level.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(LevelUnit unit)
        {
            var quantity = Level.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(LevelUnit unit)
        {
            // See if there is a unit available that is not the base unit.
            var fromUnit = Level.Units.FirstOrDefault(u => u != Level.BaseUnit && u != LevelUnit.Undefined);

            // If there is only one unit for the quantity, we must use the base unit.
            if (fromUnit == LevelUnit.Undefined)
                fromUnit = Level.BaseUnit;

            var quantity = Level.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Level decibel = Level.FromDecibels(1);
            AssertEx.EqualTolerance(1, Level.FromDecibels(decibel.Decibels).Decibels, DecibelsTolerance);
            AssertEx.EqualTolerance(1, Level.FromNepers(decibel.Nepers).Decibels, NepersTolerance);
        }

        [Fact]
        public void LogarithmicArithmeticOperators()
        {
            Level v = Level.FromDecibels(40);
            AssertEx.EqualTolerance(-40, -v.Decibels, NepersTolerance);
            AssertLogarithmicAddition();
            AssertLogarithmicSubtraction();
            AssertEx.EqualTolerance(50, (v*10).Decibels, NepersTolerance);
            AssertEx.EqualTolerance(50, (10*v).Decibels, NepersTolerance);
            AssertEx.EqualTolerance(35, (v/5).Decibels, NepersTolerance);
            AssertEx.EqualTolerance(35, v/Level.FromDecibels(5), NepersTolerance);
        }

        protected abstract void AssertLogarithmicAddition();

        protected abstract void AssertLogarithmicSubtraction();

        [Fact]
        public void ComparisonOperators()
        {
            Level oneDecibel = Level.FromDecibels(1);
            Level twoDecibels = Level.FromDecibels(2);

            Assert.True(oneDecibel < twoDecibels);
            Assert.True(oneDecibel <= twoDecibels);
            Assert.True(twoDecibels > oneDecibel);
            Assert.True(twoDecibels >= oneDecibel);

            Assert.False(oneDecibel > twoDecibels);
            Assert.False(oneDecibel >= twoDecibels);
            Assert.False(twoDecibels < oneDecibel);
            Assert.False(twoDecibels <= oneDecibel);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Level decibel = Level.FromDecibels(1);
            Assert.Equal(0, decibel.CompareTo(decibel));
            Assert.True(decibel.CompareTo(Level.Zero) > 0);
            Assert.True(Level.Zero.CompareTo(decibel) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Level decibel = Level.FromDecibels(1);
            Assert.Throws<ArgumentException>(() => decibel.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Level decibel = Level.FromDecibels(1);
            Assert.Throws<ArgumentNullException>(() => decibel.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = Level.FromDecibels(1);
            var b = Level.FromDecibels(2);

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
            var a = Level.FromDecibels(1);
            var b = Level.FromDecibels(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = Level.FromDecibels(1);
            object b = Level.FromDecibels(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = Level.FromDecibels(1);
            Assert.True(v.Equals(Level.FromDecibels(1), DecibelsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Level.Zero, DecibelsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = Level.FromDecibels(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(Level.FromDecibels(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Level decibel = Level.FromDecibels(1);
            Assert.False(decibel.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Level decibel = Level.FromDecibels(1);
            Assert.False(decibel.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(LevelUnit.Undefined, Level.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(LevelUnit)).Cast<LevelUnit>();
            foreach(var unit in units)
            {
                if (unit == LevelUnit.Undefined)
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
                Assert.Equal("1 dB", new Level(1, LevelUnit.Decibel).ToString());
                Assert.Equal("1 Np", new Level(1, LevelUnit.Neper).ToString());
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

            Assert.Equal("1 dB", new Level(1, LevelUnit.Decibel).ToString(swedishCulture));
            Assert.Equal("1 Np", new Level(1, LevelUnit.Neper).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 dB", new Level(0.123456, LevelUnit.Decibel).ToString("s1"));
                Assert.Equal("0.12 dB", new Level(0.123456, LevelUnit.Decibel).ToString("s2"));
                Assert.Equal("0.123 dB", new Level(0.123456, LevelUnit.Decibel).ToString("s3"));
                Assert.Equal("0.1235 dB", new Level(0.123456, LevelUnit.Decibel).ToString("s4"));
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
            Assert.Equal("0.1 dB", new Level(0.123456, LevelUnit.Decibel).ToString("s1", culture));
            Assert.Equal("0.12 dB", new Level(0.123456, LevelUnit.Decibel).ToString("s2", culture));
            Assert.Equal("0.123 dB", new Level(0.123456, LevelUnit.Decibel).ToString("s3", culture));
            Assert.Equal("0.1235 dB", new Level(0.123456, LevelUnit.Decibel).ToString("s4", culture));
        }

/*
        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }
*/

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = Level.FromDecibels(1.0);
           Assert.Equal((byte)quantity.Value.Real, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal((decimal)quantity.Value.Real, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal((double)quantity.Value.Real, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal((short)quantity.Value.Real, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal((int)quantity.Value.Real, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal((long)quantity.Value.Real, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal((sbyte)quantity.Value.Real, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal((float)quantity.Value.Real, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal((ushort)quantity.Value.Real, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal((uint)quantity.Value.Real, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal((ulong)quantity.Value.Real, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(Level)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(LevelUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal(Level.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal(Level.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal(new {Level.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = Level.FromDecibels(value);
            Assert.Equal(Level.FromDecibels(-value), -quantity);
        }
    }
}
