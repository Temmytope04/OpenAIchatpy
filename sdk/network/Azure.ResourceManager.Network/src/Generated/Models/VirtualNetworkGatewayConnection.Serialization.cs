// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VirtualNetworkGatewayConnection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
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
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AuthorizationKey))
            {
                writer.WritePropertyName("authorizationKey");
                writer.WriteStringValue(AuthorizationKey);
            }
            writer.WritePropertyName("virtualNetworkGateway1");
            writer.WriteObjectValue(VirtualNetworkGateway1);
            if (Optional.IsDefined(VirtualNetworkGateway2))
            {
                writer.WritePropertyName("virtualNetworkGateway2");
                writer.WriteObjectValue(VirtualNetworkGateway2);
            }
            if (Optional.IsDefined(LocalNetworkGateway2))
            {
                writer.WritePropertyName("localNetworkGateway2");
                writer.WriteObjectValue(LocalNetworkGateway2);
            }
            writer.WritePropertyName("connectionType");
            writer.WriteStringValue(ConnectionType.ToString());
            if (Optional.IsDefined(ConnectionProtocol))
            {
                writer.WritePropertyName("connectionProtocol");
                writer.WriteStringValue(ConnectionProtocol.Value.ToString());
            }
            if (Optional.IsDefined(RoutingWeight))
            {
                writer.WritePropertyName("routingWeight");
                writer.WriteNumberValue(RoutingWeight.Value);
            }
            if (Optional.IsDefined(DpdTimeoutSeconds))
            {
                writer.WritePropertyName("dpdTimeoutSeconds");
                writer.WriteNumberValue(DpdTimeoutSeconds.Value);
            }
            if (Optional.IsDefined(SharedKey))
            {
                writer.WritePropertyName("sharedKey");
                writer.WriteStringValue(SharedKey);
            }
            if (Optional.IsDefined(ConnectionStatus))
            {
                writer.WritePropertyName("connectionStatus");
                writer.WriteStringValue(ConnectionStatus.Value.ToString());
            }
            if (Optional.IsCollectionDefined(TunnelConnectionStatus))
            {
                writer.WritePropertyName("tunnelConnectionStatus");
                writer.WriteStartArray();
                foreach (var item in TunnelConnectionStatus)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EgressBytesTransferred))
            {
                writer.WritePropertyName("egressBytesTransferred");
                writer.WriteNumberValue(EgressBytesTransferred.Value);
            }
            if (Optional.IsDefined(IngressBytesTransferred))
            {
                writer.WritePropertyName("ingressBytesTransferred");
                writer.WriteNumberValue(IngressBytesTransferred.Value);
            }
            if (Optional.IsDefined(Peer))
            {
                writer.WritePropertyName("peer");
                writer.WriteObjectValue(Peer);
            }
            if (Optional.IsDefined(EnableBgp))
            {
                writer.WritePropertyName("enableBgp");
                writer.WriteBooleanValue(EnableBgp.Value);
            }
            if (Optional.IsDefined(UseLocalAzureIpAddress))
            {
                writer.WritePropertyName("useLocalAzureIpAddress");
                writer.WriteBooleanValue(UseLocalAzureIpAddress.Value);
            }
            if (Optional.IsDefined(UsePolicyBasedTrafficSelectors))
            {
                writer.WritePropertyName("usePolicyBasedTrafficSelectors");
                writer.WriteBooleanValue(UsePolicyBasedTrafficSelectors.Value);
            }
            if (Optional.IsCollectionDefined(IpsecPolicies))
            {
                writer.WritePropertyName("ipsecPolicies");
                writer.WriteStartArray();
                foreach (var item in IpsecPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TrafficSelectorPolicies))
            {
                writer.WritePropertyName("trafficSelectorPolicies");
                writer.WriteStartArray();
                foreach (var item in TrafficSelectorPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ResourceGuid))
            {
                writer.WritePropertyName("resourceGuid");
                writer.WriteStringValue(ResourceGuid);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(ExpressRouteGatewayBypass))
            {
                writer.WritePropertyName("expressRouteGatewayBypass");
                writer.WriteBooleanValue(ExpressRouteGatewayBypass.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualNetworkGatewayConnection DeserializeVirtualNetworkGatewayConnection(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> authorizationKey = default;
            VirtualNetworkGateway virtualNetworkGateway1 = default;
            Optional<VirtualNetworkGateway> virtualNetworkGateway2 = default;
            Optional<LocalNetworkGateway> localNetworkGateway2 = default;
            VirtualNetworkGatewayConnectionType connectionType = default;
            Optional<VirtualNetworkGatewayConnectionProtocol> connectionProtocol = default;
            Optional<int> routingWeight = default;
            Optional<int> dpdTimeoutSeconds = default;
            Optional<string> sharedKey = default;
            Optional<VirtualNetworkGatewayConnectionStatus> connectionStatus = default;
            Optional<IList<TunnelConnectionHealth>> tunnelConnectionStatus = default;
            Optional<long> egressBytesTransferred = default;
            Optional<long> ingressBytesTransferred = default;
            Optional<SubResource> peer = default;
            Optional<bool> enableBgp = default;
            Optional<bool> useLocalAzureIpAddress = default;
            Optional<bool> usePolicyBasedTrafficSelectors = default;
            Optional<IList<IpsecPolicy>> ipsecPolicies = default;
            Optional<IList<TrafficSelectorPolicy>> trafficSelectorPolicies = default;
            Optional<string> resourceGuid = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<bool> expressRouteGatewayBypass = default;
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("authorizationKey"))
                        {
                            authorizationKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkGateway1"))
                        {
                            virtualNetworkGateway1 = VirtualNetworkGateway.DeserializeVirtualNetworkGateway(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkGateway2"))
                        {
                            virtualNetworkGateway2 = VirtualNetworkGateway.DeserializeVirtualNetworkGateway(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("localNetworkGateway2"))
                        {
                            localNetworkGateway2 = LocalNetworkGateway.DeserializeLocalNetworkGateway(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("connectionType"))
                        {
                            connectionType = new VirtualNetworkGatewayConnectionType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("connectionProtocol"))
                        {
                            connectionProtocol = new VirtualNetworkGatewayConnectionProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("routingWeight"))
                        {
                            routingWeight = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dpdTimeoutSeconds"))
                        {
                            dpdTimeoutSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("sharedKey"))
                        {
                            sharedKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("connectionStatus"))
                        {
                            connectionStatus = new VirtualNetworkGatewayConnectionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("tunnelConnectionStatus"))
                        {
                            List<TunnelConnectionHealth> array = new List<TunnelConnectionHealth>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TunnelConnectionHealth.DeserializeTunnelConnectionHealth(item));
                            }
                            tunnelConnectionStatus = array;
                            continue;
                        }
                        if (property0.NameEquals("egressBytesTransferred"))
                        {
                            egressBytesTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("ingressBytesTransferred"))
                        {
                            ingressBytesTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("peer"))
                        {
                            peer = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enableBgp"))
                        {
                            enableBgp = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("useLocalAzureIpAddress"))
                        {
                            useLocalAzureIpAddress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("usePolicyBasedTrafficSelectors"))
                        {
                            usePolicyBasedTrafficSelectors = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ipsecPolicies"))
                        {
                            List<IpsecPolicy> array = new List<IpsecPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IpsecPolicy.DeserializeIpsecPolicy(item));
                            }
                            ipsecPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("trafficSelectorPolicies"))
                        {
                            List<TrafficSelectorPolicy> array = new List<TrafficSelectorPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TrafficSelectorPolicy.DeserializeTrafficSelectorPolicy(item));
                            }
                            trafficSelectorPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"))
                        {
                            resourceGuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("expressRouteGatewayBypass"))
                        {
                            expressRouteGatewayBypass = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualNetworkGatewayConnection(id.Value, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), etag.Value, authorizationKey.Value, virtualNetworkGateway1, virtualNetworkGateway2.Value, localNetworkGateway2.Value, connectionType, Optional.ToNullable(connectionProtocol), Optional.ToNullable(routingWeight), Optional.ToNullable(dpdTimeoutSeconds), sharedKey.Value, Optional.ToNullable(connectionStatus), Optional.ToList(tunnelConnectionStatus), Optional.ToNullable(egressBytesTransferred), Optional.ToNullable(ingressBytesTransferred), peer.Value, Optional.ToNullable(enableBgp), Optional.ToNullable(useLocalAzureIpAddress), Optional.ToNullable(usePolicyBasedTrafficSelectors), Optional.ToList(ipsecPolicies), Optional.ToList(trafficSelectorPolicies), resourceGuid.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(expressRouteGatewayBypass));
        }
    }
}
