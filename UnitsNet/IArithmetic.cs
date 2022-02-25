using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsNet
{
    /// <summary>
    /// The value can be negated, added to, subtraced from, and scaled
    /// </summary>
    public interface IArithmetic
    {
        /// <summary>Negate the value.</summary>
        public IQuantity Negate();

        /// <summary>Add two values together</summary>
        public IQuantity Add(IQuantity other);

        /// <summary>Subtract one value from another</summary>
        public IQuantity Subtract(IQuantity other);

        /// <summary>Scale an IQuantity by a double</summary>
        public IQuantity Scale(double scaleFactor);
    }
}
