﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UnitsNet.Serialization.JsonNet
{
    /// <inheritdoc />
    /// <summary>
    /// JSON.net converter for IQuantity types (e.g. all units in UnitsNet)
    /// Use this converter to serialize and deserialize UnitsNet types to and from JSON
    /// </summary>
    public sealed class UnitsNetIQuantityJsonConverter : UnitsNetBaseJsonConverter<IQuantity>
    {
        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter" /> to write to.</param>
        /// <param name="value">The value to write.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson([NotNull] JsonWriter writer, IQuantity value, [NotNull] JsonSerializer serializer)
        {
            writer = writer ?? throw new ArgumentNullException(nameof(writer));
            serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));

            if (value == null)
            {
                writer.WriteNull();
                return;
            }

            var valueUnit = ConvertIQuantity(value);

            serializer.Serialize(writer, valueUnit);
        }

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="T:Newtonsoft.Json.JsonReader" /> to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="hasExistingValue">Indicates if an existing value has been provided</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>
        /// The object value.
        /// </returns>
        /// <exception cref="UnitsNetException">Unable to parse value and unit from JSON.</exception>
        public override IQuantity ReadJson([NotNull] JsonReader reader, Type objectType, IQuantity existingValue, bool hasExistingValue,
            [NotNull] JsonSerializer serializer)
        {
            reader = reader ?? throw new ArgumentNullException(nameof(reader));
            serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));

            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            var token = JToken.Load(reader);

            var valueUnit = ReadValueUnit(token);

            return ConvertValueUnit(valueUnit);
        }
    }
}
