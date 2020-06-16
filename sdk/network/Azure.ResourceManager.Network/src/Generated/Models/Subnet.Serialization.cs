// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class Subnet : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
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
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (AddressPrefix != null)
            {
                writer.WritePropertyName("addressPrefix");
                writer.WriteStringValue(AddressPrefix);
            }
            if (AddressPrefixes != null)
            {
                writer.WritePropertyName("addressPrefixes");
                writer.WriteStartArray();
                foreach (var item in AddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (NetworkSecurityGroup != null)
            {
                writer.WritePropertyName("networkSecurityGroup");
                writer.WriteObjectValue(NetworkSecurityGroup);
            }
            if (RouteTable != null)
            {
                writer.WritePropertyName("routeTable");
                writer.WriteObjectValue(RouteTable);
            }
            if (NatGateway != null)
            {
                writer.WritePropertyName("natGateway");
                writer.WriteObjectValue(NatGateway);
            }
            if (ServiceEndpoints != null)
            {
                writer.WritePropertyName("serviceEndpoints");
                writer.WriteStartArray();
                foreach (var item in ServiceEndpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ServiceEndpointPolicies != null)
            {
                writer.WritePropertyName("serviceEndpointPolicies");
                writer.WriteStartArray();
                foreach (var item in ServiceEndpointPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (PrivateEndpoints != null)
            {
                writer.WritePropertyName("privateEndpoints");
                writer.WriteStartArray();
                foreach (var item in PrivateEndpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
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
            if (IpConfigurationProfiles != null)
            {
                writer.WritePropertyName("ipConfigurationProfiles");
                writer.WriteStartArray();
                foreach (var item in IpConfigurationProfiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (IpAllocations != null)
            {
                writer.WritePropertyName("ipAllocations");
                writer.WriteStartArray();
                foreach (var item in IpAllocations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ResourceNavigationLinks != null)
            {
                writer.WritePropertyName("resourceNavigationLinks");
                writer.WriteStartArray();
                foreach (var item in ResourceNavigationLinks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ServiceAssociationLinks != null)
            {
                writer.WritePropertyName("serviceAssociationLinks");
                writer.WriteStartArray();
                foreach (var item in ServiceAssociationLinks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Delegations != null)
            {
                writer.WritePropertyName("delegations");
                writer.WriteStartArray();
                foreach (var item in Delegations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Purpose != null)
            {
                writer.WritePropertyName("purpose");
                writer.WriteStringValue(Purpose);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (PrivateEndpointNetworkPolicies != null)
            {
                writer.WritePropertyName("privateEndpointNetworkPolicies");
                writer.WriteStringValue(PrivateEndpointNetworkPolicies);
            }
            if (PrivateLinkServiceNetworkPolicies != null)
            {
                writer.WritePropertyName("privateLinkServiceNetworkPolicies");
                writer.WriteStringValue(PrivateLinkServiceNetworkPolicies);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static Subnet DeserializeSubnet(JsonElement element)
        {
            string name = default;
            string etag = default;
            string id = default;
            string addressPrefix = default;
            IList<string> addressPrefixes = default;
            NetworkSecurityGroup networkSecurityGroup = default;
            RouteTable routeTable = default;
            SubResource natGateway = default;
            IList<ServiceEndpointPropertiesFormat> serviceEndpoints = default;
            IList<ServiceEndpointPolicy> serviceEndpointPolicies = default;
            IList<PrivateEndpoint> privateEndpoints = default;
            IList<IPConfiguration> ipConfigurations = default;
            IList<IPConfigurationProfile> ipConfigurationProfiles = default;
            IList<SubResource> ipAllocations = default;
            IList<ResourceNavigationLink> resourceNavigationLinks = default;
            IList<ServiceAssociationLink> serviceAssociationLinks = default;
            IList<Delegation> delegations = default;
            string purpose = default;
            ProvisioningState? provisioningState = default;
            string privateEndpointNetworkPolicies = default;
            string privateLinkServiceNetworkPolicies = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
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
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("addressPrefix"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            addressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("addressPrefixes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(item.GetString());
                                }
                            }
                            addressPrefixes = array;
                            continue;
                        }
                        if (property0.NameEquals("networkSecurityGroup"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkSecurityGroup = NetworkSecurityGroup.DeserializeNetworkSecurityGroup(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("routeTable"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routeTable = RouteTable.DeserializeRouteTable(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("natGateway"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            natGateway = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("serviceEndpoints"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ServiceEndpointPropertiesFormat> array = new List<ServiceEndpointPropertiesFormat>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(ServiceEndpointPropertiesFormat.DeserializeServiceEndpointPropertiesFormat(item));
                                }
                            }
                            serviceEndpoints = array;
                            continue;
                        }
                        if (property0.NameEquals("serviceEndpointPolicies"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ServiceEndpointPolicy> array = new List<ServiceEndpointPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(ServiceEndpointPolicy.DeserializeServiceEndpointPolicy(item));
                                }
                            }
                            serviceEndpointPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("privateEndpoints"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PrivateEndpoint> array = new List<PrivateEndpoint>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(PrivateEndpoint.DeserializePrivateEndpoint(item));
                                }
                            }
                            privateEndpoints = array;
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IPConfiguration> array = new List<IPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(IPConfiguration.DeserializeIPConfiguration(item));
                                }
                            }
                            ipConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurationProfiles"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IPConfigurationProfile> array = new List<IPConfigurationProfile>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(IPConfigurationProfile.DeserializeIPConfigurationProfile(item));
                                }
                            }
                            ipConfigurationProfiles = array;
                            continue;
                        }
                        if (property0.NameEquals("ipAllocations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(DeserializeSubResource(item));
                                }
                            }
                            ipAllocations = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceNavigationLinks"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceNavigationLink> array = new List<ResourceNavigationLink>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(ResourceNavigationLink.DeserializeResourceNavigationLink(item));
                                }
                            }
                            resourceNavigationLinks = array;
                            continue;
                        }
                        if (property0.NameEquals("serviceAssociationLinks"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ServiceAssociationLink> array = new List<ServiceAssociationLink>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(ServiceAssociationLink.DeserializeServiceAssociationLink(item));
                                }
                            }
                            serviceAssociationLinks = array;
                            continue;
                        }
                        if (property0.NameEquals("delegations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<Delegation> array = new List<Delegation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(Delegation.DeserializeDelegation(item));
                                }
                            }
                            delegations = array;
                            continue;
                        }
                        if (property0.NameEquals("purpose"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            purpose = property0.Value.GetString();
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
                        if (property0.NameEquals("privateEndpointNetworkPolicies"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateEndpointNetworkPolicies = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateLinkServiceNetworkPolicies"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateLinkServiceNetworkPolicies = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new Subnet(id, name, etag, addressPrefix, addressPrefixes, networkSecurityGroup, routeTable, natGateway, serviceEndpoints, serviceEndpointPolicies, privateEndpoints, ipConfigurations, ipConfigurationProfiles, ipAllocations, resourceNavigationLinks, serviceAssociationLinks, delegations, purpose, provisioningState, privateEndpointNetworkPolicies, privateLinkServiceNetworkPolicies);
        }
    }
}
