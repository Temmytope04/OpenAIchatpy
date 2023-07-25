// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Peering;

namespace Azure.ResourceManager.Peering.Models
{
    internal partial class PeeringRegisteredPrefixListResult
    {
        internal static PeeringRegisteredPrefixListResult DeserializePeeringRegisteredPrefixListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<PeeringRegisteredPrefixData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PeeringRegisteredPrefixData> array = new List<PeeringRegisteredPrefixData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PeeringRegisteredPrefixData.DeserializePeeringRegisteredPrefixData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new PeeringRegisteredPrefixListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
