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
    internal partial class ArmDisasterRecoveryListResult
    {
        internal static ArmDisasterRecoveryListResult DeserializeArmDisasterRecoveryListResult(JsonElement element)
        {
            Optional<IReadOnlyList<EventHubsDisasterRecoveryData>> value = default;
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
                    List<EventHubsDisasterRecoveryData> array = new List<EventHubsDisasterRecoveryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventHubsDisasterRecoveryData.DeserializeEventHubsDisasterRecoveryData(item));
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
            return new ArmDisasterRecoveryListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
