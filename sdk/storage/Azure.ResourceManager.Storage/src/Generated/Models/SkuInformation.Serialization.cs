// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class SkuInformation
    {
        internal static SkuInformation DeserializeSkuInformation(JsonElement element)
        {
            SkuName name = default;
            Optional<SkuTier> tier = default;
            Optional<string> resourceType = default;
            Optional<Kind> kind = default;
            Optional<IReadOnlyList<string>> locations = default;
            Optional<IReadOnlyList<SKUCapability>> capabilities = default;
            Optional<IReadOnlyList<Restriction>> restrictions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = new SkuName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tier"))
                {
                    tier = property.Value.GetString().ToSkuTier();
                    continue;
                }
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = new Kind(property.Value.GetString());
                    continue;
                }
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
                if (property.NameEquals("capabilities"))
                {
                    List<SKUCapability> array = new List<SKUCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SKUCapability.DeserializeSKUCapability(item));
                    }
                    capabilities = array;
                    continue;
                }
                if (property.NameEquals("restrictions"))
                {
                    List<Restriction> array = new List<Restriction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Restriction.DeserializeRestriction(item));
                    }
                    restrictions = array;
                    continue;
                }
            }
            return new SkuInformation(name, Optional.ToNullable(tier), resourceType.Value, Optional.ToNullable(kind), Optional.ToList(locations), Optional.ToList(capabilities), Optional.ToList(restrictions));
        }
    }
}
