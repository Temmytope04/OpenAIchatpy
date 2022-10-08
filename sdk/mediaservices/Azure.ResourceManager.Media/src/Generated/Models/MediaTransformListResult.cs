// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> A collection of Transform items. </summary>
    internal partial class MediaTransformListResult
    {
        /// <summary> Initializes a new instance of MediaTransformListResult. </summary>
        internal MediaTransformListResult()
        {
            Value = new ChangeTrackingList<MediaTransformData>();
        }

        /// <summary> Initializes a new instance of MediaTransformListResult. </summary>
        /// <param name="value"> A collection of Transform items. </param>
        /// <param name="odataNextLink"> A link to the next page of the collection (when the collection contains too many results to return in one response). </param>
        internal MediaTransformListResult(IReadOnlyList<MediaTransformData> value, string odataNextLink)
        {
            Value = value;
            OdataNextLink = odataNextLink;
        }

        /// <summary> A collection of Transform items. </summary>
        public IReadOnlyList<MediaTransformData> Value { get; }
        /// <summary> A link to the next page of the collection (when the collection contains too many results to return in one response). </summary>
        public string OdataNextLink { get; }
    }
}
