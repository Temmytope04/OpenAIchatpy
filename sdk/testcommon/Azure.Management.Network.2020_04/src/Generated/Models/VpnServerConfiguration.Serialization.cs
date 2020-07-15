// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class VpnServerConfiguration : IUtf8JsonSerializable
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
            if (Optional.IsDefined(NamePropertiesName))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(NamePropertiesName);
            }
            if (Optional.IsCollectionDefined(VpnProtocols))
            {
                writer.WritePropertyName("vpnProtocols");
                writer.WriteStartArray();
                foreach (var item in VpnProtocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VpnAuthenticationTypes))
            {
                writer.WritePropertyName("vpnAuthenticationTypes");
                writer.WriteStartArray();
                foreach (var item in VpnAuthenticationTypes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VpnClientRootCertificates))
            {
                writer.WritePropertyName("vpnClientRootCertificates");
                writer.WriteStartArray();
                foreach (var item in VpnClientRootCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VpnClientRevokedCertificates))
            {
                writer.WritePropertyName("vpnClientRevokedCertificates");
                writer.WriteStartArray();
                foreach (var item in VpnClientRevokedCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RadiusServerRootCertificates))
            {
                writer.WritePropertyName("radiusServerRootCertificates");
                writer.WriteStartArray();
                foreach (var item in RadiusServerRootCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RadiusClientRootCertificates))
            {
                writer.WritePropertyName("radiusClientRootCertificates");
                writer.WriteStartArray();
                foreach (var item in RadiusClientRootCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VpnClientIpsecPolicies))
            {
                writer.WritePropertyName("vpnClientIpsecPolicies");
                writer.WriteStartArray();
                foreach (var item in VpnClientIpsecPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RadiusServerAddress))
            {
                writer.WritePropertyName("radiusServerAddress");
                writer.WriteStringValue(RadiusServerAddress);
            }
            if (Optional.IsDefined(RadiusServerSecret))
            {
                writer.WritePropertyName("radiusServerSecret");
                writer.WriteStringValue(RadiusServerSecret);
            }
            if (Optional.IsCollectionDefined(RadiusServers))
            {
                writer.WritePropertyName("radiusServers");
                writer.WriteStartArray();
                foreach (var item in RadiusServers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AadAuthenticationParameters))
            {
                writer.WritePropertyName("aadAuthenticationParameters");
                writer.WriteObjectValue(AadAuthenticationParameters);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsCollectionDefined(P2SVpnGateways))
            {
                writer.WritePropertyName("p2SVpnGateways");
                writer.WriteStartArray();
                foreach (var item in P2SVpnGateways)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EtagPropertiesEtag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(EtagPropertiesEtag);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VpnServerConfiguration DeserializeVpnServerConfiguration(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> name0 = default;
            Optional<IList<VpnGatewayTunnelingProtocol>> vpnProtocols = default;
            Optional<IList<VpnAuthenticationType>> vpnAuthenticationTypes = default;
            Optional<IList<VpnServerConfigVpnClientRootCertificate>> vpnClientRootCertificates = default;
            Optional<IList<VpnServerConfigVpnClientRevokedCertificate>> vpnClientRevokedCertificates = default;
            Optional<IList<VpnServerConfigRadiusServerRootCertificate>> radiusServerRootCertificates = default;
            Optional<IList<VpnServerConfigRadiusClientRootCertificate>> radiusClientRootCertificates = default;
            Optional<IList<IpsecPolicy>> vpnClientIpsecPolicies = default;
            Optional<string> radiusServerAddress = default;
            Optional<string> radiusServerSecret = default;
            Optional<IList<RadiusServer>> radiusServers = default;
            Optional<AadAuthenticationParameters> aadAuthenticationParameters = default;
            Optional<string> provisioningState = default;
            Optional<IList<P2SVpnGateway>> p2SVpnGateways = default;
            Optional<string> etag0 = default;
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
                        if (property0.NameEquals("name"))
                        {
                            name0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vpnProtocols"))
                        {
                            List<VpnGatewayTunnelingProtocol> array = new List<VpnGatewayTunnelingProtocol>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new VpnGatewayTunnelingProtocol(item.GetString()));
                            }
                            vpnProtocols = array;
                            continue;
                        }
                        if (property0.NameEquals("vpnAuthenticationTypes"))
                        {
                            List<VpnAuthenticationType> array = new List<VpnAuthenticationType>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new VpnAuthenticationType(item.GetString()));
                            }
                            vpnAuthenticationTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("vpnClientRootCertificates"))
                        {
                            List<VpnServerConfigVpnClientRootCertificate> array = new List<VpnServerConfigVpnClientRootCertificate>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnServerConfigVpnClientRootCertificate.DeserializeVpnServerConfigVpnClientRootCertificate(item));
                            }
                            vpnClientRootCertificates = array;
                            continue;
                        }
                        if (property0.NameEquals("vpnClientRevokedCertificates"))
                        {
                            List<VpnServerConfigVpnClientRevokedCertificate> array = new List<VpnServerConfigVpnClientRevokedCertificate>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnServerConfigVpnClientRevokedCertificate.DeserializeVpnServerConfigVpnClientRevokedCertificate(item));
                            }
                            vpnClientRevokedCertificates = array;
                            continue;
                        }
                        if (property0.NameEquals("radiusServerRootCertificates"))
                        {
                            List<VpnServerConfigRadiusServerRootCertificate> array = new List<VpnServerConfigRadiusServerRootCertificate>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnServerConfigRadiusServerRootCertificate.DeserializeVpnServerConfigRadiusServerRootCertificate(item));
                            }
                            radiusServerRootCertificates = array;
                            continue;
                        }
                        if (property0.NameEquals("radiusClientRootCertificates"))
                        {
                            List<VpnServerConfigRadiusClientRootCertificate> array = new List<VpnServerConfigRadiusClientRootCertificate>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnServerConfigRadiusClientRootCertificate.DeserializeVpnServerConfigRadiusClientRootCertificate(item));
                            }
                            radiusClientRootCertificates = array;
                            continue;
                        }
                        if (property0.NameEquals("vpnClientIpsecPolicies"))
                        {
                            List<IpsecPolicy> array = new List<IpsecPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IpsecPolicy.DeserializeIpsecPolicy(item));
                            }
                            vpnClientIpsecPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("radiusServerAddress"))
                        {
                            radiusServerAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("radiusServerSecret"))
                        {
                            radiusServerSecret = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("radiusServers"))
                        {
                            List<RadiusServer> array = new List<RadiusServer>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RadiusServer.DeserializeRadiusServer(item));
                            }
                            radiusServers = array;
                            continue;
                        }
                        if (property0.NameEquals("aadAuthenticationParameters"))
                        {
                            aadAuthenticationParameters = AadAuthenticationParameters.DeserializeAadAuthenticationParameters(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("p2SVpnGateways"))
                        {
                            List<P2SVpnGateway> array = new List<P2SVpnGateway>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(P2SVpnGateway.DeserializeP2SVpnGateway(item));
                            }
                            p2SVpnGateways = array;
                            continue;
                        }
                        if (property0.NameEquals("etag"))
                        {
                            etag0 = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VpnServerConfiguration(id.Value, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), etag.Value, name0.Value, Optional.ToList(vpnProtocols), Optional.ToList(vpnAuthenticationTypes), Optional.ToList(vpnClientRootCertificates), Optional.ToList(vpnClientRevokedCertificates), Optional.ToList(radiusServerRootCertificates), Optional.ToList(radiusClientRootCertificates), Optional.ToList(vpnClientIpsecPolicies), radiusServerAddress.Value, radiusServerSecret.Value, Optional.ToList(radiusServers), aadAuthenticationParameters.Value, provisioningState.Value, Optional.ToList(p2SVpnGateways), etag0.Value);
        }
    }
}
