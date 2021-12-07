// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventHubs;

namespace Azure.ResourceManager.EventHubs.Models
{
    internal partial class PrivateEndpointConnectionListResult
    {
        internal static PrivateEndpointConnectionListResult DeserializePrivateEndpointConnectionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PrivateEndpointConnectionData>> value = default;
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
                    List<PrivateEndpointConnectionData> array = new List<PrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateEndpointConnectionData.DeserializePrivateEndpointConnectionData(item));
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
            return new PrivateEndpointConnectionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
