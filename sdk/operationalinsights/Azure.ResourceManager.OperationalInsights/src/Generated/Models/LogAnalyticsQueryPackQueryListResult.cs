// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.OperationalInsights;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> Describes the list of Log Analytics QueryPack-Query resources. </summary>
    internal partial class LogAnalyticsQueryPackQueryListResult
    {
        /// <summary> Initializes a new instance of LogAnalyticsQueryPackQueryListResult. </summary>
        /// <param name="value"> List of Log Analytics QueryPack Query definitions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal LogAnalyticsQueryPackQueryListResult(IEnumerable<LogAnalyticsQueryData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of LogAnalyticsQueryPackQueryListResult. </summary>
        /// <param name="value"> List of Log Analytics QueryPack Query definitions. </param>
        /// <param name="nextLink"> The URI to get the next set of Log Analytics QueryPack definitions if too many QueryPack-Queries where returned in the result set. </param>
        internal LogAnalyticsQueryPackQueryListResult(IReadOnlyList<LogAnalyticsQueryData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Log Analytics QueryPack Query definitions. </summary>
        public IReadOnlyList<LogAnalyticsQueryData> Value { get; }
        /// <summary> The URI to get the next set of Log Analytics QueryPack definitions if too many QueryPack-Queries where returned in the result set. </summary>
        public string NextLink { get; }
    }
}
