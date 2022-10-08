// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServices;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    internal partial class VaultList
    {
        internal static VaultList DeserializeVaultList(JsonElement element)
        {
            Optional<IReadOnlyList<VaultData>> value = default;
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
                    List<VaultData> array = new List<VaultData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VaultData.DeserializeVaultData(item));
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
            return new VaultList(Optional.ToList(value), nextLink.Value);
        }
    }
}
