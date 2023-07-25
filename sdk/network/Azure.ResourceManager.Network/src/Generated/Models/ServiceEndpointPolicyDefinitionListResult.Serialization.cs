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
    internal partial class ServiceEndpointPolicyDefinitionListResult
    {
        internal static ServiceEndpointPolicyDefinitionListResult DeserializeServiceEndpointPolicyDefinitionListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ServiceEndpointPolicyDefinitionData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceEndpointPolicyDefinitionData> array = new List<ServiceEndpointPolicyDefinitionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceEndpointPolicyDefinitionData.DeserializeServiceEndpointPolicyDefinitionData(item));
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
            return new ServiceEndpointPolicyDefinitionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
