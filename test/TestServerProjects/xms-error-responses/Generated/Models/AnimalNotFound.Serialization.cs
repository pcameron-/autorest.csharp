// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace xms_error_responses.Models
{
    internal partial class AnimalNotFound
    {
        internal static AnimalNotFound DeserializeAnimalNotFound(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> reason = default;
            string whatNotFound = default;
            Optional<string> someBaseProp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reason"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    reason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("whatNotFound"))
                {
                    whatNotFound = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("someBaseProp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    someBaseProp = property.Value.GetString();
                    continue;
                }
            }
            return new AnimalNotFound(someBaseProp.Value, reason.Value, whatNotFound, name.Value);
        }
    }
}
