// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterServiceConfigsProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("serviceName"u8);
            writer.WriteStringValue(ServiceName);
            writer.WritePropertyName("configs"u8);
            writer.WriteStartArray();
            foreach (var item in Configs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static ClusterServiceConfigsProfile DeserializeClusterServiceConfigsProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string serviceName = default;
            IList<ClusterServiceConfig> configs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceName"u8))
                {
                    serviceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configs"u8))
                {
                    List<ClusterServiceConfig> array = new List<ClusterServiceConfig>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ClusterServiceConfig.DeserializeClusterServiceConfig(item));
                    }
                    configs = array;
                    continue;
                }
            }
            return new ClusterServiceConfigsProfile(serviceName, configs);
        }
    }
}
