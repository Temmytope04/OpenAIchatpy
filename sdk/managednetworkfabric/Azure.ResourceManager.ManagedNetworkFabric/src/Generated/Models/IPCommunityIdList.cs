// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> IP Community ID list properties. </summary>
    public partial class IPCommunityIdList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IPCommunityIdList"/>. </summary>
        public IPCommunityIdList()
        {
            IPCommunityIds = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of <see cref="IPCommunityIdList"/>. </summary>
        /// <param name="ipCommunityIds"> List of IP Community resource IDs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IPCommunityIdList(IList<ResourceIdentifier> ipCommunityIds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IPCommunityIds = ipCommunityIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of IP Community resource IDs. </summary>
        public IList<ResourceIdentifier> IPCommunityIds { get; }
    }
}
