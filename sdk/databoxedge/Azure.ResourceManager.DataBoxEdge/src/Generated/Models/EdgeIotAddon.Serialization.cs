// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeIotAddon : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("ioTDeviceDetails");
            writer.WriteObjectValue(IotDeviceDetails);
            writer.WritePropertyName("ioTEdgeDeviceDetails");
            writer.WriteObjectValue(IotEdgeDeviceDetails);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static EdgeIotAddon DeserializeEdgeIotAddon(JsonElement element)
        {
            AddonType kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            EdgeIotDeviceInfo iotDeviceDetails = default;
            EdgeIotDeviceInfo iotEdgeDeviceDetails = default;
            Optional<string> version = default;
            Optional<DataBoxEdgeOSPlatformType> hostPlatform = default;
            Optional<HostPlatformType> hostPlatformType = default;
            Optional<DataBoxEdgeRoleAddonProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new AddonType(property.Value.GetString());
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
                        if (property0.NameEquals("ioTDeviceDetails"))
                        {
                            iotDeviceDetails = EdgeIotDeviceInfo.DeserializeEdgeIotDeviceInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ioTEdgeDeviceDetails"))
                        {
                            iotEdgeDeviceDetails = EdgeIotDeviceInfo.DeserializeEdgeIotDeviceInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("version"))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
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
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new DataBoxEdgeRoleAddonProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new EdgeIotAddon(id, name, type, systemData.Value, kind, iotDeviceDetails, iotEdgeDeviceDetails, version.Value, Optional.ToNullable(hostPlatform), Optional.ToNullable(hostPlatformType), Optional.ToNullable(provisioningState));
        }
    }
}
