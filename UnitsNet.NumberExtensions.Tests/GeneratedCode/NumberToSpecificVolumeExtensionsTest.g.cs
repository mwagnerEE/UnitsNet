﻿//------------------------------------------------------------------------------
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

using UnitsNet.NumberExtensions.NumberToSpecificVolume;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToSpecificVolumeExtensionsTests
    {
        [Fact]
        public void NumberToCubicFeetPerPoundTest() =>
            Assert.Equal(SpecificVolume.FromCubicFeetPerPound(2), 2.CubicFeetPerPound());

        [Fact]
        public void NumberToCubicMetersPerKilogramTest() =>
            Assert.Equal(SpecificVolume.FromCubicMetersPerKilogram(2), 2.CubicMetersPerKilogram());

        [Fact]
        public void NumberToMillicubicMetersPerKilogramTest() =>
            Assert.Equal(SpecificVolume.FromMillicubicMetersPerKilogram(2), 2.MillicubicMetersPerKilogram());

    }
}