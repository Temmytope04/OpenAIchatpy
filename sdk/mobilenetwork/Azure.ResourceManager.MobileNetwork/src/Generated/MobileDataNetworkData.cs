// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing the MobileDataNetwork data model.
    /// Data network resource. Must be created in the same location as its parent mobile network.
    /// </summary>
    public partial class MobileDataNetworkData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="MobileDataNetworkData"/>. </summary>
        /// <param name="location"> The location. </param>
        public MobileDataNetworkData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="MobileDataNetworkData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The provisioning state of the data network resource. </param>
        /// <param name="description"> An optional description for this data network. </param>
        internal MobileDataNetworkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, MobileNetworkProvisioningState? provisioningState, string description) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            Description = description;
        }

        /// <summary> The provisioning state of the data network resource. </summary>
        public MobileNetworkProvisioningState? ProvisioningState { get; }
        /// <summary> An optional description for this data network. </summary>
        public string Description { get; set; }
    }
}
