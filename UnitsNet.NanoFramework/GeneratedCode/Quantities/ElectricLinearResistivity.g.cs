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
    ///     Electrical linear resistivity is a property of one dimensional conductors that represents the resistance per unit length.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Electrical_resistivity_and_conductivity
    /// </remarks>
    public struct  ElectricLinearResistivity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly QuantityValue _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricLinearResistivityUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public QuantityValue Value => _value;

        /// <inheritdoc />
        public ElectricLinearResistivityUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ElectricLinearResistivity(QuantityValue value, ElectricLinearResistivityUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static ElectricLinearResistivityUnit BaseUnit { get; } = ElectricLinearResistivityUnit.OhmPerMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static ElectricLinearResistivity MaxValue { get; } = new ElectricLinearResistivity(QuantityValue.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static ElectricLinearResistivity MinValue { get; } = new ElectricLinearResistivity(QuantityValue.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ElectricLinearResistivity Zero { get; } = new ElectricLinearResistivity(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.KiloohmPerCentimeter"/>
        /// </summary>
        public QuantityValue KiloohmsPerCentimeter => As(ElectricLinearResistivityUnit.KiloohmPerCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.KiloohmPerFoot"/>
        /// </summary>
        public QuantityValue KiloohmsPerFoot => As(ElectricLinearResistivityUnit.KiloohmPerFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.KiloohmPerKilometer"/>
        /// </summary>
        public QuantityValue KiloohmsPerKilometer => As(ElectricLinearResistivityUnit.KiloohmPerKilometer);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.KiloohmPerMeter"/>
        /// </summary>
        public QuantityValue KiloohmsPerMeter => As(ElectricLinearResistivityUnit.KiloohmPerMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.KiloohmPerMile"/>
        /// </summary>
        public QuantityValue KiloohmsPerMile => As(ElectricLinearResistivityUnit.KiloohmPerMile);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.MegaohmPerCentimeter"/>
        /// </summary>
        public QuantityValue MegaohmsPerCentimeter => As(ElectricLinearResistivityUnit.MegaohmPerCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.MegaohmPerFoot"/>
        /// </summary>
        public QuantityValue MegaohmsPerFoot => As(ElectricLinearResistivityUnit.MegaohmPerFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.MegaohmPerKilometer"/>
        /// </summary>
        public QuantityValue MegaohmsPerKilometer => As(ElectricLinearResistivityUnit.MegaohmPerKilometer);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.MegaohmPerMeter"/>
        /// </summary>
        public QuantityValue MegaohmsPerMeter => As(ElectricLinearResistivityUnit.MegaohmPerMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.MegaohmPerMile"/>
        /// </summary>
        public QuantityValue MegaohmsPerMile => As(ElectricLinearResistivityUnit.MegaohmPerMile);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.MicroohmPerCentimeter"/>
        /// </summary>
        public QuantityValue MicroohmsPerCentimeter => As(ElectricLinearResistivityUnit.MicroohmPerCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.MicroohmPerFoot"/>
        /// </summary>
        public QuantityValue MicroohmsPerFoot => As(ElectricLinearResistivityUnit.MicroohmPerFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.MicroohmPerKilometer"/>
        /// </summary>
        public QuantityValue MicroohmsPerKilometer => As(ElectricLinearResistivityUnit.MicroohmPerKilometer);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.MicroohmPerMeter"/>
        /// </summary>
        public QuantityValue MicroohmsPerMeter => As(ElectricLinearResistivityUnit.MicroohmPerMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.MicroohmPerMile"/>
        /// </summary>
        public QuantityValue MicroohmsPerMile => As(ElectricLinearResistivityUnit.MicroohmPerMile);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.MilliohmPerCentimeter"/>
        /// </summary>
        public QuantityValue MilliohmsPerCentimeter => As(ElectricLinearResistivityUnit.MilliohmPerCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.MilliohmPerFoot"/>
        /// </summary>
        public QuantityValue MilliohmsPerFoot => As(ElectricLinearResistivityUnit.MilliohmPerFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.MilliohmPerKilometer"/>
        /// </summary>
        public QuantityValue MilliohmsPerKilometer => As(ElectricLinearResistivityUnit.MilliohmPerKilometer);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.MilliohmPerMeter"/>
        /// </summary>
        public QuantityValue MilliohmsPerMeter => As(ElectricLinearResistivityUnit.MilliohmPerMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.MilliohmPerMile"/>
        /// </summary>
        public QuantityValue MilliohmsPerMile => As(ElectricLinearResistivityUnit.MilliohmPerMile);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.NanoohmPerCentimeter"/>
        /// </summary>
        public QuantityValue NanoohmsPerCentimeter => As(ElectricLinearResistivityUnit.NanoohmPerCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.NanoohmPerFoot"/>
        /// </summary>
        public QuantityValue NanoohmsPerFoot => As(ElectricLinearResistivityUnit.NanoohmPerFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.NanoohmPerKilometer"/>
        /// </summary>
        public QuantityValue NanoohmsPerKilometer => As(ElectricLinearResistivityUnit.NanoohmPerKilometer);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.NanoohmPerMeter"/>
        /// </summary>
        public QuantityValue NanoohmsPerMeter => As(ElectricLinearResistivityUnit.NanoohmPerMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.NanoohmPerMile"/>
        /// </summary>
        public QuantityValue NanoohmsPerMile => As(ElectricLinearResistivityUnit.NanoohmPerMile);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.OhmPerCentimeter"/>
        /// </summary>
        public QuantityValue OhmsPerCentimeter => As(ElectricLinearResistivityUnit.OhmPerCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.OhmPerFoot"/>
        /// </summary>
        public QuantityValue OhmsPerFoot => As(ElectricLinearResistivityUnit.OhmPerFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.OhmPerKilometer"/>
        /// </summary>
        public QuantityValue OhmsPerKilometer => As(ElectricLinearResistivityUnit.OhmPerKilometer);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.OhmPerMeter"/>
        /// </summary>
        public QuantityValue OhmsPerMeter => As(ElectricLinearResistivityUnit.OhmPerMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.OhmPerMile"/>
        /// </summary>
        public QuantityValue OhmsPerMile => As(ElectricLinearResistivityUnit.OhmPerMile);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.PicoohmPerCentimeter"/>
        /// </summary>
        public QuantityValue PicoohmsPerCentimeter => As(ElectricLinearResistivityUnit.PicoohmPerCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.PicoohmPerFoot"/>
        /// </summary>
        public QuantityValue PicoohmsPerFoot => As(ElectricLinearResistivityUnit.PicoohmPerFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.PicoohmPerKilometer"/>
        /// </summary>
        public QuantityValue PicoohmsPerKilometer => As(ElectricLinearResistivityUnit.PicoohmPerKilometer);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.PicoohmPerMeter"/>
        /// </summary>
        public QuantityValue PicoohmsPerMeter => As(ElectricLinearResistivityUnit.PicoohmPerMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricLinearResistivityUnit.PicoohmPerMile"/>
        /// </summary>
        public QuantityValue PicoohmsPerMile => As(ElectricLinearResistivityUnit.PicoohmPerMile);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.KiloohmPerCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromKiloohmsPerCentimeter(QuantityValue kiloohmspercentimeter) => new ElectricLinearResistivity(kiloohmspercentimeter, ElectricLinearResistivityUnit.KiloohmPerCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.KiloohmPerFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromKiloohmsPerFoot(QuantityValue kiloohmsperfoot) => new ElectricLinearResistivity(kiloohmsperfoot, ElectricLinearResistivityUnit.KiloohmPerFoot);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.KiloohmPerKilometer"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromKiloohmsPerKilometer(QuantityValue kiloohmsperkilometer) => new ElectricLinearResistivity(kiloohmsperkilometer, ElectricLinearResistivityUnit.KiloohmPerKilometer);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.KiloohmPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromKiloohmsPerMeter(QuantityValue kiloohmspermeter) => new ElectricLinearResistivity(kiloohmspermeter, ElectricLinearResistivityUnit.KiloohmPerMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.KiloohmPerMile"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromKiloohmsPerMile(QuantityValue kiloohmspermile) => new ElectricLinearResistivity(kiloohmspermile, ElectricLinearResistivityUnit.KiloohmPerMile);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.MegaohmPerCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromMegaohmsPerCentimeter(QuantityValue megaohmspercentimeter) => new ElectricLinearResistivity(megaohmspercentimeter, ElectricLinearResistivityUnit.MegaohmPerCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.MegaohmPerFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromMegaohmsPerFoot(QuantityValue megaohmsperfoot) => new ElectricLinearResistivity(megaohmsperfoot, ElectricLinearResistivityUnit.MegaohmPerFoot);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.MegaohmPerKilometer"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromMegaohmsPerKilometer(QuantityValue megaohmsperkilometer) => new ElectricLinearResistivity(megaohmsperkilometer, ElectricLinearResistivityUnit.MegaohmPerKilometer);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.MegaohmPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromMegaohmsPerMeter(QuantityValue megaohmspermeter) => new ElectricLinearResistivity(megaohmspermeter, ElectricLinearResistivityUnit.MegaohmPerMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.MegaohmPerMile"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromMegaohmsPerMile(QuantityValue megaohmspermile) => new ElectricLinearResistivity(megaohmspermile, ElectricLinearResistivityUnit.MegaohmPerMile);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.MicroohmPerCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromMicroohmsPerCentimeter(QuantityValue microohmspercentimeter) => new ElectricLinearResistivity(microohmspercentimeter, ElectricLinearResistivityUnit.MicroohmPerCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.MicroohmPerFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromMicroohmsPerFoot(QuantityValue microohmsperfoot) => new ElectricLinearResistivity(microohmsperfoot, ElectricLinearResistivityUnit.MicroohmPerFoot);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.MicroohmPerKilometer"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromMicroohmsPerKilometer(QuantityValue microohmsperkilometer) => new ElectricLinearResistivity(microohmsperkilometer, ElectricLinearResistivityUnit.MicroohmPerKilometer);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.MicroohmPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromMicroohmsPerMeter(QuantityValue microohmspermeter) => new ElectricLinearResistivity(microohmspermeter, ElectricLinearResistivityUnit.MicroohmPerMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.MicroohmPerMile"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromMicroohmsPerMile(QuantityValue microohmspermile) => new ElectricLinearResistivity(microohmspermile, ElectricLinearResistivityUnit.MicroohmPerMile);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.MilliohmPerCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromMilliohmsPerCentimeter(QuantityValue milliohmspercentimeter) => new ElectricLinearResistivity(milliohmspercentimeter, ElectricLinearResistivityUnit.MilliohmPerCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.MilliohmPerFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromMilliohmsPerFoot(QuantityValue milliohmsperfoot) => new ElectricLinearResistivity(milliohmsperfoot, ElectricLinearResistivityUnit.MilliohmPerFoot);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.MilliohmPerKilometer"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromMilliohmsPerKilometer(QuantityValue milliohmsperkilometer) => new ElectricLinearResistivity(milliohmsperkilometer, ElectricLinearResistivityUnit.MilliohmPerKilometer);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.MilliohmPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromMilliohmsPerMeter(QuantityValue milliohmspermeter) => new ElectricLinearResistivity(milliohmspermeter, ElectricLinearResistivityUnit.MilliohmPerMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.MilliohmPerMile"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromMilliohmsPerMile(QuantityValue milliohmspermile) => new ElectricLinearResistivity(milliohmspermile, ElectricLinearResistivityUnit.MilliohmPerMile);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.NanoohmPerCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromNanoohmsPerCentimeter(QuantityValue nanoohmspercentimeter) => new ElectricLinearResistivity(nanoohmspercentimeter, ElectricLinearResistivityUnit.NanoohmPerCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.NanoohmPerFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromNanoohmsPerFoot(QuantityValue nanoohmsperfoot) => new ElectricLinearResistivity(nanoohmsperfoot, ElectricLinearResistivityUnit.NanoohmPerFoot);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.NanoohmPerKilometer"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromNanoohmsPerKilometer(QuantityValue nanoohmsperkilometer) => new ElectricLinearResistivity(nanoohmsperkilometer, ElectricLinearResistivityUnit.NanoohmPerKilometer);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.NanoohmPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromNanoohmsPerMeter(QuantityValue nanoohmspermeter) => new ElectricLinearResistivity(nanoohmspermeter, ElectricLinearResistivityUnit.NanoohmPerMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.NanoohmPerMile"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromNanoohmsPerMile(QuantityValue nanoohmspermile) => new ElectricLinearResistivity(nanoohmspermile, ElectricLinearResistivityUnit.NanoohmPerMile);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.OhmPerCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromOhmsPerCentimeter(QuantityValue ohmspercentimeter) => new ElectricLinearResistivity(ohmspercentimeter, ElectricLinearResistivityUnit.OhmPerCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.OhmPerFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromOhmsPerFoot(QuantityValue ohmsperfoot) => new ElectricLinearResistivity(ohmsperfoot, ElectricLinearResistivityUnit.OhmPerFoot);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.OhmPerKilometer"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromOhmsPerKilometer(QuantityValue ohmsperkilometer) => new ElectricLinearResistivity(ohmsperkilometer, ElectricLinearResistivityUnit.OhmPerKilometer);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.OhmPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromOhmsPerMeter(QuantityValue ohmspermeter) => new ElectricLinearResistivity(ohmspermeter, ElectricLinearResistivityUnit.OhmPerMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.OhmPerMile"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromOhmsPerMile(QuantityValue ohmspermile) => new ElectricLinearResistivity(ohmspermile, ElectricLinearResistivityUnit.OhmPerMile);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.PicoohmPerCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromPicoohmsPerCentimeter(QuantityValue picoohmspercentimeter) => new ElectricLinearResistivity(picoohmspercentimeter, ElectricLinearResistivityUnit.PicoohmPerCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.PicoohmPerFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromPicoohmsPerFoot(QuantityValue picoohmsperfoot) => new ElectricLinearResistivity(picoohmsperfoot, ElectricLinearResistivityUnit.PicoohmPerFoot);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.PicoohmPerKilometer"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromPicoohmsPerKilometer(QuantityValue picoohmsperkilometer) => new ElectricLinearResistivity(picoohmsperkilometer, ElectricLinearResistivityUnit.PicoohmPerKilometer);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.PicoohmPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromPicoohmsPerMeter(QuantityValue picoohmspermeter) => new ElectricLinearResistivity(picoohmspermeter, ElectricLinearResistivityUnit.PicoohmPerMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricLinearResistivity"/> from <see cref="ElectricLinearResistivityUnit.PicoohmPerMile"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricLinearResistivity FromPicoohmsPerMile(QuantityValue picoohmspermile) => new ElectricLinearResistivity(picoohmspermile, ElectricLinearResistivityUnit.PicoohmPerMile);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricLinearResistivityUnit" /> to <see cref="ElectricLinearResistivity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricLinearResistivity unit value.</returns>
        public static ElectricLinearResistivity From(QuantityValue value, ElectricLinearResistivityUnit fromUnit)
        {
            return new ElectricLinearResistivity(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public QuantityValue As(ElectricLinearResistivityUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public ElectricLinearResistivity ToUnit(ElectricLinearResistivityUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new ElectricLinearResistivity(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private QuantityValue GetValueInBaseUnit()
        {
            return Unit switch
            {
                ElectricLinearResistivityUnit.KiloohmPerCentimeter => (_value / 100) * 1e3d,
                ElectricLinearResistivityUnit.KiloohmPerFoot => (_value / 3.2808398950131234) * 1e3d,
                ElectricLinearResistivityUnit.KiloohmPerKilometer => (_value * 1000) * 1e3d,
                ElectricLinearResistivityUnit.KiloohmPerMeter => (_value) * 1e3d,
                ElectricLinearResistivityUnit.KiloohmPerMile => (_value * 1609) * 1e3d,
                ElectricLinearResistivityUnit.MegaohmPerCentimeter => (_value / 100) * 1e6d,
                ElectricLinearResistivityUnit.MegaohmPerFoot => (_value / 3.2808398950131234) * 1e6d,
                ElectricLinearResistivityUnit.MegaohmPerKilometer => (_value * 1000) * 1e6d,
                ElectricLinearResistivityUnit.MegaohmPerMeter => (_value) * 1e6d,
                ElectricLinearResistivityUnit.MegaohmPerMile => (_value * 1609) * 1e6d,
                ElectricLinearResistivityUnit.MicroohmPerCentimeter => (_value / 100) * 1e-6d,
                ElectricLinearResistivityUnit.MicroohmPerFoot => (_value / 3.2808398950131234) * 1e-6d,
                ElectricLinearResistivityUnit.MicroohmPerKilometer => (_value * 1000) * 1e-6d,
                ElectricLinearResistivityUnit.MicroohmPerMeter => (_value) * 1e-6d,
                ElectricLinearResistivityUnit.MicroohmPerMile => (_value * 1609) * 1e-6d,
                ElectricLinearResistivityUnit.MilliohmPerCentimeter => (_value / 100) * 1e-3d,
                ElectricLinearResistivityUnit.MilliohmPerFoot => (_value / 3.2808398950131234) * 1e-3d,
                ElectricLinearResistivityUnit.MilliohmPerKilometer => (_value * 1000) * 1e-3d,
                ElectricLinearResistivityUnit.MilliohmPerMeter => (_value) * 1e-3d,
                ElectricLinearResistivityUnit.MilliohmPerMile => (_value * 1609) * 1e-3d,
                ElectricLinearResistivityUnit.NanoohmPerCentimeter => (_value / 100) * 1e-9d,
                ElectricLinearResistivityUnit.NanoohmPerFoot => (_value / 3.2808398950131234) * 1e-9d,
                ElectricLinearResistivityUnit.NanoohmPerKilometer => (_value * 1000) * 1e-9d,
                ElectricLinearResistivityUnit.NanoohmPerMeter => (_value) * 1e-9d,
                ElectricLinearResistivityUnit.NanoohmPerMile => (_value * 1609) * 1e-9d,
                ElectricLinearResistivityUnit.OhmPerCentimeter => _value / 100,
                ElectricLinearResistivityUnit.OhmPerFoot => _value / 3.2808398950131234,
                ElectricLinearResistivityUnit.OhmPerKilometer => _value * 1000,
                ElectricLinearResistivityUnit.OhmPerMeter => _value,
                ElectricLinearResistivityUnit.OhmPerMile => _value * 1609,
                ElectricLinearResistivityUnit.PicoohmPerCentimeter => (_value / 100) * 1e-12d,
                ElectricLinearResistivityUnit.PicoohmPerFoot => (_value / 3.2808398950131234) * 1e-12d,
                ElectricLinearResistivityUnit.PicoohmPerKilometer => (_value * 1000) * 1e-12d,
                ElectricLinearResistivityUnit.PicoohmPerMeter => (_value) * 1e-12d,
                ElectricLinearResistivityUnit.PicoohmPerMile => (_value * 1609) * 1e-12d,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private QuantityValue GetValueAs(ElectricLinearResistivityUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                ElectricLinearResistivityUnit.KiloohmPerCentimeter => (baseUnitValue * 100) / 1e3d,
                ElectricLinearResistivityUnit.KiloohmPerFoot => (baseUnitValue * 3.2808398950131234) / 1e3d,
                ElectricLinearResistivityUnit.KiloohmPerKilometer => (baseUnitValue / 1000) / 1e3d,
                ElectricLinearResistivityUnit.KiloohmPerMeter => (baseUnitValue) / 1e3d,
                ElectricLinearResistivityUnit.KiloohmPerMile => (baseUnitValue / 1609) / 1e3d,
                ElectricLinearResistivityUnit.MegaohmPerCentimeter => (baseUnitValue * 100) / 1e6d,
                ElectricLinearResistivityUnit.MegaohmPerFoot => (baseUnitValue * 3.2808398950131234) / 1e6d,
                ElectricLinearResistivityUnit.MegaohmPerKilometer => (baseUnitValue / 1000) / 1e6d,
                ElectricLinearResistivityUnit.MegaohmPerMeter => (baseUnitValue) / 1e6d,
                ElectricLinearResistivityUnit.MegaohmPerMile => (baseUnitValue / 1609) / 1e6d,
                ElectricLinearResistivityUnit.MicroohmPerCentimeter => (baseUnitValue * 100) / 1e-6d,
                ElectricLinearResistivityUnit.MicroohmPerFoot => (baseUnitValue * 3.2808398950131234) / 1e-6d,
                ElectricLinearResistivityUnit.MicroohmPerKilometer => (baseUnitValue / 1000) / 1e-6d,
                ElectricLinearResistivityUnit.MicroohmPerMeter => (baseUnitValue) / 1e-6d,
                ElectricLinearResistivityUnit.MicroohmPerMile => (baseUnitValue / 1609) / 1e-6d,
                ElectricLinearResistivityUnit.MilliohmPerCentimeter => (baseUnitValue * 100) / 1e-3d,
                ElectricLinearResistivityUnit.MilliohmPerFoot => (baseUnitValue * 3.2808398950131234) / 1e-3d,
                ElectricLinearResistivityUnit.MilliohmPerKilometer => (baseUnitValue / 1000) / 1e-3d,
                ElectricLinearResistivityUnit.MilliohmPerMeter => (baseUnitValue) / 1e-3d,
                ElectricLinearResistivityUnit.MilliohmPerMile => (baseUnitValue / 1609) / 1e-3d,
                ElectricLinearResistivityUnit.NanoohmPerCentimeter => (baseUnitValue * 100) / 1e-9d,
                ElectricLinearResistivityUnit.NanoohmPerFoot => (baseUnitValue * 3.2808398950131234) / 1e-9d,
                ElectricLinearResistivityUnit.NanoohmPerKilometer => (baseUnitValue / 1000) / 1e-9d,
                ElectricLinearResistivityUnit.NanoohmPerMeter => (baseUnitValue) / 1e-9d,
                ElectricLinearResistivityUnit.NanoohmPerMile => (baseUnitValue / 1609) / 1e-9d,
                ElectricLinearResistivityUnit.OhmPerCentimeter => baseUnitValue * 100,
                ElectricLinearResistivityUnit.OhmPerFoot => baseUnitValue * 3.2808398950131234,
                ElectricLinearResistivityUnit.OhmPerKilometer => baseUnitValue / 1000,
                ElectricLinearResistivityUnit.OhmPerMeter => baseUnitValue,
                ElectricLinearResistivityUnit.OhmPerMile => baseUnitValue / 1609,
                ElectricLinearResistivityUnit.PicoohmPerCentimeter => (baseUnitValue * 100) / 1e-12d,
                ElectricLinearResistivityUnit.PicoohmPerFoot => (baseUnitValue * 3.2808398950131234) / 1e-12d,
                ElectricLinearResistivityUnit.PicoohmPerKilometer => (baseUnitValue / 1000) / 1e-12d,
                ElectricLinearResistivityUnit.PicoohmPerMeter => (baseUnitValue) / 1e-12d,
                ElectricLinearResistivityUnit.PicoohmPerMile => (baseUnitValue / 1609) / 1e-12d,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion

    }
}

