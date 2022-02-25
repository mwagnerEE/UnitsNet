using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Numerics;
using System.Text;
using System.Runtime.Serialization;

namespace UnitsNet
{
    /// <summary>
    /// A unit which does not correspond to a named Quantity
    /// </summary>
    public enum NamelessUnit
    {
        /// <summary>
        /// The only value
        /// </summary>
        Nameless = 0
    }
    /// <summary>
    /// The base class for all Quantities, and the default type returned after arithmetic if the result has Dimensions which do not correspond to a named Quantity 
    /// </summary>
    [DataContract]
    public class QuantityBase : IQuantity, IQuantity<NamelessUnit>, IEquatable<IQuantity>, IComparable, IComparable<IQuantity>, IFormattable
    {
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="dimensions">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public QuantityBase(QuantityValue value, Dimensions dimensions)
        {
            _value = value;
            _dimensions = dimensions;
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="dimensions">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public QuantityBase(double value, Dimensions dimensions) : this(new QuantityValue(value), dimensions)
        {
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The complex numeric value to construct this quantity with.</param>
        /// <param name="dimensions">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public QuantityBase(Complex value, Dimensions dimensions) : this(new QuantityValue(value), dimensions)
        {
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and base units.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static IQuantity FromBaseUnits(QuantityValue value)
        {
            return new Density(value);
        }

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        [DataMember(Name = nameof(Value), Order = 0)]
        private readonly QuantityValue _value;

        
        [DataMember(Name = nameof(Dimensions), Order = 1)]
        private readonly Dimensions _dimensions;

        /// <inheritdoc cref="IQuantity.Dimensions"/>
        public Dimensions Dimensions => _dimensions;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo QuantityInfo => null;

        /// <inheritdoc cref="IQuantity.Value"/>
        public QuantityValue Value => _value;

        /// <inheritdoc cref="IQuantity.InBaseUnits"/>
        public virtual QuantityValue InBaseUnits => _value;

        Dimensions IQuantity.Dimensions => _dimensions;

        QuantityInfo IQuantity.QuantityInfo => QuantityInfo;

        Enum IQuantity.Unit => NamelessUnit.Nameless;

        QuantityValue IQuantity.Value => Value;

        QuantityValue IQuantity.InBaseUnits => InBaseUnits;

        NamelessUnit IQuantity<NamelessUnit>.Unit => NamelessUnit.Nameless;

        QuantityInfo<NamelessUnit> IQuantity<NamelessUnit>.QuantityInfo => null;

        /// <inheritdoc />
        public virtual string ToString(IFormatProvider? provider)
        {
            return ToString("g", provider);
        }

        /// <inheritdoc />
        public virtual string ToString(string? format, IFormatProvider? formatProvider)
        {
            return QuantityFormatter.Format<NamelessUnit>(this, format, formatProvider);
        }

        /// <inheritdoc />
        public virtual IQuantity ToUnit(Enum unit)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public virtual IQuantity ToUnit(Enum unit, UnitConverter unitConverter)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public virtual IQuantity ToUnit(UnitSystem unitSystem)
        {
            throw new NotImplementedException();
        }

        #region Arithmetic Operators

        /// <summary>
        /// Tests whether two quantities have the same <see cref="Dimensions"/>
        /// </summary>
        /// <returns>True if the two quantities have the same <see cref="Dimensions"/>, False otherwise</returns>
        public static bool HasSameDimensions(IQuantity left, IQuantity right) => left.Dimensions == right.Dimensions;
        /// <summary>
        /// Tests whether this quantity has the same <see cref="Dimensions"/> as an <paramref name="other"/> quantity
        /// </summary>
        /// <param name="other">The other quantity to compare dimensions with</param>
        /// <returns>True if the two quantities have the same <see cref="Dimensions"/>, False otherwise</returns>
        public bool HasSameDimensions(IQuantity other) => HasSameDimensions(this, other);

        private static void EnforceSameDimensions(IQuantity left, IQuantity right)
        {
            if (!HasSameDimensions(left, right))
            {
                throw new ArgumentException($"Incompatible units '{left.Dimensions}' and '{right.Dimensions}'");
            }
        }

        /// <summary>Gets the complex conjugate of the this Quantity</summary>
        public QuantityBase Conjugate => GetConjugate(this);

        /// <summary>Gets the complex conjugate of the a Quantity</summary>
        public static QuantityBase GetConjugate(QuantityBase right)
        {
            return Quantity.FromOrNameless(right.Value.Conjugate, right.Dimensions);
        }

        /// <summary>Negate the value.</summary>
        public static QuantityBase operator -(QuantityBase right)
        {
            return Quantity.FromOrNameless(-right.Value, right.Dimensions);
            //return new QuantityBase(-right.Value, right.Dimensions);
        }

        /// <summary>Get <see cref="QuantityBase"/> from adding two <see cref="QuantityBase"/>.</summary>
        public static QuantityBase operator +(QuantityBase left, IQuantity right)
        {
            EnforceSameDimensions(left, right);
            return Quantity.FromOrNameless(left.InBaseUnits - right.InBaseUnits, left.Dimensions);
            //return new QuantityBase(left.InBaseUnits - right.InBaseUnits, left.Dimensions);
        }

        /// <summary>Get <see cref="QuantityBase"/> from subtracting two <see cref="QuantityBase"/>.</summary>
        public static QuantityBase operator -(QuantityBase left, IQuantity right)
        {
            EnforceSameDimensions(left, right);
            return Quantity.FromOrNameless(left.InBaseUnits - right.InBaseUnits, left.Dimensions);
            //return new QuantityBase(left.InBaseUnits - right.InBaseUnits, left.Dimensions);
        }

        /// <summary>Get <see cref="QuantityBase"/> from multiplying value and <see cref="QuantityBase"/>.</summary>
        public QuantityBase Pow(QuantityValue power)
        {
            return Quantity.FromOrNameless(this.Value.Pow(power), this.Dimensions.Pow(power));
            //return new QuantityBase(this.Value.Pow(power), this.Dimensions.Pow(power));
        }

        /// <summary>Get <see cref="QuantityBase"/> from multiplying value and <see cref="QuantityBase"/>.</summary>
        public QuantityBase Pow(double power)
        {
            return Quantity.FromOrNameless(this.Value.Pow(power), this.Dimensions.Pow(power));
            //return new QuantityBase(this.Value.Pow(power), this.Dimensions.Pow(power));
        }

        /// <summary>Get <see cref="QuantityBase"/> from multiplying value and <see cref="QuantityBase"/>.</summary>
        public QuantityBase Sqrt()
        {
            return Quantity.FromOrNameless(this.Value.Sqrt(), this.Dimensions.Sqrt());
            //return new QuantityBase(this.Value.Sqrt(), this.Dimensions.Sqrt());
        }

        /// <summary>Get <see cref="QuantityBase"/> from multiplying value and <see cref="QuantityBase"/>.</summary>
        public static QuantityBase operator *(QuantityValue left, QuantityBase right)
        {
            return Quantity.FromOrNameless(left * right.Value, right.Dimensions);
            //return new QuantityBase(left * right.Value, right.Dimensions);
        }

        /// <summary>Get <see cref="QuantityBase"/> from multiplying value and <see cref="QuantityBase"/>.</summary>
        public static QuantityBase operator *(QuantityBase left, IQuantity right)
        {
            return Quantity.FromOrNameless(left.InBaseUnits * right.InBaseUnits, left.Dimensions * right.Dimensions);
            //return new QuantityBase(left.InBaseUnits * right.InBaseUnits, left.Dimensions * right.Dimensions);
        }

        /// <summary>Get <see cref="QuantityBase"/> from multiplying value and <see cref="QuantityBase"/>.</summary>
        public static QuantityBase operator *(QuantityBase left, QuantityValue right)
        {
            return Quantity.FromOrNameless(left.Value * right, left.Dimensions);
            //return new QuantityBase(left.Value * right, left.Dimensions);
        }

        /// <summary>Get <see cref="QuantityBase"/> from dividing <see cref="QuantityBase"/> by value.</summary>
        public static QuantityBase operator /(QuantityBase left, QuantityValue right)
        {
            return Quantity.FromOrNameless(left.Value / right, left.Dimensions);
            //return new QuantityBase(left.Value / right, left.Dimensions);
        }

        /// <summary>Get <see cref="QuantityBase"/> from dividing <see cref="QuantityBase"/> by value.</summary>
        public static QuantityBase operator /(QuantityValue left, QuantityBase right)
        {
            return Quantity.FromOrNameless(left / right.Value, right.Dimensions.Inverse);
            //return new QuantityBase(left / right.Value, right.Dimensions.Inverse);
        }

        /// <summary>Get ratio value from dividing <see cref="QuantityBase"/> by <see cref="QuantityBase"/>.</summary>
        public static QuantityBase operator /(QuantityBase left, IQuantity right)
        {
            return Quantity.FromOrNameless(left.InBaseUnits / right.InBaseUnits, left.Dimensions / right.Dimensions);
            //return new QuantityBase(left.InBaseUnits / right.InBaseUnits, left.Dimensions / right.Dimensions);
        }

        /// <summary>Negate the <see cref="QuantityBase"/>.</summary>
        public IQuantity Negate()
        {
            return -this;
        }

        /// <summary>Add two <see cref="QuantityBase"/> together</summary>
        public IQuantity Add(IQuantity other)
        {
            return this + other;
        }

        /// <summary>Subtract one <see cref="QuantityBase"/> from another</summary>
        public IQuantity Subtract(IQuantity other)
        {
            return this - other;
        }

        /// <summary>Scale the <see cref="QuantityBase"/> by a constant</summary>
        public IQuantity Scale(double scaleFactor)
        {
            return new QuantityBase(scaleFactor * this.Value, this.Dimensions);
        }
        /// <inheritdoc/>
        public int CompareTo(IQuantity? other)
        {
            EnforceSameDimensions(this, other);
            return this.InBaseUnits.CompareTo(other.InBaseUnits);
        }

        /// <inheritdoc/>
        public int CompareTo(object? obj)
        {
            if(obj is IQuantity quantity)
            {
                return this.CompareTo(quantity);
            }
            else
            {
                throw new ArgumentException($"The object must be an '{nameof(IQuantity)}'");
            }
        }

        /// <inheritdoc/>
        public bool Equals(IQuantity? other)
        {
            return HasSameDimensions(this, other) && this.InBaseUnits.Equals(other.InBaseUnits);
        }

        QuantityValue IQuantity.As(Enum unit)
        {
            throw new NotImplementedException();
        }

        QuantityValue IQuantity.As(UnitSystem unitSystem)
        {
            throw new NotImplementedException();
        }

        IQuantity IQuantity.ToUnit(Enum unit)
        {
            throw new NotImplementedException();
        }

        IQuantity IQuantity.ToUnit(Enum unit, UnitConverter unitConverter)
        {
            throw new NotImplementedException();
        }

        IQuantity IQuantity.ToUnit(UnitSystem unitSystem)
        {
            throw new NotImplementedException();
        }

        QuantityValue IQuantity<NamelessUnit>.As(NamelessUnit unit)
        {
            throw new NotImplementedException();
        }

        IQuantity<NamelessUnit> IQuantity<NamelessUnit>.ToUnit(NamelessUnit unit)
        {
            throw new NotImplementedException();
        }

        IQuantity<NamelessUnit> IQuantity<NamelessUnit>.ToUnit(NamelessUnit unit, UnitConverter unitConverter)
        {
            throw new NotImplementedException();
        }

        IQuantity<NamelessUnit> IQuantity<NamelessUnit>.ToUnit(UnitSystem unitSystem)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
