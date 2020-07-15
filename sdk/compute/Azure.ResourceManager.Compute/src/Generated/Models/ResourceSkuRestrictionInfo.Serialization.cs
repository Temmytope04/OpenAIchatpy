// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class ResourceSkuRestrictionInfo
    {
        internal static ResourceSkuRestrictionInfo DeserializeResourceSkuRestrictionInfo(JsonElement element)
        {
            Optional<IReadOnlyList<string>> locations = default;
            Optional<IReadOnlyList<string>> zones = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("locations"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("zones"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
                    continue;
                }
            }
            return new ResourceSkuRestrictionInfo(Optional.ToList(locations), Optional.ToList(zones));
        }
    }
}
