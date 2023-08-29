// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The response to a list Sql pool usages request. </summary>
    internal partial class SqlPoolUsageListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SqlPoolUsageListResult"/>. </summary>
        /// <param name="value"> The list of usages for the Sql pool. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SqlPoolUsageListResult(IEnumerable<SqlPoolUsage> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SqlPoolUsageListResult"/>. </summary>
        /// <param name="value"> The list of usages for the Sql pool. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlPoolUsageListResult(IReadOnlyList<SqlPoolUsage> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SqlPoolUsageListResult"/> for deserialization. </summary>
        internal SqlPoolUsageListResult()
        {
        }

        /// <summary> The list of usages for the Sql pool. </summary>
        public IReadOnlyList<SqlPoolUsage> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
