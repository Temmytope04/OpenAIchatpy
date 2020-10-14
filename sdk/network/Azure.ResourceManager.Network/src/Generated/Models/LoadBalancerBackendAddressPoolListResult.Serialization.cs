// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class LoadBalancerBackendAddressPoolListResult
    {
        internal static LoadBalancerBackendAddressPoolListResult DeserializeLoadBalancerBackendAddressPoolListResult(JsonElement element)
        {
            Optional<IReadOnlyList<BackendAddressPool>> value = default;
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
                    List<BackendAddressPool> array = new List<BackendAddressPool>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BackendAddressPool.DeserializeBackendAddressPool(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new LoadBalancerBackendAddressPoolListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
