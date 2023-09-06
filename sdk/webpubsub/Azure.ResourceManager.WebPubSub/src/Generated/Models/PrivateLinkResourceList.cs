// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Contains a list of PrivateLinkResource and a possible link to query more results. </summary>
    internal partial class PrivateLinkResourceList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PrivateLinkResourceList"/>. </summary>
        internal PrivateLinkResourceList()
        {
            Value = new ChangeTrackingList<WebPubSubPrivateLink>();
        }

        /// <summary> Initializes a new instance of <see cref="PrivateLinkResourceList"/>. </summary>
        /// <param name="value"> List of PrivateLinkResource. </param>
        /// <param name="nextLink">
        /// The URL the client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateLinkResourceList(IReadOnlyList<WebPubSubPrivateLink> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of PrivateLinkResource. </summary>
        public IReadOnlyList<WebPubSubPrivateLink> Value { get; }
        /// <summary>
        /// The URL the client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}
