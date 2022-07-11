// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerRegistry.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary> A class representing the AgentPool data model. </summary>
    public partial class AgentPoolData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of AgentPoolData. </summary>
        /// <param name="location"> The location. </param>
        public AgentPoolData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of AgentPoolData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="count"> The count of agent machine. </param>
        /// <param name="tier"> The Tier of agent machine. </param>
        /// <param name="os"> The OS of agent machine. </param>
        /// <param name="virtualNetworkSubnetResourceId"> The Virtual Network Subnet Resource Id of the agent machine. </param>
        /// <param name="provisioningState"> The provisioning state of this agent pool. </param>
        internal AgentPoolData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, int? count, string tier, O? os, string virtualNetworkSubnetResourceId, ProvisioningState? provisioningState) : base(id, name, resourceType, systemData, tags, location)
        {
            Count = count;
            Tier = tier;
            OS = os;
            VirtualNetworkSubnetResourceId = virtualNetworkSubnetResourceId;
            ProvisioningState = provisioningState;
        }

        /// <summary> The count of agent machine. </summary>
        public int? Count { get; set; }
        /// <summary> The Tier of agent machine. </summary>
        public string Tier { get; set; }
        /// <summary> The OS of agent machine. </summary>
        public O? OS { get; set; }
        /// <summary> The Virtual Network Subnet Resource Id of the agent machine. </summary>
        public string VirtualNetworkSubnetResourceId { get; set; }
        /// <summary> The provisioning state of this agent pool. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
