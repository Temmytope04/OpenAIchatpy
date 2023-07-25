// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    internal partial class IotHubEndpointHealthInfoListResult
    {
        internal static IotHubEndpointHealthInfoListResult DeserializeIotHubEndpointHealthInfoListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<IotHubEndpointHealthInfo>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IotHubEndpointHealthInfo> array = new List<IotHubEndpointHealthInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotHubEndpointHealthInfo.DeserializeIotHubEndpointHealthInfo(item));
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
            return new IotHubEndpointHealthInfoListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
