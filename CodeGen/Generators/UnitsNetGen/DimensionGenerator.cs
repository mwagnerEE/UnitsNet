using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeGen.Helpers;
using CodeGen.JsonTypes;

namespace CodeGen.Generators.UnitsNetGen
{
    internal class DimensionGenerator : GeneratorBase
    {
        private readonly HashSet<string> _dimensionNames;
        private readonly List<string> _dimensionlessNames = new List<string>()
        {
            "Angle"
        };

        public DimensionGenerator(HashSet<string> dimensionNames)
        {
            _dimensionNames = dimensionNames;
        }

        public override string Generate()
        {
            Writer.WL($@"
// ReSharper disable once CheckNamespace
namespace UnitsNet
{{
    // Disable missing XML comment warnings for the generated unit enums.
    #pragma warning disable 1591

    public partial struct Dimension
    {{");

            foreach (string dimensionName in _dimensionNames)
            {
                string dimensionless = _dimensionlessNames.Contains(dimensionName) ? ", true" : "";
                Writer.WL($@"
        public static Dimension {dimensionName} {{ get; }} = new Dimension(nameof({dimensionName}){dimensionless});");
            }
            Writer.WL($@"
    }}

    #pragma warning restore 1591
}}");
            return Writer.ToString();
        }
    }
}

