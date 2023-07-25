// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevCenter;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> Results of the image list operation. </summary>
    internal partial class DevCenterImageListResult
    {
        /// <summary> Initializes a new instance of DevCenterImageListResult. </summary>
        internal DevCenterImageListResult()
        {
            Value = new ChangeTrackingList<DevCenterImageData>();
        }

        /// <summary> Initializes a new instance of DevCenterImageListResult. </summary>
        /// <param name="value"> Current page of results. </param>
        /// <param name="nextLink"> URL to get the next set of results if there are any. </param>
        internal DevCenterImageListResult(IReadOnlyList<DevCenterImageData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Current page of results. </summary>
        public IReadOnlyList<DevCenterImageData> Value { get; }
        /// <summary> URL to get the next set of results if there are any. </summary>
        public string NextLink { get; }
    }
}
