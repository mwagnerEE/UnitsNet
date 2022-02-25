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

#nullable enable

namespace UnitsNet.NumberExtensions.NumberToRotationalAcceleration
{
    /// <summary>
    /// A number to RotationalAcceleration Extensions
    /// </summary>
    public static class NumberToRotationalAccelerationExtensions
    {
        /// <inheritdoc cref="RotationalAcceleration.FromDegreesPerSecondSquared(UnitsNet.QuantityValue)" />
        public static RotationalAcceleration DegreesPerSecondSquared<T>(this T value) =>
            RotationalAcceleration.FromDegreesPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalAcceleration.FromRadiansPerSecondSquared(UnitsNet.QuantityValue)" />
        public static RotationalAcceleration RadiansPerSecondSquared<T>(this T value) =>
            RotationalAcceleration.FromRadiansPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalAcceleration.FromRevolutionsPerMinutePerSecond(UnitsNet.QuantityValue)" />
        public static RotationalAcceleration RevolutionsPerMinutePerSecond<T>(this T value) =>
            RotationalAcceleration.FromRevolutionsPerMinutePerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalAcceleration.FromRevolutionsPerSecondSquared(UnitsNet.QuantityValue)" />
        public static RotationalAcceleration RevolutionsPerSecondSquared<T>(this T value) =>
            RotationalAcceleration.FromRevolutionsPerSecondSquared(Convert.ToDouble(value));

    }
}
