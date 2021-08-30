// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.KeyVault;

namespace Azure.ResourceManager.KeyVault.Models
{
    internal partial class ManagedHsmListResult
    {
        internal static ManagedHsmListResult DeserializeManagedHsmListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ManagedHsmData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ManagedHsmData> array = new List<ManagedHsmData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedHsmData.DeserializeManagedHsmData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ManagedHsmListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
