// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> A list of NSX Port Mirroring. </summary>
    internal partial class WorkloadNetworkPortMirroringList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkPortMirroringList"/>. </summary>
        internal WorkloadNetworkPortMirroringList()
        {
            Value = new ChangeTrackingList<WorkloadNetworkPortMirroringProfileData>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkPortMirroringList"/>. </summary>
        /// <param name="value"> The items on the page. </param>
        /// <param name="nextLink"> URL to get the next page if any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkloadNetworkPortMirroringList(IReadOnlyList<WorkloadNetworkPortMirroringProfileData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The items on the page. </summary>
        public IReadOnlyList<WorkloadNetworkPortMirroringProfileData> Value { get; }
        /// <summary> URL to get the next page if any. </summary>
        public string NextLink { get; }
    }
}
