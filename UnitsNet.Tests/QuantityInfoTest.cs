﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using UnitsNet.Tests.CustomQuantities;
using UnitsNet.Units;
using Xunit;

namespace UnitsNet.Tests
{
    public class QuantityInfoTest
    {
        [Fact]
        public void Constructor_AssignsProperties()
        {
            var expectedZero = Length.FromCentimeters(10);
            var expectedUnitInfos = new UnitInfo[]{
                new UnitInfo(LengthUnit.Centimeter, "Centimeters", new BaseUnits(LengthUnit.Centimeter)),
                new UnitInfo(LengthUnit.Kilometer, "Kilometers", new BaseUnits(LengthUnit.Kilometer))
            };
            var expectedBaseUnit = LengthUnit.Centimeter;
            var expectedBaseDimensions = Length.BaseDimensions;

            var info = new QuantityInfo(nameof(Length), typeof(LengthUnit), expectedUnitInfos,
                expectedBaseUnit, expectedZero, expectedBaseDimensions);

            Assert.Equal(expectedZero, info.Zero);
            Assert.Equal("Length", info.Name);
            Assert.Equal(expectedUnitInfos, info.UnitInfos);
            Assert.Equal(expectedBaseDimensions, info.Dimensions);

        }

        [Fact]
        public void Constructor_AssignsPropertiesForCustomQuantity()
        {
            var expectedZero = new HowMuch(10, HowMuchUnit.Some);
            var expectedUnitInfos = new UnitInfo[]
            {
                new UnitInfo(HowMuchUnit.Some, "Some", BaseUnits.Undefined),
                new UnitInfo(HowMuchUnit.ATon, "Tons", BaseUnits.Undefined),
                new UnitInfo(HowMuchUnit.AShitTon, "ShitTons", BaseUnits.Undefined)
            };
            var expectedBaseUnit = HowMuchUnit.Some;
            var expectedBaseDimensions = Dimensions.Dimensionless;

            var info = new QuantityInfo(nameof(HowMuch), typeof(HowMuchUnit), expectedUnitInfos,
                expectedBaseUnit, expectedZero, expectedBaseDimensions);

            Assert.Equal(expectedZero, info.Zero);
            Assert.Equal(nameof(HowMuch), info.Name);
            Assert.Equal(expectedUnitInfos, info.UnitInfos);
            Assert.Equal(expectedBaseDimensions, info.Dimensions);

        }

        [Fact]
        public void ObsoleteConstructor_AssignsProperties()
        {
            var expectedZero = Length.FromCentimeters(10);
            var expectedUnitInfos = new UnitInfo[]{
                new UnitInfo(LengthUnit.Centimeter, "Centimeters", new BaseUnits(LengthUnit.Centimeter)),
                new UnitInfo(LengthUnit.Kilometer, "Kilometers", new BaseUnits(LengthUnit.Kilometer))
            };
            var expectedBaseUnit = LengthUnit.Centimeter;
            var expectedBaseDimensions = Length.BaseDimensions;

            var info = new QuantityInfo(nameof(Length), typeof(Length), expectedUnitInfos, expectedBaseUnit, expectedZero, expectedBaseDimensions);

            Assert.Equal(expectedZero, info.Zero);
            Assert.Equal("Length", info.Name);
            Assert.Equal(expectedUnitInfos, info.UnitInfos);
            Assert.Equal(expectedBaseDimensions, info.Dimensions);

        }


        [Fact]
        public void GenericsConstructor_AssignsProperties()
        {
            var expectedZero = Length.FromCentimeters(10);
            var expectedUnitInfos = new UnitInfo<LengthUnit>[]{
                new UnitInfo<LengthUnit>(LengthUnit.Centimeter, "Centimeters", new BaseUnits(LengthUnit.Centimeter)),
                new UnitInfo<LengthUnit>(LengthUnit.Kilometer,"Kilometers",  new BaseUnits(LengthUnit.Kilometer))
            };
            var expectedBaseUnit = LengthUnit.Centimeter;
            var expectedBaseDimensions = Length.BaseDimensions;

            var info = new QuantityInfo<LengthUnit>(nameof(Length), expectedUnitInfos,
                expectedBaseUnit, expectedZero, expectedBaseDimensions);
            Assert.Equal(expectedZero, info.Zero);
            Assert.Equal("Length", info.Name);
            Assert.Equal(expectedUnitInfos, info.UnitInfos);
            Assert.Equal(expectedBaseDimensions, info.Dimensions);

        }

        [Fact]
        [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
        public void Constructor_GivenNullAsUnitInfos_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new QuantityInfo(nameof(Length), typeof(LengthUnit),
                null, Length.BaseUnit, Length.Zero, Length.BaseDimensions));
        }

        [Fact]
        [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
        public void GenericsConstructor_GivenNullAsUnitInfos_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new QuantityInfo<LengthUnit>(nameof(Length),
                null, Length.BaseUnit, Length.Zero, Length.BaseDimensions));
        }

        [Fact]
        [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
        public void Constructor_GivenNullAsBaseUnit_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new QuantityInfo(nameof(Length), typeof(LengthUnit),
                Length.Info.UnitInfos, null, Length.Zero, Length.BaseDimensions));
        }

        [Fact]
        [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
        public void Constructor_GivenNullAsZero_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new QuantityInfo(nameof(Length), typeof(LengthUnit),
                Length.Info.UnitInfos, Length.BaseUnit, null, Length.BaseDimensions));
        }

        [Fact]
        [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
        public void GenericsConstructor_GivenNullAsZero_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new QuantityInfo<LengthUnit>(nameof(Length),
                Length.Info.UnitInfos, Length.BaseUnit, null, Length.BaseDimensions));
        }

        //[Fact]
        //[SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
        //public void Constructor_GivenNullAsBaseDimensions_ThrowsArgumentNullException()
        //{
        //    Assert.Throws<ArgumentNullException>(() => new QuantityInfo(nameof(Length), typeof(LengthUnit),
        //        Length.Info.UnitInfos, Length.BaseUnit, Length.Zero, null));
        //}

        //[Fact]
        //[SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
        //public void GenericsConstructor_GivenNullAsBaseDimensions_ThrowsArgumentNullException()
        //{
        //    Assert.Throws<ArgumentNullException>(() => new QuantityInfo<LengthUnit>(nameof(Length),
        //        Length.Info.UnitInfos, Length.BaseUnit, Length.Zero, null));
        //}
        [Fact]
        [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
        public void Constructor2_GivenNullAsUnitInfos_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new QuantityInfo(Length.Info.Name, typeof(LengthUnit),
                null, Length.BaseUnit, Length.Zero, Length.BaseDimensions));
        }

        [Fact]
        [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
        public void GenericsConstructor2_GivenNullAsUnitInfos_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new QuantityInfo<LengthUnit>(Length.Info.Name,
                null, Length.BaseUnit, Length.Zero, Length.BaseDimensions));
        }

        [Fact]
        [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
        public void Constructor2_GivenNullAsBaseUnit_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new QuantityInfo(Length.Info.Name, typeof(LengthUnit),
                Length.Info.UnitInfos, null, Length.Zero, Length.BaseDimensions));
        }

        [Fact]
        [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
        public void Constructor2_GivenNullAsZero_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new QuantityInfo(Length.Info.Name, typeof(LengthUnit),
                Length.Info.UnitInfos, Length.BaseUnit, null, Length.BaseDimensions));
        }

        [Fact]
        [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
        public void GenericsConstructor2_GivenNullAsZero_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new QuantityInfo<LengthUnit>(Length.Info.Name,
                Length.Info.UnitInfos, Length.BaseUnit, null, Length.BaseDimensions));
        }

        //[Fact]
        //[SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
        //public void Constructor2_GivenNullAsBaseDimensions_ThrowsArgumentNullException()
        //{
        //    Assert.Throws<ArgumentNullException>(() => new QuantityInfo(Length.Info.Name, typeof(LengthUnit),
        //        Length.Info.UnitInfos, Length.BaseUnit, Length.Zero, null));
        //}

        //[Fact]
        //[SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
        //public void GenericsConstructor2_GivenNullAsBaseDimensions_ThrowsArgumentNullException()
        //{
        //    Assert.Throws<ArgumentNullException>(() => new QuantityInfo<LengthUnit>(Length.Info.Name,
        //        Length.Info.UnitInfos, Length.BaseUnit, Length.Zero, null));
        //}

        [Fact]
        public void GetUnitInfoFor_GivenNullAsBaseUnits_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Length.Info.GetUnitInfoFor(null));
        }

        [Fact]
        public void GetUnitInfoFor_GivenBaseUnitsWithNoMatch_ThrowsInvalidOperationException()
        {
            var baseUnitsWithNoMatch = new BaseUnits(mass: MassUnit.Kilogram);
            Assert.Throws<InvalidOperationException>(() => Length.Info.GetUnitInfoFor(baseUnitsWithNoMatch));
        }

        [Fact]
        public void GetUnitInfoFor_GivenBaseUnitsWithMultipleMatches_ThrowsInvalidOperationException()
        {
            var baseUnits = new BaseUnits(LengthUnit.Meter);

            var quantityInfo = new QuantityInfo<LengthUnit>(Length.Info.Name,
                new UnitInfo<LengthUnit>[]{
                    new UnitInfo<LengthUnit>(LengthUnit.Meter, "Meters", baseUnits),
                    new UnitInfo<LengthUnit>(LengthUnit.Foot, "Feet", baseUnits) },
                LengthUnit.Meter, Length.Zero, Length.BaseDimensions);

            Assert.Throws<InvalidOperationException>(() => quantityInfo.GetUnitInfoFor(baseUnits));
        }

        [Fact]
        public void GetUnitInfosFor_GivenNullAsBaseUnits_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Length.Info.GetUnitInfosFor(null));
        }

        [Fact]
        public void GetUnitInfosFor_GivenBaseUnitsWithNoMatch_ReturnsEmpty()
        {
            var baseUnitsWithNoMatch = new BaseUnits(mass: MassUnit.Kilogram);
            var result = Length.Info.GetUnitInfosFor(baseUnitsWithNoMatch);
            Assert.Empty(result);
        }

        [Fact]
        public void GetUnitInfosFor_GivenBaseUnitsWithOneMatch_ReturnsOneMatch()
        {
            var baseUnitsWithOneMatch = new BaseUnits(LengthUnit.Foot);
            var result = Length.Info.GetUnitInfosFor(baseUnitsWithOneMatch);
            Assert.Collection(result, element1 => Assert.Equal(LengthUnit.Foot, element1.Value));
        }

        [Fact]
        public void GetUnitInfosFor_GivenBaseUnitsWithMultipleMatches_ReturnsMultipleMatches()
        {
            var baseUnits = new BaseUnits(LengthUnit.Meter);

            var quantityInfo = new QuantityInfo<LengthUnit>(Length.Info.Name,
                new UnitInfo<LengthUnit>[]{
                    new UnitInfo<LengthUnit>(LengthUnit.Meter, "Meters", baseUnits),
                    new UnitInfo<LengthUnit>(LengthUnit.Foot, "Feet", baseUnits) },
                LengthUnit.Meter, Length.Zero, Length.BaseDimensions);

            var result = quantityInfo.GetUnitInfosFor(baseUnits);

            Assert.Collection(result,
                element1 =>
                {
                    Assert.Equal(LengthUnit.Meter, element1.Value);
                    Assert.Equal(baseUnits, element1.BaseUnits);
                },
                element2 =>
                {
                    Assert.Equal(LengthUnit.Foot, element2.Value);
                    Assert.Equal(baseUnits, element2.BaseUnits);
                } );
        }
    }
}
