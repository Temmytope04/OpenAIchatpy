// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Marketplace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Marketplace
{
    /// <summary>
    /// A class representing the PrivateStoreOffer data model.
    /// The privateStore offer data structure.
    /// </summary>
    public partial class PrivateStoreOfferData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="PrivateStoreOfferData"/>. </summary>
        public PrivateStoreOfferData()
        {
            SpecificPlanIdsLimitation = new ChangeTrackingList<string>();
            IconFileUris = new ChangeTrackingDictionary<string, Uri>();
            Plans = new ChangeTrackingList<PrivateStorePlan>();
        }

        /// <summary> Initializes a new instance of <see cref="PrivateStoreOfferData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="uniqueOfferId"> Offers unique id. </param>
        /// <param name="offerDisplayName"> It will be displayed prominently in the marketplace. </param>
        /// <param name="publisherDisplayName"> Publisher name that will be displayed prominently in the marketplace. </param>
        /// <param name="eTag"> Identifier for purposes of race condition. </param>
        /// <param name="privateStoreId"> Private store unique id. </param>
        /// <param name="createdOn"> Private store offer creation date. </param>
        /// <param name="modifiedOn"> Private store offer modification date. </param>
        /// <param name="specificPlanIdsLimitation"> Plan ids limitation for this offer. </param>
        /// <param name="isUpdateSuppressedDueToIdempotence"> Indicating whether the offer was not updated to db (true = not updated). If the allow list is identical to the existed one in db, the offer would not be updated. </param>
        /// <param name="iconFileUris"> Icon File Uris. </param>
        /// <param name="plans"> Offer plans. </param>
        internal PrivateStoreOfferData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string uniqueOfferId, string offerDisplayName, string publisherDisplayName, ETag? eTag, Guid? privateStoreId, DateTimeOffset? createdOn, DateTimeOffset? modifiedOn, IList<string> specificPlanIdsLimitation, bool? isUpdateSuppressedDueToIdempotence, IDictionary<string, Uri> iconFileUris, IList<PrivateStorePlan> plans) : base(id, name, resourceType, systemData)
        {
            UniqueOfferId = uniqueOfferId;
            OfferDisplayName = offerDisplayName;
            PublisherDisplayName = publisherDisplayName;
            ETag = eTag;
            PrivateStoreId = privateStoreId;
            CreatedOn = createdOn;
            ModifiedOn = modifiedOn;
            SpecificPlanIdsLimitation = specificPlanIdsLimitation;
            IsUpdateSuppressedDueToIdempotence = isUpdateSuppressedDueToIdempotence;
            IconFileUris = iconFileUris;
            Plans = plans;
        }

        /// <summary> Offers unique id. </summary>
        public string UniqueOfferId { get; }
        /// <summary> It will be displayed prominently in the marketplace. </summary>
        public string OfferDisplayName { get; }
        /// <summary> Publisher name that will be displayed prominently in the marketplace. </summary>
        public string PublisherDisplayName { get; }
        /// <summary> Identifier for purposes of race condition. </summary>
        public ETag? ETag { get; set; }
        /// <summary> Private store unique id. </summary>
        public Guid? PrivateStoreId { get; }
        /// <summary> Private store offer creation date. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Private store offer modification date. </summary>
        public DateTimeOffset? ModifiedOn { get; }
        /// <summary> Plan ids limitation for this offer. </summary>
        public IList<string> SpecificPlanIdsLimitation { get; }
        /// <summary> Indicating whether the offer was not updated to db (true = not updated). If the allow list is identical to the existed one in db, the offer would not be updated. </summary>
        public bool? IsUpdateSuppressedDueToIdempotence { get; set; }
        /// <summary> Icon File Uris. </summary>
        public IDictionary<string, Uri> IconFileUris { get; }
        /// <summary> Offer plans. </summary>
        public IList<PrivateStorePlan> Plans { get; }
    }
}
