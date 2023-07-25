// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ExtendedLocations;

namespace Azure.ResourceManager.ExtendedLocations.Models
{
    internal partial class CustomLocationListResult
    {
        internal static CustomLocationListResult DeserializeCustomLocationListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<CustomLocationData>> value = default;
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
                    List<CustomLocationData> array = new List<CustomLocationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomLocationData.DeserializeCustomLocationData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new CustomLocationListResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
