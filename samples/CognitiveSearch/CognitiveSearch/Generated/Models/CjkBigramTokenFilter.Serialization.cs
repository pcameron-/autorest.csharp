// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class CjkBigramTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(IgnoreScripts))
            {
                writer.WritePropertyName("ignoreScripts");
                writer.WriteStartArray();
                foreach (var item in IgnoreScripts)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OutputUnigrams))
            {
                writer.WritePropertyName("outputUnigrams");
                writer.WriteBooleanValue(OutputUnigrams.Value);
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static CjkBigramTokenFilter DeserializeCjkBigramTokenFilter(JsonElement element)
        {
            Optional<IList<CjkBigramTokenFilterScripts>> ignoreScripts = default;
            Optional<bool> outputUnigrams = default;
            string odataType = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ignoreScripts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CjkBigramTokenFilterScripts> array = new List<CjkBigramTokenFilterScripts>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToCjkBigramTokenFilterScripts());
                    }
                    ignoreScripts = array;
                    continue;
                }
                if (property.NameEquals("outputUnigrams"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    outputUnigrams = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new CjkBigramTokenFilter(odataType, name, Optional.ToList(ignoreScripts), Optional.ToNullable(outputUnigrams));
        }
    }
}
