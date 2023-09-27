// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Kubernetes.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Kubernetes
{
    public partial class ConnectedClusterData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("identity"u8);
            JsonSerializer.Serialize(writer, Identity);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("agentPublicKeyCertificate"u8);
            writer.WriteStringValue(AgentPublicKeyCertificate);
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(Distribution))
            {
                writer.WritePropertyName("distribution"u8);
                writer.WriteStringValue(Distribution);
            }
            if (Optional.IsDefined(Infrastructure))
            {
                writer.WritePropertyName("infrastructure"u8);
                writer.WriteStringValue(Infrastructure);
            }
            if (Optional.IsDefined(PrivateLinkState))
            {
                writer.WritePropertyName("privateLinkState"u8);
                writer.WriteStringValue(PrivateLinkState.Value.ToString());
            }
            if (Optional.IsDefined(PrivateLinkScopeResourceId))
            {
                writer.WritePropertyName("privateLinkScopeResourceId"u8);
                writer.WriteStringValue(PrivateLinkScopeResourceId);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ConnectedClusterData DeserializeConnectedClusterData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedServiceIdentity identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            string agentPublicKeyCertificate = default;
            Optional<string> kubernetesVersion = default;
            Optional<int> totalNodeCount = default;
            Optional<int> totalCoreCount = default;
            Optional<string> agentVersion = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> distribution = default;
            Optional<string> infrastructure = default;
            Optional<string> offering = default;
            Optional<DateTimeOffset> managedIdentityCertificateExpirationTime = default;
            Optional<DateTimeOffset> lastConnectivityTime = default;
            Optional<ConnectivityStatus> connectivityStatus = default;
            Optional<PrivateLinkState> privateLinkState = default;
            Optional<string> privateLinkScopeResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("agentPublicKeyCertificate"u8))
                        {
                            agentPublicKeyCertificate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("kubernetesVersion"u8))
                        {
                            kubernetesVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("totalNodeCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalNodeCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("totalCoreCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalCoreCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("agentVersion"u8))
                        {
                            agentVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("distribution"u8))
                        {
                            distribution = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("infrastructure"u8))
                        {
                            infrastructure = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("offering"u8))
                        {
                            offering = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managedIdentityCertificateExpirationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedIdentityCertificateExpirationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastConnectivityTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastConnectivityTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("connectivityStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectivityStatus = new ConnectivityStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateLinkState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateLinkState = new PrivateLinkState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateLinkScopeResourceId"u8))
                        {
                            privateLinkScopeResourceId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ConnectedClusterData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity, agentPublicKeyCertificate, kubernetesVersion.Value, Optional.ToNullable(totalNodeCount), Optional.ToNullable(totalCoreCount), agentVersion.Value, Optional.ToNullable(provisioningState), distribution.Value, infrastructure.Value, offering.Value, Optional.ToNullable(managedIdentityCertificateExpirationTime), Optional.ToNullable(lastConnectivityTime), Optional.ToNullable(connectivityStatus), Optional.ToNullable(privateLinkState), privateLinkScopeResourceId.Value);
        }
    }
}
