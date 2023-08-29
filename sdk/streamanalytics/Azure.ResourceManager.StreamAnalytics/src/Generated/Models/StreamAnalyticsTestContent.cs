// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.StreamAnalytics;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> A stream analytics input. </summary>
    public partial class StreamAnalyticsTestContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsTestContent"/>. </summary>
        /// <param name="input"> The stream analytics input to test. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public StreamAnalyticsTestContent(StreamingJobInputData input)
        {
            Argument.AssertNotNull(input, nameof(input));

            Input = input;
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsTestContent"/>. </summary>
        /// <param name="input"> The stream analytics input to test. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamAnalyticsTestContent(StreamingJobInputData input, Dictionary<string, BinaryData> rawData)
        {
            Input = input;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsTestContent"/> for deserialization. </summary>
        internal StreamAnalyticsTestContent()
        {
        }

        /// <summary> The stream analytics input to test. </summary>
        public StreamingJobInputData Input { get; }
    }
}
