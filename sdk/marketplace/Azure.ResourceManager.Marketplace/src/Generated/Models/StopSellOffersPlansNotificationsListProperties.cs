// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary>
    /// List of stop sell offers and plans notifications.
    /// Serialized Name: StopSellOffersPlansNotificationsListProperties
    /// </summary>
    public partial class StopSellOffersPlansNotificationsListProperties
    {
        /// <summary> Initializes a new instance of StopSellOffersPlansNotificationsListProperties. </summary>
        internal StopSellOffersPlansNotificationsListProperties()
        {
            Plans = new ChangeTrackingList<PlanNotificationDetails>();
            SubscriptionsIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of StopSellOffersPlansNotificationsListProperties. </summary>
        /// <param name="offerId">
        /// The offer id
        /// Serialized Name: StopSellOffersPlansNotificationsListProperties.offerId
        /// </param>
        /// <param name="displayName">
        /// The offer display name
        /// Serialized Name: StopSellOffersPlansNotificationsListProperties.displayName
        /// </param>
        /// <param name="isEntire">
        /// A value indicating whether entire offer is in stop sell or only few of its plans
        /// Serialized Name: StopSellOffersPlansNotificationsListProperties.isEntire
        /// </param>
        /// <param name="messageCode">
        /// The notification message code
        /// Serialized Name: StopSellOffersPlansNotificationsListProperties.messageCode
        /// </param>
        /// <param name="icon">
        /// The icon url
        /// Serialized Name: StopSellOffersPlansNotificationsListProperties.icon
        /// </param>
        /// <param name="plans">
        /// The list of removed plans notifications
        /// Serialized Name: StopSellOffersPlansNotificationsListProperties.plans
        /// </param>
        /// <param name="publicContext">
        /// True if the offer has public plans
        /// Serialized Name: StopSellOffersPlansNotificationsListProperties.publicContext
        /// </param>
        /// <param name="subscriptionsIds">
        /// The subscriptions related to private plans
        /// Serialized Name: StopSellOffersPlansNotificationsListProperties.subscriptionsIds
        /// </param>
        internal StopSellOffersPlansNotificationsListProperties(string offerId, string displayName, bool? isEntire, long? messageCode, string icon, IReadOnlyList<PlanNotificationDetails> plans, bool? publicContext, IReadOnlyList<string> subscriptionsIds)
        {
            OfferId = offerId;
            DisplayName = displayName;
            IsEntire = isEntire;
            MessageCode = messageCode;
            Icon = icon;
            Plans = plans;
            PublicContext = publicContext;
            SubscriptionsIds = subscriptionsIds;
        }

        /// <summary>
        /// The offer id
        /// Serialized Name: StopSellOffersPlansNotificationsListProperties.offerId
        /// </summary>
        public string OfferId { get; }
        /// <summary>
        /// The offer display name
        /// Serialized Name: StopSellOffersPlansNotificationsListProperties.displayName
        /// </summary>
        public string DisplayName { get; }
        /// <summary>
        /// A value indicating whether entire offer is in stop sell or only few of its plans
        /// Serialized Name: StopSellOffersPlansNotificationsListProperties.isEntire
        /// </summary>
        public bool? IsEntire { get; }
        /// <summary>
        /// The notification message code
        /// Serialized Name: StopSellOffersPlansNotificationsListProperties.messageCode
        /// </summary>
        public long? MessageCode { get; }
        /// <summary>
        /// The icon url
        /// Serialized Name: StopSellOffersPlansNotificationsListProperties.icon
        /// </summary>
        public string Icon { get; }
        /// <summary>
        /// The list of removed plans notifications
        /// Serialized Name: StopSellOffersPlansNotificationsListProperties.plans
        /// </summary>
        public IReadOnlyList<PlanNotificationDetails> Plans { get; }
        /// <summary>
        /// True if the offer has public plans
        /// Serialized Name: StopSellOffersPlansNotificationsListProperties.publicContext
        /// </summary>
        public bool? PublicContext { get; }
        /// <summary>
        /// The subscriptions related to private plans
        /// Serialized Name: StopSellOffersPlansNotificationsListProperties.subscriptionsIds
        /// </summary>
        public IReadOnlyList<string> SubscriptionsIds { get; }
    }
}
