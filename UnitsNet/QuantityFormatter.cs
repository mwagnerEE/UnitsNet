﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using System.Text;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <summary>
    /// The QuantityFormatter class is responsible for formatting a quantity using the given format string.
    /// </summary>
    public class QuantityFormatter
    {
        /// <summary>
        /// The available UnitsNet custom format specifiers.
        /// </summary>
        private static readonly char[] UnitsNetFormatSpecifiers = { 'A', 'a', 'G', 'g', 'Q', 'q', 'S', 's', 'U', 'u', 'V', 'v' };

        /// <summary>
        /// Formats a quantity using the given format string and format provider.
        /// </summary>
        /// <typeparam name="TUnitType">The quantity's unit type, for example <see cref="LengthUnit"/>.</typeparam>
        /// <param name="quantity">The quantity to format.</param>
        /// <param name="format">The format string.</param>
        /// <remarks>
        /// The valid format strings are as follows:
        /// <list type="bullet">
        ///     <item>
        ///         <term>A standard numeric format string.</term>
        ///         <description>Any of the standard numeric format for <see cref="IQuantity.Value" /> except for "G" or "g".
        ///         "C" or "c", "E" or "e", "F" or "f", "N" or "n", "P" or "p", "R" or "r" are all accepted.
        ///         </description>
        ///     </item>
        ///     <item>
        ///         <term>"G" or "g".</term>
        ///         <description>The value with 2 significant digits after the radix followed by the unit abbreviation, such as "1.23 m".</description>
        ///     </item>
        ///     <item>
        ///         <term>"A" or "a".</term>
        ///         <description>The default unit abbreviation for <see cref="IQuantity{TUnitType}.Unit" />, such as "m".</description>
        ///     </item>
        ///     <item>
        ///         <term>"A0", "A1", ..., "An" or "a0", "a1", ..., "an".</term>
        ///         <description>The n-th unit abbreviation for <see cref="IQuantity{TUnitType}.Unit" />. "a0" is the same as "a".
        ///         A <see cref="FormatException"/> will be thrown if the requested abbreviation index does not exist.</description>
        ///     </item>
        ///     <item>
        ///         <term>"V" or "v".</term>
        ///         <description>The string representation of <see cref="IQuantity.Value" /> using the default ToString method.</description>
        ///     </item>
        ///     <item>
        ///         <term>"U" or "u".</term>
        ///         <description>The enum name of <see cref="IQuantity{TUnitType}.Unit" />, such as "Meter".</description>
        ///     </item>
        ///     <item>
        ///         <term>"Q" or "q".</term>
        ///         <description>The quantity name, such as "Length".</description>
        ///     </item>
        ///     <item>
        ///         <term>"S1", "S2", ..., "Sn" or "s1", "s2", ..., "sn".</term>
        ///         <description>The value with n significant digits after the radix followed by the unit abbreviation. For example,
        ///         "s4" would return "1.2345 m" if <see cref="IQuantity.Value" /> is 1.2345678. Trailing zeros are omitted.</description>
        ///     </item>
        /// </list>
        /// </remarks>
        /// <returns>The string representation.</returns>
        public static string Format<TUnitType>(IQuantity<TUnitType> quantity, string format)
            where TUnitType : Enum
        {
            return Format(quantity, format, CultureInfo.CurrentUICulture);
        }

        /// <summary>
        /// Formats a quantity using the given format string and format provider.
        /// </summary>
        /// <typeparam name="TUnitType">The quantity's unit type, for example <see cref="LengthUnit"/>.</typeparam>
        /// <param name="quantity">The quantity to format.</param>
        /// <param name="format">The format string.</param>
        /// <param name="formatProvider">The format provider to use for localization and number formatting. Defaults to
        /// <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        /// <remarks>
        /// The valid format strings are as follows:
        /// <list type="bullet">
        ///     <item>
        ///         <term>A standard numeric format string.</term>
        ///         <description>Any of the standard numeric format for <see cref="IQuantity.Value" /> except for "G" or "g".
        ///         "C" or "c", "E" or "e", "F" or "f", "N" or "n", "P" or "p", "R" or "r" are all accepted.
        ///         </description>
        ///     </item>
        ///     <item>
        ///         <term>"G" or "g".</term>
        ///         <description>The value with 2 significant digits after the radix followed by the unit abbreviation, such as "1.23 m".</description>
        ///     </item>
        ///     <item>
        ///         <term>"A" or "a".</term>
        ///         <description>The default unit abbreviation for <see cref="IQuantity{TUnitType}.Unit" />, such as "m".</description>
        ///     </item>
        ///     <item>
        ///         <term>"A0", "A1", ..., "An" or "a0", "a1", ..., "an".</term>
        ///         <description>The n-th unit abbreviation for <see cref="IQuantity{TUnitType}.Unit" />. "a0" is the same as "a".
        ///         A <see cref="FormatException"/> will be thrown if the requested abbreviation index does not exist.</description>
        ///     </item>
        ///     <item>
        ///         <term>"V" or "v".</term>
        ///         <description>The string representation of <see cref="IQuantity.Value" /> using the default ToString method.</description>
        ///     </item>
        ///     <item>
        ///         <term>"U" or "u".</term>
        ///         <description>The enum name of <see cref="IQuantity{TUnitType}.Unit" />, such as "Meter".</description>
        ///     </item>
        ///     <item>
        ///         <term>"Q" or "q".</term>
        ///         <description>The quantity name, such as "Length".</description>
        ///     </item>
        ///     <item>
        ///         <term>"S1", "S2", ..., "Sn" or "s1", "s2", ..., "sn".</term>
        ///         <description>The value with n significant digits after the radix followed by the unit abbreviation. For example,
        ///         "s4" would return "1.2345 m" if <see cref="IQuantity.Value" /> is 1.2345678. Trailing zeros are omitted.</description>
        ///     </item>
        /// </list>
        /// </remarks>
        /// <returns>The string representation.</returns>
        public static string Format<TUnitType>(IQuantity<TUnitType> quantity, string? format, IFormatProvider? formatProvider)
            where TUnitType : Enum
        {
            if (quantity is IQuantity<NamelessUnit> namelessQuantity)
            {
                return FormatNamelessUnit(namelessQuantity, format, CultureInfo.CurrentUICulture);
            }
            else
            {
                return FormatUntrimmed(quantity, format, formatProvider).TrimEnd();
            }
        }

        private static string FormatNamelessUnit(IQuantity<NamelessUnit> quantity, string format, IFormatProvider? formatProvider)
        {
            formatProvider ??= CultureInfo.CurrentUICulture;

            if (string.IsNullOrWhiteSpace(format))
                format = "g";

            char formatSpecifier = format[0];

            if (UnitsNetFormatSpecifiers.Any(unitsNetFormatSpecifier => unitsNetFormatSpecifier == formatSpecifier))
            {
                // UnitsNet custom format string

                int precisionSpecifier = 0;

                switch (formatSpecifier)
                {
                    case 'A':
                    case 'a':
                    case 'S':
                    case 's':
                        if (format.Length > 1 && !int.TryParse(format.Substring(1), out precisionSpecifier))
                            throw new FormatException($"The {format} format string is not supported.");
                        break;
                }

                switch (formatSpecifier)
                {
                    case 'G':
                    case 'g':
                        return ToStringWithSignificantDigitsAfterRadix(quantity, formatProvider, 2);
                    case 'V':
                    case 'v':
                        return quantity.Value.ToString(formatProvider);
                    case 'U':
                    case 'u':
                        return quantity.Unit.ToString();
                    case 'Q':
                    case 'q':
                        return quantity.QuantityInfo.Name;
                    case 'A':
                    case 'a':
                    case 'S':
                    case 's':
                        return ToStringWithSignificantDigitsAfterRadix(quantity, formatProvider, precisionSpecifier);
                    default:
                        throw new FormatException($"The {format} format string is not supported.");
                }
            }
            else
            {
                // Anything else is a standard numeric format string with default unit abbreviation postfix.

                //var abbreviations = UnitAbbreviationsCache.Default.GetUnitAbbreviations(quantity.Unit, formatProvider);
                string abbreviation;
                StringBuilder sb = new StringBuilder();
                if (quantity.Dimensions.Count > 0)
                {
                    abbreviation = Dimension.Abbreviations[quantity.Dimensions.First().Key];
                    if (quantity.Dimensions.First().Value == 1)
                    {
                        sb.Append($"{abbreviation}");
                    }
                    else if (quantity.Dimensions.First().Value.Denominator == 1)
                    {
                        sb.Append($"{abbreviation}^({quantity.Dimensions.First().Value.Numerator})");
                    }
                    else
                    {
                        sb.Append($"{abbreviation}^({quantity.Dimensions.First().Value})");
                    }
                }
                foreach(var item in quantity.Dimensions.Skip(1))
                {
                    abbreviation = Dimension.Abbreviations[item.Key];
                    if (item.Value == 1)
                    {
                        sb.Append($"{abbreviation}");
                    }
                    else if (item.Value.Denominator == 1)
                    {
                        sb.Append($"{abbreviation}^({item.Value.Numerator})");
                    }
                    else
                    {
                        sb.Append($"{abbreviation}^({item.Value})");
                    }
                }
                return string.Format(formatProvider, $"{{0:{format}}} {{1}}", quantity.Value, sb.ToString());
            }
        }

        private static string FormatUntrimmed<TUnitType>(IQuantity<TUnitType> quantity, string format, IFormatProvider? formatProvider)
            where TUnitType : Enum
        {
            formatProvider ??= CultureInfo.CurrentUICulture;

            if (string.IsNullOrWhiteSpace(format))
                format = "g";

            char formatSpecifier = format[0];

            if (UnitsNetFormatSpecifiers.Any(unitsNetFormatSpecifier => unitsNetFormatSpecifier == formatSpecifier))
            {
                // UnitsNet custom format string

                int precisionSpecifier = 0;

                switch(formatSpecifier)
                {
                    case 'A':
                    case 'a':
                    case 'S':
                    case 's':
                        if (format.Length > 1 && !int.TryParse(format.Substring(1), out precisionSpecifier))
                            throw new FormatException($"The {format} format string is not supported.");
                        break;
                }

                switch(formatSpecifier)
                {
                    case 'G':
                    case 'g':
                        return ToStringWithSignificantDigitsAfterRadix(quantity, formatProvider, 2);
                    case 'A':
                    case 'a':
                        var abbreviations = UnitAbbreviationsCache.Default.GetUnitAbbreviations(quantity.Unit, formatProvider);

                        if (precisionSpecifier >= abbreviations.Length)
                            throw new FormatException($"The {format} format string is invalid because the abbreviation index does not exist.");

                        return abbreviations[precisionSpecifier];
                    case 'V':
                    case 'v':
                        return quantity.Value.ToString(formatProvider);
                    case 'U':
                    case 'u':
                        return quantity.Unit.ToString();
                    case 'Q':
                    case 'q':
                        return quantity.QuantityInfo.Name;
                    case 'S':
                    case 's':
                        return ToStringWithSignificantDigitsAfterRadix(quantity, formatProvider, precisionSpecifier);
                    default:
                        throw new FormatException($"The {format} format string is not supported.");
                }
            }
            else
            {
                // Anything else is a standard numeric format string with default unit abbreviation postfix.

                var abbreviations = UnitAbbreviationsCache.Default.GetUnitAbbreviations(quantity.Unit, formatProvider);
                return string.Format(formatProvider, $"{{0:{format}}} {{1}}", quantity.Value, abbreviations.First());
            }
        }

        private static string ToStringWithSignificantDigitsAfterRadix<TUnitType>(IQuantity<TUnitType> quantity, IFormatProvider formatProvider, int number) where TUnitType : Enum
        {
            if (quantity.Value.IsReal)
            {
                string formatForSignificantDigits = UnitFormatter.GetFormat(quantity.Value.Real, number);
                object[] formatArgs = null;
                if (quantity is IQuantity<NamelessUnit> namelessQuantity)
                {
                    formatArgs = UnitFormatter.GetFormatArgsNameless(namelessQuantity, quantity.Value.Real, formatProvider, Enumerable.Empty<object>());
                }
                else
                {
                    formatArgs = UnitFormatter.GetFormatArgs(quantity.Unit, quantity.Value.Real, formatProvider, Enumerable.Empty<object>());
                }
                return string.Format(formatProvider, formatForSignificantDigits, formatArgs);
            }
            else
            {
                string formatForSignificantDigits = UnitFormatter.GetFormatComplex(quantity.Value, number);
                object[] formatArgs = null;
                if (quantity is IQuantity<NamelessUnit> namelessQuantity)
                {
                    formatArgs = UnitFormatter.GetFormatArgsComplexNameless(namelessQuantity, quantity.Value, formatProvider, Enumerable.Empty<object>());
                }
                else
                {
                    formatArgs = UnitFormatter.GetFormatArgsComplex(quantity.Unit, quantity.Value, formatProvider, Enumerable.Empty<object>());
                }
                return string.Format(formatProvider, formatForSignificantDigits, formatArgs);
            }
        }
    }
}
