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
    /// Test of ElectricCurrent.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricCurrentTestsBase : QuantityTestsBase
    {
        protected abstract double AmperesInOneAmpere { get; }
        protected abstract double CentiamperesInOneAmpere { get; }
        protected abstract double KiloamperesInOneAmpere { get; }
        protected abstract double MegaamperesInOneAmpere { get; }
        protected abstract double MicroamperesInOneAmpere { get; }
        protected abstract double MilliamperesInOneAmpere { get; }
        protected abstract double NanoamperesInOneAmpere { get; }
        protected abstract double PicoamperesInOneAmpere { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double AmperesTolerance { get { return 1e-5; } }
        protected virtual double CentiamperesTolerance { get { return 1e-5; } }
        protected virtual double KiloamperesTolerance { get { return 1e-5; } }
        protected virtual double MegaamperesTolerance { get { return 1e-5; } }
        protected virtual double MicroamperesTolerance { get { return 1e-5; } }
        protected virtual double MilliamperesTolerance { get { return 1e-5; } }
        protected virtual double NanoamperesTolerance { get { return 1e-5; } }
        protected virtual double PicoamperesTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(ElectricCurrentUnit unit)
        {
            return unit switch
            {
                ElectricCurrentUnit.Ampere => (AmperesInOneAmpere, AmperesTolerance),
                ElectricCurrentUnit.Centiampere => (CentiamperesInOneAmpere, CentiamperesTolerance),
                ElectricCurrentUnit.Kiloampere => (KiloamperesInOneAmpere, KiloamperesTolerance),
                ElectricCurrentUnit.Megaampere => (MegaamperesInOneAmpere, MegaamperesTolerance),
                ElectricCurrentUnit.Microampere => (MicroamperesInOneAmpere, MicroamperesTolerance),
                ElectricCurrentUnit.Milliampere => (MilliamperesInOneAmpere, MilliamperesTolerance),
                ElectricCurrentUnit.Nanoampere => (NanoamperesInOneAmpere, NanoamperesTolerance),
                ElectricCurrentUnit.Picoampere => (PicoamperesInOneAmpere, PicoamperesTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { ElectricCurrentUnit.Ampere },
            new object[] { ElectricCurrentUnit.Centiampere },
            new object[] { ElectricCurrentUnit.Kiloampere },
            new object[] { ElectricCurrentUnit.Megaampere },
            new object[] { ElectricCurrentUnit.Microampere },
            new object[] { ElectricCurrentUnit.Milliampere },
            new object[] { ElectricCurrentUnit.Nanoampere },
            new object[] { ElectricCurrentUnit.Picoampere },
        };

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricCurrent((QuantityValue)0.0, ElectricCurrentUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ElectricCurrent();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ElectricCurrentUnit.Ampere, quantity.Unit);
        }


        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ElectricCurrent(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new ElectricCurrent(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (ElectricCurrent) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void ElectricCurrent_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ElectricCurrent(1, ElectricCurrentUnit.Ampere);

            QuantityInfo<ElectricCurrentUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ElectricCurrent.Zero, quantityInfo.Zero);
            Assert.Equal("ElectricCurrent", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<ElectricCurrentUnit>().Except(new[] {ElectricCurrentUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

        }

        [Fact]
        public void AmpereToElectricCurrentUnits()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            AssertEx.EqualTolerance(AmperesInOneAmpere, ampere.Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(CentiamperesInOneAmpere, ampere.Centiamperes, CentiamperesTolerance);
            AssertEx.EqualTolerance(KiloamperesInOneAmpere, ampere.Kiloamperes, KiloamperesTolerance);
            AssertEx.EqualTolerance(MegaamperesInOneAmpere, ampere.Megaamperes, MegaamperesTolerance);
            AssertEx.EqualTolerance(MicroamperesInOneAmpere, ampere.Microamperes, MicroamperesTolerance);
            AssertEx.EqualTolerance(MilliamperesInOneAmpere, ampere.Milliamperes, MilliamperesTolerance);
            AssertEx.EqualTolerance(NanoamperesInOneAmpere, ampere.Nanoamperes, NanoamperesTolerance);
            AssertEx.EqualTolerance(PicoamperesInOneAmpere, ampere.Picoamperes, PicoamperesTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ElectricCurrent.From(1, ElectricCurrentUnit.Ampere);
            AssertEx.EqualTolerance(1, quantity00.Amperes, AmperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Ampere, quantity00.Unit);

            var quantity01 = ElectricCurrent.From(1, ElectricCurrentUnit.Centiampere);
            AssertEx.EqualTolerance(1, quantity01.Centiamperes, CentiamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Centiampere, quantity01.Unit);

            var quantity02 = ElectricCurrent.From(1, ElectricCurrentUnit.Kiloampere);
            AssertEx.EqualTolerance(1, quantity02.Kiloamperes, KiloamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Kiloampere, quantity02.Unit);

            var quantity03 = ElectricCurrent.From(1, ElectricCurrentUnit.Megaampere);
            AssertEx.EqualTolerance(1, quantity03.Megaamperes, MegaamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Megaampere, quantity03.Unit);

            var quantity04 = ElectricCurrent.From(1, ElectricCurrentUnit.Microampere);
            AssertEx.EqualTolerance(1, quantity04.Microamperes, MicroamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Microampere, quantity04.Unit);

            var quantity05 = ElectricCurrent.From(1, ElectricCurrentUnit.Milliampere);
            AssertEx.EqualTolerance(1, quantity05.Milliamperes, MilliamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Milliampere, quantity05.Unit);

            var quantity06 = ElectricCurrent.From(1, ElectricCurrentUnit.Nanoampere);
            AssertEx.EqualTolerance(1, quantity06.Nanoamperes, NanoamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Nanoampere, quantity06.Unit);

            var quantity07 = ElectricCurrent.From(1, ElectricCurrentUnit.Picoampere);
            AssertEx.EqualTolerance(1, quantity07.Picoamperes, PicoamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Picoampere, quantity07.Unit);

        }

        [Fact]
        public void As()
        {
            var ampere = ElectricCurrent.FromAmperes(1);
            AssertEx.EqualTolerance(AmperesInOneAmpere, ampere.As(ElectricCurrentUnit.Ampere), AmperesTolerance);
            AssertEx.EqualTolerance(CentiamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Centiampere), CentiamperesTolerance);
            AssertEx.EqualTolerance(KiloamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Kiloampere), KiloamperesTolerance);
            AssertEx.EqualTolerance(MegaamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Megaampere), MegaamperesTolerance);
            AssertEx.EqualTolerance(MicroamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Microampere), MicroamperesTolerance);
            AssertEx.EqualTolerance(MilliamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Milliampere), MilliamperesTolerance);
            AssertEx.EqualTolerance(NanoamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Nanoampere), NanoamperesTolerance);
            AssertEx.EqualTolerance(PicoamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Picoampere), PicoamperesTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new ElectricCurrent(value: 1, unit: ElectricCurrent.BaseUnit);
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
        public void ToUnit(ElectricCurrentUnit unit)
        {
            var inBaseUnits = ElectricCurrent.From(1.0, ElectricCurrent.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(ElectricCurrentUnit unit)
        {
            var quantity = ElectricCurrent.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(ElectricCurrentUnit unit)
        {
            // See if there is a unit available that is not the base unit.
            var fromUnit = ElectricCurrent.Units.FirstOrDefault(u => u != ElectricCurrent.BaseUnit && u != ElectricCurrentUnit.Undefined);

            // If there is only one unit for the quantity, we must use the base unit.
            if (fromUnit == ElectricCurrentUnit.Undefined)
                fromUnit = ElectricCurrent.BaseUnit;

            var quantity = ElectricCurrent.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromAmperes(ampere.Amperes).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromCentiamperes(ampere.Centiamperes).Amperes, CentiamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromKiloamperes(ampere.Kiloamperes).Amperes, KiloamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromMegaamperes(ampere.Megaamperes).Amperes, MegaamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromMicroamperes(ampere.Microamperes).Amperes, MicroamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromMilliamperes(ampere.Milliamperes).Amperes, MilliamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromNanoamperes(ampere.Nanoamperes).Amperes, NanoamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromPicoamperes(ampere.Picoamperes).Amperes, PicoamperesTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricCurrent v = ElectricCurrent.FromAmperes(1);
            AssertEx.EqualTolerance(-1, -v.Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(2, (ElectricCurrent.FromAmperes(3)-v).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(2, (v + v).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(10, (v*10).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(10, (10*v).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(2, (ElectricCurrent.FromAmperes(10)/5).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(2, ElectricCurrent.FromAmperes(10)/ElectricCurrent.FromAmperes(5), AmperesTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricCurrent oneAmpere = ElectricCurrent.FromAmperes(1);
            ElectricCurrent twoAmperes = ElectricCurrent.FromAmperes(2);

            Assert.True(oneAmpere < twoAmperes);
            Assert.True(oneAmpere <= twoAmperes);
            Assert.True(twoAmperes > oneAmpere);
            Assert.True(twoAmperes >= oneAmpere);

            Assert.False(oneAmpere > twoAmperes);
            Assert.False(oneAmpere >= twoAmperes);
            Assert.False(twoAmperes < oneAmpere);
            Assert.False(twoAmperes <= oneAmpere);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            Assert.Equal(0, ampere.CompareTo(ampere));
            Assert.True(ampere.CompareTo(ElectricCurrent.Zero) > 0);
            Assert.True(ElectricCurrent.Zero.CompareTo(ampere) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            Assert.Throws<ArgumentException>(() => ampere.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            Assert.Throws<ArgumentNullException>(() => ampere.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = ElectricCurrent.FromAmperes(1);
            var b = ElectricCurrent.FromAmperes(2);

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
            var a = ElectricCurrent.FromAmperes(1);
            var b = ElectricCurrent.FromAmperes(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = ElectricCurrent.FromAmperes(1);
            object b = ElectricCurrent.FromAmperes(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = ElectricCurrent.FromAmperes(1);
            Assert.True(v.Equals(ElectricCurrent.FromAmperes(1), AmperesTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ElectricCurrent.Zero, AmperesTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = ElectricCurrent.FromAmperes(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(ElectricCurrent.FromAmperes(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            Assert.False(ampere.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            Assert.False(ampere.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ElectricCurrentUnit.Undefined, ElectricCurrent.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ElectricCurrentUnit)).Cast<ElectricCurrentUnit>();
            foreach(var unit in units)
            {
                if (unit == ElectricCurrentUnit.Undefined)
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
                Assert.Equal("1 A", new ElectricCurrent(1, ElectricCurrentUnit.Ampere).ToString());
                Assert.Equal("1 cA", new ElectricCurrent(1, ElectricCurrentUnit.Centiampere).ToString());
                Assert.Equal("1 kA", new ElectricCurrent(1, ElectricCurrentUnit.Kiloampere).ToString());
                Assert.Equal("1 MA", new ElectricCurrent(1, ElectricCurrentUnit.Megaampere).ToString());
                Assert.Equal("1 µA", new ElectricCurrent(1, ElectricCurrentUnit.Microampere).ToString());
                Assert.Equal("1 mA", new ElectricCurrent(1, ElectricCurrentUnit.Milliampere).ToString());
                Assert.Equal("1 nA", new ElectricCurrent(1, ElectricCurrentUnit.Nanoampere).ToString());
                Assert.Equal("1 pA", new ElectricCurrent(1, ElectricCurrentUnit.Picoampere).ToString());
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

            Assert.Equal("1 A", new ElectricCurrent(1, ElectricCurrentUnit.Ampere).ToString(swedishCulture));
            Assert.Equal("1 cA", new ElectricCurrent(1, ElectricCurrentUnit.Centiampere).ToString(swedishCulture));
            Assert.Equal("1 kA", new ElectricCurrent(1, ElectricCurrentUnit.Kiloampere).ToString(swedishCulture));
            Assert.Equal("1 MA", new ElectricCurrent(1, ElectricCurrentUnit.Megaampere).ToString(swedishCulture));
            Assert.Equal("1 µA", new ElectricCurrent(1, ElectricCurrentUnit.Microampere).ToString(swedishCulture));
            Assert.Equal("1 mA", new ElectricCurrent(1, ElectricCurrentUnit.Milliampere).ToString(swedishCulture));
            Assert.Equal("1 nA", new ElectricCurrent(1, ElectricCurrentUnit.Nanoampere).ToString(swedishCulture));
            Assert.Equal("1 pA", new ElectricCurrent(1, ElectricCurrentUnit.Picoampere).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 A", new ElectricCurrent(0.123456, ElectricCurrentUnit.Ampere).ToString("s1"));
                Assert.Equal("0.12 A", new ElectricCurrent(0.123456, ElectricCurrentUnit.Ampere).ToString("s2"));
                Assert.Equal("0.123 A", new ElectricCurrent(0.123456, ElectricCurrentUnit.Ampere).ToString("s3"));
                Assert.Equal("0.1235 A", new ElectricCurrent(0.123456, ElectricCurrentUnit.Ampere).ToString("s4"));
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
            Assert.Equal("0.1 A", new ElectricCurrent(0.123456, ElectricCurrentUnit.Ampere).ToString("s1", culture));
            Assert.Equal("0.12 A", new ElectricCurrent(0.123456, ElectricCurrentUnit.Ampere).ToString("s2", culture));
            Assert.Equal("0.123 A", new ElectricCurrent(0.123456, ElectricCurrentUnit.Ampere).ToString("s3", culture));
            Assert.Equal("0.1235 A", new ElectricCurrent(0.123456, ElectricCurrentUnit.Ampere).ToString("s4", culture));
        }

/*
        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }
*/

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
           Assert.Equal((byte)quantity.Value.Real, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal((decimal)quantity.Value.Real, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal((double)quantity.Value.Real, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal((short)quantity.Value.Real, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal((int)quantity.Value.Real, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal((long)quantity.Value.Real, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal((sbyte)quantity.Value.Real, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal((float)quantity.Value.Real, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal((ushort)quantity.Value.Real, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal((uint)quantity.Value.Real, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal((ulong)quantity.Value.Real, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(ElectricCurrent)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ElectricCurrentUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal(ElectricCurrent.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal(ElectricCurrent.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = ElectricCurrent.FromAmperes(1.0);
            Assert.Equal(new {ElectricCurrent.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = ElectricCurrent.FromAmperes(value);
            Assert.Equal(ElectricCurrent.FromAmperes(-value), -quantity);
        }
    }
}
