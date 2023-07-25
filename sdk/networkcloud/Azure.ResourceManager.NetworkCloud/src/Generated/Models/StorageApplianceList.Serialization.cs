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
    internal partial class StorageApplianceList
    {
        internal static StorageApplianceList DeserializeStorageApplianceList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<StorageApplianceData>> value = default;
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
                    List<StorageApplianceData> array = new List<StorageApplianceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageApplianceData.DeserializeStorageApplianceData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new StorageApplianceList(nextLink.Value, Optional.ToList(value));
        }
    }
}
