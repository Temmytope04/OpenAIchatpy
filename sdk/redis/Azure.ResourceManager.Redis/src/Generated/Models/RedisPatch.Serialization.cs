// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Redis.Models
{
    public partial class RedisPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                JsonSerializer.Serialize(writer, Identity);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(RedisConfiguration))
            {
                writer.WritePropertyName("redisConfiguration");
                writer.WriteObjectValue(RedisConfiguration);
            }
            if (Optional.IsDefined(RedisVersion))
            {
                writer.WritePropertyName("redisVersion");
                writer.WriteStringValue(RedisVersion);
            }
            if (Optional.IsDefined(EnableNonSslPort))
            {
                writer.WritePropertyName("enableNonSslPort");
                writer.WriteBooleanValue(EnableNonSslPort.Value);
            }
            if (Optional.IsDefined(ReplicasPerMaster))
            {
                writer.WritePropertyName("replicasPerMaster");
                writer.WriteNumberValue(ReplicasPerMaster.Value);
            }
            if (Optional.IsDefined(ReplicasPerPrimary))
            {
                writer.WritePropertyName("replicasPerPrimary");
                writer.WriteNumberValue(ReplicasPerPrimary.Value);
            }
            if (Optional.IsCollectionDefined(TenantSettings))
            {
                writer.WritePropertyName("tenantSettings");
                writer.WriteStartObject();
                foreach (var item in TenantSettings)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ShardCount))
            {
                writer.WritePropertyName("shardCount");
                writer.WriteNumberValue(ShardCount.Value);
            }
            if (Optional.IsDefined(MinimumTlsVersion))
            {
                writer.WritePropertyName("minimumTlsVersion");
                writer.WriteStringValue(MinimumTlsVersion.Value.ToString());
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess");
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
