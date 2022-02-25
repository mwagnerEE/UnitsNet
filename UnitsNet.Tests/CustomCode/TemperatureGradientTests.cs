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
using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class TemperatureGradientTests : TemperatureGradientTestsBase
    {
        protected override bool SupportsSIUnitSystem => true;

        protected override double DegreesCelciusPerKilometerInOneKelvinPerMeter => 1000;

        protected override double DegreesCelciusPerMeterInOneKelvinPerMeter => 1;

        protected override double DegreesFahrenheitPerFootInOneKelvinPerMeter => 0.54864;

        protected override double KelvinsPerMeterInOneKelvinPerMeter => 1;

        [Fact]
        public void TemperatureDeltaDividedByTemperatureGradientEqualsLength()
        {
            Length length = TemperatureDelta.FromDegreesCelsius(50) / TemperatureGradient.FromDegreesCelciusPerKilometer(5);
            Assert.Equal(length, Length.FromKilometers(10));
        }

        [Fact]
        public void TemperatureDeltaDividedByLengthEqualsTemperatureGradient()
        {
            TemperatureGradient temperatureGradient = TemperatureDelta.FromDegreesCelsius(50) / Length.FromKilometers(10);
            Assert.Equal(temperatureGradient, TemperatureGradient.FromDegreesCelciusPerKilometer(5));
        }

        [Fact]
        public void LengthMultipliedByTemperatureGradientEqualsTemperatureDelta()
        {
            TemperatureDelta temperatureDelta = Length.FromKilometers(10) * TemperatureGradient.FromDegreesCelciusPerKilometer(5);
            Assert.Equal(temperatureDelta, TemperatureDelta.FromDegreesCelsius(50));
        }

        [Fact]
        public void TemperatureGradientMultipliedByLengthEqualsTemperatureDelta()
        {
            TemperatureDelta temperatureDelta = TemperatureGradient.FromDegreesCelciusPerKilometer(5) * Length.FromKilometers(10);
            Assert.Equal(temperatureDelta, TemperatureDelta.FromDegreesCelsius(50));
        }
    }
}
