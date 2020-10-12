// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace TypeSchemaMapping.Models
{
    public partial class ModelWithUriProperty : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("Uri");
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            writer.WriteEndObject();
        }

        internal static ModelWithUriProperty DeserializeModelWithUriProperty(JsonElement element)
        {
            Optional<Uri> uri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Uri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new ModelWithUriProperty(uri.Value);
        }
    }
}
