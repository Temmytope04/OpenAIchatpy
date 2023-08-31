// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Batch;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The result of performing list applications. </summary>
    internal partial class ListApplicationsResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ListApplicationsResult"/>. </summary>
        internal ListApplicationsResult()
        {
            Value = new ChangeTrackingList<BatchApplicationData>();
        }

        /// <summary> Initializes a new instance of <see cref="ListApplicationsResult"/>. </summary>
        /// <param name="value"> The list of applications. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ListApplicationsResult(IReadOnlyList<BatchApplicationData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of applications. </summary>
        public IReadOnlyList<BatchApplicationData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
