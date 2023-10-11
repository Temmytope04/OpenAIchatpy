// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.ContainerServiceFleet.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerServiceFleet
{
    public partial class ContainerServiceFleetUpdateRunData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Strategy))
            {
                writer.WritePropertyName("strategy"u8);
                writer.WriteObjectValue(Strategy);
            }
            if (Optional.IsDefined(ManagedClusterUpdate))
            {
                writer.WritePropertyName("managedClusterUpdate"u8);
                writer.WriteObjectValue(ManagedClusterUpdate);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ContainerServiceFleetUpdateRunData DeserializeContainerServiceFleetUpdateRunData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> eTag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ContainerServiceFleetUpdateRunProvisioningState> provisioningState = default;
            Optional<ContainerServiceFleetUpdateRunStrategy> strategy = default;
            Optional<ContainerServiceFleetManagedClusterUpdate> managedClusterUpdate = default;
            Optional<ContainerServiceFleetUpdateRunStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ContainerServiceFleetUpdateRunProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("strategy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            strategy = ContainerServiceFleetUpdateRunStrategy.DeserializeContainerServiceFleetUpdateRunStrategy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("managedClusterUpdate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedClusterUpdate = ContainerServiceFleetManagedClusterUpdate.DeserializeContainerServiceFleetManagedClusterUpdate(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = ContainerServiceFleetUpdateRunStatus.DeserializeContainerServiceFleetUpdateRunStatus(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ContainerServiceFleetUpdateRunData(id, name, type, systemData.Value, Optional.ToNullable(eTag), Optional.ToNullable(provisioningState), strategy.Value, managedClusterUpdate.Value, status.Value);
        }
    }
}
