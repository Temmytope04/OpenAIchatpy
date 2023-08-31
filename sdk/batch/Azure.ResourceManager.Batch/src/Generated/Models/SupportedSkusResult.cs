// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The Batch List supported SKUs operation response. </summary>
    internal partial class SupportedSkusResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SupportedSkusResult"/>. </summary>
        /// <param name="value"> The list of SKUs available for the Batch service in the location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SupportedSkusResult(IEnumerable<BatchSupportedSku> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SupportedSkusResult"/>. </summary>
        /// <param name="value"> The list of SKUs available for the Batch service in the location. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SupportedSkusResult(IReadOnlyList<BatchSupportedSku> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SupportedSkusResult"/> for deserialization. </summary>
        internal SupportedSkusResult()
        {
        }

        /// <summary> The list of SKUs available for the Batch service in the location. </summary>
        public IReadOnlyList<BatchSupportedSku> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
