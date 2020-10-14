// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ExpressRouteCrossConnectionPeering : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(PeeringType))
            {
                writer.WritePropertyName("peeringType");
                writer.WriteStringValue(PeeringType.Value.ToString());
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state");
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(PeerASN))
            {
                writer.WritePropertyName("peerASN");
                writer.WriteNumberValue(PeerASN.Value);
            }
            if (Optional.IsDefined(PrimaryPeerAddressPrefix))
            {
                writer.WritePropertyName("primaryPeerAddressPrefix");
                writer.WriteStringValue(PrimaryPeerAddressPrefix);
            }
            if (Optional.IsDefined(SecondaryPeerAddressPrefix))
            {
                writer.WritePropertyName("secondaryPeerAddressPrefix");
                writer.WriteStringValue(SecondaryPeerAddressPrefix);
            }
            if (Optional.IsDefined(SharedKey))
            {
                writer.WritePropertyName("sharedKey");
                writer.WriteStringValue(SharedKey);
            }
            if (Optional.IsDefined(VlanId))
            {
                writer.WritePropertyName("vlanId");
                writer.WriteNumberValue(VlanId.Value);
            }
            if (Optional.IsDefined(MicrosoftPeeringConfig))
            {
                writer.WritePropertyName("microsoftPeeringConfig");
                writer.WriteObjectValue(MicrosoftPeeringConfig);
            }
            if (Optional.IsDefined(GatewayManagerEtag))
            {
                writer.WritePropertyName("gatewayManagerEtag");
                writer.WriteStringValue(GatewayManagerEtag);
            }
            if (Optional.IsDefined(Ipv6PeeringConfig))
            {
                writer.WritePropertyName("ipv6PeeringConfig");
                writer.WriteObjectValue(Ipv6PeeringConfig);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ExpressRouteCrossConnectionPeering DeserializeExpressRouteCrossConnectionPeering(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<ExpressRoutePeeringType> peeringType = default;
            Optional<ExpressRoutePeeringState> state = default;
            Optional<int> azureASN = default;
            Optional<long> peerASN = default;
            Optional<string> primaryPeerAddressPrefix = default;
            Optional<string> secondaryPeerAddressPrefix = default;
            Optional<string> primaryAzurePort = default;
            Optional<string> secondaryAzurePort = default;
            Optional<string> sharedKey = default;
            Optional<int> vlanId = default;
            Optional<ExpressRouteCircuitPeeringConfig> microsoftPeeringConfig = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> gatewayManagerEtag = default;
            Optional<string> lastModifiedBy = default;
            Optional<Ipv6ExpressRouteCircuitPeeringConfig> ipv6PeeringConfig = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
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
                        if (property0.NameEquals("peeringType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            peeringType = new ExpressRoutePeeringType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("state"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            state = new ExpressRoutePeeringState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("azureASN"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            azureASN = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("peerASN"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            peerASN = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("primaryPeerAddressPrefix"))
                        {
                            primaryPeerAddressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secondaryPeerAddressPrefix"))
                        {
                            secondaryPeerAddressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("primaryAzurePort"))
                        {
                            primaryAzurePort = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secondaryAzurePort"))
                        {
                            secondaryAzurePort = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sharedKey"))
                        {
                            sharedKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vlanId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            vlanId = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("microsoftPeeringConfig"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            microsoftPeeringConfig = ExpressRouteCircuitPeeringConfig.DeserializeExpressRouteCircuitPeeringConfig(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("gatewayManagerEtag"))
                        {
                            gatewayManagerEtag = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedBy"))
                        {
                            lastModifiedBy = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ipv6PeeringConfig"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ipv6PeeringConfig = Ipv6ExpressRouteCircuitPeeringConfig.DeserializeIpv6ExpressRouteCircuitPeeringConfig(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ExpressRouteCrossConnectionPeering(id.Value, name.Value, etag.Value, Optional.ToNullable(peeringType), Optional.ToNullable(state), Optional.ToNullable(azureASN), Optional.ToNullable(peerASN), primaryPeerAddressPrefix.Value, secondaryPeerAddressPrefix.Value, primaryAzurePort.Value, secondaryAzurePort.Value, sharedKey.Value, Optional.ToNullable(vlanId), microsoftPeeringConfig.Value, Optional.ToNullable(provisioningState), gatewayManagerEtag.Value, lastModifiedBy.Value, ipv6PeeringConfig.Value);
        }
    }
}
