// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> An output event timestamp. </summary>
    public partial class LastOutputEventTimestamp
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LastOutputEventTimestamp"/>. </summary>
        internal LastOutputEventTimestamp()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LastOutputEventTimestamp"/>. </summary>
        /// <param name="lastOutputEventOn"> The last output event time. </param>
        /// <param name="lastUpdatedOn"> The time that the last update happened. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LastOutputEventTimestamp(DateTimeOffset? lastOutputEventOn, DateTimeOffset? lastUpdatedOn, Dictionary<string, BinaryData> rawData)
        {
            LastOutputEventOn = lastOutputEventOn;
            LastUpdatedOn = lastUpdatedOn;
            _rawData = rawData;
        }

        /// <summary> The last output event time. </summary>
        public DateTimeOffset? LastOutputEventOn { get; }
        /// <summary> The time that the last update happened. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
    }
}
