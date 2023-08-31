// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Object that includes an array of Build service resources and a possible link for next set. </summary>
    internal partial class AppBuildServiceList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppBuildServiceList"/>. </summary>
        internal AppBuildServiceList()
        {
            Value = new ChangeTrackingList<AppPlatformBuildServiceData>();
        }

        /// <summary> Initializes a new instance of <see cref="AppBuildServiceList"/>. </summary>
        /// <param name="value"> Collection of Build service resources. </param>
        /// <param name="nextLink">
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppBuildServiceList(IReadOnlyList<AppPlatformBuildServiceData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Collection of Build service resources. </summary>
        public IReadOnlyList<AppPlatformBuildServiceData> Value { get; }
        /// <summary>
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}
