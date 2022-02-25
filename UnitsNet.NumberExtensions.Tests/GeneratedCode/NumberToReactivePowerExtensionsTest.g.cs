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

using UnitsNet.NumberExtensions.NumberToReactivePower;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToReactivePowerExtensionsTests
    {
        [Fact]
        public void NumberToGigavoltamperesReactiveTest() =>
            Assert.Equal(ReactivePower.FromGigavoltamperesReactive(2), 2.GigavoltamperesReactive());

        [Fact]
        public void NumberToKilovoltamperesReactiveTest() =>
            Assert.Equal(ReactivePower.FromKilovoltamperesReactive(2), 2.KilovoltamperesReactive());

        [Fact]
        public void NumberToMegavoltamperesReactiveTest() =>
            Assert.Equal(ReactivePower.FromMegavoltamperesReactive(2), 2.MegavoltamperesReactive());

        [Fact]
        public void NumberToVoltamperesReactiveTest() =>
            Assert.Equal(ReactivePower.FromVoltamperesReactive(2), 2.VoltamperesReactive());

    }
}
