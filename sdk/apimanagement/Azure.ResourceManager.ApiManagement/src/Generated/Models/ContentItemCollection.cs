// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Paged list of content items. </summary>
    internal partial class ContentItemCollection
    {
        /// <summary> Initializes a new instance of ContentItemCollection. </summary>
        internal ContentItemCollection()
        {
            Value = new ChangeTrackingList<ContentItemContractData>();
        }

        /// <summary> Initializes a new instance of ContentItemCollection. </summary>
        /// <param name="value"> Collection of content items. </param>
        /// <param name="nextLink"> Next page link, if any. </param>
        internal ContentItemCollection(IReadOnlyList<ContentItemContractData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of content items. </summary>
        public IReadOnlyList<ContentItemContractData> Value { get; }
        /// <summary> Next page link, if any. </summary>
        public string NextLink { get; }
    }
}
