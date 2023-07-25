// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class SynapseServerUsageListResult
    {
        internal static SynapseServerUsageListResult DeserializeSynapseServerUsageListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<SynapseServerUsage> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<SynapseServerUsage> array = new List<SynapseServerUsage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseServerUsage.DeserializeSynapseServerUsage(item));
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
            return new SynapseServerUsageListResult(value, nextLink.Value);
        }
    }
}
