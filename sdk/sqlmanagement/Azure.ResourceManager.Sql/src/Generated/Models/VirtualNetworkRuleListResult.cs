// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of virtual network rules. </summary>
    internal partial class VirtualNetworkRuleListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkRuleListResult"/>. </summary>
        internal VirtualNetworkRuleListResult()
        {
            Value = new ChangeTrackingList<SqlServerVirtualNetworkRuleData>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkRuleListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualNetworkRuleListResult(IReadOnlyList<SqlServerVirtualNetworkRuleData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SqlServerVirtualNetworkRuleData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
