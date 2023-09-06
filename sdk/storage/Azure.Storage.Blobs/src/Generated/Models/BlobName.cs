// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> The BlobName. </summary>
    internal partial class BlobName
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BlobName"/>. </summary>
        internal BlobName()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BlobName"/>. </summary>
        /// <param name="encoded"> Indicates if the blob name is encoded. </param>
        /// <param name="content"> The name of the blob. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BlobName(bool? encoded, string content, Dictionary<string, BinaryData> rawData)
        {
            Encoded = encoded;
            Content = content;
            _rawData = rawData;
        }

        /// <summary> Indicates if the blob name is encoded. </summary>
        public bool? Encoded { get; }
        /// <summary> The name of the blob. </summary>
        public string Content { get; }
    }
}
