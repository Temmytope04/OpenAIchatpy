// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Paged Users list representation. </summary>
    internal partial class UserListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="UserListResult"/>. </summary>
        internal UserListResult()
        {
            Value = new ChangeTrackingList<UserContractData>();
        }

        /// <summary> Initializes a new instance of <see cref="UserListResult"/>. </summary>
        /// <param name="value"> Page values. </param>
        /// <param name="count"> Total record count number across all pages. </param>
        /// <param name="nextLink"> Next page link if any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UserListResult(IReadOnlyList<UserContractData> value, long? count, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            Count = count;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Page values. </summary>
        public IReadOnlyList<UserContractData> Value { get; }
        /// <summary> Total record count number across all pages. </summary>
        public long? Count { get; }
        /// <summary> Next page link if any. </summary>
        public string NextLink { get; }
    }
}
