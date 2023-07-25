// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class TunnelConnectionHealth
    {
        internal static TunnelConnectionHealth DeserializeTunnelConnectionHealth(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> tunnel = default;
            Optional<VirtualNetworkGatewayConnectionStatus> connectionStatus = default;
            Optional<long> ingressBytesTransferred = default;
            Optional<long> egressBytesTransferred = default;
            Optional<string> lastConnectionEstablishedUtcTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tunnel"u8))
                {
                    tunnel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionStatus = new VirtualNetworkGatewayConnectionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ingressBytesTransferred"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ingressBytesTransferred = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("egressBytesTransferred"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    egressBytesTransferred = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastConnectionEstablishedUtcTime"u8))
                {
                    lastConnectionEstablishedUtcTime = property.Value.GetString();
                    continue;
                }
            }
            return new TunnelConnectionHealth(tunnel.Value, Optional.ToNullable(connectionStatus), Optional.ToNullable(ingressBytesTransferred), Optional.ToNullable(egressBytesTransferred), lastConnectionEstablishedUtcTime.Value);
        }
    }
}
