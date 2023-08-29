// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The QueryTableStatusRequest. </summary>
    public partial class QueryTableStatusRequest
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="QueryTableStatusRequest"/>. </summary>
        public QueryTableStatusRequest()
        {
        }

        /// <summary> Initializes a new instance of <see cref="QueryTableStatusRequest"/>. </summary>
        /// <param name="maxSegmentCount"> Max segment count to query table status. </param>
        /// <param name="continuationToken"> Continuation token to query table status. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal QueryTableStatusRequest(int? maxSegmentCount, object continuationToken, Dictionary<string, BinaryData> rawData)
        {
            MaxSegmentCount = maxSegmentCount;
            ContinuationToken = continuationToken;
            _rawData = rawData;
        }

        /// <summary> Max segment count to query table status. </summary>
        public int? MaxSegmentCount { get; set; }
        /// <summary> Continuation token to query table status. </summary>
        public object ContinuationToken { get; set; }
    }
}
