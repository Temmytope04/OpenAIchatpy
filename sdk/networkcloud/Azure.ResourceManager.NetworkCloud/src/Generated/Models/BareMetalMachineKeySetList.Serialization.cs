// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    internal partial class BareMetalMachineKeySetList
    {
        internal static BareMetalMachineKeySetList DeserializeBareMetalMachineKeySetList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<BareMetalMachineKeySetData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BareMetalMachineKeySetData> array = new List<BareMetalMachineKeySetData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BareMetalMachineKeySetData.DeserializeBareMetalMachineKeySetData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new BareMetalMachineKeySetList(nextLink.Value, Optional.ToList(value));
        }
    }
}
