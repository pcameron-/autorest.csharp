// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace multiple_inheritance.Models
{
    public partial class Feline : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Meows))
            {
                writer.WritePropertyName("meows");
                writer.WriteBooleanValue(Meows.Value);
            }
            if (Optional.IsDefined(Hisses))
            {
                writer.WritePropertyName("hisses");
                writer.WriteBooleanValue(Hisses.Value);
            }
            writer.WriteEndObject();
        }

        internal static Feline DeserializeFeline(JsonElement element)
        {
            Optional<bool> meows = default;
            Optional<bool> hisses = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("meows"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    meows = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("hisses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    hisses = property.Value.GetBoolean();
                    continue;
                }
            }
            return new Feline(Optional.ToNullable(meows), Optional.ToNullable(hisses));
        }
    }
}
