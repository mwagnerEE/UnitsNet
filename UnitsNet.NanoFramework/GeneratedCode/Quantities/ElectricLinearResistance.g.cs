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
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     Electrical linear resistance is a property of one dimensional conductors that represents the resistance per unit length.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Electrical_resistivity_and_conductivity
    /// </remarks>
    public struct  ElectricLinearResistance
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricLinearResistanceUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ElectricLinearResistanceUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ElectricLinearResistance(double value, ElectricLinearResistanceUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static ElectricLinearResistanceUnit BaseUnit { get; } = ElectricLinearResistanceUnit.OhmPerMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static ElectricLinearResistance MaxValue { get; } = new ElectricLinearResistance(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static ElectricLinearResistance MinValue { get; } = new ElectricLinearResistance(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ElectricLinearResistance Zero { get; } = new ElectricLinearResistance(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.KiloohmPerCentimeter"/>
        /// </summary>
        public double KiloohmsPerCentimeter => As(ElectricLinearResistanceUnit.KiloohmPerCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.KiloohmPerFoot"/>
        /// </summary>
        public double KiloohmsPerFoot => As(ElectricLinearResistanceUnit.KiloohmPerFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.KiloohmPerKiloimeter"/>
        /// </summary>
        public double KiloohmsPerKilometer => As(ElectricLinearResistanceUnit.KiloohmPerKiloimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.KiloohmPerMeter"/>
        /// </summary>
        public double KiloohmsPerMeter => As(ElectricLinearResistanceUnit.KiloohmPerMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.KiloohmPerMile"/>
        /// </summary>
        public double KiloohmsPerMile => As(ElectricLinearResistanceUnit.KiloohmPerMile);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.MegaohmPerCentimeter"/>
        /// </summary>
        public double MegaohmsPerCentimeter => As(ElectricLinearResistanceUnit.MegaohmPerCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.MegaohmPerFoot"/>
        /// </summary>
        public double MegaohmsPerFoot => As(ElectricLinearResistanceUnit.MegaohmPerFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.MegaohmPerKiloimeter"/>
        /// </summary>
        public double MegaohmsPerKilometer => As(ElectricLinearResistanceUnit.MegaohmPerKiloimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.MegaohmPerMeter"/>
        /// </summary>
        public double MegaohmsPerMeter => As(ElectricLinearResistanceUnit.MegaohmPerMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.MegaohmPerMile"/>
        /// </summary>
        public double MegaohmsPerMile => As(ElectricLinearResistanceUnit.MegaohmPerMile);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.MicroohmPerCentimeter"/>
        /// </summary>
        public double MicroohmsPerCentimeter => As(ElectricLinearResistanceUnit.MicroohmPerCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.MicroohmPerFoot"/>
        /// </summary>
        public double MicroohmsPerFoot => As(ElectricLinearResistanceUnit.MicroohmPerFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.MicroohmPerKiloimeter"/>
        /// </summary>
        public double MicroohmsPerKilometer => As(ElectricLinearResistanceUnit.MicroohmPerKiloimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.MicroohmPerMeter"/>
        /// </summary>
        public double MicroohmsPerMeter => As(ElectricLinearResistanceUnit.MicroohmPerMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.MicroohmPerMile"/>
        /// </summary>
        public double MicroohmsPerMile => As(ElectricLinearResistanceUnit.MicroohmPerMile);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.MilliohmPerCentimeter"/>
        /// </summary>
        public double MilliohmsPerCentimeter => As(ElectricLinearResistanceUnit.MilliohmPerCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.MilliohmPerFoot"/>
        /// </summary>
        public double MilliohmsPerFoot => As(ElectricLinearResistanceUnit.MilliohmPerFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.MilliohmPerKiloimeter"/>
        /// </summary>
        public double MilliohmsPerKilometer => As(ElectricLinearResistanceUnit.MilliohmPerKiloimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.MilliohmPerMeter"/>
        /// </summary>
        public double MilliohmsPerMeter => As(ElectricLinearResistanceUnit.MilliohmPerMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.MilliohmPerMile"/>
        /// </summary>
        public double MilliohmsPerMile => As(ElectricLinearResistanceUnit.MilliohmPerMile);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.NanoohmPerCentimeter"/>
        /// </summary>
        public double NanoohmsPerCentimeter => As(ElectricLinearResistanceUnit.NanoohmPerCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.NanoohmPerFoot"/>
        /// </summary>
        public double NanoohmsPerFoot => As(ElectricLinearResistanceUnit.NanoohmPerFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.NanoohmPerKiloimeter"/>
        /// </summary>
        public double NanoohmsPerKilometer => As(ElectricLinearResistanceUnit.NanoohmPerKiloimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.NanoohmPerMeter"/>
        /// </summary>
        public double NanoohmsPerMeter => As(ElectricLinearResistanceUnit.NanoohmPerMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.NanoohmPerMile"/>
        /// </summary>
        public double NanoohmsPerMile => As(ElectricLinearResistanceUnit.NanoohmPerMile);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.OhmPerCentimeter"/>
        /// </summary>
        public double OhmsPerCentimeter => As(ElectricLinearResistanceUnit.OhmPerCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.OhmPerFoot"/>
        /// </summary>
        public double OhmsPerFoot => As(ElectricLinearResistanceUnit.OhmPerFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.OhmPerKiloimeter"/>
        /// </summary>
        public double OhmsPerKilometer => As(ElectricLinearResistanceUnit.OhmPerKiloimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.OhmPerMeter"/>
        /// </summary>
        public double OhmsPerMeter => As(ElectricLinearResistanceUnit.OhmPerMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.OhmPerMile"/>
        /// </summary>
        public double OhmsPerMile => As(ElectricLinearResistanceUnit.OhmPerMile);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.PicoohmPerCentimeter"/>
        /// </summary>
        public double PicoohmsPerCentimeter => As(ElectricLinearResistanceUnit.PicoohmPerCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.PicoohmPerFoot"/>
        /// </summary>
        public double PicoohmsPerFoot => As(ElectricLinearResistanceUnit.PicoohmPerFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.PicoohmPerKiloimeter"/>
        /// </summary>
        public double PicoohmsPerKilometer => As(ElectricLinearResistanceUnit.PicoohmPerKiloimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.PicoohmPerMeter"/>
        /// </summary>
        public double PicoohmsPerMeter => As(ElectricLinearResistanceUnit.PicoohmPerMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistanceUnit.PicoohmPerMile"/>
        /// </summary>
        public double PicoohmsPerMile => As(ElectricLinearResistanceUnit.PicoohmPerMile);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.KiloohmPerCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromKiloohmsPerCentimeter(double kiloohmspercentimeter) => new ElectricLinearResistance(kiloohmspercentimeter, ElectricLinearResistanceUnit.KiloohmPerCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.KiloohmPerFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromKiloohmsPerFoot(double kiloohmsperfoot) => new ElectricLinearResistance(kiloohmsperfoot, ElectricLinearResistanceUnit.KiloohmPerFoot);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.KiloohmPerKiloimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromKiloohmsPerKilometer(double kiloohmsperkilometer) => new ElectricLinearResistance(kiloohmsperkilometer, ElectricLinearResistanceUnit.KiloohmPerKiloimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.KiloohmPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromKiloohmsPerMeter(double kiloohmspermeter) => new ElectricLinearResistance(kiloohmspermeter, ElectricLinearResistanceUnit.KiloohmPerMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.KiloohmPerMile"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromKiloohmsPerMile(double kiloohmspermile) => new ElectricLinearResistance(kiloohmspermile, ElectricLinearResistanceUnit.KiloohmPerMile);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.MegaohmPerCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromMegaohmsPerCentimeter(double megaohmspercentimeter) => new ElectricLinearResistance(megaohmspercentimeter, ElectricLinearResistanceUnit.MegaohmPerCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.MegaohmPerFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromMegaohmsPerFoot(double megaohmsperfoot) => new ElectricLinearResistance(megaohmsperfoot, ElectricLinearResistanceUnit.MegaohmPerFoot);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.MegaohmPerKiloimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromMegaohmsPerKilometer(double megaohmsperkilometer) => new ElectricLinearResistance(megaohmsperkilometer, ElectricLinearResistanceUnit.MegaohmPerKiloimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.MegaohmPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromMegaohmsPerMeter(double megaohmspermeter) => new ElectricLinearResistance(megaohmspermeter, ElectricLinearResistanceUnit.MegaohmPerMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.MegaohmPerMile"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromMegaohmsPerMile(double megaohmspermile) => new ElectricLinearResistance(megaohmspermile, ElectricLinearResistanceUnit.MegaohmPerMile);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.MicroohmPerCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromMicroohmsPerCentimeter(double microohmspercentimeter) => new ElectricLinearResistance(microohmspercentimeter, ElectricLinearResistanceUnit.MicroohmPerCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.MicroohmPerFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromMicroohmsPerFoot(double microohmsperfoot) => new ElectricLinearResistance(microohmsperfoot, ElectricLinearResistanceUnit.MicroohmPerFoot);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.MicroohmPerKiloimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromMicroohmsPerKilometer(double microohmsperkilometer) => new ElectricLinearResistance(microohmsperkilometer, ElectricLinearResistanceUnit.MicroohmPerKiloimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.MicroohmPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromMicroohmsPerMeter(double microohmspermeter) => new ElectricLinearResistance(microohmspermeter, ElectricLinearResistanceUnit.MicroohmPerMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.MicroohmPerMile"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromMicroohmsPerMile(double microohmspermile) => new ElectricLinearResistance(microohmspermile, ElectricLinearResistanceUnit.MicroohmPerMile);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.MilliohmPerCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromMilliohmsPerCentimeter(double milliohmspercentimeter) => new ElectricLinearResistance(milliohmspercentimeter, ElectricLinearResistanceUnit.MilliohmPerCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.MilliohmPerFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromMilliohmsPerFoot(double milliohmsperfoot) => new ElectricLinearResistance(milliohmsperfoot, ElectricLinearResistanceUnit.MilliohmPerFoot);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.MilliohmPerKiloimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromMilliohmsPerKilometer(double milliohmsperkilometer) => new ElectricLinearResistance(milliohmsperkilometer, ElectricLinearResistanceUnit.MilliohmPerKiloimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.MilliohmPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromMilliohmsPerMeter(double milliohmspermeter) => new ElectricLinearResistance(milliohmspermeter, ElectricLinearResistanceUnit.MilliohmPerMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.MilliohmPerMile"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromMilliohmsPerMile(double milliohmspermile) => new ElectricLinearResistance(milliohmspermile, ElectricLinearResistanceUnit.MilliohmPerMile);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.NanoohmPerCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromNanoohmsPerCentimeter(double nanoohmspercentimeter) => new ElectricLinearResistance(nanoohmspercentimeter, ElectricLinearResistanceUnit.NanoohmPerCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.NanoohmPerFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromNanoohmsPerFoot(double nanoohmsperfoot) => new ElectricLinearResistance(nanoohmsperfoot, ElectricLinearResistanceUnit.NanoohmPerFoot);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.NanoohmPerKiloimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromNanoohmsPerKilometer(double nanoohmsperkilometer) => new ElectricLinearResistance(nanoohmsperkilometer, ElectricLinearResistanceUnit.NanoohmPerKiloimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.NanoohmPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromNanoohmsPerMeter(double nanoohmspermeter) => new ElectricLinearResistance(nanoohmspermeter, ElectricLinearResistanceUnit.NanoohmPerMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.NanoohmPerMile"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromNanoohmsPerMile(double nanoohmspermile) => new ElectricLinearResistance(nanoohmspermile, ElectricLinearResistanceUnit.NanoohmPerMile);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.OhmPerCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromOhmsPerCentimeter(double ohmspercentimeter) => new ElectricLinearResistance(ohmspercentimeter, ElectricLinearResistanceUnit.OhmPerCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.OhmPerFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromOhmsPerFoot(double ohmsperfoot) => new ElectricLinearResistance(ohmsperfoot, ElectricLinearResistanceUnit.OhmPerFoot);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.OhmPerKiloimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromOhmsPerKilometer(double ohmsperkilometer) => new ElectricLinearResistance(ohmsperkilometer, ElectricLinearResistanceUnit.OhmPerKiloimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.OhmPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromOhmsPerMeter(double ohmspermeter) => new ElectricLinearResistance(ohmspermeter, ElectricLinearResistanceUnit.OhmPerMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.OhmPerMile"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromOhmsPerMile(double ohmspermile) => new ElectricLinearResistance(ohmspermile, ElectricLinearResistanceUnit.OhmPerMile);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.PicoohmPerCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromPicoohmsPerCentimeter(double picoohmspercentimeter) => new ElectricLinearResistance(picoohmspercentimeter, ElectricLinearResistanceUnit.PicoohmPerCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.PicoohmPerFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromPicoohmsPerFoot(double picoohmsperfoot) => new ElectricLinearResistance(picoohmsperfoot, ElectricLinearResistanceUnit.PicoohmPerFoot);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.PicoohmPerKiloimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromPicoohmsPerKilometer(double picoohmsperkilometer) => new ElectricLinearResistance(picoohmsperkilometer, ElectricLinearResistanceUnit.PicoohmPerKiloimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.PicoohmPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromPicoohmsPerMeter(double picoohmspermeter) => new ElectricLinearResistance(picoohmspermeter, ElectricLinearResistanceUnit.PicoohmPerMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistance"/> from <see cref="ElectricLinearResistanceUnit.PicoohmPerMile"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistance FromPicoohmsPerMile(double picoohmspermile) => new ElectricLinearResistance(picoohmspermile, ElectricLinearResistanceUnit.PicoohmPerMile);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricLinearResistanceUnit" /> to <see cref="ElectricLinearResistance" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricLinearResistance unit value.</returns>
        public static ElectricLinearResistance From(double value, ElectricLinearResistanceUnit fromUnit)
        {
            return new ElectricLinearResistance(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(ElectricLinearResistanceUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public ElectricLinearResistance ToUnit(ElectricLinearResistanceUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new ElectricLinearResistance(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            return Unit switch
            {
                ElectricLinearResistanceUnit.KiloohmPerCentimeter => (_value / 100) * 1e3d,
                ElectricLinearResistanceUnit.KiloohmPerFoot => (_value / 3.281) * 1e3d,
                ElectricLinearResistanceUnit.KiloohmPerKiloimeter => (_value * 1000) * 1e3d,
                ElectricLinearResistanceUnit.KiloohmPerMeter => (_value) * 1e3d,
                ElectricLinearResistanceUnit.KiloohmPerMile => (_value * 1609) * 1e3d,
                ElectricLinearResistanceUnit.MegaohmPerCentimeter => (_value / 100) * 1e6d,
                ElectricLinearResistanceUnit.MegaohmPerFoot => (_value / 3.281) * 1e6d,
                ElectricLinearResistanceUnit.MegaohmPerKiloimeter => (_value * 1000) * 1e6d,
                ElectricLinearResistanceUnit.MegaohmPerMeter => (_value) * 1e6d,
                ElectricLinearResistanceUnit.MegaohmPerMile => (_value * 1609) * 1e6d,
                ElectricLinearResistanceUnit.MicroohmPerCentimeter => (_value / 100) * 1e-6d,
                ElectricLinearResistanceUnit.MicroohmPerFoot => (_value / 3.281) * 1e-6d,
                ElectricLinearResistanceUnit.MicroohmPerKiloimeter => (_value * 1000) * 1e-6d,
                ElectricLinearResistanceUnit.MicroohmPerMeter => (_value) * 1e-6d,
                ElectricLinearResistanceUnit.MicroohmPerMile => (_value * 1609) * 1e-6d,
                ElectricLinearResistanceUnit.MilliohmPerCentimeter => (_value / 100) * 1e-3d,
                ElectricLinearResistanceUnit.MilliohmPerFoot => (_value / 3.281) * 1e-3d,
                ElectricLinearResistanceUnit.MilliohmPerKiloimeter => (_value * 1000) * 1e-3d,
                ElectricLinearResistanceUnit.MilliohmPerMeter => (_value) * 1e-3d,
                ElectricLinearResistanceUnit.MilliohmPerMile => (_value * 1609) * 1e-3d,
                ElectricLinearResistanceUnit.NanoohmPerCentimeter => (_value / 100) * 1e-9d,
                ElectricLinearResistanceUnit.NanoohmPerFoot => (_value / 3.281) * 1e-9d,
                ElectricLinearResistanceUnit.NanoohmPerKiloimeter => (_value * 1000) * 1e-9d,
                ElectricLinearResistanceUnit.NanoohmPerMeter => (_value) * 1e-9d,
                ElectricLinearResistanceUnit.NanoohmPerMile => (_value * 1609) * 1e-9d,
                ElectricLinearResistanceUnit.OhmPerCentimeter => _value / 100,
                ElectricLinearResistanceUnit.OhmPerFoot => _value / 3.281,
                ElectricLinearResistanceUnit.OhmPerKiloimeter => _value * 1000,
                ElectricLinearResistanceUnit.OhmPerMeter => _value,
                ElectricLinearResistanceUnit.OhmPerMile => _value * 1609,
                ElectricLinearResistanceUnit.PicoohmPerCentimeter => (_value / 100) * 1e-12d,
                ElectricLinearResistanceUnit.PicoohmPerFoot => (_value / 3.281) * 1e-12d,
                ElectricLinearResistanceUnit.PicoohmPerKiloimeter => (_value * 1000) * 1e-12d,
                ElectricLinearResistanceUnit.PicoohmPerMeter => (_value) * 1e-12d,
                ElectricLinearResistanceUnit.PicoohmPerMile => (_value * 1609) * 1e-12d,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(ElectricLinearResistanceUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                ElectricLinearResistanceUnit.KiloohmPerCentimeter => (baseUnitValue * 100) / 1e3d,
                ElectricLinearResistanceUnit.KiloohmPerFoot => (baseUnitValue * 3.281) / 1e3d,
                ElectricLinearResistanceUnit.KiloohmPerKiloimeter => (baseUnitValue / 1000) / 1e3d,
                ElectricLinearResistanceUnit.KiloohmPerMeter => (baseUnitValue) / 1e3d,
                ElectricLinearResistanceUnit.KiloohmPerMile => (baseUnitValue / 1609) / 1e3d,
                ElectricLinearResistanceUnit.MegaohmPerCentimeter => (baseUnitValue * 100) / 1e6d,
                ElectricLinearResistanceUnit.MegaohmPerFoot => (baseUnitValue * 3.281) / 1e6d,
                ElectricLinearResistanceUnit.MegaohmPerKiloimeter => (baseUnitValue / 1000) / 1e6d,
                ElectricLinearResistanceUnit.MegaohmPerMeter => (baseUnitValue) / 1e6d,
                ElectricLinearResistanceUnit.MegaohmPerMile => (baseUnitValue / 1609) / 1e6d,
                ElectricLinearResistanceUnit.MicroohmPerCentimeter => (baseUnitValue * 100) / 1e-6d,
                ElectricLinearResistanceUnit.MicroohmPerFoot => (baseUnitValue * 3.281) / 1e-6d,
                ElectricLinearResistanceUnit.MicroohmPerKiloimeter => (baseUnitValue / 1000) / 1e-6d,
                ElectricLinearResistanceUnit.MicroohmPerMeter => (baseUnitValue) / 1e-6d,
                ElectricLinearResistanceUnit.MicroohmPerMile => (baseUnitValue / 1609) / 1e-6d,
                ElectricLinearResistanceUnit.MilliohmPerCentimeter => (baseUnitValue * 100) / 1e-3d,
                ElectricLinearResistanceUnit.MilliohmPerFoot => (baseUnitValue * 3.281) / 1e-3d,
                ElectricLinearResistanceUnit.MilliohmPerKiloimeter => (baseUnitValue / 1000) / 1e-3d,
                ElectricLinearResistanceUnit.MilliohmPerMeter => (baseUnitValue) / 1e-3d,
                ElectricLinearResistanceUnit.MilliohmPerMile => (baseUnitValue / 1609) / 1e-3d,
                ElectricLinearResistanceUnit.NanoohmPerCentimeter => (baseUnitValue * 100) / 1e-9d,
                ElectricLinearResistanceUnit.NanoohmPerFoot => (baseUnitValue * 3.281) / 1e-9d,
                ElectricLinearResistanceUnit.NanoohmPerKiloimeter => (baseUnitValue / 1000) / 1e-9d,
                ElectricLinearResistanceUnit.NanoohmPerMeter => (baseUnitValue) / 1e-9d,
                ElectricLinearResistanceUnit.NanoohmPerMile => (baseUnitValue / 1609) / 1e-9d,
                ElectricLinearResistanceUnit.OhmPerCentimeter => baseUnitValue * 100,
                ElectricLinearResistanceUnit.OhmPerFoot => baseUnitValue * 3.281,
                ElectricLinearResistanceUnit.OhmPerKiloimeter => baseUnitValue / 1000,
                ElectricLinearResistanceUnit.OhmPerMeter => baseUnitValue,
                ElectricLinearResistanceUnit.OhmPerMile => baseUnitValue / 1609,
                ElectricLinearResistanceUnit.PicoohmPerCentimeter => (baseUnitValue * 100) / 1e-12d,
                ElectricLinearResistanceUnit.PicoohmPerFoot => (baseUnitValue * 3.281) / 1e-12d,
                ElectricLinearResistanceUnit.PicoohmPerKiloimeter => (baseUnitValue / 1000) / 1e-12d,
                ElectricLinearResistanceUnit.PicoohmPerMeter => (baseUnitValue) / 1e-12d,
                ElectricLinearResistanceUnit.PicoohmPerMile => (baseUnitValue / 1609) / 1e-12d,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion

    }
}

