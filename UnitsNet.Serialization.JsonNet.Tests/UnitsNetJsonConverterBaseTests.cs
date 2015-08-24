﻿// Copyright Initial Force AS.  All rights reserved.
// https://github.com/anjdreas/UnitsNet
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using Newtonsoft.Json;
using NUnit.Framework;

namespace UnitsNet.Serialization.JsonNet.Tests
{
    public class UnitsNetJsonConverterBaseTests
    {
        private JsonSerializerSettings _jsonSerializerSettings;
        private UnitsNetJsonConverterBase<Mass> _massJsonConverter;
        private UnitsNetJsonConverterBase<Ratio> _ratioJsonConverter;

        [SetUp]
        public void Setup()
        {
            _massJsonConverter = new MassJsonConverter();
            _ratioJsonConverter = new RatioJsonConverter();

            _jsonSerializerSettings = new JsonSerializerSettings() { Formatting = Formatting.Indented };
            _jsonSerializerSettings.Converters.Add(_massJsonConverter);
            _jsonSerializerSettings.Converters.Add(_ratioJsonConverter);
        }

        [TestFixture]
        public class Serialize : UnitsNetJsonConverterBaseTests
        {
            [Test]
            public void Mass_ExpectKilogramsUsedAsBaseValueAndUnit()
            {
                Mass mass = Mass.FromPounds(200);
                string expectedJson = "{\r\n  \"Value\": 90.718474,\r\n  \"Unit\": \"MassUnit.Kilogram\"\r\n}";

                string json = SerializeObject(mass);

                Assert.That(json, Is.EqualTo(expectedJson));
            }

            [Test]
            public void Ratio_ExpectDecimalFractionsUsedAsBaseValueAndUnit()
            {
                Ratio ratio = Ratio.FromPartsPerThousand(250);
                string expectedJson = "{\r\n  \"Value\": 0.25,\r\n  \"Unit\": \"RatioUnit.DecimalFraction\"\r\n}";

                string json = SerializeObject(ratio);

                Assert.That(json, Is.EqualTo(expectedJson));
            }
        }

        [TestFixture]
        public class Deserialize : UnitsNetJsonConverterBaseTests
        {
            [Test]
            public void Mass_ExpectJsonCorrectlyDeserialized()
            {
                Mass originalMass = Mass.FromKilograms(33.33);
                string json = SerializeObject(originalMass);

                Mass deserializedMass = DeserializeObject<Mass>(json);

                Assert.That(deserializedMass, Is.EqualTo(originalMass));
            }

            [Test]
            public void UnitEnumChangedAfterSerialization_ExpectUnitCorrectlyDeserialized()
            {
                Mass originalMass = Mass.FromKilograms(33.33);
                string json = SerializeObject(originalMass);
                // Someone manually changed the serialized JSON string to 1000 grams.
                json = json.Replace("33.33", "1000");
                json = json.Replace("MassUnit.Kilogram", "MassUnit.Gram");

                var deserializedMass = DeserializeObject<Mass>(json);
                
                // The original value serialized was 33.33 kg, but someone edited the JSON to be 1000 g. We expect the JSON is
                //  still deserializable, and the correct value of 1000 g is obtained.
                Assert.That(deserializedMass.Grams, Is.EqualTo(1000));
            }
        }

        protected string SerializeObject(object obj)
        {
            return JsonConvert.SerializeObject(obj, _jsonSerializerSettings);
        }

        protected T DeserializeObject<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json, _jsonSerializerSettings);
        }
    }
}