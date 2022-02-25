// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using UnitsNet.InternalHelpers;
using System.Numerics;
using System;
using System.Diagnostics;

namespace UnitsNet
{
    /// <summary>
    /// A complex number z is a number of the form z = x + yi, where x and y
    /// are real numbers, and i is the imaginary unit, with the property i2= -1.
    /// </summary>
    [Serializable]
    public readonly struct QuantityValue : IEquatable<QuantityValue>, IComparable<QuantityValue>, IComparable, IFormattable, IConvertible
    {
        /// <summary>A <see cref="QuantityValue"/> of value 0+0i</summary>
        public static readonly QuantityValue Zero = new QuantityValue(0.0, 0.0);
        /// <summary>A <see cref="QuantityValue"/> of value 1+0i</summary>
        public static readonly QuantityValue One = new QuantityValue(1.0, 0.0);
        /// <summary>A <see cref="QuantityValue"/> of value 0+1i</summary>
        public static readonly QuantityValue ImaginaryOne = new QuantityValue(0.0, 1.0);

        /// <summary>
        /// Truncates both components
        /// </summary>
        /// <param name="value">The value to truncate</param>
        public static object Truncate(QuantityValue value)
        {
            return new QuantityValue(Math.Truncate(value.Real), Math.Truncate(value.Imaginary));
        }

        /// <summary>A <see cref="QuantityValue"/> of value NaN+NaNi</summary>
        public static readonly QuantityValue NaN = new QuantityValue(double.NaN, double.NaN);
        /// <summary>A <see cref="QuantityValue"/> of value inf+infi</summary>
        public static readonly QuantityValue Infinity = new QuantityValue(double.PositiveInfinity, double.PositiveInfinity);
        /// <inheritdoc cref="Math.PI"/>
        public const double PI = Math.PI;

        /// <summary>
        /// Represents the value 1 / Log(10)
        /// </summary>
        private const double InverseOfLog10 = 0.43429448190325;

        // This is the largest x for which (Hypot(x,x) + x) will not overflow. It is used for branching inside Sqrt.
        private static readonly double s_sqrtRescaleThreshold = double.MaxValue / (Math.Sqrt(2.0) + 1.0);

        // This is the largest x for which 2 x^2 will not overflow. It is used for branching inside Asin and Acos.
        private static readonly double s_asinOverflowThreshold = Math.Sqrt(double.MaxValue) / 2.0;

        // This value is used inside Asin and Acos.
        private static readonly double s_log2 = Math.Log(2.0);

        // Do not rename, these fields are needed for binary serialization
        private readonly double m_real; // Do not rename (binary serialization)
        private readonly double m_imaginary; // Do not rename (binary serialization)

        /// <summary>
        /// Creates a <see cref="QuantityValue"/> with the given <paramref name="real"/> and <paramref name="imaginary"/> components
        /// </summary>
        /// <param name="real">The real component</param>
        /// <param name="imaginary">The imaginary component</param>
        public QuantityValue(double real, double imaginary)
        {
            m_real = real;
            m_imaginary = imaginary;
        }

        /// <summary>
        /// Creates a <see cref="QuantityValue"/> with the given <paramref name="real"/> component and an imaginary component equal to 0.
        /// </summary>
        /// <param name="real">The real component</param>
        public QuantityValue(double real) : this(real, 0)
        {
        }
        /// <summary>
        /// Creates a <see cref="QuantityValue"/> with the given <see cref="Complex"/> <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The <see cref="Complex"/> value</param>
        public QuantityValue(Complex value) : this(value.Real, value.Imaginary)
        {
        }

        /// <summary>
        /// Rounds both components to a specified number of <paramref name="digits"/>
        /// </summary>
        /// <param name="value">The value to round</param>
        /// <param name="digits">The amount of digits to round to</param>
        public static QuantityValue Round(QuantityValue value, int digits)
        {
            return new QuantityValue(Math.Round(value.Real, digits), Math.Round(value.Imaginary, digits));
        }

        /// <remarks>
        /// 0 + 0i is considered real
        /// </remarks>
        public bool IsReal => m_imaginary == 0;
        /// <remarks>
        /// 0 + 0i is not considered imaginary
        /// </remarks>
        public bool IsImaginary => m_real == 0 && m_imaginary != 0;
        /// <summary>
        /// The real component of the <see cref="QuantityValue"/>
        /// </summary>
        public double Real { get { return m_real; } }
        /// <summary>
        /// The imaginary component of the <see cref="QuantityValue"/>
        /// </summary>
        public double Imaginary { get { return m_imaginary; } }
        /// <summary>
        /// The magnitude of the <see cref="QuantityValue"/>'s complex value
        /// </summary>
        public double Magnitude { get { return Abs(this); } }
        /// <summary>
        /// The angle of the <see cref="QuantityValue"/>'s complex value to the positive real axis.
        /// </summary>
        /// <remarks>In Radians</remarks>
        public double Phase { get { return Math.Atan2(m_imaginary, m_real); } }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static QuantityValue FromPolarCoordinates(double magnitude, double phase)
        {
            return new QuantityValue(magnitude * Math.Cos(phase), magnitude * Math.Sin(phase));
        }

        public static QuantityValue Negate(QuantityValue value)
        {
            return -value;
        }

        public static QuantityValue Add(QuantityValue left, QuantityValue right)
        {
            return left + right;
        }

        public static QuantityValue Add(QuantityValue left, double right)
        {
            return left + right;
        }

        public static QuantityValue Add(double left, QuantityValue right)
        {
            return left + right;
        }

        public static QuantityValue Subtract(QuantityValue left, QuantityValue right)
        {
            return left - right;
        }

        public static QuantityValue Subtract(QuantityValue left, double right)
        {
            return left - right;
        }

        public static QuantityValue Subtract(double left, QuantityValue right)
        {
            return left - right;
        }

        public static QuantityValue Multiply(QuantityValue left, QuantityValue right)
        {
            return left * right;
        }

        public static QuantityValue Multiply(QuantityValue left, double right)
        {
            return left * right;
        }

        public static QuantityValue Multiply(double left, QuantityValue right)
        {
            return left * right;
        }

        public static QuantityValue Divide(QuantityValue dividend, QuantityValue divisor)
        {
            return dividend / divisor;
        }

        public static QuantityValue Divide(QuantityValue dividend, double divisor)
        {
            return dividend / divisor;
        }

        public static QuantityValue Divide(double dividend, QuantityValue divisor)
        {
            return dividend / divisor;
        }

        public static QuantityValue operator -(QuantityValue value)  /* Unary negation of a complex number */
        {
            return new QuantityValue(-value.m_real, -value.m_imaginary);
        }

        public static QuantityValue operator +(QuantityValue left, QuantityValue right)
        {
            return new QuantityValue(left.m_real + right.m_real, left.m_imaginary + right.m_imaginary);
        }

        public static QuantityValue operator +(QuantityValue left, double right)
        {
            return new QuantityValue(left.m_real + right, left.m_imaginary);
        }

        public static QuantityValue operator +(double left, QuantityValue right)
        {
            return new QuantityValue(left + right.m_real, right.m_imaginary);
        }

        public static QuantityValue operator -(QuantityValue left, QuantityValue right)
        {
            return new QuantityValue(left.m_real - right.m_real, left.m_imaginary - right.m_imaginary);
        }

        public static QuantityValue operator -(QuantityValue left, double right)
        {
            return new QuantityValue(left.m_real - right, left.m_imaginary);
        }

        public static QuantityValue operator -(double left, QuantityValue right)
        {
            return new QuantityValue(left - right.m_real, -right.m_imaginary);
        }

        public static QuantityValue operator *(QuantityValue left, QuantityValue right)
        {
            // Multiplication:  (a + bi)(c + di) = (ac -bd) + (bc + ad)i
            double result_realpart = (left.m_real * right.m_real) - (left.m_imaginary * right.m_imaginary);
            double result_imaginarypart = (left.m_imaginary * right.m_real) + (left.m_real * right.m_imaginary);
            return new QuantityValue(result_realpart, result_imaginarypart);
        }

        public static QuantityValue operator *(QuantityValue left, double right)
        {
            if (double.IsInfinity(left.m_real))
            {
                if (double.IsInfinity(left.m_imaginary))
                {
                    return new QuantityValue(double.NaN, double.NaN);
                }

                return new QuantityValue(left.m_real * right, double.NaN);
            }

            if (double.IsInfinity(left.m_imaginary))
            {
                return new QuantityValue(double.NaN, left.m_imaginary * right);
            }

            return new QuantityValue(left.m_real * right, left.m_imaginary * right);
        }

        public static QuantityValue operator *(double left, QuantityValue right)
        {
            return right * left;
        }

        public static QuantityValue operator *(int left, QuantityValue right)
        {
            return (double)left * right;
        }

        public static QuantityValue operator *(QuantityValue left, int right)
        {
            return (double)right * left;
        }

        public static QuantityValue operator *(long left, QuantityValue right)
        {
            return right * left;
        }

        public static QuantityValue operator *(QuantityValue left, long right)
        {
            if (double.IsInfinity(left.m_real))
            {
                if (double.IsInfinity(left.m_imaginary))
                {
                    return new QuantityValue(double.NaN, double.NaN);
                }

                return new QuantityValue(left.m_real * right, double.NaN);
            }

            if (double.IsInfinity(left.m_imaginary))
            {
                return new QuantityValue(double.NaN, left.m_imaginary * right);
            }

            return new QuantityValue(left.m_real * right, left.m_imaginary * right);
        }

        public static QuantityValue operator /(QuantityValue left, QuantityValue right)
        {
            // Division : Smith's formula.
            double a = left.m_real;
            double b = left.m_imaginary;
            double c = right.m_real;
            double d = right.m_imaginary;

            // Computing c * c + d * d will overflow even in cases where the actual result of the division does not overflow.
            if (Math.Abs(d) < Math.Abs(c))
            {
                double doc = d / c;
                return new QuantityValue((a + b * doc) / (c + d * doc), (b - a * doc) / (c + d * doc));
            }
            else
            {
                double cod = c / d;
                return new QuantityValue((b + a * cod) / (d + c * cod), (-a + b * cod) / (d + c * cod));
            }
        }
        public static QuantityValue operator /(QuantityValue left, int right)
        {
            // IEEE prohibit optimizations which are value changing
            // so we make sure that behaviour for the simplified version exactly match
            // full version.
            if (right == 0)
            {
                return new QuantityValue(double.NaN, double.NaN);
            }

            if (double.IsInfinity(left.m_real))
            {
                if (double.IsInfinity(left.m_imaginary))
                {
                    return new QuantityValue(double.NaN, double.NaN);
                }

                return new QuantityValue(left.m_real / right, double.NaN);
            }

            if (double.IsInfinity(left.m_imaginary))
            {
                return new QuantityValue(double.NaN, left.m_imaginary / right);
            }

            // Here the actual optimized version of code.
            return new QuantityValue(left.m_real / right, left.m_imaginary / right);
        }
        public static QuantityValue operator /(QuantityValue left, long right)
        {
            // IEEE prohibit optimizations which are value changing
            // so we make sure that behaviour for the simplified version exactly match
            // full version.
            if (right == 0)
            {
                return new QuantityValue(double.NaN, double.NaN);
            }

            if (double.IsInfinity(left.m_real))
            {
                if (double.IsInfinity(left.m_imaginary))
                {
                    return new QuantityValue(double.NaN, double.NaN);
                }

                return new QuantityValue(left.m_real / right, double.NaN);
            }

            if (double.IsInfinity(left.m_imaginary))
            {
                return new QuantityValue(double.NaN, left.m_imaginary / right);
            }

            // Here the actual optimized version of code.
            return new QuantityValue(left.m_real / right, left.m_imaginary / right);
        }
        public static QuantityValue operator /(QuantityValue left, double right)
        {
            // IEEE prohibit optimizations which are value changing
            // so we make sure that behaviour for the simplified version exactly match
            // full version.
            if (right == 0)
            {
                return new QuantityValue(double.NaN, double.NaN);
            }

            if (double.IsInfinity(left.m_real))
            {
                if (double.IsInfinity(left.m_imaginary))
                {
                    return new QuantityValue(double.NaN, double.NaN);
                }

                return new QuantityValue(left.m_real / right, double.NaN);
            }

            if (double.IsInfinity(left.m_imaginary))
            {
                return new QuantityValue(double.NaN, left.m_imaginary / right);
            }

            // Here the actual optimized version of code.
            return new QuantityValue(left.m_real / right, left.m_imaginary / right);
        }
        public static QuantityValue operator /(QuantityValue left, decimal right)
        {
            return left / Convert.ToDouble(right);
        }
        public static QuantityValue operator *(QuantityValue left, decimal right)
        {
            return left * Convert.ToDouble(right);
        }
        public static QuantityValue operator *(decimal left, QuantityValue right)
        {
            return right * Convert.ToDouble(left);
        }

        public static QuantityValue operator /(double left, QuantityValue right)
        {
            // Division : Smith's formula.
            double a = left;
            double c = right.m_real;
            double d = right.m_imaginary;

            // Computing c * c + d * d will overflow even in cases where the actual result of the division does not overflow.
            if (Math.Abs(d) < Math.Abs(c))
            {
                double doc = d / c;
                return new QuantityValue(a / (c + d * doc), (-a * doc) / (c + d * doc));
            }
            else
            {
                double cod = c / d;
                return new QuantityValue(a * cod / (d + c * cod), -a / (d + c * cod));
            }
        }

        public static double Abs(QuantityValue value)
        {
            return Hypot(value.m_real, value.m_imaginary);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        private static double Hypot(double a, double b)
        {
            // Using
            //   sqrt(a^2 + b^2) = |a| * sqrt(1 + (b/a)^2)
            // we can factor out the larger component to dodge overflow even when a * a would overflow.

            a = Math.Abs(a);
            b = Math.Abs(b);

            double small, large;
            if (a < b)
            {
                small = a;
                large = b;
            }
            else
            {
                small = b;
                large = a;
            }

            if (small == 0.0)
            {
                return (large);
            }
            else if (double.IsPositiveInfinity(large) && !double.IsNaN(small))
            {
                // The NaN test is necessary so we don't return +inf when small=NaN and large=+inf.
                // NaN in any other place returns NaN without any special handling.
                return (double.PositiveInfinity);
            }
            else
            {
                double ratio = small / large;
                return (large * Math.Sqrt(1.0 + ratio * ratio));
            }

        }


        private static double Log1P(double x)
        {
            // Compute log(1 + x) without loss of accuracy when x is small.

            // Our only use case so far is for positive values, so this isn't coded to handle negative values.
            Debug.Assert((x >= 0.0) || double.IsNaN(x));

            double xp1 = 1.0 + x;
            if (xp1 == 1.0)
            {
                return x;
            }
            else if (x < 0.75)
            {
                // This is accurate to within 5 ulp with any floating-point system that uses a guard digit,
                // as proven in Theorem 4 of "What Every Computer Scientist Should Know About Floating-Point
                // Arithmetic" (https://docs.oracle.com/cd/E19957-01/806-3568/ncg_goldberg.html)
                return x * Math.Log(xp1) / (xp1 - 1.0);
            }
            else
            {
                return Math.Log(xp1);
            }

        }

        /// <summary>
        /// Gets the complex conjugate of the this QuantityValue
        /// </summary>
        public QuantityValue Conjugate => GetConjugate(this);

        /// <summary>
        /// Gets the complex conjugate of the <paramref name="value"/>
        /// </summary>
        /// <returns>A new <see cref="QuantityValue"/> which is the complex conjugate of <paramref name="value"/></returns>
        public static QuantityValue GetConjugate(QuantityValue value)
        {
            // Conjugate of a QuantityValue number: the conjugate of x+i*y is x-i*y
            return new QuantityValue(value.m_real, -value.m_imaginary);
        }
        /// <summary>
        /// Gets the reciprocal of the <paramref name="value"/>
        /// </summary>
        /// <returns>A new <see cref="QuantityValue"/> which is the reciprocal of <paramref name="value"/></returns>
        public static QuantityValue Reciprocal(QuantityValue value)
        {
            // Reciprocal of a QuantityValue number : the reciprocal of x+i*y is 1/(x+i*y)
            if (value.m_real == 0 && value.m_imaginary == 0)
            {
                return Zero;
            }
            return One / value;
        }

        /// <summary>
        /// Tests whether two <see cref="QuantityValue"/>s are equal.
        /// </summary>
        public static bool operator ==(QuantityValue left, QuantityValue right)
        {
            return left.m_real == right.m_real && left.m_imaginary == right.m_imaginary;
        }
        /// <summary>
        /// Tests whether two <see cref="QuantityValue"/>s are not equal.
        /// </summary>
        public static bool operator !=(QuantityValue left, QuantityValue right)
        {
            return left.m_real != right.m_real || left.m_imaginary != right.m_imaginary;
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            if (!(obj is QuantityValue)) return false;
            return Equals((QuantityValue)obj);
        }

        /// <inheritdoc/>
        public bool Equals(QuantityValue value)
        {
            return m_real.Equals(value.m_real) && m_imaginary.Equals(value.m_imaginary);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int n1 = 99999997;
            int realHash = m_real.GetHashCode() % n1;
            int imaginaryHash = m_imaginary.GetHashCode();
            int finalHash = realHash ^ imaginaryHash;
            return finalHash;
        }

        /// <inheritdoc/>
        public override string ToString() => $"({m_real}, {m_imaginary})";

        /// <inheritdoc/>
        public string ToString(string? format) => ToString(format, null);

        /// <inheritdoc/>
        public string ToString(IFormatProvider? provider) => ToString(null, provider);

        /// <inheritdoc/>
        public string ToString(string? format, IFormatProvider? provider)
        {
            return string.Format(provider, "({0}, {1})", m_real.ToString(format, provider), m_imaginary.ToString(format, provider));
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static QuantityValue Sin(QuantityValue value)
        {
            // We need both sinh and cosh of imaginary part. To avoid multiple calls to Math.Exp with the same value,
            // we compute them both here from a single call to Math.Exp.
            double p = Math.Exp(value.m_imaginary);
            double q = 1.0 / p;
            double sinh = (p - q) * 0.5;
            double cosh = (p + q) * 0.5;
            return new QuantityValue(Math.Sin(value.m_real) * cosh, Math.Cos(value.m_real) * sinh);
            // There is a known limitation with this algorithm: inputs that cause sinh and cosh to overflow, but for
            // which sin or cos are small enough that sin * cosh or cos * sinh are still representable, nonetheless
            // produce overflow. For example, Sin((0.01, 711.0)) should produce (~3.0E306, PositiveInfinity), but
            // instead produces (PositiveInfinity, PositiveInfinity).
        }

        public static QuantityValue Sinh(QuantityValue value)
        {
            // Use sinh(z) = -i sin(iz) to compute via sin(z).
            QuantityValue sin = Sin(new QuantityValue(-value.m_imaginary, value.m_real));
            return new QuantityValue(sin.m_imaginary, -sin.m_real);
        }

        public static QuantityValue Asin(QuantityValue value)
        {
            double b, bPrime, v;
            Asin_Internal(Math.Abs(value.Real), Math.Abs(value.Imaginary), out b, out bPrime, out v);

            double u;
            if (bPrime < 0.0)
            {
                u = Math.Asin(b);
            }
            else
            {
                u = Math.Atan(bPrime);
            }

            if (value.Real < 0.0) u = -u;
            if (value.Imaginary < 0.0) v = -v;

            return new QuantityValue(u, v);
        }

        public static QuantityValue Cos(QuantityValue value)
        {
            double p = Math.Exp(value.m_imaginary);
            double q = 1.0 / p;
            double sinh = (p - q) * 0.5;
            double cosh = (p + q) * 0.5;
            return new QuantityValue(Math.Cos(value.m_real) * cosh, -Math.Sin(value.m_real) * sinh);
        }

        public static QuantityValue Cosh(QuantityValue value)
        {
            // Use cosh(z) = cos(iz) to compute via cos(z).
            return Cos(new QuantityValue(-value.m_imaginary, value.m_real));
        }

        public static QuantityValue Acos(QuantityValue value)
        {
            double b, bPrime, v;
            Asin_Internal(Math.Abs(value.Real), Math.Abs(value.Imaginary), out b, out bPrime, out v);

            double u;
            if (bPrime < 0.0)
            {
                u = Math.Acos(b);
            }
            else
            {
                u = Math.Atan(1.0 / bPrime);
            }

            if (value.Real < 0.0) u = Math.PI - u;
            if (value.Imaginary > 0.0) v = -v;

            return new QuantityValue(u, v);
        }

        public static QuantityValue Tan(QuantityValue value)
        {
            // tan z = sin z / cos z, but to avoid unnecessary repeated trig computations, use
            //   tan z = (sin(2x) + i sinh(2y)) / (cos(2x) + cosh(2y))
            // (see Abramowitz & Stegun 4.3.57 or derive by hand), and compute trig functions here.

            // This approach does not work for |y| > ~355, because sinh(2y) and cosh(2y) overflow,
            // even though their ratio does not. In that case, divide through by cosh to get:
            //   tan z = (sin(2x) / cosh(2y) + i \tanh(2y)) / (1 + cos(2x) / cosh(2y))
            // which correctly computes the (tiny) real part and the (normal-sized) imaginary part.

            double x2 = 2.0 * value.m_real;
            double y2 = 2.0 * value.m_imaginary;
            double p = Math.Exp(y2);
            double q = 1.0 / p;
            double cosh = (p + q) * 0.5;
            if (Math.Abs(value.m_imaginary) <= 4.0)
            {
                double sinh = (p - q) * 0.5;
                double D = Math.Cos(x2) + cosh;
                return new QuantityValue(Math.Sin(x2) / D, sinh / D);
            }
            else
            {
                double D = 1.0 + Math.Cos(x2) / cosh;
                return new QuantityValue(Math.Sin(x2) / cosh / D, Math.Tanh(y2) / D);
            }
        }

        public static QuantityValue Tanh(QuantityValue value)
        {
            // Use tanh(z) = -i tan(iz) to compute via tan(z).
            QuantityValue tan = Tan(new QuantityValue(-value.m_imaginary, value.m_real));
            return new QuantityValue(tan.m_imaginary, -tan.m_real);
        }

        public static QuantityValue Atan(QuantityValue value)
        {
            QuantityValue two = new QuantityValue(2.0, 0.0);
            return (ImaginaryOne / two) * (Log(One - ImaginaryOne * value) - Log(One + ImaginaryOne * value));
        }

        private static void Asin_Internal(double x, double y, out double b, out double bPrime, out double v)
        {

            // This method for the inverse complex sine (and cosine) is described in Hull, Fairgrieve,
            // and Tang, "Implementing the QuantityValue Arcsine and Arccosine Functions Using Exception Handling",
            // ACM Transactions on Mathematical Software (1997)
            // (https://www.researchgate.net/profile/Ping_Tang3/publication/220493330_Implementing_the_QuantityValue_Arcsine_and_Arccosine_Functions_Using_Exception_Handling/links/55b244b208ae9289a085245d.pdf)

            // First, the basics: start with sin(w) = (e^{iw} - e^{-iw}) / (2i) = z. Here z is the input
            // and w is the output. To solve for w, define t = e^{i w} and multiply through by t to
            // get the quadratic equation t^2 - 2 i z t - 1 = 0. The solution is t = i z + sqrt(1 - z^2), so
            //   w = arcsin(z) = - i log( i z + sqrt(1 - z^2) )
            // Decompose z = x + i y, multiply out i z + sqrt(1 - z^2), use log(s) = |s| + i arg(s), and do a
            // bunch of algebra to get the components of w = arcsin(z) = u + i v
            //   u = arcsin(beta)  v = sign(y) log(alpha + sqrt(alpha^2 - 1))
            // where
            //   alpha = (rho + sigma) / 2      beta = (rho - sigma) / 2
            //   rho = sqrt((x + 1)^2 + y^2)    sigma = sqrt((x - 1)^2 + y^2)
            // These formulas appear in DLMF section 4.23. (http://dlmf.nist.gov/4.23), along with the analogous
            //   arccos(w) = arccos(beta) - i sign(y) log(alpha + sqrt(alpha^2 - 1))
            // So alpha and beta together give us arcsin(w) and arccos(w).

            // As written, alpha is not susceptible to cancelation errors, but beta is. To avoid cancelation, note
            //   beta = (rho^2 - sigma^2) / (rho + sigma) / 2 = (2 x) / (rho + sigma) = x / alpha
            // which is not subject to cancelation. Note alpha >= 1 and |beta| <= 1.

            // For alpha ~ 1, the argument of the log is near unity, so we compute (alpha - 1) instead,
            // write the argument as 1 + (alpha - 1) + sqrt((alpha - 1)(alpha + 1)), and use the log1p function
            // to compute the log without loss of accuracy.
            // For beta ~ 1, arccos does not accurately resolve small angles, so we compute the tangent of the angle
            // instead.
            // Hull, Fairgrieve, and Tang derive formulas for (alpha - 1) and beta' = tan(u) that do not suffer
            // from cancelation in these cases.

            // For simplicity, we assume all positive inputs and return all positive outputs. The caller should
            // assign signs appropriate to the desired cut conventions. We return v directly since its magnitude
            // is the same for both arcsin and arccos. Instead of u, we usually return beta and sometimes beta'.
            // If beta' is not computed, it is set to -1; if it is computed, it should be used instead of beta
            // to determine u. Compute u = arcsin(beta) or u = arctan(beta') for arcsin, u = arccos(beta)
            // or arctan(1/beta') for arccos.

            Debug.Assert((x >= 0.0) || double.IsNaN(x));
            Debug.Assert((y >= 0.0) || double.IsNaN(y));

            // For x or y large enough to overflow alpha^2, we can simplify our formulas and avoid overflow.
            if ((x > s_asinOverflowThreshold) || (y > s_asinOverflowThreshold))
            {
                b = -1.0;
                bPrime = x / y;

                double small, big;
                if (x < y)
                {
                    small = x;
                    big = y;
                }
                else
                {
                    small = y;
                    big = x;
                }
                double ratio = small / big;
                v = s_log2 + Math.Log(big) + 0.5 * Log1P(ratio * ratio);
            }
            else
            {
                double r = Hypot((x + 1.0), y);
                double s = Hypot((x - 1.0), y);

                double a = (r + s) * 0.5;
                b = x / a;

                if (b > 0.75)
                {
                    if (x <= 1.0)
                    {
                        double amx = (y * y / (r + (x + 1.0)) + (s + (1.0 - x))) * 0.5;
                        bPrime = x / Math.Sqrt((a + x) * amx);
                    }
                    else
                    {
                        // In this case, amx ~ y^2. Since we take the square root of amx, we should
                        // pull y out from under the square root so we don't lose its contribution
                        // when y^2 underflows.
                        double t = (1.0 / (r + (x + 1.0)) + 1.0 / (s + (x - 1.0))) * 0.5;
                        bPrime = x / y / Math.Sqrt((a + x) * t);
                    }
                }
                else
                {
                    bPrime = -1.0;
                }

                if (a < 1.5)
                {
                    if (x < 1.0)
                    {
                        // This is another case where our expression is proportional to y^2 and
                        // we take its square root, so again we pull out a factor of y from
                        // under the square root.
                        double t = (1.0 / (r + (x + 1.0)) + 1.0 / (s + (1.0 - x))) * 0.5;
                        double am1 = y * y * t;
                        v = Log1P(am1 + y * Math.Sqrt(t * (a + 1.0)));
                    }
                    else
                    {
                        double am1 = (y * y / (r + (x + 1.0)) + (s + (x - 1.0))) * 0.5;
                        v = Log1P(am1 + Math.Sqrt(am1 * (a + 1.0)));
                    }
                }
                else
                {
                    // Because of the test above, we can be sure that a * a will not overflow.
                    v = Math.Log(a + Math.Sqrt((a - 1.0) * (a + 1.0)));
                }
            }
        }

        /// <summary>
        /// Checks whether the given <paramref name="value"/> has no infinite component.
        /// </summary>
        /// <returns>False if either the Real or Imaginary component is infinite, True otherwise</returns>
        public static bool IsFinite(QuantityValue value) => !double.IsInfinity(value.m_real) && !double.IsInfinity(value.m_imaginary);

        /// <summary>
        /// Checks whether the given <paramref name="value"/> has an infinite component.
        /// </summary>
        /// <returns>True if either the Real or Imaginary component is infinite, False otherwise</returns>
        public static bool IsInfinity(QuantityValue value) => double.IsInfinity(value.m_real) || double.IsInfinity(value.m_imaginary);

        /// <summary>
        /// Checks whether the given <paramref name="value"/> has an NaN component.
        /// </summary>
        /// <returns>True if the <paramref name="value"/> is neither Finite nor Infinite, False otherwise</returns>
        public static bool IsNaN(QuantityValue value) => !IsInfinity(value) && !IsFinite(value);

        public static QuantityValue Log(QuantityValue value)
        {
            return new QuantityValue(Math.Log(Abs(value)), Math.Atan2(value.m_imaginary, value.m_real));
        }

        public static QuantityValue Log(QuantityValue value, double baseValue)
        {
            return Log(value) / Log(baseValue);
        }

        public static QuantityValue Log10(QuantityValue value)
        {
            QuantityValue tempLog = Log(value);
            return Scale(tempLog, InverseOfLog10);
        }

        public static QuantityValue Exp(QuantityValue value)
        {
            double expReal = Math.Exp(value.m_real);
            double cosImaginary = expReal * Math.Cos(value.m_imaginary);
            double sinImaginary = expReal * Math.Sin(value.m_imaginary);
            return new QuantityValue(cosImaginary, sinImaginary);
        }
        public QuantityValue Sqrt() => Sqrt(this);
        public static QuantityValue Sqrt(QuantityValue value)
        {

            if (value.m_imaginary == 0.0)
            {
                // Handle the trivial case quickly.
                if (value.m_real < 0.0)
                {
                    return new QuantityValue(0.0, Math.Sqrt(-value.m_real));
                }

                return new QuantityValue(Math.Sqrt(value.m_real), 0.0);
            }

            // One way to compute Sqrt(z) is just to call Pow(z, 0.5), which coverts to polar coordinates
            // (sqrt + atan), halves the phase, and reconverts to cartesian coordinates (cos + sin).
            // Not only is this more expensive than necessary, it also fails to preserve certain expected
            // symmetries, such as that the square root of a pure negative is a pure imaginary, and that the
            // square root of a pure imaginary has exactly equal real and imaginary parts. This all goes
            // back to the fact that Math.PI is not stored with infinite precision, so taking half of Math.PI
            // does not land us on an argument with cosine exactly equal to zero.

            // To find a fast and symmetry-respecting formula for complex square root,
            // note x + i y = \sqrt{a + i b} implies x^2 + 2 i x y - y^2 = a + i b,
            // so x^2 - y^2 = a and 2 x y = b. Cross-substitute and use the quadratic formula to obtain
            //   x = \sqrt{\frac{\sqrt{a^2 + b^2} + a}{2}}  y = \pm \sqrt{\frac{\sqrt{a^2 + b^2} - a}{2}}
            // There is just one complication: depending on the sign on a, either x or y suffers from
            // cancelation when |b| << |a|. We can get aroud this by noting that our formulas imply
            // x^2 y^2 = b^2 / 4, so |x| |y| = |b| / 2. So after computing the one that doesn't suffer
            // from cancelation, we can compute the other with just a division. This is basically just
            // the right way to evaluate the quadratic formula without cancelation.

            // All this reduces our total cost to two sqrts and a few flops, and it respects the desired
            // symmetries. Much better than atan + cos + sin!

            // The signs are a matter of choice of branch cut, which is traditionally taken so x > 0 and sign(y) = sign(b).

            // If the components are too large, Hypot will overflow, even though the subsequent sqrt would
            // make the result representable. To avoid this, we re-scale (by exact powers of 2 for accuracy)
            // when we encounter very large components to avoid intermediate infinities.
            bool rescale = false;
            double realCopy = value.m_real;
            double imaginaryCopy = value.m_imaginary;
            if ((Math.Abs(realCopy) >= s_sqrtRescaleThreshold) || (Math.Abs(imaginaryCopy) >= s_sqrtRescaleThreshold))
            {
                if (double.IsInfinity(value.m_imaginary) && !double.IsNaN(value.m_real))
                {
                    // We need to handle infinite imaginary parts specially because otherwise
                    // our formulas below produce inf/inf = NaN. The NaN test is necessary
                    // so that we return NaN rather than (+inf,inf) for (NaN,inf).
                    return (new QuantityValue(double.PositiveInfinity, imaginaryCopy));
                }

                realCopy *= 0.25;
                imaginaryCopy *= 0.25;
                rescale = true;
            }

            // This is the core of the algorithm. Everything else is special case handling.
            double x, y;
            if (realCopy >= 0.0)
            {
                x = Math.Sqrt((Hypot(realCopy, imaginaryCopy) + realCopy) * 0.5);
                y = imaginaryCopy / (2.0 * x);
            }
            else
            {
                y = Math.Sqrt((Hypot(realCopy, imaginaryCopy) - realCopy) * 0.5);
                if (imaginaryCopy < 0.0) y = -y;
                x = imaginaryCopy / (2.0 * y);
            }

            if (rescale)
            {
                x *= 2.0;
                y *= 2.0;
            }

            return new QuantityValue(x, y);
        }
        public QuantityValue Pow(QuantityValue power) => Pow(this, power);
        public static QuantityValue Pow(QuantityValue value, QuantityValue power)
        {
            if (power == Zero)
            {
                return One;
            }

            if (value == Zero)
            {
                return Zero;
            }

            double valueReal = value.m_real;
            double valueImaginary = value.m_imaginary;
            double powerReal = power.m_real;
            double powerImaginary = power.m_imaginary;

            double rho = Abs(value);
            double theta = Math.Atan2(valueImaginary, valueReal);
            double newRho = powerReal * theta + powerImaginary * Math.Log(rho);

            double t = Math.Pow(rho, powerReal) * Math.Pow(Math.E, -powerImaginary * theta);

            return new QuantityValue(t * Math.Cos(newRho), t * Math.Sin(newRho));
        }

        public static QuantityValue Pow(QuantityValue value, double power)
        {
            return Pow(value, new QuantityValue(power, 0));
        }

        public static QuantityValue Pow(double value, QuantityValue power)
        {
            return Pow(new QuantityValue(value, 0), power);
        }

        public static QuantityValue Pow(double value, double power) => Math.Pow(value, power);

        private static QuantityValue Scale(QuantityValue value, double factor)
        {
            double realResult = factor * value.m_real;
            double imaginaryResuilt = factor * value.m_imaginary;
            return new QuantityValue(realResult, imaginaryResuilt);
        }

        public static implicit operator QuantityValue(short value)
        {
            return new QuantityValue(value, 0.0);
        }

        public static implicit operator QuantityValue(int value)
        {
            return new QuantityValue(value, 0.0);
        }

        public static implicit operator QuantityValue(long value)
        {
            return new QuantityValue(value, 0.0);
        }

        [CLSCompliant(false)]
        public static implicit operator QuantityValue(ushort value)
        {
            return new QuantityValue(value, 0.0);
        }

        [CLSCompliant(false)]
        public static implicit operator QuantityValue(uint value)
        {
            return new QuantityValue(value, 0.0);
        }

        [CLSCompliant(false)]
        public static implicit operator QuantityValue(ulong value)
        {
            return new QuantityValue(value, 0.0);
        }

        [CLSCompliant(false)]
        public static implicit operator QuantityValue(sbyte value)
        {
            return new QuantityValue(value, 0.0);
        }

        public static implicit operator QuantityValue(byte value)
        {
            return new QuantityValue(value, 0.0);
        }

        public static implicit operator QuantityValue(float value)
        {
            return new QuantityValue(value, 0.0);
        }

        public static implicit operator QuantityValue(double value)
        {
            return new QuantityValue(value, 0.0);
        }

        public static implicit operator QuantityValue(Complex value)
        {
            return new QuantityValue(value.Real, value.Imaginary);
        }

        public static explicit operator QuantityValue(BigInteger value)
        {
            return new QuantityValue((double)value, 0.0);
        }

        public static implicit operator QuantityValue(decimal value) //Should make explicit
        {
            return new QuantityValue((double)value, 0.0);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        #region IConvertible Implementation
        /// <inheritdoc/>
        public TypeCode GetTypeCode()
        {
            return TypeCode.Object;
        }
        /// <inheritdoc/>
        public bool ToBoolean(IFormatProvider provider)
        {
            return this != 0;
        }
        /// <inheritdoc/>
        public byte ToByte(IFormatProvider provider)
        {
            if (Imaginary != 0)
            {
                throw new InvalidOperationException($"A complex valued '{nameof(QuantityValue)}' cannot be converted to a '{nameof(Byte)}'");
            }
            return Convert.ToByte(this.Real);
        }
        /// <inheritdoc/>
        public char ToChar(IFormatProvider provider)
        {
            if (Imaginary != 0)
            {
                throw new InvalidOperationException($"A complex valued '{nameof(QuantityValue)}' cannot be converted to a '{nameof(Char)}'");
            }
            return Convert.ToChar(this.Real);
        }
        /// <inheritdoc/>
        public DateTime ToDateTime(IFormatProvider provider)
        {
            if (Imaginary != 0)
            {
                throw new InvalidOperationException($"A complex valued '{nameof(QuantityValue)}' cannot be converted to a '{nameof(DateTime)}'");
            }
            return Convert.ToDateTime(this.Real);
        }
        /// <inheritdoc/>
        public decimal ToDecimal(IFormatProvider provider)
        {
            if (Imaginary != 0)
            {
                throw new InvalidOperationException($"A complex valued '{nameof(QuantityValue)}' cannot be converted to a '{nameof(Decimal)}'");
            }
            return Convert.ToDecimal(this.Real);
        }
        /// <inheritdoc/>
        public double ToDouble(IFormatProvider provider)
        {
            if (Imaginary != 0)
            {
                throw new InvalidOperationException($"A complex valued '{nameof(QuantityValue)}' cannot be converted to a '{nameof(Double)}'");
            }
            return this.Real;
        }
        /// <inheritdoc/>
        public short ToInt16(IFormatProvider provider)
        {
            if (Imaginary != 0)
            {
                throw new InvalidOperationException($"A complex valued '{nameof(QuantityValue)}' cannot be converted to a '{nameof(Int16)}'");
            }
            return Convert.ToInt16(this.Real);
        }
        /// <inheritdoc/>
        public int ToInt32(IFormatProvider provider)
        {
            if (Imaginary != 0)
            {
                throw new InvalidOperationException($"A complex valued '{nameof(QuantityValue)}' cannot be converted to a '{nameof(Int32)}'");
            }
            return Convert.ToInt32(this.Real);
        }
        /// <inheritdoc/>
        public long ToInt64(IFormatProvider provider)
        {
            if (Imaginary != 0)
            {
                throw new InvalidOperationException($"A complex valued '{nameof(QuantityValue)}' cannot be converted to a '{nameof(Byte)}'");
            }
            return Convert.ToInt64(this.Real);
        }

        /// <inheritdoc/>
        [CLSCompliant(false)]
        public sbyte ToSByte(IFormatProvider provider)
        {
            if (Imaginary != 0)
            {
                throw new InvalidOperationException($"A complex valued '{nameof(QuantityValue)}' cannot be converted to a '{nameof(SByte)}'");
            }
            return Convert.ToSByte(this.Real);
        }
        /// <inheritdoc/>
        public float ToSingle(IFormatProvider provider)
        {
            if (Imaginary != 0)
            {
                throw new InvalidOperationException($"A complex valued '{nameof(QuantityValue)}' cannot be converted to a '{nameof(Single)}'");
            }
            return Convert.ToSingle(this.Real);
        }
        /// <inheritdoc/>
        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }
        /// <inheritdoc/>
        [CLSCompliant(false)]
        public ushort ToUInt16(IFormatProvider provider)
        {
            if (Imaginary != 0)
            {
                throw new InvalidOperationException($"A complex valued '{nameof(QuantityValue)}' cannot be converted to a '{nameof(UInt16)}'");
            }
            return Convert.ToUInt16(this.Real);
        }
        /// <inheritdoc/>
        [CLSCompliant(false)]
        public uint ToUInt32(IFormatProvider provider)
        {
            if (Imaginary != 0)
            {
                throw new InvalidOperationException($"A complex valued '{nameof(QuantityValue)}' cannot be converted to a '{nameof(UInt32)}'");
            }
            return Convert.ToUInt32(this.Real);
        }

        /// <inheritdoc/>
        [CLSCompliant(false)]
        public ulong ToUInt64(IFormatProvider provider)
        {
            if (Imaginary != 0)
            {
                throw new InvalidOperationException($"A complex valued '{nameof(QuantityValue)}' cannot be converted to a '{nameof(UInt64)}'");
            }
            return Convert.ToUInt64(this.Real);
        }
        #endregion

        #region IComparible Implementation
        /// <summary>
        /// Compare reals first and if equal, compare imaginary
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(QuantityValue other)
        {
            QuantityValue value = this;

            if (value.Real < other.Real) return -1;
            if (value.Real > other.Real) return 1;
            if (value.Imaginary < other.Imaginary) return -1;
            if (value.Imaginary > other.Imaginary) return 1;
            return 0;

        }

        /// <summary>
        /// Compare reals first and if equal, compare imaginary
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(double other)
        {
            QuantityValue value = this;

            if (value.Real < other) return -1;
            if (value.Real > other) return 1;
            if (value.Imaginary < 0) return -1;
            if (value.Imaginary > 0) return 1;
            return 0;
        }

        /// <inheritdoc/>
        int IComparable.CompareTo(object? obj)
        {
            switch (obj)
            {
                case QuantityValue quantity:
                    return CompareTo(quantity);
                case byte val:
                    return CompareTo(Convert.ToDouble(val));
                case short val:
                    return CompareTo(Convert.ToDouble(val));
                case int val:
                    return CompareTo(Convert.ToDouble(val));
                case long val:
                    return CompareTo(Convert.ToDouble(val));
                case float val:
                    return CompareTo(Convert.ToDouble(val));
                case double val:
                    return CompareTo(val);
                case decimal val:
                    return CompareTo(Convert.ToDouble(val));
                case bool val:
                    return CompareTo(Convert.ToDouble(val));

                default:
                    throw new InvalidOperationException($"Comparrison between types '{nameof(QuantityValue)}' and '{obj.GetType()}' is not supported.");
            }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static bool operator <(QuantityValue left, QuantityValue right)
        {
            return left.CompareTo(right) == -1;
        }
        public static bool operator >(QuantityValue left, QuantityValue right)
        {
            return left.CompareTo(right) == 1;
        }
        public static bool operator <=(QuantityValue left, QuantityValue right)
        {
            return left.CompareTo(right) != 1;
        }
        public static bool operator >=(QuantityValue left, QuantityValue right)
        {
            return left.CompareTo(right) != -1;
        }
        [CLSCompliant(false)]
        public static bool operator <(QuantityValue left, IConvertible right)
        {
            if(right is QuantityValue rightQuantityValue)
            {
                return left < rightQuantityValue;
            }
            return left.CompareTo(right.ToDouble(null)) == -1;
        }
        [CLSCompliant(false)]
        public static bool operator >(QuantityValue left, IConvertible right)
        {
            if (right is QuantityValue rightQuantityValue)
            {
                return left > rightQuantityValue;
            }
            return left.CompareTo(right.ToDouble(null)) == 1;
        }
        [CLSCompliant(false)]
        public static bool operator <=(QuantityValue left, IConvertible right)
        {
            if (right is QuantityValue rightQuantityValue)
            {
                return left <= rightQuantityValue;
            }
            return left.CompareTo(right.ToDouble(null)) != 1;
        }
        [CLSCompliant(false)]
        public static bool operator >=(QuantityValue left, IConvertible right)
        {
            if (right is QuantityValue rightQuantityValue)
            {
                return left >= rightQuantityValue;
            }
            return left.CompareTo(right.ToDouble(null)) != -1;
        }

        [CLSCompliant(false)]
        public static bool operator <(IConvertible left, QuantityValue right)
        {
            return !(right >= left);
        }
        [CLSCompliant(false)]
        public static bool operator >(IConvertible left, QuantityValue right)
        {
            return !(right <= left);
        }
        [CLSCompliant(false)]
        public static bool operator <=(IConvertible left, QuantityValue right)
        {
            return !(right > left);
        }
        [CLSCompliant(false)]
        public static bool operator >=(IConvertible left, QuantityValue right)
        {
            return !(right < left);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        #endregion
    }

}
