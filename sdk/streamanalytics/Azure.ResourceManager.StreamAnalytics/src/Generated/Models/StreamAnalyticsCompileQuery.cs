// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The query compilation object which defines the input, output, and transformation for the query compilation. </summary>
    public partial class StreamAnalyticsCompileQuery
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsCompileQuery"/>. </summary>
        /// <param name="query"> The query to compile. </param>
        /// <param name="jobType"> Describes the type of the job. Valid values are `Cloud` and 'Edge'. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="query"/> is null. </exception>
        public StreamAnalyticsCompileQuery(string query, StreamingJobType jobType)
        {
            Argument.AssertNotNull(query, nameof(query));

            Query = query;
            Inputs = new ChangeTrackingList<StreamAnalyticsQueryInput>();
            Functions = new ChangeTrackingList<StreamAnalyticsQueryFunction>();
            JobType = jobType;
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsCompileQuery"/>. </summary>
        /// <param name="query"> The query to compile. </param>
        /// <param name="inputs"> The inputs for the query compilation. </param>
        /// <param name="functions"> The functions for the query compilation. </param>
        /// <param name="jobType"> Describes the type of the job. Valid values are `Cloud` and 'Edge'. </param>
        /// <param name="compatibilityLevel"> The query to compile. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamAnalyticsCompileQuery(string query, IList<StreamAnalyticsQueryInput> inputs, IList<StreamAnalyticsQueryFunction> functions, StreamingJobType jobType, StreamingJobCompatibilityLevel? compatibilityLevel, Dictionary<string, BinaryData> rawData)
        {
            Query = query;
            Inputs = inputs;
            Functions = functions;
            JobType = jobType;
            CompatibilityLevel = compatibilityLevel;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsCompileQuery"/> for deserialization. </summary>
        internal StreamAnalyticsCompileQuery()
        {
        }

        /// <summary> The query to compile. </summary>
        public string Query { get; }
        /// <summary> The inputs for the query compilation. </summary>
        public IList<StreamAnalyticsQueryInput> Inputs { get; }
        /// <summary> The functions for the query compilation. </summary>
        public IList<StreamAnalyticsQueryFunction> Functions { get; }
        /// <summary> Describes the type of the job. Valid values are `Cloud` and 'Edge'. </summary>
        public StreamingJobType JobType { get; }
        /// <summary> The query to compile. </summary>
        public StreamingJobCompatibilityLevel? CompatibilityLevel { get; set; }
    }
}
