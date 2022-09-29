// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Search.Models;

namespace Azure.ResourceManager.Search
{
    public partial class SearchServiceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ReplicaCount))
            {
                writer.WritePropertyName("replicaCount");
                writer.WriteNumberValue(ReplicaCount.Value);
            }
            if (Optional.IsDefined(PartitionCount))
            {
                writer.WritePropertyName("partitionCount");
                writer.WriteNumberValue(PartitionCount.Value);
            }
            if (Optional.IsDefined(HostingMode))
            {
                writer.WritePropertyName("hostingMode");
                writer.WriteStringValue(HostingMode.Value.ToSerialString());
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess");
                writer.WriteStringValue(PublicNetworkAccess.Value.ToSerialString());
            }
            if (Optional.IsDefined(NetworkRuleSet))
            {
                writer.WritePropertyName("networkRuleSet");
                writer.WriteObjectValue(NetworkRuleSet);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SearchServiceData DeserializeSearchServiceData(JsonElement element)
        {
            Optional<SearchSku> sku = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> replicaCount = default;
            Optional<int> partitionCount = default;
            Optional<SearchServiceHostingMode> hostingMode = default;
            Optional<SearchServicePublicNetworkAccess> publicNetworkAccess = default;
            Optional<SearchServiceStatus> status = default;
            Optional<string> statusDetails = default;
            Optional<SearchServiceProvisioningState> provisioningState = default;
            Optional<NetworkRuleSet> networkRuleSet = default;
            Optional<IReadOnlyList<SearchPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<IReadOnlyList<SharedSearchServicePrivateLinkResourceData>> sharedPrivateLinkResources = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = SearchSku.DeserializeSearchSku(property.Value);
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("replicaCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            replicaCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("partitionCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            partitionCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("hostingMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hostingMode = property0.Value.GetString().ToSearchServiceHostingMode();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            publicNetworkAccess = property0.Value.GetString().ToSearchServicePublicNetworkAccess();
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = property0.Value.GetString().ToSearchServiceStatus();
                            continue;
                        }
                        if (property0.NameEquals("statusDetails"))
                        {
                            statusDetails = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToSearchServiceProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("networkRuleSet"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            networkRuleSet = NetworkRuleSet.DeserializeNetworkRuleSet(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SearchPrivateEndpointConnectionData> array = new List<SearchPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SearchPrivateEndpointConnectionData.DeserializeSearchPrivateEndpointConnectionData(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("sharedPrivateLinkResources"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SharedSearchServicePrivateLinkResourceData> array = new List<SharedSearchServicePrivateLinkResourceData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SharedSearchServicePrivateLinkResourceData.DeserializeSharedSearchServicePrivateLinkResourceData(item));
                            }
                            sharedPrivateLinkResources = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SearchServiceData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku.Value, identity, Optional.ToNullable(replicaCount), Optional.ToNullable(partitionCount), Optional.ToNullable(hostingMode), Optional.ToNullable(publicNetworkAccess), Optional.ToNullable(status), statusDetails.Value, Optional.ToNullable(provisioningState), networkRuleSet.Value, Optional.ToList(privateEndpointConnections), Optional.ToList(sharedPrivateLinkResources));
        }
    }
}
