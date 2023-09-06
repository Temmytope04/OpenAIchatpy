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
    /// <summary> A list of sparkconfiguration resources. </summary>
    internal partial class SparkConfigurationListResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SparkConfigurationListResponse"/>. </summary>
        /// <param name="value"> List of sparkconfigurations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SparkConfigurationListResponse(IEnumerable<SparkConfigurationResource> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SparkConfigurationListResponse"/>. </summary>
        /// <param name="value"> List of sparkconfigurations. </param>
        /// <param name="nextLink"> The link to the next page of results, if any remaining results exist. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SparkConfigurationListResponse(IReadOnlyList<SparkConfigurationResource> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SparkConfigurationListResponse"/> for deserialization. </summary>
        internal SparkConfigurationListResponse()
        {
        }

        /// <summary> List of sparkconfigurations. </summary>
        public IReadOnlyList<SparkConfigurationResource> Value { get; }
        /// <summary> The link to the next page of results, if any remaining results exist. </summary>
        public string NextLink { get; }
    }
}
