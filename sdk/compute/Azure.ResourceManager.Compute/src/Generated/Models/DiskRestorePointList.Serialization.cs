// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class DiskRestorePointList
    {
        internal static DiskRestorePointList DeserializeDiskRestorePointList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DiskRestorePointData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<DiskRestorePointData> array = new List<DiskRestorePointData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiskRestorePointData.DeserializeDiskRestorePointData(item));
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
            return new DiskRestorePointList(value, nextLink.Value);
        }
    }
}
