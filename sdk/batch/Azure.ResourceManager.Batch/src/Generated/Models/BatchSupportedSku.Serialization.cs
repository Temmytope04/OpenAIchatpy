// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchSupportedSku
    {
        internal static BatchSupportedSku DeserializeBatchSupportedSku(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> familyName = default;
            Optional<IReadOnlyList<BatchSkuCapability>> capabilities = default;
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
                    List<BatchSkuCapability> array = new List<BatchSkuCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchSkuCapability.DeserializeBatchSkuCapability(item));
                    }
                    capabilities = array;
                    continue;
                }
            }
            return new BatchSupportedSku(name.Value, familyName.Value, Optional.ToList(capabilities));
        }
    }
}
