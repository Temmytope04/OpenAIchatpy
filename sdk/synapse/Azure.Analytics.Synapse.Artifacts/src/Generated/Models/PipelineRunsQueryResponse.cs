// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A list pipeline runs. </summary>
    public partial class PipelineRunsQueryResponse
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PipelineRunsQueryResponse"/>. </summary>
        /// <param name="value"> List of pipeline runs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal PipelineRunsQueryResponse(IEnumerable<PipelineRun> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="PipelineRunsQueryResponse"/>. </summary>
        /// <param name="value"> List of pipeline runs. </param>
        /// <param name="continuationToken"> The continuation token for getting the next page of results, if any remaining results exist, null otherwise. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PipelineRunsQueryResponse(IReadOnlyList<PipelineRun> value, string continuationToken, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            ContinuationToken = continuationToken;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PipelineRunsQueryResponse"/> for deserialization. </summary>
        internal PipelineRunsQueryResponse()
        {
        }

        /// <summary> List of pipeline runs. </summary>
        public IReadOnlyList<PipelineRun> Value { get; }
        /// <summary> The continuation token for getting the next page of results, if any remaining results exist, null otherwise. </summary>
        public string ContinuationToken { get; }
    }
}
