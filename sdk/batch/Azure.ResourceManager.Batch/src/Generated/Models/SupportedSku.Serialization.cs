// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class SupportedSku
    {
        internal static SupportedSku DeserializeSupportedSku(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> familyName = default;
            Optional<IReadOnlyList<SkuCapability>> capabilities = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("familyName"))
                {
                    familyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capabilities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SkuCapability> array = new List<SkuCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SkuCapability.DeserializeSkuCapability(item));
                    }
                    capabilities = array;
                    continue;
                }
            }
            return new SupportedSku(name.Value, familyName.Value, Optional.ToList(capabilities));
        }
    }
}
