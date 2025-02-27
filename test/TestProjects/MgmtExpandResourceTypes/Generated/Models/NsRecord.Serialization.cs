// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtExpandResourceTypes.Models
{
    public partial class NsRecord : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Nsdname))
            {
                writer.WritePropertyName("nsdname");
                writer.WriteStringValue(Nsdname);
            }
            writer.WriteEndObject();
        }

        internal static NsRecord DeserializeNsRecord(JsonElement element)
        {
            Optional<string> nsdname = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nsdname"))
                {
                    nsdname = property.Value.GetString();
                    continue;
                }
            }
            return new NsRecord(nsdname.Value);
        }
    }
}
