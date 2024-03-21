// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Security.KeyVault.Storage.Models
{
    internal partial class SasDefinitionListResult
    {
        internal static SasDefinitionListResult DeserializeSasDefinitionListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<SasDefinitionItem> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SasDefinitionItem> array = new List<SasDefinitionItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SasDefinitionItem.DeserializeSasDefinitionItem(item));
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
            return new SasDefinitionListResult(value ?? new ChangeTrackingList<SasDefinitionItem>(), nextLink);
        }
    }
}
