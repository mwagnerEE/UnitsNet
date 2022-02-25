﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

namespace UnitsNet
{
    public partial class ElectricCharge
    {
        /// <summary>Get <see cref="ElectricCurrent"/> from <see cref="ElectricCharge"/> divided by <see cref="Duration"/>.</summary>
        public static ElectricCurrent operator /(ElectricCharge charge, Duration time)
        {
            return ElectricCurrent.FromAmperes(charge.AmpereHours / time.Hours);
        }

        /// <summary>Get <see cref="Duration"/> from <see cref="ElectricCharge"/> divided by <see cref="ElectricCurrent"/>.</summary>
        public static Duration operator /(ElectricCharge charge, ElectricCurrent current)
        {
            return Duration.FromHours(charge.AmpereHours / current.Amperes);
        }
    }
}
