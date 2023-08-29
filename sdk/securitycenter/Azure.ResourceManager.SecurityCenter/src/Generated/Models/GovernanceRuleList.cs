// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Page of a governance rules list. </summary>
    internal partial class GovernanceRuleList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GovernanceRuleList"/>. </summary>
        internal GovernanceRuleList()
        {
            Value = new ChangeTrackingList<GovernanceRuleData>();
        }

        /// <summary> Initializes a new instance of <see cref="GovernanceRuleList"/>. </summary>
        /// <param name="value"> Collection of governance rules in this page. </param>
        /// <param name="nextLink"> The URI to fetch the next page. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GovernanceRuleList(IReadOnlyList<GovernanceRuleData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Collection of governance rules in this page. </summary>
        public IReadOnlyList<GovernanceRuleData> Value { get; }
        /// <summary> The URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}
