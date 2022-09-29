// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeKubernetesRole : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(HostPlatform))
            {
                writer.WritePropertyName("hostPlatform");
                writer.WriteStringValue(HostPlatform.Value.ToString());
            }
            if (Optional.IsDefined(KubernetesClusterInfo))
            {
                writer.WritePropertyName("kubernetesClusterInfo");
                writer.WriteObjectValue(KubernetesClusterInfo);
            }
            if (Optional.IsDefined(KubernetesRoleResources))
            {
                writer.WritePropertyName("kubernetesRoleResources");
                writer.WriteObjectValue(KubernetesRoleResources);
            }
            if (Optional.IsDefined(RoleStatus))
            {
                writer.WritePropertyName("roleStatus");
                writer.WriteStringValue(RoleStatus.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static EdgeKubernetesRole DeserializeEdgeKubernetesRole(JsonElement element)
        {
            DataBoxEdgeRoleType kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DataBoxEdgeOSPlatformType> hostPlatform = default;
            Optional<EdgeKubernetesState> provisioningState = default;
            Optional<HostPlatformType> hostPlatformType = default;
            Optional<EdgeKubernetesClusterInfo> kubernetesClusterInfo = default;
            Optional<EdgeKubernetesRoleResources> kubernetesRoleResources = default;
            Optional<DataBoxEdgeRoleStatus> roleStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new DataBoxEdgeRoleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("hostPlatform"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hostPlatform = new DataBoxEdgeOSPlatformType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new EdgeKubernetesState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("hostPlatformType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hostPlatformType = new HostPlatformType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("kubernetesClusterInfo"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            kubernetesClusterInfo = EdgeKubernetesClusterInfo.DeserializeEdgeKubernetesClusterInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("kubernetesRoleResources"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            kubernetesRoleResources = EdgeKubernetesRoleResources.DeserializeEdgeKubernetesRoleResources(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("roleStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            roleStatus = new DataBoxEdgeRoleStatus(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new EdgeKubernetesRole(id, name, type, systemData.Value, kind, Optional.ToNullable(hostPlatform), Optional.ToNullable(provisioningState), Optional.ToNullable(hostPlatformType), kubernetesClusterInfo.Value, kubernetesRoleResources.Value, Optional.ToNullable(roleStatus));
        }
    }
}
