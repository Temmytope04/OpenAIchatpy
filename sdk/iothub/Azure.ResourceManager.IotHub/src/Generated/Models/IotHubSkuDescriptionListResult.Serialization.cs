// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    internal partial class IotHubSkuDescriptionListResult
    {
        internal static IotHubSkuDescriptionListResult DeserializeIotHubSkuDescriptionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<IotHubSkuDescription>> value = default;
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
                    List<IotHubSkuDescription> array = new List<IotHubSkuDescription>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotHubSkuDescription.DeserializeIotHubSkuDescription(item));
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
            return new IotHubSkuDescriptionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
