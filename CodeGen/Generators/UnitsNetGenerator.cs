﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System.Collections.Generic;
using System.IO;
using System.Linq;
using CodeGen.Generators.UnitsNetGen;
using CodeGen.JsonTypes;
using Serilog;

namespace CodeGen.Generators
{
    /// <summary>
    ///     Code generator for UnitsNet and UnitsNet.Tests projects.
    /// </summary>
    internal static class UnitsNetGenerator
    {
        /// <summary>
        ///     Generate source code for UnitsNet project for the given parsed quantities.
        ///     Outputs files relative to the given root dir to these locations:
        ///     <list type="bullet">
        ///         <item>
        ///             <description>UnitsNet/GeneratedCode (quantity and unit types, Quantity, UnitAbbreviationCache)</description>
        ///         </item>
        ///         <item>
        ///             <description>UnitsNet.Tests/GeneratedCode (tests)</description>
        ///         </item>
        ///         <item>
        ///             <description>UnitsNet.Tests/CustomCode (test stubs, one for each quantity if not already created)</description>
        ///         </item>
        ///     </list>
        /// </summary>
        /// <param name="rootDir">Path to repository root directory.</param>
        /// <param name="quantities">The parsed quantities.</param>
        public static void Generate(string rootDir, Quantity[] quantities)
        {
            var outputDir = $"{rootDir}/UnitsNet/GeneratedCode";
            var extensionsOutputDir = $"{rootDir}/UnitsNet.NumberExtensions/GeneratedCode";
            var extensionsTestOutputDir = $"{rootDir}/UnitsNet.NumberExtensions.Tests/GeneratedCode";
            var testProjectDir = $"{rootDir}/UnitsNet.Tests";

            // Ensure output directories exist
            Directory.CreateDirectory($"{outputDir}/Quantities");
            Directory.CreateDirectory($"{outputDir}/Units");
            Directory.CreateDirectory($"{extensionsOutputDir}");
            Directory.CreateDirectory($"{extensionsTestOutputDir}");
            Directory.CreateDirectory($"{testProjectDir}/GeneratedCode");
            Directory.CreateDirectory($"{testProjectDir}/GeneratedCode/TestsBase");
            Directory.CreateDirectory($"{testProjectDir}/GeneratedCode/QuantityTests");

            foreach (var quantity in quantities)
            {
                GenerateQuantity(quantity, $"{outputDir}/Quantities/{quantity.Name}.g.cs");
                GenerateUnitType(quantity, $"{outputDir}/Units/{quantity.Name}Unit.g.cs");
                GenerateNumberToExtensions(quantity, $"{extensionsOutputDir}/NumberTo{quantity.Name}Extensions.g.cs");
                GenerateNumberToExtensionsTestClass(quantity, $"{extensionsTestOutputDir}/NumberTo{quantity.Name}ExtensionsTest.g.cs");

                // Example: CustomCode/Quantities/LengthTests inherits GeneratedCode/TestsBase/LengthTestsBase
                // This way when new units are added to the quantity JSON definition, we auto-generate the new
                // conversion function tests that needs to be manually implemented by the developer to fix the compile error
                // so it cannot be forgotten.
                GenerateQuantityTestBaseClass(quantity, $"{testProjectDir}/GeneratedCode/TestsBase/{quantity.Name}TestsBase.g.cs");
                GenerateQuantityTestClassIfNotExists(quantity, $"{testProjectDir}/CustomCode/{quantity.Name}Tests.cs");

                Log.Information("✅ {Quantity}", quantity.Name);
            }

            Log.Information("");
            GenerateDimensions(_dimensionNames, $"{outputDir}/Units/Dimension.g.cs");
            GenerateIQuantityTests(quantities, $"{testProjectDir}/GeneratedCode/IQuantityTests.g.cs");
            GenerateQuantityType(quantities, $"{outputDir}/QuantityType.g.cs");
            GenerateStaticQuantity(quantities, $"{outputDir}/Quantity.g.cs");

            var unitCount = quantities.SelectMany(q => q.Units).Count();
            Log.Information("");
            Log.Information("Total of {UnitCount} units and {QuantityCount} quantities", unitCount, quantities.Length);
            Log.Information("");
        }

        private static void GenerateQuantityTestClassIfNotExists(Quantity quantity, string filePath)
        {
            if (File.Exists(filePath)) return;

            var content = new UnitTestStubGenerator(quantity).Generate();
            File.WriteAllText(filePath, content);
            Log.Information("✅ {Quantity} initial test stub", quantity.Name);
        }
        private static HashSet<string> _dimensionNames = new HashSet<string>()
        {
            "Length",
            "Mass",
            "Time",
            "Current",
            "Temperature",
            "Amount",
            "LuminousIntensity",
        };
        private static void GenerateQuantity(Quantity quantity, string filePath)
        {
            var content = new QuantityGenerator(quantity, _dimensionNames).Generate();
            File.WriteAllText(filePath, content);
        }
        private static void GenerateDimensions(HashSet<string> dimensionNames, string filePath)
        {
            var content = new DimensionGenerator(dimensionNames).Generate();
            File.WriteAllText(filePath, content);
        }

        private static void GenerateNumberToExtensions(Quantity quantity, string filePath)
        {
            var content = new NumberExtensionsGenerator(quantity).Generate();
            File.WriteAllText(filePath, content);
        }

        private static void GenerateNumberToExtensionsTestClass(Quantity quantity, string filePath)
        {
            var content = new NumberExtensionsTestClassGenerator(quantity).Generate();
            File.WriteAllText(filePath, content);
        }

        private static void GenerateUnitType(Quantity quantity, string filePath)
        {
            var content = new UnitTypeGenerator(quantity).Generate();
            File.WriteAllText(filePath, content);
        }

        private static void GenerateQuantityTestBaseClass(Quantity quantity, string filePath)
        {
            var content = new UnitTestBaseClassGenerator(quantity).Generate();
            File.WriteAllText(filePath, content);
        }

        private static void GenerateIQuantityTests(Quantity[] quantities, string filePath)
        {
            var content = new IQuantityTestClassGenerator(quantities).Generate();
            File.WriteAllText(filePath, content);
            Log.Information("✅ IQuantityTests.g.cs");
        }

        private static void GenerateQuantityType(Quantity[] quantities, string filePath)
        {
            var content = new QuantityTypeGenerator(quantities).Generate();
            File.WriteAllText(filePath, content);
            Log.Information("✅ QuantityType.g.cs");
        }

        private static void GenerateStaticQuantity(Quantity[] quantities, string filePath)
        {
            var content = new StaticQuantityGenerator(quantities).Generate();
            File.WriteAllText(filePath, content);
            Log.Information("✅ Quantity.g.cs");
        }
    }
}
