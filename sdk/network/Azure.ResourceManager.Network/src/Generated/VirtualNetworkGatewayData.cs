// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the VirtualNetworkGateway data model. </summary>
    public partial class VirtualNetworkGatewayData : Resource
    {
        /// <summary> Initializes a new instance of VirtualNetworkGatewayData. </summary>
        public VirtualNetworkGatewayData()
        {
            IpConfigurations = new ChangeTrackingList<VirtualNetworkGatewayIPConfiguration>();
            NatRules = new ChangeTrackingList<VirtualNetworkGatewayNatRuleData>();
        }

        /// <summary> Initializes a new instance of VirtualNetworkGatewayData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="extendedLocation"> The extended location of type local virtual network gateway. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="ipConfigurations"> IP configurations for virtual network gateway. </param>
        /// <param name="gatewayType"> The type of this virtual network gateway. </param>
        /// <param name="vpnType"> The type of this virtual network gateway. </param>
        /// <param name="vpnGatewayGeneration"> The generation for this VirtualNetworkGateway. Must be None if gatewayType is not VPN. </param>
        /// <param name="enableBgp"> Whether BGP is enabled for this virtual network gateway or not. </param>
        /// <param name="enablePrivateIpAddress"> Whether private IP needs to be enabled on this gateway for connections or not. </param>
        /// <param name="active"> ActiveActive flag. </param>
        /// <param name="gatewayDefaultSite"> The reference to the LocalNetworkGateway resource which represents local network site having default routes. Assign Null value in case of removing existing default site setting. </param>
        /// <param name="sku"> The reference to the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network gateway. </param>
        /// <param name="vpnClientConfiguration"> The reference to the VpnClientConfiguration resource which represents the P2S VpnClient configurations. </param>
        /// <param name="bgpSettings"> Virtual network gateway&apos;s BGP speaker settings. </param>
        /// <param name="customRoutes"> The reference to the address space resource which represents the custom routes address space specified by the customer for virtual network gateway and VpnClient. </param>
        /// <param name="resourceGuid"> The resource GUID property of the virtual network gateway resource. </param>
        /// <param name="provisioningState"> The provisioning state of the virtual network gateway resource. </param>
        /// <param name="enableDnsForwarding"> Whether dns forwarding is enabled or not. </param>
        /// <param name="inboundDnsForwardingEndpoint"> The IP address allocated by the gateway to which dns requests can be sent. </param>
        /// <param name="vNetExtendedLocationResourceId"> Customer vnet resource id. VirtualNetworkGateway of type local gateway is associated with the customer vnet. </param>
        /// <param name="natRules"> NatRules for virtual network gateway. </param>
        /// <param name="enableBgpRouteTranslationForNat"> EnableBgpRouteTranslationForNat flag. </param>
        internal VirtualNetworkGatewayData(string id, string name, string type, string location, IDictionary<string, string> tags, ExtendedLocation extendedLocation, string etag, IList<VirtualNetworkGatewayIPConfiguration> ipConfigurations, VirtualNetworkGatewayType? gatewayType, VpnType? vpnType, VpnGatewayGeneration? vpnGatewayGeneration, bool? enableBgp, bool? enablePrivateIpAddress, bool? active, WritableSubResource gatewayDefaultSite, VirtualNetworkGatewaySku sku, VpnClientConfiguration vpnClientConfiguration, BgpSettings bgpSettings, AddressSpace customRoutes, string resourceGuid, ProvisioningState? provisioningState, bool? enableDnsForwarding, string inboundDnsForwardingEndpoint, string vNetExtendedLocationResourceId, IList<VirtualNetworkGatewayNatRuleData> natRules, bool? enableBgpRouteTranslationForNat) : base(id, name, type, location, tags)
        {
            ExtendedLocation = extendedLocation;
            Etag = etag;
            IpConfigurations = ipConfigurations;
            GatewayType = gatewayType;
            VpnType = vpnType;
            VpnGatewayGeneration = vpnGatewayGeneration;
            EnableBgp = enableBgp;
            EnablePrivateIpAddress = enablePrivateIpAddress;
            Active = active;
            GatewayDefaultSite = gatewayDefaultSite;
            Sku = sku;
            VpnClientConfiguration = vpnClientConfiguration;
            BgpSettings = bgpSettings;
            CustomRoutes = customRoutes;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            EnableDnsForwarding = enableDnsForwarding;
            InboundDnsForwardingEndpoint = inboundDnsForwardingEndpoint;
            VNetExtendedLocationResourceId = vNetExtendedLocationResourceId;
            NatRules = natRules;
            EnableBgpRouteTranslationForNat = enableBgpRouteTranslationForNat;
        }

        /// <summary> The extended location of type local virtual network gateway. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> IP configurations for virtual network gateway. </summary>
        public IList<VirtualNetworkGatewayIPConfiguration> IpConfigurations { get; }
        /// <summary> The type of this virtual network gateway. </summary>
        public VirtualNetworkGatewayType? GatewayType { get; set; }
        /// <summary> The type of this virtual network gateway. </summary>
        public VpnType? VpnType { get; set; }
        /// <summary> The generation for this VirtualNetworkGateway. Must be None if gatewayType is not VPN. </summary>
        public VpnGatewayGeneration? VpnGatewayGeneration { get; set; }
        /// <summary> Whether BGP is enabled for this virtual network gateway or not. </summary>
        public bool? EnableBgp { get; set; }
        /// <summary> Whether private IP needs to be enabled on this gateway for connections or not. </summary>
        public bool? EnablePrivateIpAddress { get; set; }
        /// <summary> ActiveActive flag. </summary>
        public bool? Active { get; set; }
        /// <summary> The reference to the LocalNetworkGateway resource which represents local network site having default routes. Assign Null value in case of removing existing default site setting. </summary>
        public WritableSubResource GatewayDefaultSite { get; set; }
        /// <summary> The reference to the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network gateway. </summary>
        public VirtualNetworkGatewaySku Sku { get; set; }
        /// <summary> The reference to the VpnClientConfiguration resource which represents the P2S VpnClient configurations. </summary>
        public VpnClientConfiguration VpnClientConfiguration { get; set; }
        /// <summary> Virtual network gateway&apos;s BGP speaker settings. </summary>
        public BgpSettings BgpSettings { get; set; }
        /// <summary> The reference to the address space resource which represents the custom routes address space specified by the customer for virtual network gateway and VpnClient. </summary>
        public AddressSpace CustomRoutes { get; set; }
        /// <summary> The resource GUID property of the virtual network gateway resource. </summary>
        public string ResourceGuid { get; }
        /// <summary> The provisioning state of the virtual network gateway resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Whether dns forwarding is enabled or not. </summary>
        public bool? EnableDnsForwarding { get; set; }
        /// <summary> The IP address allocated by the gateway to which dns requests can be sent. </summary>
        public string InboundDnsForwardingEndpoint { get; }
        /// <summary> Customer vnet resource id. VirtualNetworkGateway of type local gateway is associated with the customer vnet. </summary>
        public string VNetExtendedLocationResourceId { get; set; }
        /// <summary> NatRules for virtual network gateway. </summary>
        public IList<VirtualNetworkGatewayNatRuleData> NatRules { get; }
        /// <summary> EnableBgpRouteTranslationForNat flag. </summary>
        public bool? EnableBgpRouteTranslationForNat { get; set; }
    }
}
