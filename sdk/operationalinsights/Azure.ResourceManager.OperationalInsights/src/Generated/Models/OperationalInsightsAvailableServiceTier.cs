// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> Service Tier details. </summary>
    public partial class OperationalInsightsAvailableServiceTier
    {
        /// <summary> Initializes a new instance of OperationalInsightsAvailableServiceTier. </summary>
        internal OperationalInsightsAvailableServiceTier()
        {
        }

        /// <summary> Initializes a new instance of OperationalInsightsAvailableServiceTier. </summary>
        /// <param name="serviceTier"> The name of the Service Tier. </param>
        /// <param name="isEnabled"> True if the Service Tier is enabled for the workspace. </param>
        /// <param name="minimumRetention"> The minimum retention for the Service Tier, in days. </param>
        /// <param name="maximumRetention"> The maximum retention for the Service Tier, in days. </param>
        /// <param name="defaultRetention"> The default retention for the Service Tier, in days. </param>
        /// <param name="capacityReservationLevel"> The capacity reservation level in GB per day. Returned for the Capacity Reservation Service Tier. </param>
        /// <param name="lastSkuUpdatedOn"> Time when the sku was last updated for the workspace. Returned for the Capacity Reservation Service Tier. </param>
        internal OperationalInsightsAvailableServiceTier(OperationalInsightsSkuName? serviceTier, bool? isEnabled, long? minimumRetention, long? maximumRetention, long? defaultRetention, long? capacityReservationLevel, DateTimeOffset? lastSkuUpdatedOn)
        {
            ServiceTier = serviceTier;
            IsEnabled = isEnabled;
            MinimumRetention = minimumRetention;
            MaximumRetention = maximumRetention;
            DefaultRetention = defaultRetention;
            CapacityReservationLevel = capacityReservationLevel;
            LastSkuUpdatedOn = lastSkuUpdatedOn;
        }

        /// <summary> The name of the Service Tier. </summary>
        public OperationalInsightsSkuName? ServiceTier { get; }
        /// <summary> True if the Service Tier is enabled for the workspace. </summary>
        public bool? IsEnabled { get; }
        /// <summary> The minimum retention for the Service Tier, in days. </summary>
        public long? MinimumRetention { get; }
        /// <summary> The maximum retention for the Service Tier, in days. </summary>
        public long? MaximumRetention { get; }
        /// <summary> The default retention for the Service Tier, in days. </summary>
        public long? DefaultRetention { get; }
        /// <summary> The capacity reservation level in GB per day. Returned for the Capacity Reservation Service Tier. </summary>
        public long? CapacityReservationLevel { get; }
        /// <summary> Time when the sku was last updated for the workspace. Returned for the Capacity Reservation Service Tier. </summary>
        public DateTimeOffset? LastSkuUpdatedOn { get; }
    }
}
