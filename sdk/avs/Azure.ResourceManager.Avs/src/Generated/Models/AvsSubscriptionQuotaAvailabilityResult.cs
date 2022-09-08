// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Subscription quotas. </summary>
    public partial class AvsSubscriptionQuotaAvailabilityResult
    {
        /// <summary> Initializes a new instance of AvsSubscriptionQuotaAvailabilityResult. </summary>
        internal AvsSubscriptionQuotaAvailabilityResult()
        {
            HostsRemaining = new ChangeTrackingDictionary<string, int>();
        }

        /// <summary> Initializes a new instance of AvsSubscriptionQuotaAvailabilityResult. </summary>
        /// <param name="hostsRemaining"> Remaining hosts quota by sku type. </param>
        /// <param name="quotaEnabled"> Host quota is active for current subscription. </param>
        internal AvsSubscriptionQuotaAvailabilityResult(IReadOnlyDictionary<string, int> hostsRemaining, AvsSubscriptionQuotaEnabled? quotaEnabled)
        {
            HostsRemaining = hostsRemaining;
            QuotaEnabled = quotaEnabled;
        }

        /// <summary> Remaining hosts quota by sku type. </summary>
        public IReadOnlyDictionary<string, int> HostsRemaining { get; }
        /// <summary> Host quota is active for current subscription. </summary>
        public AvsSubscriptionQuotaEnabled? QuotaEnabled { get; }
    }
}
