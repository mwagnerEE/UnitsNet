// ReSharper disable once CheckNamespace
namespace UnitsNet
{
    // Disable missing XML comment warnings for the generated unit enums.
    #pragma warning disable 1591

    public partial struct Dimension
    {
        public static Dimension Length { get; } = new Dimension(nameof(Length));
        public static Dimension Mass { get; } = new Dimension(nameof(Mass));
        public static Dimension Time { get; } = new Dimension(nameof(Time));
        public static Dimension Current { get; } = new Dimension(nameof(Current));
        public static Dimension Temperature { get; } = new Dimension(nameof(Temperature));
        public static Dimension Amount { get; } = new Dimension(nameof(Amount));
        public static Dimension LuminousIntensity { get; } = new Dimension(nameof(LuminousIntensity));
        public static Dimension Angle { get; } = new Dimension(nameof(Angle), true);
        public static Dimension Data { get; } = new Dimension(nameof(Data));
        public static Dimension VitaminA { get; } = new Dimension(nameof(VitaminA));
    }

    #pragma warning restore 1591
}
