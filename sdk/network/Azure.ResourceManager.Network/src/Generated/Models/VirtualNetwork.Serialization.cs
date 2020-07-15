// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VirtualNetwork : IUtf8JsonSerializable
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
            if (Optional.IsDefined(AddressSpace))
            {
                writer.WritePropertyName("addressSpace");
                writer.WriteObjectValue(AddressSpace);
            }
            if (Optional.IsDefined(DhcpOptions))
            {
                writer.WritePropertyName("dhcpOptions");
                writer.WriteObjectValue(DhcpOptions);
            }
            if (Optional.IsCollectionDefined(Subnets))
            {
                writer.WritePropertyName("subnets");
                writer.WriteStartArray();
                foreach (var item in Subnets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VirtualNetworkPeerings))
            {
                writer.WritePropertyName("virtualNetworkPeerings");
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkPeerings)
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
            if (Optional.IsDefined(EnableDdosProtection))
            {
                writer.WritePropertyName("enableDdosProtection");
                writer.WriteBooleanValue(EnableDdosProtection.Value);
            }
            if (Optional.IsDefined(EnableVmProtection))
            {
                writer.WritePropertyName("enableVmProtection");
                writer.WriteBooleanValue(EnableVmProtection.Value);
            }
            if (Optional.IsDefined(DdosProtectionPlan))
            {
                writer.WritePropertyName("ddosProtectionPlan");
                writer.WriteObjectValue(DdosProtectionPlan);
            }
            if (Optional.IsDefined(BgpCommunities))
            {
                writer.WritePropertyName("bgpCommunities");
                writer.WriteObjectValue(BgpCommunities);
            }
            if (Optional.IsCollectionDefined(IpAllocations))
            {
                writer.WritePropertyName("ipAllocations");
                writer.WriteStartArray();
                foreach (var item in IpAllocations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualNetwork DeserializeVirtualNetwork(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<AddressSpace> addressSpace = default;
            Optional<DhcpOptions> dhcpOptions = default;
            Optional<IList<Subnet>> subnets = default;
            Optional<IList<VirtualNetworkPeering>> virtualNetworkPeerings = default;
            Optional<string> resourceGuid = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<bool> enableDdosProtection = default;
            Optional<bool> enableVmProtection = default;
            Optional<SubResource> ddosProtectionPlan = default;
            Optional<VirtualNetworkBgpCommunities> bgpCommunities = default;
            Optional<IList<SubResource>> ipAllocations = default;
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
                        if (property0.NameEquals("addressSpace"))
                        {
                            addressSpace = AddressSpace.DeserializeAddressSpace(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dhcpOptions"))
                        {
                            dhcpOptions = DhcpOptions.DeserializeDhcpOptions(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("subnets"))
                        {
                            List<Subnet> array = new List<Subnet>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Subnet.DeserializeSubnet(item));
                            }
                            subnets = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkPeerings"))
                        {
                            List<VirtualNetworkPeering> array = new List<VirtualNetworkPeering>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualNetworkPeering.DeserializeVirtualNetworkPeering(item));
                            }
                            virtualNetworkPeerings = array;
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
                        if (property0.NameEquals("enableDdosProtection"))
                        {
                            enableDdosProtection = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableVmProtection"))
                        {
                            enableVmProtection = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ddosProtectionPlan"))
                        {
                            ddosProtectionPlan = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("bgpCommunities"))
                        {
                            bgpCommunities = VirtualNetworkBgpCommunities.DeserializeVirtualNetworkBgpCommunities(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ipAllocations"))
                        {
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SubResource.DeserializeSubResource(item));
                            }
                            ipAllocations = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualNetwork(id.Value, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), etag.Value, addressSpace.Value, dhcpOptions.Value, Optional.ToList(subnets), Optional.ToList(virtualNetworkPeerings), resourceGuid.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(enableDdosProtection), Optional.ToNullable(enableVmProtection), ddosProtectionPlan.Value, bgpCommunities.Value, Optional.ToList(ipAllocations));
        }
    }
}
