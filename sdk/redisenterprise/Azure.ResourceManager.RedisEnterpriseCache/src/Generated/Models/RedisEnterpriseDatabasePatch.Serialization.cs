// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RedisEnterpriseCache.Models
{
    public partial class RedisEnterpriseDatabasePatch : IUtf8JsonSerializable
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
    }
}
