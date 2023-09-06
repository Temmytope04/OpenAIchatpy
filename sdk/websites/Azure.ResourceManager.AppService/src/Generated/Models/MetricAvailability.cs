// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Retention policy of a resource metric. </summary>
    public partial class MetricAvailability
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MetricAvailability"/>. </summary>
        internal MetricAvailability()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MetricAvailability"/>. </summary>
        /// <param name="timeGrain"></param>
        /// <param name="blobDuration"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MetricAvailability(string timeGrain, TimeSpan? blobDuration, Dictionary<string, BinaryData> rawData)
        {
            TimeGrain = timeGrain;
            BlobDuration = blobDuration;
            _rawData = rawData;
        }

        /// <summary> Gets the time grain. </summary>
        public string TimeGrain { get; }
        /// <summary> Gets the blob duration. </summary>
        public TimeSpan? BlobDuration { get; }
    }
}
