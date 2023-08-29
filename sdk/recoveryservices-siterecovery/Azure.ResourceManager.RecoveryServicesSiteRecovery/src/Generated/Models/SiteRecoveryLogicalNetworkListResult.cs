// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> List of logical networks. </summary>
    internal partial class SiteRecoveryLogicalNetworkListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryLogicalNetworkListResult"/>. </summary>
        internal SiteRecoveryLogicalNetworkListResult()
        {
            Value = new ChangeTrackingList<SiteRecoveryLogicalNetworkData>();
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryLogicalNetworkListResult"/>. </summary>
        /// <param name="value"> The Logical Networks list details. </param>
        /// <param name="nextLink"> The value of next link. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryLogicalNetworkListResult(IReadOnlyList<SiteRecoveryLogicalNetworkData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The Logical Networks list details. </summary>
        public IReadOnlyList<SiteRecoveryLogicalNetworkData> Value { get; }
        /// <summary> The value of next link. </summary>
        public string NextLink { get; }
    }
}
