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
    /// <summary> A class representing the OutboundRule data model. </summary>
    public partial class OutboundRuleData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of OutboundRuleData. </summary>
        public OutboundRuleData()
        {
            FrontendIPConfigurations = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of OutboundRuleData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="allocatedOutboundPorts"> The number of outbound ports to be used for NAT. </param>
        /// <param name="frontendIPConfigurations"> The Frontend IP addresses of the load balancer. </param>
        /// <param name="backendAddressPool"> A reference to a pool of DIPs. Outbound traffic is randomly load balanced across IPs in the backend IPs. </param>
        /// <param name="provisioningState"> The provisioning state of the outbound rule resource. </param>
        /// <param name="protocol"> The protocol for the outbound rule in load balancer. </param>
        /// <param name="enableTcpReset"> Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP. </param>
        /// <param name="idleTimeoutInMinutes"> The timeout for the TCP idle connection. </param>
        internal OutboundRuleData(ResourceIdentifier id, string name, ResourceType? resourceType, string etag, int? allocatedOutboundPorts, IList<WritableSubResource> frontendIPConfigurations, WritableSubResource backendAddressPool, NetworkProvisioningState? provisioningState, LoadBalancerOutboundRuleProtocol? protocol, bool? enableTcpReset, int? idleTimeoutInMinutes) : base(id, name, resourceType)
        {
            Etag = etag;
            AllocatedOutboundPorts = allocatedOutboundPorts;
            FrontendIPConfigurations = frontendIPConfigurations;
            BackendAddressPool = backendAddressPool;
            ProvisioningState = provisioningState;
            Protocol = protocol;
            EnableTcpReset = enableTcpReset;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The number of outbound ports to be used for NAT. </summary>
        public int? AllocatedOutboundPorts { get; set; }
        /// <summary> The Frontend IP addresses of the load balancer. </summary>
        public IList<WritableSubResource> FrontendIPConfigurations { get; }
        /// <summary> A reference to a pool of DIPs. Outbound traffic is randomly load balanced across IPs in the backend IPs. </summary>
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

        /// <summary> The provisioning state of the outbound rule resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The protocol for the outbound rule in load balancer. </summary>
        public LoadBalancerOutboundRuleProtocol? Protocol { get; set; }
        /// <summary> Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP. </summary>
        public bool? EnableTcpReset { get; set; }
        /// <summary> The timeout for the TCP idle connection. </summary>
        public int? IdleTimeoutInMinutes { get; set; }
    }
}
