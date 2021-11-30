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
    /// <summary> A class representing the NetworkInterface data model. </summary>
    public partial class NetworkInterfaceData : Resource
    {
        /// <summary> Initializes a new instance of NetworkInterfaceData. </summary>
        public NetworkInterfaceData()
        {
            IpConfigurations = new ChangeTrackingList<NetworkInterfaceIPConfigurationData>();
            TapConfigurations = new ChangeTrackingList<NetworkInterfaceTapConfigurationData>();
            HostedWorkloads = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of NetworkInterfaceData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="extendedLocation"> The extended location of the network interface. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="virtualMachine"> The reference to a virtual machine. </param>
        /// <param name="networkSecurityGroup"> The reference to the NetworkSecurityGroup resource. </param>
        /// <param name="privateEndpoint"> A reference to the private endpoint to which the network interface is linked. </param>
        /// <param name="ipConfigurations"> A list of IPConfigurations of the network interface. </param>
        /// <param name="tapConfigurations"> A list of TapConfigurations of the network interface. </param>
        /// <param name="dnsSettings"> The DNS settings in network interface. </param>
        /// <param name="macAddress"> The MAC address of the network interface. </param>
        /// <param name="primary"> Whether this is a primary network interface on a virtual machine. </param>
        /// <param name="enableAcceleratedNetworking"> If the network interface is accelerated networking enabled. </param>
        /// <param name="enableIPForwarding"> Indicates whether IP forwarding is enabled on this network interface. </param>
        /// <param name="hostedWorkloads"> A list of references to linked BareMetal resources. </param>
        /// <param name="dscpConfiguration"> A reference to the dscp configuration to which the network interface is linked. </param>
        /// <param name="resourceGuid"> The resource GUID property of the network interface resource. </param>
        /// <param name="provisioningState"> The provisioning state of the network interface resource. </param>
        /// <param name="workloadType"> WorkloadType of the NetworkInterface for BareMetal resources. </param>
        /// <param name="nicType"> Type of Network Interface resource. </param>
        /// <param name="privateLinkService"> Privatelinkservice of the network interface resource. </param>
        /// <param name="migrationPhase"> Migration phase of Network Interface resource. </param>
        internal NetworkInterfaceData(string id, string name, string type, string location, IDictionary<string, string> tags, ExtendedLocation extendedLocation, string etag, WritableSubResource virtualMachine, NetworkSecurityGroupData networkSecurityGroup, PrivateEndpointData privateEndpoint, IList<NetworkInterfaceIPConfigurationData> ipConfigurations, IReadOnlyList<NetworkInterfaceTapConfigurationData> tapConfigurations, NetworkInterfaceDnsSettings dnsSettings, string macAddress, bool? primary, bool? enableAcceleratedNetworking, bool? enableIPForwarding, IReadOnlyList<string> hostedWorkloads, WritableSubResource dscpConfiguration, string resourceGuid, ProvisioningState? provisioningState, string workloadType, NetworkInterfaceNicType? nicType, PrivateLinkServiceData privateLinkService, NetworkInterfaceMigrationPhase? migrationPhase) : base(id, name, type, location, tags)
        {
            ExtendedLocation = extendedLocation;
            Etag = etag;
            VirtualMachine = virtualMachine;
            NetworkSecurityGroup = networkSecurityGroup;
            PrivateEndpoint = privateEndpoint;
            IpConfigurations = ipConfigurations;
            TapConfigurations = tapConfigurations;
            DnsSettings = dnsSettings;
            MacAddress = macAddress;
            Primary = primary;
            EnableAcceleratedNetworking = enableAcceleratedNetworking;
            EnableIPForwarding = enableIPForwarding;
            HostedWorkloads = hostedWorkloads;
            DscpConfiguration = dscpConfiguration;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            WorkloadType = workloadType;
            NicType = nicType;
            PrivateLinkService = privateLinkService;
            MigrationPhase = migrationPhase;
        }

        /// <summary> The extended location of the network interface. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The reference to a virtual machine. </summary>
        public WritableSubResource VirtualMachine { get; }
        /// <summary> The reference to the NetworkSecurityGroup resource. </summary>
        public NetworkSecurityGroupData NetworkSecurityGroup { get; set; }
        /// <summary> A reference to the private endpoint to which the network interface is linked. </summary>
        public PrivateEndpointData PrivateEndpoint { get; }
        /// <summary> A list of IPConfigurations of the network interface. </summary>
        public IList<NetworkInterfaceIPConfigurationData> IpConfigurations { get; }
        /// <summary> A list of TapConfigurations of the network interface. </summary>
        public IReadOnlyList<NetworkInterfaceTapConfigurationData> TapConfigurations { get; }
        /// <summary> The DNS settings in network interface. </summary>
        public NetworkInterfaceDnsSettings DnsSettings { get; set; }
        /// <summary> The MAC address of the network interface. </summary>
        public string MacAddress { get; }
        /// <summary> Whether this is a primary network interface on a virtual machine. </summary>
        public bool? Primary { get; }
        /// <summary> If the network interface is accelerated networking enabled. </summary>
        public bool? EnableAcceleratedNetworking { get; set; }
        /// <summary> Indicates whether IP forwarding is enabled on this network interface. </summary>
        public bool? EnableIPForwarding { get; set; }
        /// <summary> A list of references to linked BareMetal resources. </summary>
        public IReadOnlyList<string> HostedWorkloads { get; }
        /// <summary> A reference to the dscp configuration to which the network interface is linked. </summary>
        public WritableSubResource DscpConfiguration { get; }
        /// <summary> The resource GUID property of the network interface resource. </summary>
        public string ResourceGuid { get; }
        /// <summary> The provisioning state of the network interface resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> WorkloadType of the NetworkInterface for BareMetal resources. </summary>
        public string WorkloadType { get; set; }
        /// <summary> Type of Network Interface resource. </summary>
        public NetworkInterfaceNicType? NicType { get; set; }
        /// <summary> Privatelinkservice of the network interface resource. </summary>
        public PrivateLinkServiceData PrivateLinkService { get; set; }
        /// <summary> Migration phase of Network Interface resource. </summary>
        public NetworkInterfaceMigrationPhase? MigrationPhase { get; set; }
    }
}
