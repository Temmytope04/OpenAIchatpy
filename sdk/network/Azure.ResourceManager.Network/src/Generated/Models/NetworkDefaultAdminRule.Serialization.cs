// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkDefaultAdminRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Flag))
            {
                writer.WritePropertyName("flag"u8);
                writer.WriteStringValue(Flag);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetworkDefaultAdminRule DeserializeNetworkDefaultAdminRule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AdminRuleKind kind = default;
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> description = default;
            Optional<string> flag = default;
            Optional<SecurityConfigurationRuleProtocol> protocol = default;
            Optional<IReadOnlyList<AddressPrefixItem>> sources = default;
            Optional<IReadOnlyList<AddressPrefixItem>> destinations = default;
            Optional<IReadOnlyList<string>> sourcePortRanges = default;
            Optional<IReadOnlyList<string>> destinationPortRanges = default;
            Optional<SecurityConfigurationRuleAccess> access = default;
            Optional<int> priority = default;
            Optional<SecurityConfigurationRuleDirection> direction = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<Guid> resourceGuid = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new AdminRuleKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
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
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("flag"u8))
                        {
                            flag = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("protocol"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protocol = new SecurityConfigurationRuleProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AddressPrefixItem> array = new List<AddressPrefixItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AddressPrefixItem.DeserializeAddressPrefixItem(item));
                            }
                            sources = array;
                            continue;
                        }
                        if (property0.NameEquals("destinations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AddressPrefixItem> array = new List<AddressPrefixItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AddressPrefixItem.DeserializeAddressPrefixItem(item));
                            }
                            destinations = array;
                            continue;
                        }
                        if (property0.NameEquals("sourcePortRanges"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            sourcePortRanges = array;
                            continue;
                        }
                        if (property0.NameEquals("destinationPortRanges"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            destinationPortRanges = array;
                            continue;
                        }
                        if (property0.NameEquals("access"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            access = new SecurityConfigurationRuleAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("priority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            priority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("direction"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            direction = new SecurityConfigurationRuleDirection(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceGuid = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetworkDefaultAdminRule(id, name, type, systemData.Value, kind, Optional.ToNullable(etag), description.Value, flag.Value, Optional.ToNullable(protocol), Optional.ToList(sources), Optional.ToList(destinations), Optional.ToList(sourcePortRanges), Optional.ToList(destinationPortRanges), Optional.ToNullable(access), Optional.ToNullable(priority), Optional.ToNullable(direction), Optional.ToNullable(provisioningState), Optional.ToNullable(resourceGuid));
        }
    }
}
