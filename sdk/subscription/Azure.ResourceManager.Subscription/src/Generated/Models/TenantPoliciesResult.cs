// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Subscription;

namespace Azure.ResourceManager.Subscription.Models
{
    /// <summary> Tenant policy information list. </summary>
    internal partial class TenantPoliciesResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TenantPoliciesResult"/>. </summary>
        internal TenantPoliciesResult()
        {
            Value = new ChangeTrackingList<TenantPolicyData>();
        }

        /// <summary> Initializes a new instance of <see cref="TenantPoliciesResult"/>. </summary>
        /// <param name="value"> The list of tenant policies. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TenantPoliciesResult(IReadOnlyList<TenantPolicyData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of tenant policies. </summary>
        public IReadOnlyList<TenantPolicyData> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}
