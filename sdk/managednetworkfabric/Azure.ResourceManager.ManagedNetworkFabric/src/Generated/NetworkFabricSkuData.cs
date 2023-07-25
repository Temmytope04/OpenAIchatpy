// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing the NetworkFabricSku data model.
    /// The NetworkFabricSku resource definition.
    /// </summary>
    public partial class NetworkFabricSkuData : ResourceData
    {
        /// <summary> Initializes a new instance of NetworkFabricSkuData. </summary>
        public NetworkFabricSkuData()
        {
        }

        /// <summary> Initializes a new instance of NetworkFabricSkuData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="typePropertiesType"> Type of Network Fabric Sku. </param>
        /// <param name="maxComputeRacks"> Maximum number of compute racks available for this Network Fabric SKU. </param>
        /// <param name="minSupportedVer"> Minimum supported version. </param>
        /// <param name="maxSupportedVer"> Maximum supported version. </param>
        /// <param name="detailsUri"> The URI gives full details of sku. </param>
        /// <param name="provisioningState"> Gets the provisioning state of the resource. </param>
        internal NetworkFabricSkuData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string typePropertiesType, int? maxComputeRacks, string minSupportedVer, string maxSupportedVer, Uri detailsUri, ProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            TypePropertiesType = typePropertiesType;
            MaxComputeRacks = maxComputeRacks;
            MinSupportedVer = minSupportedVer;
            MaxSupportedVer = maxSupportedVer;
            DetailsUri = detailsUri;
            ProvisioningState = provisioningState;
        }

        /// <summary> Type of Network Fabric Sku. </summary>
        public string TypePropertiesType { get; }
        /// <summary> Maximum number of compute racks available for this Network Fabric SKU. </summary>
        public int? MaxComputeRacks { get; set; }
        /// <summary> Minimum supported version. </summary>
        public string MinSupportedVer { get; }
        /// <summary> Maximum supported version. </summary>
        public string MaxSupportedVer { get; }
        /// <summary> The URI gives full details of sku. </summary>
        public Uri DetailsUri { get; }
        /// <summary> Gets the provisioning state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
