// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Marketplace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Marketplace
{
    /// <summary> A class representing the AdminApprovalRequest data model. </summary>
    public partial class AdminApprovalRequestData : ResourceData
    {
        /// <summary> Initializes a new instance of AdminApprovalRequestData. </summary>
        public AdminApprovalRequestData()
        {
            ApprovedPlans = new ChangeTrackingList<string>();
            Plans = new ChangeTrackingList<PlanRequesterDetails>();
            CollectionIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AdminApprovalRequestData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="offerId">
        /// Gets or sets offer Id
        /// Serialized Name: AdminRequestApprovalsResource.properties.offerId
        /// </param>
        /// <param name="displayName">
        /// Gets display name
        /// Serialized Name: AdminRequestApprovalsResource.properties.displayName
        /// </param>
        /// <param name="publisherId">
        /// Gets or sets publisher Id
        /// Serialized Name: AdminRequestApprovalsResource.properties.publisherId
        /// </param>
        /// <param name="adminAction">
        /// Gets or sets admin action
        /// Serialized Name: AdminRequestApprovalsResource.properties.adminAction
        /// </param>
        /// <param name="approvedPlans">
        /// Gets or sets Approved plans ids, empty in case of rejected
        /// Serialized Name: AdminRequestApprovalsResource.properties.approvedPlans
        /// </param>
        /// <param name="comment">
        /// Gets or sets admin comment
        /// Serialized Name: AdminRequestApprovalsResource.properties.comment
        /// </param>
        /// <param name="administrator">
        /// Gets or sets admin details
        /// Serialized Name: AdminRequestApprovalsResource.properties.administrator
        /// </param>
        /// <param name="plans">
        /// Gets list of plans with requesters details
        /// Serialized Name: AdminRequestApprovalsResource.properties.plans
        /// </param>
        /// <param name="collectionIds">
        /// Gets or sets list of associated collection ids
        /// Serialized Name: AdminRequestApprovalsResource.properties.collectionIds
        /// </param>
        /// <param name="icon">
        /// The offer icon url.
        /// Serialized Name: AdminRequestApprovalsResource.properties.icon
        /// </param>
        internal AdminApprovalRequestData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string offerId, string displayName, string publisherId, AdminAction? adminAction, IList<string> approvedPlans, string comment, string administrator, IReadOnlyList<PlanRequesterDetails> plans, IList<string> collectionIds, Uri icon) : base(id, name, resourceType, systemData)
        {
            OfferId = offerId;
            DisplayName = displayName;
            PublisherId = publisherId;
            AdminAction = adminAction;
            ApprovedPlans = approvedPlans;
            Comment = comment;
            Administrator = administrator;
            Plans = plans;
            CollectionIds = collectionIds;
            Icon = icon;
        }

        /// <summary>
        /// Gets or sets offer Id
        /// Serialized Name: AdminRequestApprovalsResource.properties.offerId
        /// </summary>
        public string OfferId { get; set; }
        /// <summary>
        /// Gets display name
        /// Serialized Name: AdminRequestApprovalsResource.properties.displayName
        /// </summary>
        public string DisplayName { get; }
        /// <summary>
        /// Gets or sets publisher Id
        /// Serialized Name: AdminRequestApprovalsResource.properties.publisherId
        /// </summary>
        public string PublisherId { get; set; }
        /// <summary>
        /// Gets or sets admin action
        /// Serialized Name: AdminRequestApprovalsResource.properties.adminAction
        /// </summary>
        public AdminAction? AdminAction { get; set; }
        /// <summary>
        /// Gets or sets Approved plans ids, empty in case of rejected
        /// Serialized Name: AdminRequestApprovalsResource.properties.approvedPlans
        /// </summary>
        public IList<string> ApprovedPlans { get; }
        /// <summary>
        /// Gets or sets admin comment
        /// Serialized Name: AdminRequestApprovalsResource.properties.comment
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// Gets or sets admin details
        /// Serialized Name: AdminRequestApprovalsResource.properties.administrator
        /// </summary>
        public string Administrator { get; set; }
        /// <summary>
        /// Gets list of plans with requesters details
        /// Serialized Name: AdminRequestApprovalsResource.properties.plans
        /// </summary>
        public IReadOnlyList<PlanRequesterDetails> Plans { get; }
        /// <summary>
        /// Gets or sets list of associated collection ids
        /// Serialized Name: AdminRequestApprovalsResource.properties.collectionIds
        /// </summary>
        public IList<string> CollectionIds { get; }
        /// <summary>
        /// The offer icon url.
        /// Serialized Name: AdminRequestApprovalsResource.properties.icon
        /// </summary>
        public Uri Icon { get; }
    }
}
