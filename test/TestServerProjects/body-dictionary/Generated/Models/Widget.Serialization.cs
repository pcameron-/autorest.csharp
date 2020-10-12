// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace body_dictionary.Models
{
    public partial class Widget : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Integer))
            {
                writer.WritePropertyName("integer");
                writer.WriteNumberValue(Integer.Value);
            }
            if (Optional.IsDefined(String))
            {
                writer.WritePropertyName("string");
                writer.WriteStringValue(String);
            }
            writer.WriteEndObject();
        }

        internal static Widget DeserializeWidget(JsonElement element)
        {
            Optional<int> integer = default;
            Optional<string> @string = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("integer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    integer = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("string"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    @string = property.Value.GetString();
                    continue;
                }
            }
            return new Widget(Optional.ToNullable(integer), @string.Value);
        }
    }
}
