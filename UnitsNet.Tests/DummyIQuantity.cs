using System;
using JetBrains.Annotations;

namespace UnitsNet.Tests
{
    internal class DummyIQuantity : IQuantity
    {

        public Dimensions Dimensions => throw new NotImplementedException();

        public QuantityInfo QuantityInfo => throw new NotImplementedException();

        public Enum Unit => throw new NotImplementedException();

        public QuantityValue Value => throw new NotImplementedException();

        public QuantityValue InBaseUnits => throw new NotImplementedException();

        public QuantityValue As(Enum unit ) => throw new NotImplementedException();

        public QuantityValue As(UnitSystem unitSystem ) => throw new NotImplementedException();

        public string ToString([CanBeNull] IFormatProvider provider ) => throw new NotImplementedException();

        public string ToString([CanBeNull] IFormatProvider provider, int significantDigitsAfterRadix ) => throw new NotImplementedException();

        public string ToString([CanBeNull] IFormatProvider provider, [NotNull] string format, [NotNull] params object[] args ) => throw new NotImplementedException();

        public string ToString(string format, IFormatProvider formatProvider ) => throw new NotImplementedException();

        public IQuantity ToUnit(Enum unit ) => throw new NotImplementedException();

        public IQuantity ToUnit(Enum unit, UnitConverter unitConverter) => throw new NotImplementedException();

        public IQuantity ToUnit(UnitSystem unitSystem ) => throw new NotImplementedException();
    }
}
