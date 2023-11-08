// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Security.KeyVault.Storage.Models
{
    /// <summary> The deleted storage account list result. </summary>
    internal partial class DeletedStorageListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DeletedStorageListResult"/>. </summary>
        internal DeletedStorageListResult()
        {
            Value = new ChangeTrackingList<DeletedStorageAccountItem>();
        }

        /// <summary> Initializes a new instance of <see cref="DeletedStorageListResult"/>. </summary>
        /// <param name="value"> A response message containing a list of the deleted storage accounts in the vault along with a link to the next page of deleted storage accounts. </param>
        /// <param name="nextLink"> The URL to get the next set of deleted storage accounts. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeletedStorageListResult(IReadOnlyList<DeletedStorageAccountItem> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A response message containing a list of the deleted storage accounts in the vault along with a link to the next page of deleted storage accounts. </summary>
        public IReadOnlyList<DeletedStorageAccountItem> Value { get; }
        /// <summary> The URL to get the next set of deleted storage accounts. </summary>
        public string NextLink { get; }
    }
}
