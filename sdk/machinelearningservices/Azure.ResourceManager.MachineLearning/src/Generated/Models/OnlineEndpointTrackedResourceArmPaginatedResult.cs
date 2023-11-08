// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> A paginated list of OnlineEndpoint entities. </summary>
    internal partial class OnlineEndpointTrackedResourceArmPaginatedResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OnlineEndpointTrackedResourceArmPaginatedResult"/>. </summary>
        internal OnlineEndpointTrackedResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<MachineLearningOnlineEndpointData>();
        }

        /// <summary> Initializes a new instance of <see cref="OnlineEndpointTrackedResourceArmPaginatedResult"/>. </summary>
        /// <param name="nextLink"> The link to the next page of OnlineEndpoint objects. If null, there are no additional pages. </param>
        /// <param name="value"> An array of objects of type OnlineEndpoint. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OnlineEndpointTrackedResourceArmPaginatedResult(string nextLink, IReadOnlyList<MachineLearningOnlineEndpointData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The link to the next page of OnlineEndpoint objects. If null, there are no additional pages. </summary>
        public string NextLink { get; }
        /// <summary> An array of objects of type OnlineEndpoint. </summary>
        public IReadOnlyList<MachineLearningOnlineEndpointData> Value { get; }
    }
}
