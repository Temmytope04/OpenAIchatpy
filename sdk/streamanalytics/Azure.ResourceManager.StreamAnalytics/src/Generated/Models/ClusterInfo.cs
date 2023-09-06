// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The properties associated with a Stream Analytics cluster. </summary>
    internal partial class ClusterInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ClusterInfo"/>. </summary>
        public ClusterInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ClusterInfo"/>. </summary>
        /// <param name="id"> The resource id of cluster. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterInfo(ResourceIdentifier id, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            _rawData = rawData;
        }

        /// <summary> The resource id of cluster. </summary>
        public ResourceIdentifier Id { get; set; }
    }
}
