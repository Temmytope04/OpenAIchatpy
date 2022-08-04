// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of the server&apos;s Advanced Threat Protection configurations. </summary>
    internal partial class LogicalServerAdvancedThreatProtectionListResult
    {
        /// <summary> Initializes a new instance of LogicalServerAdvancedThreatProtectionListResult. </summary>
        internal LogicalServerAdvancedThreatProtectionListResult()
        {
            Value = new ChangeTrackingList<ServerAdvancedThreatProtectionData>();
        }

        /// <summary> Initializes a new instance of LogicalServerAdvancedThreatProtectionListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal LogicalServerAdvancedThreatProtectionListResult(IReadOnlyList<ServerAdvancedThreatProtectionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ServerAdvancedThreatProtectionData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
