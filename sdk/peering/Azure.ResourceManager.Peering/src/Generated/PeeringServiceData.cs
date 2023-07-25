// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Peering.Models;

namespace Azure.ResourceManager.Peering
{
    /// <summary>
    /// A class representing the PeeringService data model.
    /// Peering Service
    /// </summary>
    public partial class PeeringServiceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of PeeringServiceData. </summary>
        /// <param name="location"> The location. </param>
        public PeeringServiceData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of PeeringServiceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The SKU that defines the type of the peering service. </param>
        /// <param name="peeringServiceLocation"> The location (state/province) of the customer. </param>
        /// <param name="peeringServiceProvider"> The name of the service provider. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="providerPrimaryPeeringLocation"> The primary peering (Microsoft/service provider) location to be used for customer traffic. </param>
        /// <param name="providerBackupPeeringLocation"> The backup peering (Microsoft/service provider) location to be used for customer traffic. </param>
        /// <param name="logAnalyticsWorkspaceProperties"> The Log Analytics Workspace Properties. </param>
        internal PeeringServiceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, PeeringServiceSku sku, string peeringServiceLocation, string peeringServiceProvider, PeeringProvisioningState? provisioningState, string providerPrimaryPeeringLocation, string providerBackupPeeringLocation, PeeringLogAnalyticsWorkspaceProperties logAnalyticsWorkspaceProperties) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            PeeringServiceLocation = peeringServiceLocation;
            PeeringServiceProvider = peeringServiceProvider;
            ProvisioningState = provisioningState;
            ProviderPrimaryPeeringLocation = providerPrimaryPeeringLocation;
            ProviderBackupPeeringLocation = providerBackupPeeringLocation;
            LogAnalyticsWorkspaceProperties = logAnalyticsWorkspaceProperties;
        }

        /// <summary> The SKU that defines the type of the peering service. </summary>
        internal PeeringServiceSku Sku { get; set; }
        /// <summary> The name of the peering service SKU. </summary>
        public string SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set
            {
                if (Sku is null)
                    Sku = new PeeringServiceSku();
                Sku.Name = value;
            }
        }

        /// <summary> The location (state/province) of the customer. </summary>
        public string PeeringServiceLocation { get; set; }
        /// <summary> The name of the service provider. </summary>
        public string PeeringServiceProvider { get; set; }
        /// <summary> The provisioning state of the resource. </summary>
        public PeeringProvisioningState? ProvisioningState { get; }
        /// <summary> The primary peering (Microsoft/service provider) location to be used for customer traffic. </summary>
        public string ProviderPrimaryPeeringLocation { get; set; }
        /// <summary> The backup peering (Microsoft/service provider) location to be used for customer traffic. </summary>
        public string ProviderBackupPeeringLocation { get; set; }
        /// <summary> The Log Analytics Workspace Properties. </summary>
        public PeeringLogAnalyticsWorkspaceProperties LogAnalyticsWorkspaceProperties { get; set; }
    }
}
