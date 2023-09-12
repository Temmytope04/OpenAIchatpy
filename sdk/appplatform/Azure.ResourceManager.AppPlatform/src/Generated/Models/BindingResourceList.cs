// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Object that includes an array of Binding resources and a possible link for next set. </summary>
    internal partial class BindingResourceList
    {
        /// <summary> Initializes a new instance of BindingResourceList. </summary>
        internal BindingResourceList()
        {
            Value = new ChangeTrackingList<AppPlatformBindingData>();
        }

        /// <summary> Initializes a new instance of BindingResourceList. </summary>
        /// <param name="value"> Collection of Binding resources. </param>
        /// <param name="nextLink">
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </param>
        internal BindingResourceList(IReadOnlyList<AppPlatformBindingData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of Binding resources. </summary>
        public IReadOnlyList<AppPlatformBindingData> Value { get; }
        /// <summary>
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}
