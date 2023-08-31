// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> Result of the transfer eligibility validation. </summary>
    public partial class BillingSubscriptionValidateMoveEligibilityResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BillingSubscriptionValidateMoveEligibilityResult"/>. </summary>
        internal BillingSubscriptionValidateMoveEligibilityResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BillingSubscriptionValidateMoveEligibilityResult"/>. </summary>
        /// <param name="isMoveEligible"> Specifies whether the subscription is eligible to move. </param>
        /// <param name="errorDetails"> Validation error details. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BillingSubscriptionValidateMoveEligibilityResult(bool? isMoveEligible, BillingSubscriptionValidateMoveEligibilityError errorDetails, Dictionary<string, BinaryData> rawData)
        {
            IsMoveEligible = isMoveEligible;
            ErrorDetails = errorDetails;
            _rawData = rawData;
        }

        /// <summary> Specifies whether the subscription is eligible to move. </summary>
        public bool? IsMoveEligible { get; }
        /// <summary> Validation error details. </summary>
        public BillingSubscriptionValidateMoveEligibilityError ErrorDetails { get; }
    }
}
