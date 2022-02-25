using System;

namespace UnitsNet.Tests.CustomQuantities
{
    /// <inheritdoc cref="IQuantity"/>
    /// <summary>
    /// Example of a custom/third-party quantity implementation, for plugging in quantities and units at runtime.
    /// </summary>
    public class HowMuch : QuantityBase, IQuantity
    {
        public HowMuch(double value, HowMuchUnit unit) : base(value, BaseDimensions)
        {
            Unit = unit;
        }
        public HowMuch(QuantityValue value, HowMuchUnit unit) : base(value, BaseDimensions)
        {
            Unit = unit;
        }

        Enum IQuantity.Unit => Unit;
        public HowMuchUnit Unit { get; }


        #region IQuantity

        private static readonly HowMuch Zero = new HowMuch(0, HowMuchUnit.Some);

        public static Dimensions BaseDimensions => Dimensions.Dimensionless;

        public new QuantityInfo QuantityInfo => new QuantityInfo(
            nameof(HowMuch),
            typeof(HowMuchUnit),
            new UnitInfo[]
            {
                new UnitInfo<HowMuchUnit>(HowMuchUnit.Some, "Some", BaseUnits.Undefined),
                new UnitInfo<HowMuchUnit>(HowMuchUnit.ATon, "Tons", BaseUnits.Undefined),
                new UnitInfo<HowMuchUnit>(HowMuchUnit.AShitTon, "ShitTons", BaseUnits.Undefined),
            },
            HowMuchUnit.Some,
            Zero,
            BaseDimensions);

        public double As(Enum unit) => Convert.ToDouble(unit);

        public double As(UnitSystem unitSystem) => throw new NotImplementedException();

        public override IQuantity ToUnit(Enum unit)
        {
            if (unit is HowMuchUnit howMuchUnit) return new HowMuch(As(unit), howMuchUnit);
            throw new ArgumentException("Must be of type HowMuchUnit.", nameof(unit));
        }

        public override IQuantity ToUnit(Enum unit, UnitConverter unitConverter) => throw new NotImplementedException();

        public override IQuantity ToUnit(UnitSystem unitSystem) => throw new NotImplementedException();

        public override string ToString() => $"{Value} {Unit}";
        public override string ToString(string format, IFormatProvider formatProvider) => $"HowMuch ({format}, {formatProvider})";
        public override string ToString(IFormatProvider provider) => $"HowMuch ({provider})";
        public string ToString(IFormatProvider provider, int significantDigitsAfterRadix) => $"HowMuch ({provider}, {significantDigitsAfterRadix})";
        public string ToString(IFormatProvider provider, string format, params object[] args) => $"HowMuch ({provider}, {string.Join(", ", args)})";

        #endregion
    }
}
