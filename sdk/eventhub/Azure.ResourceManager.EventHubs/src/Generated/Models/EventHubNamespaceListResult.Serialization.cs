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
    internal partial class EventHubNamespaceListResult
    {
        internal static EventHubNamespaceListResult DeserializeEventHubNamespaceListResult(JsonElement element)
        {
            Optional<IReadOnlyList<EventHubNamespaceData>> value = default;
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
                    List<EventHubNamespaceData> array = new List<EventHubNamespaceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventHubNamespaceData.DeserializeEventHubNamespaceData(item));
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
            return new EventHubNamespaceListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
