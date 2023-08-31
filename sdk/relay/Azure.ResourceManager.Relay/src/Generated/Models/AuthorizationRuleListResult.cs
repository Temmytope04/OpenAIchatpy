// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Relay;

namespace Azure.ResourceManager.Relay.Models
{
    /// <summary> The response from the list namespace operation. </summary>
    internal partial class AuthorizationRuleListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AuthorizationRuleListResult"/>. </summary>
        internal AuthorizationRuleListResult()
        {
            Value = new ChangeTrackingList<RelayAuthorizationRuleData>();
        }

        /// <summary> Initializes a new instance of <see cref="AuthorizationRuleListResult"/>. </summary>
        /// <param name="value"> Result of the list authorization rules operation. </param>
        /// <param name="nextLink"> Link to the next set of results. Not empty if value contains incomplete list of authorization rules. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AuthorizationRuleListResult(IReadOnlyList<RelayAuthorizationRuleData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Result of the list authorization rules operation. </summary>
        public IReadOnlyList<RelayAuthorizationRuleData> Value { get; }
        /// <summary> Link to the next set of results. Not empty if value contains incomplete list of authorization rules. </summary>
        public string NextLink { get; }
    }
}
