// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class IPGroupListResult
    {
        internal static IPGroupListResult DeserializeIPGroupListResult(JsonElement element)
        {
            Optional<IReadOnlyList<IPGroupData>> value = default;
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
                    List<IPGroupData> array = new List<IPGroupData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IPGroupData.DeserializeIPGroupData(item));
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
            return new IPGroupListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
