// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class VirtualNetworkGateway : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Etag != null)
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Location != null)
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Tags != null)
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
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (IpConfigurations != null)
            {
                writer.WritePropertyName("ipConfigurations");
                writer.WriteStartArray();
                foreach (var item in IpConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (GatewayType != null)
            {
                writer.WritePropertyName("gatewayType");
                writer.WriteStringValue(GatewayType.Value.ToString());
            }
            if (VpnType != null)
            {
                writer.WritePropertyName("vpnType");
                writer.WriteStringValue(VpnType.Value.ToString());
            }
            if (VpnGatewayGeneration != null)
            {
                writer.WritePropertyName("vpnGatewayGeneration");
                writer.WriteStringValue(VpnGatewayGeneration.Value.ToString());
            }
            if (EnableBgp != null)
            {
                writer.WritePropertyName("enableBgp");
                writer.WriteBooleanValue(EnableBgp.Value);
            }
            if (EnablePrivateIpAddress != null)
            {
                writer.WritePropertyName("enablePrivateIpAddress");
                writer.WriteBooleanValue(EnablePrivateIpAddress.Value);
            }
            if (Active != null)
            {
                writer.WritePropertyName("activeActive");
                writer.WriteBooleanValue(Active.Value);
            }
            if (GatewayDefaultSite != null)
            {
                writer.WritePropertyName("gatewayDefaultSite");
                writer.WriteObjectValue(GatewayDefaultSite);
            }
            if (Sku != null)
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (VpnClientConfiguration != null)
            {
                writer.WritePropertyName("vpnClientConfiguration");
                writer.WriteObjectValue(VpnClientConfiguration);
            }
            if (BgpSettings != null)
            {
                writer.WritePropertyName("bgpSettings");
                writer.WriteObjectValue(BgpSettings);
            }
            if (CustomRoutes != null)
            {
                writer.WritePropertyName("customRoutes");
                writer.WriteObjectValue(CustomRoutes);
            }
            if (ResourceGuid != null)
            {
                writer.WritePropertyName("resourceGuid");
                writer.WriteStringValue(ResourceGuid);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (EnableDnsForwarding != null)
            {
                writer.WritePropertyName("enableDnsForwarding");
                writer.WriteBooleanValue(EnableDnsForwarding.Value);
            }
            if (InboundDnsForwardingEndpoint != null)
            {
                writer.WritePropertyName("inboundDnsForwardingEndpoint");
                writer.WriteStringValue(InboundDnsForwardingEndpoint);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualNetworkGateway DeserializeVirtualNetworkGateway(JsonElement element)
        {
            string etag = default;
            string id = default;
            string name = default;
            string type = default;
            string location = default;
            IDictionary<string, string> tags = default;
            IList<VirtualNetworkGatewayIPConfiguration> ipConfigurations = default;
            VirtualNetworkGatewayType? gatewayType = default;
            VpnType? vpnType = default;
            VpnGatewayGeneration? vpnGatewayGeneration = default;
            bool? enableBgp = default;
            bool? enablePrivateIpAddress = default;
            bool? activeActive = default;
            SubResource gatewayDefaultSite = default;
            VirtualNetworkGatewaySku sku = default;
            VpnClientConfiguration vpnClientConfiguration = default;
            BgpSettings bgpSettings = default;
            AddressSpace customRoutes = default;
            string resourceGuid = default;
            ProvisioningState? provisioningState = default;
            bool? enableDnsForwarding = default;
            string inboundDnsForwardingEndpoint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("ipConfigurations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VirtualNetworkGatewayIPConfiguration> array = new List<VirtualNetworkGatewayIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(VirtualNetworkGatewayIPConfiguration.DeserializeVirtualNetworkGatewayIPConfiguration(item));
                                }
                            }
                            ipConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("gatewayType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            gatewayType = new VirtualNetworkGatewayType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vpnType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vpnType = new VpnType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vpnGatewayGeneration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vpnGatewayGeneration = new VpnGatewayGeneration(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enableBgp"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableBgp = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enablePrivateIpAddress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enablePrivateIpAddress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("activeActive"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            activeActive = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("gatewayDefaultSite"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            gatewayDefaultSite = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sku"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sku = VirtualNetworkGatewaySku.DeserializeVirtualNetworkGatewaySku(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("vpnClientConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vpnClientConfiguration = VpnClientConfiguration.DeserializeVpnClientConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("bgpSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bgpSettings = BgpSettings.DeserializeBgpSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("customRoutes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customRoutes = AddressSpace.DeserializeAddressSpace(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceGuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enableDnsForwarding"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableDnsForwarding = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("inboundDnsForwardingEndpoint"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            inboundDnsForwardingEndpoint = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualNetworkGateway(id, name, type, location, tags, etag, ipConfigurations, gatewayType, vpnType, vpnGatewayGeneration, enableBgp, enablePrivateIpAddress, activeActive, gatewayDefaultSite, sku, vpnClientConfiguration, bgpSettings, customRoutes, resourceGuid, provisioningState, enableDnsForwarding, inboundDnsForwardingEndpoint);
        }
    }
}
