// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EdgeMarketplace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EdgeMarketplace
{
    /// <summary>
    /// A class representing the Offer data model.
    /// An offer.
    /// </summary>
    public partial class OfferData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="OfferData"/>. </summary>
        internal OfferData()
        {
            MarketplaceSkus = new ChangeTrackingList<MarketplaceSku>();
        }

        /// <summary> Initializes a new instance of <see cref="OfferData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="contentVersion"> The content version. </param>
        /// <param name="contentUri"> The content url. </param>
        /// <param name="offerContent"> The offer content. </param>
        /// <param name="provisioningState"> The resource provisioning state. </param>
        /// <param name="marketplaceSkus"> The marketplace skus. </param>
        internal OfferData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string contentVersion, Uri contentUri, OfferContent offerContent, ResourceProvisioningState? provisioningState, IReadOnlyList<MarketplaceSku> marketplaceSkus) : base(id, name, resourceType, systemData)
        {
            ContentVersion = contentVersion;
            ContentUri = contentUri;
            OfferContent = offerContent;
            ProvisioningState = provisioningState;
            MarketplaceSkus = marketplaceSkus;
        }

        /// <summary> The content version. </summary>
        public string ContentVersion { get; }
        /// <summary> The content url. </summary>
        public Uri ContentUri { get; }
        /// <summary> The offer content. </summary>
        public OfferContent OfferContent { get; }
        /// <summary> The resource provisioning state. </summary>
        public ResourceProvisioningState? ProvisioningState { get; }
        /// <summary> The marketplace skus. </summary>
        public IReadOnlyList<MarketplaceSku> MarketplaceSkus { get; }
    }
}
