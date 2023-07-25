// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PowerBIDedicated.Models
{
    internal partial class SkuEnumerationForExistingResourceResult
    {
        internal static SkuEnumerationForExistingResourceResult DeserializeSkuEnumerationForExistingResourceResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SkuDetailsForExistingResource>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SkuDetailsForExistingResource> array = new List<SkuDetailsForExistingResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SkuDetailsForExistingResource.DeserializeSkuDetailsForExistingResource(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SkuEnumerationForExistingResourceResult(Optional.ToList(value));
        }
    }
}
