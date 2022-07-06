// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal partial class ApiReleaseCollection
    {
        internal static ApiReleaseCollection DeserializeApiReleaseCollection(JsonElement element)
        {
            Optional<IReadOnlyList<ApiReleaseContractData>> value = default;
            Optional<long> count = default;
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
                    List<ApiReleaseContractData> array = new List<ApiReleaseContractData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiReleaseContractData.DeserializeApiReleaseContractData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ApiReleaseCollection(Optional.ToList(value), Optional.ToNullable(count), nextLink.Value);
        }
    }
}
