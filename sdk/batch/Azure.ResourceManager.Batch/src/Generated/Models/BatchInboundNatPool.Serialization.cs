// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchInboundNatPool : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("protocol"u8);
            writer.WriteStringValue(Protocol.ToSerialString());
            writer.WritePropertyName("backendPort"u8);
            writer.WriteNumberValue(BackendPort);
            writer.WritePropertyName("frontendPortRangeStart"u8);
            writer.WriteNumberValue(FrontendPortRangeStart);
            writer.WritePropertyName("frontendPortRangeEnd"u8);
            writer.WriteNumberValue(FrontendPortRangeEnd);
            if (Optional.IsCollectionDefined(NetworkSecurityGroupRules))
            {
                writer.WritePropertyName("networkSecurityGroupRules"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkSecurityGroupRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static BatchInboundNatPool DeserializeBatchInboundNatPool(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            BatchInboundEndpointProtocol protocol = default;
            int backendPort = default;
            int frontendPortRangeStart = default;
            int frontendPortRangeEnd = default;
            Optional<IList<BatchNetworkSecurityGroupRule>> networkSecurityGroupRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    protocol = property.Value.GetString().ToBatchInboundEndpointProtocol();
                    continue;
                }
                if (property.NameEquals("backendPort"u8))
                {
                    backendPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("frontendPortRangeStart"u8))
                {
                    frontendPortRangeStart = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("frontendPortRangeEnd"u8))
                {
                    frontendPortRangeEnd = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("networkSecurityGroupRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchNetworkSecurityGroupRule> array = new List<BatchNetworkSecurityGroupRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchNetworkSecurityGroupRule.DeserializeBatchNetworkSecurityGroupRule(item));
                    }
                    networkSecurityGroupRules = array;
                    continue;
                }
            }
            return new BatchInboundNatPool(name, protocol, backendPort, frontendPortRangeStart, frontendPortRangeEnd, Optional.ToList(networkSecurityGroupRules));
        }
    }
}
