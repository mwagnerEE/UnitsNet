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
using System.Globalization;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;
using UnitsNet.InternalHelpers;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     The number of occurrences of a repeating event per unit time.
    /// </summary>
    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
    public sealed partial class Frequency : IQuantity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly QuantityValue _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly FrequencyUnit? _unit;

        /// <summary>
        ///     Creates the quantity with a value of 0 in the base unit Hertz.
        /// </summary>
        /// <remarks>
        ///     Windows Runtime Component requires a default constructor.
        /// </remarks>
        public Frequency()
        {
            _value = 0;
            _unit = BaseUnit;
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        private Frequency(QuantityValue value, FrequencyUnit unit)
        {
            if (unit == FrequencyUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = value;
            _unit = unit;
        }

        #region Static Properties

        /// <summary>
        ///     Information about the quantity type, such as unit values and names.
        /// </summary>
        internal static QuantityInfo Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of Frequency, which is Hertz. All conversions go via this value.
        /// </summary>
        public static FrequencyUnit BaseUnit { get; }

        /// <summary>
        /// Represents the largest possible value of Frequency
        /// </summary>
        public static Frequency MaxValue { get; }

        /// <summary>
        /// Represents the smallest possible value of Frequency
        /// </summary>
        public static Frequency MinValue { get; }

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        [Obsolete("QuantityType will be removed in the future. Use the Info property instead.")]
        public static QuantityType QuantityType { get; }

        /// <summary>
        ///     All units of measurement for the Frequency quantity.
        /// </summary>
        public static FrequencyUnit[] Units { get; }

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Hertz.
        /// </summary>
        public static Frequency Zero { get; }

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => Convert.ToDouble(_value);

        /// <inheritdoc cref="IQuantity.Unit"/>
        object IQuantity.Unit => Unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public FrequencyUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        internal QuantityInfo QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        [Obsolete("QuantityType will be removed in the future. Use the Info property instead.")]
        public QuantityType Type => Frequency.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => Frequency.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="FrequencyUnit.BeatPerMinute"/>
        /// </summary>
        public double BeatsPerMinute => As(FrequencyUnit.BeatPerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="FrequencyUnit.BUnit"/>
        /// </summary>
        public double BUnits => As(FrequencyUnit.BUnit);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="FrequencyUnit.CyclePerHour"/>
        /// </summary>
        public double CyclesPerHour => As(FrequencyUnit.CyclePerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="FrequencyUnit.CyclePerMinute"/>
        /// </summary>
        public double CyclesPerMinute => As(FrequencyUnit.CyclePerMinute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="FrequencyUnit.Gigahertz"/>
        /// </summary>
        public double Gigahertz => As(FrequencyUnit.Gigahertz);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="FrequencyUnit.Hertz"/>
        /// </summary>
        public double Hertz => As(FrequencyUnit.Hertz);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="FrequencyUnit.Kilohertz"/>
        /// </summary>
        public double Kilohertz => As(FrequencyUnit.Kilohertz);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="FrequencyUnit.Megahertz"/>
        /// </summary>
        public double Megahertz => As(FrequencyUnit.Megahertz);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="FrequencyUnit.PerSecond"/>
        /// </summary>
        public double PerSecond => As(FrequencyUnit.PerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="FrequencyUnit.RadianPerSecond"/>
        /// </summary>
        public double RadiansPerSecond => As(FrequencyUnit.RadianPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="FrequencyUnit.Terahertz"/>
        /// </summary>
        public double Terahertz => As(FrequencyUnit.Terahertz);

        #endregion

        #region Static Methods

        internal static void MapGeneratedLocalizations(UnitAbbreviationsCache unitAbbreviationsCache)
        {
            unitAbbreviationsCache.PerformAbbreviationMapping(FrequencyUnit.BeatPerMinute, new CultureInfo("en-US"), false, true, new string[]{"bpm"});
            unitAbbreviationsCache.PerformAbbreviationMapping(FrequencyUnit.BUnit, new CultureInfo("en-US"), false, true, new string[]{"B Units"});
            unitAbbreviationsCache.PerformAbbreviationMapping(FrequencyUnit.CyclePerHour, new CultureInfo("en-US"), false, true, new string[]{"cph"});
            unitAbbreviationsCache.PerformAbbreviationMapping(FrequencyUnit.CyclePerMinute, new CultureInfo("en-US"), false, true, new string[]{"cpm"});
            unitAbbreviationsCache.PerformAbbreviationMapping(FrequencyUnit.Gigahertz, new CultureInfo("en-US"), false, true, new string[]{"GHz"});
            unitAbbreviationsCache.PerformAbbreviationMapping(FrequencyUnit.Gigahertz, new CultureInfo("ru-RU"), false, true, new string[]{"ГГц"});
            unitAbbreviationsCache.PerformAbbreviationMapping(FrequencyUnit.Hertz, new CultureInfo("en-US"), false, true, new string[]{"Hz"});
            unitAbbreviationsCache.PerformAbbreviationMapping(FrequencyUnit.Hertz, new CultureInfo("ru-RU"), false, true, new string[]{"Гц"});
            unitAbbreviationsCache.PerformAbbreviationMapping(FrequencyUnit.Kilohertz, new CultureInfo("en-US"), false, true, new string[]{"kHz"});
            unitAbbreviationsCache.PerformAbbreviationMapping(FrequencyUnit.Kilohertz, new CultureInfo("ru-RU"), false, true, new string[]{"кГц"});
            unitAbbreviationsCache.PerformAbbreviationMapping(FrequencyUnit.Megahertz, new CultureInfo("en-US"), false, true, new string[]{"MHz"});
            unitAbbreviationsCache.PerformAbbreviationMapping(FrequencyUnit.Megahertz, new CultureInfo("ru-RU"), false, true, new string[]{"МГц"});
            unitAbbreviationsCache.PerformAbbreviationMapping(FrequencyUnit.PerSecond, new CultureInfo("en-US"), false, true, new string[]{"s⁻¹"});
            unitAbbreviationsCache.PerformAbbreviationMapping(FrequencyUnit.PerSecond, new CultureInfo("ru-RU"), false, true, new string[]{"с⁻¹"});
            unitAbbreviationsCache.PerformAbbreviationMapping(FrequencyUnit.RadianPerSecond, new CultureInfo("en-US"), false, true, new string[]{"rad/s"});
            unitAbbreviationsCache.PerformAbbreviationMapping(FrequencyUnit.RadianPerSecond, new CultureInfo("ru-RU"), false, true, new string[]{"рад/с"});
            unitAbbreviationsCache.PerformAbbreviationMapping(FrequencyUnit.Terahertz, new CultureInfo("en-US"), false, true, new string[]{"THz"});
            unitAbbreviationsCache.PerformAbbreviationMapping(FrequencyUnit.Terahertz, new CultureInfo("ru-RU"), false, true, new string[]{"ТГц"});
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(FrequencyUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static string GetAbbreviation(FrequencyUnit unit, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Frequency"/> from <see cref="FrequencyUnit.BeatPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Frequency FromBeatsPerMinute(double beatsperminute)
        {
            QuantityValue value = (QuantityValue) beatsperminute;
            return new Frequency(value, FrequencyUnit.BeatPerMinute);
        }
        /// <summary>
        ///     Creates a <see cref="Frequency"/> from <see cref="FrequencyUnit.BUnit"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Frequency FromBUnits(double bunits)
        {
            QuantityValue value = (QuantityValue) bunits;
            return new Frequency(value, FrequencyUnit.BUnit);
        }
        /// <summary>
        ///     Creates a <see cref="Frequency"/> from <see cref="FrequencyUnit.CyclePerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Frequency FromCyclesPerHour(double cyclesperhour)
        {
            QuantityValue value = (QuantityValue) cyclesperhour;
            return new Frequency(value, FrequencyUnit.CyclePerHour);
        }
        /// <summary>
        ///     Creates a <see cref="Frequency"/> from <see cref="FrequencyUnit.CyclePerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Frequency FromCyclesPerMinute(double cyclesperminute)
        {
            QuantityValue value = (QuantityValue) cyclesperminute;
            return new Frequency(value, FrequencyUnit.CyclePerMinute);
        }
        /// <summary>
        ///     Creates a <see cref="Frequency"/> from <see cref="FrequencyUnit.Gigahertz"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Frequency FromGigahertz(double gigahertz)
        {
            QuantityValue value = (QuantityValue) gigahertz;
            return new Frequency(value, FrequencyUnit.Gigahertz);
        }
        /// <summary>
        ///     Creates a <see cref="Frequency"/> from <see cref="FrequencyUnit.Hertz"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Frequency FromHertz(double hertz)
        {
            QuantityValue value = (QuantityValue) hertz;
            return new Frequency(value, FrequencyUnit.Hertz);
        }
        /// <summary>
        ///     Creates a <see cref="Frequency"/> from <see cref="FrequencyUnit.Kilohertz"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Frequency FromKilohertz(double kilohertz)
        {
            QuantityValue value = (QuantityValue) kilohertz;
            return new Frequency(value, FrequencyUnit.Kilohertz);
        }
        /// <summary>
        ///     Creates a <see cref="Frequency"/> from <see cref="FrequencyUnit.Megahertz"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Frequency FromMegahertz(double megahertz)
        {
            QuantityValue value = (QuantityValue) megahertz;
            return new Frequency(value, FrequencyUnit.Megahertz);
        }
        /// <summary>
        ///     Creates a <see cref="Frequency"/> from <see cref="FrequencyUnit.PerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Frequency FromPerSecond(double persecond)
        {
            QuantityValue value = (QuantityValue) persecond;
            return new Frequency(value, FrequencyUnit.PerSecond);
        }
        /// <summary>
        ///     Creates a <see cref="Frequency"/> from <see cref="FrequencyUnit.RadianPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Frequency FromRadiansPerSecond(double radianspersecond)
        {
            QuantityValue value = (QuantityValue) radianspersecond;
            return new Frequency(value, FrequencyUnit.RadianPerSecond);
        }
        /// <summary>
        ///     Creates a <see cref="Frequency"/> from <see cref="FrequencyUnit.Terahertz"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Frequency FromTerahertz(double terahertz)
        {
            QuantityValue value = (QuantityValue) terahertz;
            return new Frequency(value, FrequencyUnit.Terahertz);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="FrequencyUnit" /> to <see cref="Frequency" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Frequency unit value.</returns>
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static Frequency From(double value, FrequencyUnit fromUnit)
        {
            return new Frequency((QuantityValue)value, fromUnit);
        }

        #endregion

        #region Static Parse Methods

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static Frequency Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static Frequency Parse(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.Parse<Frequency, FrequencyUnit>(
                str,
                provider,
                From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out Frequency result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] string cultureName, out Frequency result)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.TryParse<Frequency, FrequencyUnit>(
                str,
                provider,
                From,
                out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static FrequencyUnit ParseUnit(string str)
        {
            return ParseUnit(str, null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static FrequencyUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.Parse<FrequencyUnit>(str, provider);
        }

        public static bool TryParseUnit(string str, out FrequencyUnit unit)
        {
            return TryParseUnit(str, null, out unit);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="unit">The parsed unit if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.TryParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParseUnit(string str, [CanBeNull] string cultureName, out FrequencyUnit unit)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.TryParse<FrequencyUnit>(str, provider, out unit);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj is null) throw new ArgumentNullException(nameof(obj));
            if (!(obj is Frequency objFrequency)) throw new ArgumentException("Expected type Frequency.", nameof(obj));

            return CompareTo(objFrequency);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        internal int CompareTo(Frequency other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Windows.Foundation.Metadata.DefaultOverload]
        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is Frequency objFrequency))
                return false;

            return Equals(objFrequency);
        }

        public bool Equals(Frequency other)
        {
            return _value.Equals(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another Frequency within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(Frequency other, double tolerance, ComparisonType comparisonType)
        {
            if (tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current Frequency.</returns>
        public override int GetHashCode()
        {
            return new { Info.Name, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        double IQuantity.As(object unit) => As((FrequencyUnit)unit);

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(FrequencyUnit unit)
        {
            if (Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this Frequency to another Frequency with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Frequency with the specified unit.</returns>
        public Frequency ToUnit(FrequencyUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new Frequency(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private QuantityValue AsBaseUnit()
        {
            switch(Unit)
            {
                case FrequencyUnit.BeatPerMinute: return _value / 60;
                case FrequencyUnit.BUnit: return Math.Sqrt(_value * 1e3);
                case FrequencyUnit.CyclePerHour: return _value / 3600;
                case FrequencyUnit.CyclePerMinute: return _value / 60;
                case FrequencyUnit.Gigahertz: return (_value) * 1e9d;
                case FrequencyUnit.Hertz: return _value;
                case FrequencyUnit.Kilohertz: return (_value) * 1e3d;
                case FrequencyUnit.Megahertz: return (_value) * 1e6d;
                case FrequencyUnit.PerSecond: return _value;
                case FrequencyUnit.RadianPerSecond: return _value / 6.2831853072;
                case FrequencyUnit.Terahertz: return (_value) * 1e12d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private QuantityValue AsBaseNumericType(FrequencyUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case FrequencyUnit.BeatPerMinute: return baseUnitValue * 60;
                case FrequencyUnit.BUnit: return baseUnitValue * baseUnitValue * 1e-3;
                case FrequencyUnit.CyclePerHour: return baseUnitValue * 3600;
                case FrequencyUnit.CyclePerMinute: return baseUnitValue * 60;
                case FrequencyUnit.Gigahertz: return (baseUnitValue) / 1e9d;
                case FrequencyUnit.Hertz: return baseUnitValue;
                case FrequencyUnit.Kilohertz: return (baseUnitValue) / 1e3d;
                case FrequencyUnit.Megahertz: return (baseUnitValue) / 1e6d;
                case FrequencyUnit.PerSecond: return baseUnitValue;
                case FrequencyUnit.RadianPerSecond: return baseUnitValue * 6.2831853072;
                case FrequencyUnit.Terahertz: return (baseUnitValue) / 1e12d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(null);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName)
        {
            var provider = cultureName;
            return ToString(provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString(string cultureName, int significantDigitsAfterRadix)
        {
            var provider = cultureName;
            var value = Convert.ToDouble(Value);
            var format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implicitly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName, [NotNull] string format, [NotNull] params object[] args)
        {
            var provider = GetFormatProviderFromCultureName(cultureName);
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? GlobalConfiguration.DefaultCulture;

            var value = Convert.ToDouble(Value);
            var formatArgs = UnitFormatter.GetFormatArgs(Unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion

        private static IFormatProvider GetFormatProviderFromCultureName([CanBeNull] string cultureName)
        {
            return cultureName != null ? new CultureInfo(cultureName) : (IFormatProvider)null;
        }
    }
}
