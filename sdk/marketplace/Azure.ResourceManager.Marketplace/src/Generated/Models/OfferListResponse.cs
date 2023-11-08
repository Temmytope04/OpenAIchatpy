// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Marketplace;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> The OfferListResponse. </summary>
    internal partial class OfferListResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OfferListResponse"/>. </summary>
        internal OfferListResponse()
        {
            Value = new ChangeTrackingList<PrivateStoreOfferData>();
        }

        /// <summary> Initializes a new instance of <see cref="OfferListResponse"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> URL to get the next set of offer list results if there are any. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OfferListResponse(IReadOnlyList<PrivateStoreOfferData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<PrivateStoreOfferData> Value { get; }
        /// <summary> URL to get the next set of offer list results if there are any. </summary>
        public string NextLink { get; }
    }
}
