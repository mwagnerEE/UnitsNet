﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

namespace UnitsNet
{
    public partial class ElectricCurrent
    {
        /// <summary>Get <see cref="ElectricPotential"/> from <see cref="ElectricResistance"/> multiplied by <see cref="ElectricCurrent"/>.</summary>
        /// <remarks>Ohm's law implementation</remarks>
        public static ElectricPotential operator *(ElectricCurrent current, ElectricResistance resistance)
        {
            return ElectricPotential.FromVolts(resistance.Ohms * current.Amperes);
        }

        /// <summary>Calculate <see cref="Power"/> from <see cref="ElectricPotential"/> multiplied by <see cref="ElectricCurrent"/>.</summary>
        /// <remarks>Electric power is defined as P = U * I.</remarks>
        public static Power operator *(ElectricCurrent current, ElectricPotential potential)
        {
            return Power.FromWatts(potential.Volts * current.Amperes);
        }

        /// <summary>Calculate <see cref="ElectricCharge"/> from <see cref="ElectricCurrent"/> multiplied by <see cref="Duration"/>.</summary>
        public static ElectricCharge operator *(ElectricCurrent current, Duration time)
        {
            return ElectricCharge.FromAmpereHours(current.Amperes * time.Hours);
        }
    }
}
