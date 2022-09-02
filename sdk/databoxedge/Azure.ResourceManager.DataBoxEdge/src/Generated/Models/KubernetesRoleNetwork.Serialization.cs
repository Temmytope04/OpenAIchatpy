// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class KubernetesRoleNetwork
    {
        internal static KubernetesRoleNetwork DeserializeKubernetesRoleNetwork(JsonElement element)
        {
            Optional<CniConfig> cniConfig = default;
            Optional<LoadBalancerConfig> loadBalancerConfig = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cniConfig"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cniConfig = CniConfig.DeserializeCniConfig(property.Value);
                    continue;
                }
                if (property.NameEquals("loadBalancerConfig"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    loadBalancerConfig = LoadBalancerConfig.DeserializeLoadBalancerConfig(property.Value);
                    continue;
                }
            }
            return new KubernetesRoleNetwork(cniConfig.Value, loadBalancerConfig.Value);
        }
    }
}
