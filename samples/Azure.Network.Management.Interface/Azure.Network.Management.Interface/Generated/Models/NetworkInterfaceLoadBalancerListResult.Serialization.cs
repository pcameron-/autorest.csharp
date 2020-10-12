// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class NetworkInterfaceLoadBalancerListResult
    {
        internal static NetworkInterfaceLoadBalancerListResult DeserializeNetworkInterfaceLoadBalancerListResult(JsonElement element)
        {
            Optional<IReadOnlyList<LoadBalancer>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<LoadBalancer> array = new List<LoadBalancer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoadBalancer.DeserializeLoadBalancer(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new NetworkInterfaceLoadBalancerListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
