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
    /// <summary> A class representing the LoadBalancingRule data model. </summary>
    public partial class LoadBalancingRuleData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of LoadBalancingRuleData. </summary>
        public LoadBalancingRuleData()
        {
            BackendAddressPools = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of LoadBalancingRuleData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="frontendIPConfiguration"> A reference to frontend IP addresses. </param>
        /// <param name="backendAddressPool"> A reference to a pool of DIPs. Inbound traffic is randomly load balanced across IPs in the backend IPs. </param>
        /// <param name="backendAddressPools"> An array of references to pool of DIPs. </param>
        /// <param name="probe"> The reference to the load balancer probe used by the load balancing rule. </param>
        /// <param name="protocol"> The reference to the transport protocol used by the load balancing rule. </param>
        /// <param name="loadDistribution"> The load distribution policy for this rule. </param>
        /// <param name="frontendPort"> The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values are between 0 and 65534. Note that value 0 enables &quot;Any Port&quot;. </param>
        /// <param name="backendPort"> The port used for internal connections on the endpoint. Acceptable values are between 0 and 65535. Note that value 0 enables &quot;Any Port&quot;. </param>
        /// <param name="idleTimeoutInMinutes"> The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP. </param>
        /// <param name="enableFloatingIP"> Configures a virtual machine&apos;s endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can&apos;t be changed after you create the endpoint. </param>
        /// <param name="enableTcpReset"> Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP. </param>
        /// <param name="disableOutboundSnat"> Configures SNAT for the VMs in the backend pool to use the publicIP address specified in the frontend of the load balancing rule. </param>
        /// <param name="provisioningState"> The provisioning state of the load balancing rule resource. </param>
        internal LoadBalancingRuleData(ResourceIdentifier id, string name, ResourceType? resourceType, string etag, WritableSubResource frontendIPConfiguration, WritableSubResource backendAddressPool, IList<WritableSubResource> backendAddressPools, WritableSubResource probe, TransportProtocol? protocol, LoadDistribution? loadDistribution, int? frontendPort, int? backendPort, int? idleTimeoutInMinutes, bool? enableFloatingIP, bool? enableTcpReset, bool? disableOutboundSnat, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            Etag = etag;
            FrontendIPConfiguration = frontendIPConfiguration;
            BackendAddressPool = backendAddressPool;
            BackendAddressPools = backendAddressPools;
            Probe = probe;
            Protocol = protocol;
            LoadDistribution = loadDistribution;
            FrontendPort = frontendPort;
            BackendPort = backendPort;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            EnableFloatingIP = enableFloatingIP;
            EnableTcpReset = enableTcpReset;
            DisableOutboundSnat = disableOutboundSnat;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> A reference to frontend IP addresses. </summary>
        internal WritableSubResource FrontendIPConfiguration { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier FrontendIPConfigurationId
        {
            get => FrontendIPConfiguration is null ? default : FrontendIPConfiguration.Id;
            set
            {
                if (FrontendIPConfiguration is null)
                    FrontendIPConfiguration = new WritableSubResource();
                FrontendIPConfiguration.Id = value;
            }
        }

        /// <summary> A reference to a pool of DIPs. Inbound traffic is randomly load balanced across IPs in the backend IPs. </summary>
        internal WritableSubResource BackendAddressPool { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier BackendAddressPoolId
        {
            get => BackendAddressPool is null ? default : BackendAddressPool.Id;
            set
            {
                if (BackendAddressPool is null)
                    BackendAddressPool = new WritableSubResource();
                BackendAddressPool.Id = value;
            }
        }

        /// <summary> An array of references to pool of DIPs. </summary>
        public IList<WritableSubResource> BackendAddressPools { get; }
        /// <summary> The reference to the load balancer probe used by the load balancing rule. </summary>
        internal WritableSubResource Probe { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier ProbeId
        {
            get => Probe is null ? default : Probe.Id;
            set
            {
                if (Probe is null)
                    Probe = new WritableSubResource();
                Probe.Id = value;
            }
        }

        /// <summary> The reference to the transport protocol used by the load balancing rule. </summary>
        public TransportProtocol? Protocol { get; set; }
        /// <summary> The load distribution policy for this rule. </summary>
        public LoadDistribution? LoadDistribution { get; set; }
        /// <summary> The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values are between 0 and 65534. Note that value 0 enables &quot;Any Port&quot;. </summary>
        public int? FrontendPort { get; set; }
        /// <summary> The port used for internal connections on the endpoint. Acceptable values are between 0 and 65535. Note that value 0 enables &quot;Any Port&quot;. </summary>
        public int? BackendPort { get; set; }
        /// <summary> The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP. </summary>
        public int? IdleTimeoutInMinutes { get; set; }
        /// <summary> Configures a virtual machine&apos;s endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can&apos;t be changed after you create the endpoint. </summary>
        public bool? EnableFloatingIP { get; set; }
        /// <summary> Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP. </summary>
        public bool? EnableTcpReset { get; set; }
        /// <summary> Configures SNAT for the VMs in the backend pool to use the publicIP address specified in the frontend of the load balancing rule. </summary>
        public bool? DisableOutboundSnat { get; set; }
        /// <summary> The provisioning state of the load balancing rule resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
