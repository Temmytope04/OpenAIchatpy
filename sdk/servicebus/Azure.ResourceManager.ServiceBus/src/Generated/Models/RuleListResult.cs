// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ServiceBus;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> The response of the List rule operation. </summary>
    internal partial class RuleListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RuleListResult"/>. </summary>
        internal RuleListResult()
        {
            Value = new ChangeTrackingList<ServiceBusRuleData>();
        }

        /// <summary> Initializes a new instance of <see cref="RuleListResult"/>. </summary>
        /// <param name="value"> Result of the List Rules operation. </param>
        /// <param name="nextLink"> Link to the next set of results. Not empty if Value contains incomplete list of rules. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RuleListResult(IReadOnlyList<ServiceBusRuleData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Result of the List Rules operation. </summary>
        public IReadOnlyList<ServiceBusRuleData> Value { get; }
        /// <summary> Link to the next set of results. Not empty if Value contains incomplete list of rules. </summary>
        public string NextLink { get; }
    }
}
