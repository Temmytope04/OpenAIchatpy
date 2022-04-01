// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Properties required to update a CdnWebApplicationFirewallPolicy. </summary>
    internal partial class PatchableCdnWebApplicationFirewallPolicyData
    {
        /// <summary> Initializes a new instance of PatchableCdnWebApplicationFirewallPolicyData. </summary>
        public PatchableCdnWebApplicationFirewallPolicyData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> CdnWebApplicationFirewallPolicy tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
