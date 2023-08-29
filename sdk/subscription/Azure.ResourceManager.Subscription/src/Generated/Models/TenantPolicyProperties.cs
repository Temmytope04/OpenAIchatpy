// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Subscription.Models
{
    /// <summary> Tenant policy. </summary>
    public partial class TenantPolicyProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TenantPolicyProperties"/>. </summary>
        internal TenantPolicyProperties()
        {
            ExemptedPrincipals = new ChangeTrackingList<Guid>();
        }

        /// <summary> Initializes a new instance of <see cref="TenantPolicyProperties"/>. </summary>
        /// <param name="policyId"> Policy Id. </param>
        /// <param name="blockSubscriptionsLeavingTenant"> Blocks the leaving of subscriptions from user's tenant. </param>
        /// <param name="blockSubscriptionsIntoTenant"> Blocks the entering of subscriptions into user's tenant. </param>
        /// <param name="exemptedPrincipals"> List of user objectIds that are exempted from the set subscription tenant policies for the user's tenant. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TenantPolicyProperties(string policyId, bool? blockSubscriptionsLeavingTenant, bool? blockSubscriptionsIntoTenant, IReadOnlyList<Guid> exemptedPrincipals, Dictionary<string, BinaryData> rawData)
        {
            PolicyId = policyId;
            BlockSubscriptionsLeavingTenant = blockSubscriptionsLeavingTenant;
            BlockSubscriptionsIntoTenant = blockSubscriptionsIntoTenant;
            ExemptedPrincipals = exemptedPrincipals;
            _rawData = rawData;
        }

        /// <summary> Policy Id. </summary>
        public string PolicyId { get; }
        /// <summary> Blocks the leaving of subscriptions from user's tenant. </summary>
        public bool? BlockSubscriptionsLeavingTenant { get; }
        /// <summary> Blocks the entering of subscriptions into user's tenant. </summary>
        public bool? BlockSubscriptionsIntoTenant { get; }
        /// <summary> List of user objectIds that are exempted from the set subscription tenant policies for the user's tenant. </summary>
        public IReadOnlyList<Guid> ExemptedPrincipals { get; }
    }
}
