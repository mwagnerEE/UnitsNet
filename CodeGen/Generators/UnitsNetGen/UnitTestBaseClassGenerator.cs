﻿using System;
using System.Linq;
using CodeGen.JsonTypes;

namespace CodeGen.Generators.UnitsNetGen
{
    /// <summary>
    /// Generates base class for each quantity test class, with stubs for testing conversion functions and error tolerances that the developer must complete to fix compile errors.
    /// </summary>
    /// <example>
    /// <list type="bullet">
    /// <item><description>UnitsNet.Tests\GeneratedCode\AccelerationTestsBase.g.cs</description></item>
    /// <item><description>UnitsNet.Tests\GeneratedCode\LengthTestsBase.g.cs</description></item>
    /// </list>
    /// </example>
    internal class UnitTestBaseClassGenerator : GeneratorBase
    {
        /// <summary>
        /// The quantity to generate test base class for.
        /// </summary>
        private readonly Quantity _quantity;

        /// <summary>
        /// Base unit for this quantity, such as Meter for quantity Length.
        /// </summary>
        private readonly Unit _baseUnit;

        /// <summary>
        /// Example: "LengthUnit"
        /// </summary>
        private readonly string _unitEnumName;

        /// <summary>
        /// Example: " m" for Length quantity with leading whitespace or "" for Ratio quantity where base unit does not have an abbreviation.
        /// </summary>
        private readonly string _baseUnitEnglishAbbreviation;

        /// <summary>
        /// Example: "LengthUnit.Meter".
        /// </summary>
        private readonly string _baseUnitFullName;

        /// <summary>
        /// Constructors for decimal-backed quantities require decimal numbers as input, so add the "m" suffix to numbers when constructing those quantities.
        /// </summary>
        private readonly string _numberSuffix;

        public UnitTestBaseClassGenerator(Quantity quantity)
        {
            _quantity = quantity;
            _baseUnit = quantity.Units.FirstOrDefault(u => u.SingularName == _quantity.BaseUnit) ??
                        throw new ArgumentException($"No unit found with SingularName equal to BaseUnit [{_quantity.BaseUnit}]. This unit must be defined.",
                            nameof(quantity));
            _unitEnumName = $"{quantity.Name}Unit";
            _baseUnitEnglishAbbreviation = GetEnglishAbbreviation(_baseUnit);
            _baseUnitFullName = $"{_unitEnumName}.{_baseUnit.SingularName}";
            _numberSuffix = quantity.BaseType == "decimal" ? "m" : "";
        }

        private string GetUnitFullName(Unit unit) => $"{_unitEnumName}.{unit.SingularName}";

        /// <summary>
        /// Gets the first en-US abbreviation for the unit -or- empty string if none is defined.
        /// If a unit abbreviation exists, a leading whitespace is added to separate the number and the abbreviation like "1 m".
        /// </summary>
        private static string GetEnglishAbbreviation(Unit unit)
        {
            var unitAbbreviation = unit.Localization.First(l => l.Culture == "en-US").Abbreviations.FirstOrDefault();
            return string.IsNullOrEmpty(unitAbbreviation) ? "" : $" {unitAbbreviation}";
        }

        public override string Generate()
        {
            var baseUnitVariableName = _baseUnit.SingularName.ToLowerInvariant();

            Writer.WL(GeneratedFileHeader);
            Writer.WL($@"
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
{{
    /// <summary>
    /// Test of {_quantity.Name}.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class {_quantity.Name}TestsBase : QuantityTestsBase
    {{");
            foreach (var unit in _quantity.Units)
            {
                if (unit.SkipConversionGeneration)
                    continue;

                Writer.WL($@"
        protected abstract double {unit.PluralName}InOne{_baseUnit.SingularName} {{ get; }}");
            }

            Writer.WL("");
            Writer.WL($@"
// ReSharper disable VirtualMemberNeverOverriden.Global");
            foreach (var unit in _quantity.Units)
            {
                if (unit.SkipConversionGeneration)
                    continue;

                Writer.WL($@"
        protected virtual double {unit.PluralName}Tolerance {{ get {{ return 1e-5; }} }}");
            }
        Writer.WL($@"
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor({_unitEnumName} unit)
        {{
            return unit switch
            {{");
            foreach(var unit in _quantity.Units) Writer.WL($@"
                {GetUnitFullName(unit)} => ({unit.PluralName}InOne{_baseUnit.SingularName}, {unit.PluralName}Tolerance),");
            Writer.WL($@"
                _ => throw new NotSupportedException()
            }};
        }}

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {{");
            foreach(var unit in _quantity.Units)
            {
                Writer.WL($@"
            new object[] {{ {GetUnitFullName(unit)} }},");
            }
            Writer.WL($@"
        }};

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {{
            Assert.Throws<ArgumentException>(() => new {_quantity.Name}(({_quantity.BaseType})0.0, {_unitEnumName}.Undefined));
        }}

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {{
            var quantity = new {_quantity.Name}();
            Assert.Equal(0, quantity.Value);");
            if (_quantity.BaseType == "decimal") Writer.WL($@"
            Assert.Equal(0m, ((IDecimalQuantity)quantity).Value);");
            Writer.WL($@"
            Assert.Equal({_baseUnitFullName}, quantity.Unit);
        }}

");
            if (_quantity.BaseType == "double") Writer.WL($@"
        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {{
            Assert.Throws<ArgumentException>(() => new {_quantity.Name}(double.PositiveInfinity, {_baseUnitFullName}));
            Assert.Throws<ArgumentException>(() => new {_quantity.Name}(double.NegativeInfinity, {_baseUnitFullName}));
        }}

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {{
            Assert.Throws<ArgumentException>(() => new {_quantity.Name}(double.NaN, {_baseUnitFullName}));
        }}
"); Writer.WL($@"

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {{
            Assert.Throws<ArgumentNullException>(() => new {_quantity.Name}(value: 1, unitSystem: null));
        }}

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {{
            Func<object> TestCode = () => new {_quantity.Name}(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {{
                var quantity = ({_quantity.Name}) TestCode();
                Assert.Equal(1, quantity.Value);
            }}
            else
            {{
                Assert.Throws<ArgumentException>(TestCode);
            }}
        }}

        [Fact]
        public void {_quantity.Name}_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {{
            var quantity = new {_quantity.Name}(1, {_baseUnitFullName});

            QuantityInfo<{_unitEnumName}> quantityInfo = quantity.QuantityInfo;

            Assert.Equal({_quantity.Name}.Zero, quantityInfo.Zero);
            Assert.Equal(""{_quantity.Name}"", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<{_unitEnumName}>().Except(new[] {{{_unitEnumName}.Undefined}}).ToArray();
            var unitNames = units.Select(x => x.ToString());

        }}

        [Fact]
        public void {_baseUnit.SingularName}To{_quantity.Name}Units()
        {{
            {_quantity.Name} {baseUnitVariableName} = {_quantity.Name}.From{_baseUnit.PluralName}(1);");

            foreach(var unit in _quantity.Units) Writer.WL($@"
            AssertEx.EqualTolerance({unit.PluralName}InOne{_baseUnit.SingularName}, {baseUnitVariableName}.{unit.PluralName}, {unit.PluralName}Tolerance);");
            Writer.WL($@"
        }}

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {{");
            int i = 0;
            foreach(var unit in _quantity.Units)
            {
                var quantityVariable = $"quantity{i++:D2}";
                Writer.WL($@"
            var {quantityVariable} = {_quantity.Name}.From(1, {GetUnitFullName(unit)});
            AssertEx.EqualTolerance(1, {quantityVariable}.{unit.PluralName}, {unit.PluralName}Tolerance);
            Assert.Equal({GetUnitFullName(unit)}, {quantityVariable}.Unit);
");

            }
            Writer.WL($@"
        }}
");
            if (_quantity.BaseType == "double") Writer.WL($@"
        [Fact]
        public void From{_baseUnit.PluralName}_WithInfinityValue_ThrowsArgumentException()
        {{
            Assert.Throws<ArgumentException>(() => {_quantity.Name}.From{_baseUnit.PluralName}(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => {_quantity.Name}.From{_baseUnit.PluralName}(double.NegativeInfinity));
        }}

        [Fact]
        public void From{_baseUnit.PluralName}_WithNanValue_ThrowsArgumentException()
        {{
            Assert.Throws<ArgumentException>(() => {_quantity.Name}.From{_baseUnit.PluralName}(double.NaN));
        }}
"); Writer.WL($@"

        [Fact]
        public void As()
        {{
            var {baseUnitVariableName} = {_quantity.Name}.From{_baseUnit.PluralName}(1);");
            foreach(var unit in _quantity.Units) Writer.WL($@"
            AssertEx.EqualTolerance({unit.PluralName}InOne{_baseUnit.SingularName}, {baseUnitVariableName}.As({GetUnitFullName(unit)}), {unit.PluralName}Tolerance);");
            Writer.WL($@"
        }}

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {{
            var quantity = new {_quantity.Name}(value: 1, unit: {_quantity.Name}.BaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {{
                var value = ({_quantity.BaseType}) AsWithSIUnitSystem();
                Assert.Equal(1, value);
            }}
            else
            {{
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }}
        }}

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit({_unitEnumName} unit)
        {{
            var inBaseUnits = {_quantity.Name}.From(1.0, {_quantity.Name}.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }}

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual({_unitEnumName} unit)
        {{
            var quantity = {_quantity.Name}.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }}

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit({_unitEnumName} unit)
        {{
            // See if there is a unit available that is not the base unit.
            var fromUnit = {_quantity.Name}.Units.FirstOrDefault(u => u != {_quantity.Name}.BaseUnit && u != {_unitEnumName}.Undefined);

            // If there is only one unit for the quantity, we must use the base unit.
            if (fromUnit == {_unitEnumName}.Undefined)
                fromUnit = {_quantity.Name}.BaseUnit;

            var quantity = {_quantity.Name}.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }}

        [Fact]
        public void ConversionRoundTrip()
        {{
            {_quantity.Name} {baseUnitVariableName} = {_quantity.Name}.From{_baseUnit.PluralName}(1);");
            foreach (var unit in _quantity.Units) Writer.WL($@"
            AssertEx.EqualTolerance(1, {_quantity.Name}.From{unit.PluralName}({baseUnitVariableName}.{unit.PluralName}).{_baseUnit.PluralName}, {unit.PluralName}Tolerance);");
            Writer.WL($@"
        }}
");
            if (_quantity.Logarithmic)
            {
                var unit = _quantity.Units.Last();
                Writer.WL($@"
        [Fact]
        public void LogarithmicArithmeticOperators()
        {{
            {_quantity.Name} v = {_quantity.Name}.From{_baseUnit.PluralName}(40);
            AssertEx.EqualTolerance(-40, -v.{_baseUnit.PluralName}, {unit.PluralName}Tolerance);
            AssertLogarithmicAddition();
            AssertLogarithmicSubtraction();
            AssertEx.EqualTolerance(50, (v*10).{_baseUnit.PluralName}, {unit.PluralName}Tolerance);
            AssertEx.EqualTolerance(50, (10*v).{_baseUnit.PluralName}, {unit.PluralName}Tolerance);
            AssertEx.EqualTolerance(35, (v/5).{_baseUnit.PluralName}, {unit.PluralName}Tolerance);
            AssertEx.EqualTolerance(35, v/{_quantity.Name}.From{_baseUnit.PluralName}(5), {unit.PluralName}Tolerance);
        }}

        protected abstract void AssertLogarithmicAddition();

        protected abstract void AssertLogarithmicSubtraction();
");
            }
            else if (_quantity.GenerateArithmetic)
            {
                Writer.WL($@"
        [Fact]
        public void ArithmeticOperators()
        {{
            {_quantity.Name} v = {_quantity.Name}.From{_baseUnit.PluralName}(1);
            AssertEx.EqualTolerance(-1, -v.{_baseUnit.PluralName}, {_baseUnit.PluralName}Tolerance);
            AssertEx.EqualTolerance(2, ({_quantity.Name}.From{_baseUnit.PluralName}(3)-v).{_baseUnit.PluralName}, {_baseUnit.PluralName}Tolerance);
            AssertEx.EqualTolerance(2, (v + v).{_baseUnit.PluralName}, {_baseUnit.PluralName}Tolerance);
            AssertEx.EqualTolerance(10, (v*10).{_baseUnit.PluralName}, {_baseUnit.PluralName}Tolerance);
            AssertEx.EqualTolerance(10, (10*v).{_baseUnit.PluralName}, {_baseUnit.PluralName}Tolerance);
            AssertEx.EqualTolerance(2, ({_quantity.Name}.From{_baseUnit.PluralName}(10)/5).{_baseUnit.PluralName}, {_baseUnit.PluralName}Tolerance);
            AssertEx.EqualTolerance(2, {_quantity.Name}.From{_baseUnit.PluralName}(10)/{_quantity.Name}.From{_baseUnit.PluralName}(5), {_baseUnit.PluralName}Tolerance);
        }}
");
            }
            else
            {
                Writer.WL("");
            }

            Writer.WL($@"
        [Fact]
        public void ComparisonOperators()
        {{
            {_quantity.Name} one{_baseUnit.SingularName} = {_quantity.Name}.From{_baseUnit.PluralName}(1);
            {_quantity.Name} two{_baseUnit.PluralName} = {_quantity.Name}.From{_baseUnit.PluralName}(2);

            Assert.True(one{_baseUnit.SingularName} < two{_baseUnit.PluralName});
            Assert.True(one{_baseUnit.SingularName} <= two{_baseUnit.PluralName});
            Assert.True(two{_baseUnit.PluralName} > one{_baseUnit.SingularName});
            Assert.True(two{_baseUnit.PluralName} >= one{_baseUnit.SingularName});

            Assert.False(one{_baseUnit.SingularName} > two{_baseUnit.PluralName});
            Assert.False(one{_baseUnit.SingularName} >= two{_baseUnit.PluralName});
            Assert.False(two{_baseUnit.PluralName} < one{_baseUnit.SingularName});
            Assert.False(two{_baseUnit.PluralName} <= one{_baseUnit.SingularName});
        }}

        [Fact]
        public void CompareToIsImplemented()
        {{
            {_quantity.Name} {baseUnitVariableName} = {_quantity.Name}.From{_baseUnit.PluralName}(1);
            Assert.Equal(0, {baseUnitVariableName}.CompareTo({baseUnitVariableName}));
            Assert.True({baseUnitVariableName}.CompareTo({_quantity.Name}.Zero) > 0);
            Assert.True({_quantity.Name}.Zero.CompareTo({baseUnitVariableName}) < 0);
        }}

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {{
            {_quantity.Name} {baseUnitVariableName} = {_quantity.Name}.From{_baseUnit.PluralName}(1);
            Assert.Throws<ArgumentException>(() => {baseUnitVariableName}.CompareTo(new object()));
        }}

        [Fact]
        public void CompareToThrowsOnNull()
        {{
            {_quantity.Name} {baseUnitVariableName} = {_quantity.Name}.From{_baseUnit.PluralName}(1);
            Assert.Throws<ArgumentNullException>(() => {baseUnitVariableName}.CompareTo(null));
        }}

        [Fact]
        public void EqualityOperators()
        {{
            var a = {_quantity.Name}.From{_baseUnit.PluralName}(1);
            var b = {_quantity.Name}.From{_baseUnit.PluralName}(2);

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
        }}

        [Fact]
        public void Equals_SameType_IsImplemented()
        {{
            var a = {_quantity.Name}.From{_baseUnit.PluralName}(1);
            var b = {_quantity.Name}.From{_baseUnit.PluralName}(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }}

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {{
            object a = {_quantity.Name}.From{_baseUnit.PluralName}(1);
            object b = {_quantity.Name}.From{_baseUnit.PluralName}(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }}

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {{
            var v = {_quantity.Name}.From{_baseUnit.PluralName}(1);
            Assert.True(v.Equals({_quantity.Name}.From{_baseUnit.PluralName}(1), {_baseUnit.PluralName}Tolerance, ComparisonType.Relative));
            Assert.False(v.Equals({_quantity.Name}.Zero, {_baseUnit.PluralName}Tolerance, ComparisonType.Relative));
        }}

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {{
            var v = {_quantity.Name}.From{_baseUnit.PluralName}(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals({_quantity.Name}.From{_baseUnit.PluralName}(1), -1, ComparisonType.Relative));
        }}

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {{
            {_quantity.Name} {baseUnitVariableName} = {_quantity.Name}.From{_baseUnit.PluralName}(1);
            Assert.False({baseUnitVariableName}.Equals(new object()));
        }}

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {{
            {_quantity.Name} {baseUnitVariableName} = {_quantity.Name}.From{_baseUnit.PluralName}(1);
            Assert.False({baseUnitVariableName}.Equals(null));
        }}

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {{
            Assert.DoesNotContain({_unitEnumName}.Undefined, {_quantity.Name}.Units);
        }}

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {{
            var units = Enum.GetValues(typeof({_unitEnumName})).Cast<{_unitEnumName}>();
            foreach(var unit in units)
            {{
                if (unit == {_unitEnumName}.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }}
        }}

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {{
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(""en-US"");
            try {{");
            foreach (var unit in _quantity.Units)
            {
                Writer.WL($@"
                Assert.Equal(""1{GetEnglishAbbreviation(unit)}"", new {_quantity.Name}(1, {GetUnitFullName(unit)}).ToString());");
            }
            Writer.WL($@"
            }}
            finally
            {{
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }}
        }}

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {{
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo(""sv-SE"");
");
            foreach (var unit in _quantity.Units)
            {
                Writer.WL($@"
            Assert.Equal(""1{GetEnglishAbbreviation(unit)}"", new {_quantity.Name}(1, {GetUnitFullName(unit)}).ToString(swedishCulture));");
            }
            Writer.WL($@"
        }}

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {{
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {{
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal(""0.1{_baseUnitEnglishAbbreviation}"", new {_quantity.Name}(0.123456{_numberSuffix}, {_baseUnitFullName}).ToString(""s1""));
                Assert.Equal(""0.12{_baseUnitEnglishAbbreviation}"", new {_quantity.Name}(0.123456{_numberSuffix}, {_baseUnitFullName}).ToString(""s2""));
                Assert.Equal(""0.123{_baseUnitEnglishAbbreviation}"", new {_quantity.Name}(0.123456{_numberSuffix}, {_baseUnitFullName}).ToString(""s3""));
                Assert.Equal(""0.1235{_baseUnitEnglishAbbreviation}"", new {_quantity.Name}(0.123456{_numberSuffix}, {_baseUnitFullName}).ToString(""s4""));
            }}
            finally
            {{
                CultureInfo.CurrentUICulture = oldCulture;
            }}
        }}

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {{
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal(""0.1{_baseUnitEnglishAbbreviation}"", new {_quantity.Name}(0.123456{_numberSuffix}, {_baseUnitFullName}).ToString(""s1"", culture));
            Assert.Equal(""0.12{_baseUnitEnglishAbbreviation}"", new {_quantity.Name}(0.123456{_numberSuffix}, {_baseUnitFullName}).ToString(""s2"", culture));
            Assert.Equal(""0.123{_baseUnitEnglishAbbreviation}"", new {_quantity.Name}(0.123456{_numberSuffix}, {_baseUnitFullName}).ToString(""s3"", culture));
            Assert.Equal(""0.1235{_baseUnitEnglishAbbreviation}"", new {_quantity.Name}(0.123456{_numberSuffix}, {_baseUnitFullName}).ToString(""s4"", culture));
        }}

/*
        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }}

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, ""g"", null));
        }}

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, ""g""), quantity.ToString(null, ""g""));
        }}
*/

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }}

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
           Assert.Equal((byte)quantity.Value.Real, Convert.ToByte(quantity));
        }}

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }}

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }}

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
            Assert.Equal((decimal)quantity.Value.Real, Convert.ToDecimal(quantity));
        }}

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
            Assert.Equal((double)quantity.Value.Real, Convert.ToDouble(quantity));
        }}

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
            Assert.Equal((short)quantity.Value.Real, Convert.ToInt16(quantity));
        }}

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
            Assert.Equal((int)quantity.Value.Real, Convert.ToInt32(quantity));
        }}

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
            Assert.Equal((long)quantity.Value.Real, Convert.ToInt64(quantity));
        }}

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
            Assert.Equal((sbyte)quantity.Value.Real, Convert.ToSByte(quantity));
        }}

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
            Assert.Equal((float)quantity.Value.Real, Convert.ToSingle(quantity));
        }}

        [Fact]
        public void Convert_ToString_EqualsToString()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }}

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
            Assert.Equal((ushort)quantity.Value.Real, Convert.ToUInt16(quantity));
        }}

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
            Assert.Equal((uint)quantity.Value.Real, Convert.ToUInt32(quantity));
        }}

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
            Assert.Equal((ulong)quantity.Value.Real, Convert.ToUInt64(quantity));
        }}

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof({_quantity.Name})));
        }}

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof({_unitEnumName})));
        }}

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
            Assert.Equal({_quantity.Name}.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }}

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
            Assert.Equal({_quantity.Name}.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }}

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }}

        [Fact]
        public void GetHashCode_Equals()
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(1.0);
            Assert.Equal(new {{{_quantity.Name}.Info.Name, quantity.Value, quantity.Unit}}.GetHashCode(), quantity.GetHashCode());
        }}
");

        if (_quantity.GenerateArithmetic)
        {
                Writer.WL($@"
        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {{
            var quantity = {_quantity.Name}.From{_baseUnit.PluralName}(value);
            Assert.Equal({_quantity.Name}.From{_baseUnit.PluralName}(-value), -quantity);
        }}");
        }

Writer.WL($@"
    }}
}}");
            return Writer.ToString();
        }
    }
}
