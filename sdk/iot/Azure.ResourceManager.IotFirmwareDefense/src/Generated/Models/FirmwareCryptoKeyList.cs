// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> Crypto keys list. </summary>
    internal partial class FirmwareCryptoKeyList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FirmwareCryptoKeyList"/>. </summary>
        internal FirmwareCryptoKeyList()
        {
            Value = new ChangeTrackingList<FirmwareCryptoKey>();
        }

        /// <summary> Initializes a new instance of <see cref="FirmwareCryptoKeyList"/>. </summary>
        /// <param name="value"> Crypto keys list. </param>
        /// <param name="nextLink"> The uri to fetch the next page of asset. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FirmwareCryptoKeyList(IReadOnlyList<FirmwareCryptoKey> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Crypto keys list. </summary>
        public IReadOnlyList<FirmwareCryptoKey> Value { get; }
        /// <summary> The uri to fetch the next page of asset. </summary>
        public string NextLink { get; }
    }
}
