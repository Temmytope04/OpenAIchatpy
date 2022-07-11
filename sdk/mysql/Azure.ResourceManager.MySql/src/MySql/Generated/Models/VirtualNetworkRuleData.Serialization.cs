// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.MySql.Models;

namespace Azure.ResourceManager.MySql
{
    public partial class VirtualNetworkRuleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualNetworkSubnetId))
            {
                writer.WritePropertyName("virtualNetworkSubnetId");
                writer.WriteStringValue(VirtualNetworkSubnetId);
            }
            if (Optional.IsDefined(IgnoreMissingVnetServiceEndpoint))
            {
                writer.WritePropertyName("ignoreMissingVnetServiceEndpoint");
                writer.WriteBooleanValue(IgnoreMissingVnetServiceEndpoint.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualNetworkRuleData DeserializeVirtualNetworkRuleData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> virtualNetworkSubnetId = default;
            Optional<bool> ignoreMissingVnetServiceEndpoint = default;
            Optional<VirtualNetworkRuleState> state = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("virtualNetworkSubnetId"))
                        {
                            virtualNetworkSubnetId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ignoreMissingVnetServiceEndpoint"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ignoreMissingVnetServiceEndpoint = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("state"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            state = new VirtualNetworkRuleState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualNetworkRuleData(id, name, type, systemData.Value, virtualNetworkSubnetId.Value, Optional.ToNullable(ignoreMissingVnetServiceEndpoint), Optional.ToNullable(state));
        }
    }
}
