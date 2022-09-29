// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class IntegrationRuntimeOutboundNetworkDependenciesEndpointDetails
    {
        internal static IntegrationRuntimeOutboundNetworkDependenciesEndpointDetails DeserializeIntegrationRuntimeOutboundNetworkDependenciesEndpointDetails(JsonElement element)
        {
            Optional<int> port = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("port"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    port = property.Value.GetInt32();
                    continue;
                }
            }
            return new IntegrationRuntimeOutboundNetworkDependenciesEndpointDetails(Optional.ToNullable(port));
        }
    }
}
