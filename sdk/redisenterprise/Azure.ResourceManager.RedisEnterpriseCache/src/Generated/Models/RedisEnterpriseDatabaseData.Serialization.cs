// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RedisEnterpriseCache.Models;

namespace Azure.ResourceManager.RedisEnterpriseCache
{
    public partial class RedisEnterpriseDatabaseData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ClientProtocol))
            {
                writer.WritePropertyName("clientProtocol");
                writer.WriteStringValue(ClientProtocol.Value.ToString());
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port");
                writer.WriteNumberValue(Port.Value);
            }
            if (Optional.IsDefined(ClusteringPolicy))
            {
                writer.WritePropertyName("clusteringPolicy");
                writer.WriteStringValue(ClusteringPolicy.Value.ToString());
            }
            if (Optional.IsDefined(EvictionPolicy))
            {
                writer.WritePropertyName("evictionPolicy");
                writer.WriteStringValue(EvictionPolicy.Value.ToString());
            }
            if (Optional.IsDefined(Persistence))
            {
                writer.WritePropertyName("persistence");
                writer.WriteObjectValue(Persistence);
            }
            if (Optional.IsCollectionDefined(Modules))
            {
                writer.WritePropertyName("modules");
                writer.WriteStartArray();
                foreach (var item in Modules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(GeoReplication))
            {
                writer.WritePropertyName("geoReplication");
                writer.WriteObjectValue(GeoReplication);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RedisEnterpriseDatabaseData DeserializeRedisEnterpriseDatabaseData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<RedisEnterpriseClientProtocol> clientProtocol = default;
            Optional<int> port = default;
            Optional<RedisEnterpriseProvisioningStatus> provisioningState = default;
            Optional<RedisEnterpriseClusterResourceState> resourceState = default;
            Optional<RedisEnterpriseClusteringPolicy> clusteringPolicy = default;
            Optional<RedisEnterpriseEvictionPolicy> evictionPolicy = default;
            Optional<RedisPersistenceSettings> persistence = default;
            Optional<IList<RedisEnterpriseModule>> modules = default;
            Optional<RedisEnterpriseDatabaseGeoReplication> geoReplication = default;
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
                        if (property0.NameEquals("clientProtocol"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clientProtocol = new RedisEnterpriseClientProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("port"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            port = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new RedisEnterpriseProvisioningStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            resourceState = new RedisEnterpriseClusterResourceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clusteringPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clusteringPolicy = new RedisEnterpriseClusteringPolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("evictionPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            evictionPolicy = new RedisEnterpriseEvictionPolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("persistence"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            persistence = RedisPersistenceSettings.DeserializeRedisPersistenceSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("modules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<RedisEnterpriseModule> array = new List<RedisEnterpriseModule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RedisEnterpriseModule.DeserializeRedisEnterpriseModule(item));
                            }
                            modules = array;
                            continue;
                        }
                        if (property0.NameEquals("geoReplication"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            geoReplication = RedisEnterpriseDatabaseGeoReplication.DeserializeRedisEnterpriseDatabaseGeoReplication(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RedisEnterpriseDatabaseData(id, name, type, systemData.Value, Optional.ToNullable(clientProtocol), Optional.ToNullable(port), Optional.ToNullable(provisioningState), Optional.ToNullable(resourceState), Optional.ToNullable(clusteringPolicy), Optional.ToNullable(evictionPolicy), persistence.Value, Optional.ToList(modules), geoReplication.Value);
        }
    }
}
