// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> A list of the workspace managed sql server's security alert policies. </summary>
    internal partial class SynapseServerSecurityAlertPolicyListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SynapseServerSecurityAlertPolicyListResult"/>. </summary>
        internal SynapseServerSecurityAlertPolicyListResult()
        {
            Value = new ChangeTrackingList<SynapseServerSecurityAlertPolicyData>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseServerSecurityAlertPolicyListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseServerSecurityAlertPolicyListResult(IReadOnlyList<SynapseServerSecurityAlertPolicyData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SynapseServerSecurityAlertPolicyData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
