// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace MgmtKeyvault.Models
{
    public partial class DeletedVaultProperties
    {
        internal static DeletedVaultProperties DeserializeDeletedVaultProperties(JsonElement element)
        {
            Optional<string> vaultId = default;
            Optional<string> location = default;
            Optional<DateTimeOffset> deletionDate = default;
            Optional<DateTimeOffset> scheduledPurgeDate = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            Optional<bool> purgeProtectionEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vaultId"))
                {
                    vaultId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deletionDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deletionDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("scheduledPurgeDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scheduledPurgeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("purgeProtectionEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    purgeProtectionEnabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new DeletedVaultProperties(vaultId.Value, location.Value, Optional.ToNullable(deletionDate), Optional.ToNullable(scheduledPurgeDate), Optional.ToDictionary(tags), Optional.ToNullable(purgeProtectionEnabled));
        }
    }
}
