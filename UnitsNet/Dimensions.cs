// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Collections;
using Fractions;
using System.Diagnostics;

namespace UnitsNet
{
    /// <summary>
    /// A base physical dimension
    /// </summary>
    public partial struct Dimension
    {
        /// <summary>
        /// Creates a base physical dimension
        /// </summary>
        /// <param name="name">The unique identifier of this base dimension</param>
        /// <param name="isDimensionless">The dimension is physically 'Dimensionless' such as 1 radian.</param>
        public Dimension(string name, bool isDimensionless = false)
        {
            Name = name;
            IsDimensionless = isDimensionless;
        }
        /// <summary>
        /// The unique identifier of this base dimension
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The dimension is physically 'Dimensionless' such as 1 radian.
        /// </summary>
        /// <remarks>
        /// Dimensionless dimensions are not factored in during <see cref="Dimensions.Equals(Dimensions)"/>
        /// </remarks>
        public bool IsDimensionless { get; }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is Dimension other && other.Name == this.Name;
        }


        /// <summary>
        /// Tests whether this dimension is equal to some <paramref name="other"/> dimension
        /// </summary>
        /// <param name="other">The dimension to compare to</param>
        /// <returns>True if both dimensions have the same <see cref="Name"/></returns>
        public bool Equals(Dimension other)
        {
            return other.Name == this.Name;
        }


        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        /// <inheritdoc/>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Abbrieviations of all the base dimensions.
        /// </summary>
        public static Dictionary<Dimension, string> Abbreviations => new Dictionary<Dimension, string>()
        {
            { Length,"m"},
            { Mass,"kg"},
            { Time,"s"},
            { Current,"A"},
            { Temperature,"K"}, 
            { Amount,"mol"},
            { LuminousIntensity,"J"},
            { Angle,"rad"},
            { Data,"bit"},
            { VitaminA,"VitaminA"}
        };
    }
    /// <summary>
    ///     Represents the product of base dimensions of a quantity.
    /// </summary>
    [DebuggerDisplay("{ToString()}")]
    public struct Dimensions : IDictionary<Dimension, Fraction>, IEquatable<Dimensions>
    {
        private IDictionary<Dimension, Fraction> _dimensionsDictionary = new Dictionary<Dimension, Fraction>();
        /// <summary>
        /// A dictionary of the dimensions and their exponent
        /// </summary>
        [CLSCompliant(false)]
        public IDictionary<Dimension, Fraction> DimensionsDictionary
        {
            get
            {
                if( _dimensionsDictionary == null)
                {
                    _dimensionsDictionary = new Dictionary<Dimension, Fraction>();
                }
                return _dimensionsDictionary;
            }
        }

        #region IDictionary Implementation
        /// <summary>
        /// Returns the exponent of a given dimension
        /// </summary>
        [CLSCompliant(false)]
        public Fraction this[Dimension key] { get => DimensionsDictionary.TryGetValue(key, out Fraction exponent) ? exponent : 0; set => DimensionsDictionary[key] = value; }

        /// <summary>
        /// The dimensions in this instance with a non-zero exponent.
        /// </summary>
        public ICollection<Dimension> Keys => DimensionsDictionary.Keys;

        /// <summary>
        /// The exponents in this instance which correspond to dimensions.
        /// </summary>
        [CLSCompliant(false)]
        public ICollection<Fraction> Values => DimensionsDictionary.Values;

        /// <inheritdoc/>
        public int Count => DimensionsDictionary.Count;

        /// <inheritdoc/>
        public bool IsReadOnly => DimensionsDictionary.IsReadOnly;

        /// <inheritdoc/>
        [CLSCompliant(false)]
        public void Add(Dimension key, Fraction value)
        {
            DimensionsDictionary.Add(key, value);
        }

        /// <inheritdoc/>
        [CLSCompliant(false)]
        public void Add(KeyValuePair<Dimension, Fraction> item)
        {
            DimensionsDictionary.Add(item);
        }

        /// <inheritdoc/>
        public void Clear()
        {
            DimensionsDictionary.Clear();
        }

        /// <inheritdoc/>
        [CLSCompliant(false)]
        public bool Contains(KeyValuePair<Dimension, Fraction> item)
        {
            return DimensionsDictionary.Contains(item);
        }

        /// <inheritdoc/>
        public bool ContainsKey(Dimension key)
        {
            return DimensionsDictionary.ContainsKey(key);
        }

        /// <inheritdoc/>
        [CLSCompliant(false)]
        public void CopyTo(KeyValuePair<Dimension, Fraction>[] array, int arrayIndex)
        {
            DimensionsDictionary.CopyTo(array, arrayIndex);
        }

        /// <inheritdoc/>
        [CLSCompliant(false)]
        public IEnumerator<KeyValuePair<Dimension, Fraction>> GetEnumerator()
        {
            return DimensionsDictionary?.GetEnumerator();
        }

        /// <inheritdoc/>
        public bool Remove(Dimension key)
        {
            return DimensionsDictionary.Remove(key);
        }

        /// <inheritdoc/>
        [CLSCompliant(false)]
        public bool Remove(KeyValuePair<Dimension, Fraction> item)
        {
            return DimensionsDictionary.Remove(item);
        }

        /// <inheritdoc/>
        [CLSCompliant(false)]
        public bool TryGetValue(Dimension key, out Fraction value)
        {
            return DimensionsDictionary.TryGetValue(key, out value);
        }

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)DimensionsDictionary).GetEnumerator();
        }
        #endregion

        /// <inheritdoc />
        [CLSCompliant(false)]
        public Dimensions(KeyValuePair<Dimension, Fraction>[] dimensions)
        {
            foreach(var item in dimensions)
            {
                DimensionsDictionary.Add(item);
            }
        }
        /// <inheritdoc />
        [CLSCompliant(false)]
        public Dimensions(IDictionary<Dimension, Fraction> dimensions)
        {
            foreach (var item in dimensions)
            {
                DimensionsDictionary.Add(item.Key, item.Value);
            }
        }

        /// <summary>
        /// Checks if the dimensions represent a base quantity.
        /// </summary>
        /// <returns>True if the dimensions represent a base quantity, otherwise false.</returns>
        public bool IsBaseQuantity()
        {
            return DimensionsDictionary.Count == 1 && DimensionsDictionary.First().Value == 1;
        }

        /// <summary>
        /// Checks if the dimensions represent a derived quantity.
        /// </summary>
        /// <returns>True if the dimensions represent a derived quantity, otherwise false.</returns>
        public bool IsDerivedQuantity()
        {
            return !IsBaseQuantity() && !IsDimensionless();
        }

        /// <summary>
        /// Checks if this base dimensions object represents a dimensionless quantity.
        /// </summary>
        /// <returns>True if this object represents a dimensionless quantity, otherwise false.</returns>
        public bool IsDimensionless()
        {
            return DimensionsDictionary.Count == 0;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if(obj is Dimensions dimensions)
            {
                return Equals(dimensions);
            }
            else
            {
                return false;
            }
        }

        /// <inheritdoc/>
        public bool Equals(Dimensions obj)
        {
            if (obj.Where(dim=>!dim.Key.IsDimensionless).Count() != this.Where(dim => !dim.Key.IsDimensionless).Count())
            {
                return false;
            }

            foreach (Dimension item in this.Keys.Where(dim => !dim.IsDimensionless))
            {
                if (!obj.TryGetValue(item, out Fraction fraction) || fraction != this[item])
                {
                    return false;
                }
            }
            return true;
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            int hash = 0;
            foreach(var item in this)
            {
                hash ^= item.Key.GetHashCode();
                hash ^= item.Value.GetHashCode();
            }
            return hash;
        }

        /// <summary>
        /// Get resulting dimensions after multiplying two dimensions, by performing addition of each dimension.
        /// </summary>
        /// <param name="right">Other dimensions.</param>
        /// <returns>Resulting dimensions.</returns>
        public Dimensions Multiply(Dimensions right)
        {
            Dictionary<Dimension, Fraction> result = new Dictionary<Dimension, Fraction>(this);
            foreach (var item in right)
            {
                if (result.ContainsKey(item.Key))
                {
                    result[item.Key] += item.Value;
                    if (result[item.Key] == 0)
                    {
                        result.Remove(item.Key);
                    }
                }
                else
                {
                    result[item.Key] = item.Value;
                }
            }
            return new Dimensions(result);
        }
        /// <summary>
        /// Multiplies each exponent by the given <paramref name="power"/>
        /// </summary>
        /// <param name="power">A value to multiply each exponent by</param>
        /// <returns>A new <see cref="Dimensions"/> array with each exponent multiplied by the <paramref name="power"/></returns>
        public Dimensions Pow(QuantityValue power) => Pow(this, power);

        /// <summary>
        /// Multiplies each exponent by the given <paramref name="power"/>
        /// </summary>
        /// <param name="dimensions">The <see cref="Dimensions"/> to raise to a power.</param>
        /// <param name="power">A value to multiply each exponent by</param>
        /// <returns>A new <see cref="Dimensions"/> array with each exponent multiplied by the <paramref name="power"/></returns>
        public static Dimensions Pow(Dimensions dimensions, QuantityValue power)
        {
            if (!power.IsReal)
            {
                throw new InvalidOperationException("Cannot raise to a complex power");
            }
            Dictionary<Dimension, Fraction> dictionary = new Dictionary<Dimension, Fraction>();
            foreach (var item in dimensions)
            {
                dictionary[item.Key] =  item.Value.Multiply(new Fraction(power.Real));
            }
            return new Dimensions(dictionary);
        }
        /// <summary>
        /// Divides each exponent by 2
        /// </summary>
        /// <returns>A new <see cref="Dimensions"/> array with each exponent divided by 2</returns>
        public Dimensions Sqrt() => Sqrt(this);

        /// <summary>
        /// Divides each exponent by 2
        /// </summary>
        /// <param name="dimensions">The <see cref="Dimensions"/> to take the square root of.</param>
        /// <returns>A new <see cref="Dimensions"/> array with each exponent divided by 2</returns>
        public static Dimensions Sqrt(Dimensions dimensions)
        {
            Dictionary<Dimension, Fraction> dictionary = new Dictionary<Dimension, Fraction>();
            foreach (var item in dimensions)
            {
                dictionary[item.Key] = item.Value / 2;
            }
            return new Dimensions(dictionary);
        }

        /// <summary>
        /// Returns a new Dimensions with the exponents negated.
        /// </summary>
        public Dimensions Inverse => GetInverse(this);

        private Dimensions GetInverse(Dimensions dimensions)
        {
            Dictionary<Dimension, Fraction> inverseDictionary = new Dictionary<Dimension, Fraction>();
            foreach (var item in dimensions)
            {
                inverseDictionary[item.Key] = (-1) * item.Value;
            }
            return new Dimensions(inverseDictionary);
        }
        /// <summary>
        /// Get resulting dimensions after dividing two dimensions, by performing subtraction of each dimension.
        /// </summary>
        /// <param name="right">Other dimensions.</param>
        /// <returns>Resulting dimensions.</returns>
        public Dimensions Divide(Dimensions right)
        {
            Dictionary<Dimension, Fraction> result = new Dictionary<Dimension, Fraction>(this);
            Fraction newValue = 0;
            foreach (var item in right)
            {
                if (result.ContainsKey(item.Key))
                {
                    result[item.Key] -= item.Value;
                    if(result[item.Key] == 0)
                    {
                        result.Remove(item.Key);
                    }
                }
                else
                {
                    result[item.Key] = (-1) * item.Value;
                }
            }
            return new Dimensions(result);
        }

        /// <summary>
        /// Check if two dimensions are equal.
        /// </summary>
        /// <param name="left">Left.</param>
        /// <param name="right">Right.</param>
        /// <returns>True if equal.</returns>
        public static bool operator ==(Dimensions left, Dimensions right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Check if two dimensions are unequal.
        /// </summary>
        /// <param name="left">Left.</param>
        /// <param name="right">Right.</param>
        /// <returns>True if not equal.</returns>
        public static bool operator !=(Dimensions left, Dimensions right)
        {
            return !(left.Equals(right));
        }

        /// <summary>
        /// Multiply two dimensions.
        /// </summary>
        /// <param name="left">Left.</param>
        /// <param name="right">Right.</param>
        /// <returns>Resulting dimensions.</returns>
        public static Dimensions operator *(Dimensions left, Dimensions right)
        {
            return left.Multiply(right);
        }

        /// <summary>
        /// Divide two dimensions.
        /// </summary>
        /// <param name="left">Left.</param>
        /// <param name="right">Right.</param>
        /// <returns>Resulting dimensions.</returns>
        public static Dimensions operator /(Dimensions left, Dimensions right)
        {
            return left.Divide(right);
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach(var item in this)
            {
                AppendDimensionString(sb, item);
            }

            return sb.ToString();
        }

        private static void AppendDimensionString(StringBuilder sb, KeyValuePair<Dimension, Fraction> dimension)
        {
            var absoluteValue = dimension.Value.Abs();

            if (absoluteValue > 0)
            {
                sb.AppendFormat("[{0}]", dimension.Key);

                if (dimension.Value != 1)
                    sb.AppendFormat("^{0}", dimension.Value);
            }
        }

        

        /// <summary>
        /// Represents a dimensionless (unitless) quantity.
        /// </summary>
        public static Dimensions Dimensionless { get; } = new Dimensions();
    }
}
