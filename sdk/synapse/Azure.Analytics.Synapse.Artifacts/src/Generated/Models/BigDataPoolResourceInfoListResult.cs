// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Collection of Big Data pool information. </summary>
    public partial class BigDataPoolResourceInfoListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BigDataPoolResourceInfoListResult"/>. </summary>
        internal BigDataPoolResourceInfoListResult()
        {
            Value = new ChangeTrackingList<BigDataPoolResourceInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="BigDataPoolResourceInfoListResult"/>. </summary>
        /// <param name="nextLink"> Link to the next page of results. </param>
        /// <param name="value"> List of Big Data pools. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BigDataPoolResourceInfoListResult(string nextLink, IReadOnlyList<BigDataPoolResourceInfo> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Link to the next page of results. </summary>
        public string NextLink { get; }
        /// <summary> List of Big Data pools. </summary>
        public IReadOnlyList<BigDataPoolResourceInfo> Value { get; }
    }
}
