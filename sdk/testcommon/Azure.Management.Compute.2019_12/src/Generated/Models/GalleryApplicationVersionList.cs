// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Management.Compute.Models
{
    /// <summary> The List Gallery Application version operation response. </summary>
    public partial class GalleryApplicationVersionList
    {
        /// <summary> Initializes a new instance of GalleryApplicationVersionList. </summary>
        /// <param name="value"> A list of gallery Application Versions. </param>
        internal GalleryApplicationVersionList(IEnumerable<GalleryApplicationVersion> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToArray();
        }

        /// <summary> Initializes a new instance of GalleryApplicationVersionList. </summary>
        /// <param name="value"> A list of gallery Application Versions. </param>
        /// <param name="nextLink"> The uri to fetch the next page of gallery Application Versions. Call ListNext() with this to fetch the next page of gallery Application Versions. </param>
        internal GalleryApplicationVersionList(IReadOnlyList<GalleryApplicationVersion> value, string nextLink)
        {
            Value = value ?? new List<GalleryApplicationVersion>();
            NextLink = nextLink;
        }

        /// <summary> A list of gallery Application Versions. </summary>
        public IReadOnlyList<GalleryApplicationVersion> Value { get; }
        /// <summary> The uri to fetch the next page of gallery Application Versions. Call ListNext() with this to fetch the next page of gallery Application Versions. </summary>
        public string NextLink { get; }
    }
}
