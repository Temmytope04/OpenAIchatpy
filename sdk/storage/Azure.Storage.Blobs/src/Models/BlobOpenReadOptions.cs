﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Storage.Blobs.Specialized;

namespace Azure.Storage.Blobs.Models
{
    /// <summary>
    /// Optional parameters for <see cref="BlobBaseClient.OpenReadAsync(BlobOpenReadOptions, System.Threading.CancellationToken)"/>
    /// </summary>
    public class BlobOpenReadOptions
    {
        /// <summary>
        /// If true, you can continue streaming a blob even if it has been modified.
        /// If true, <see cref="Conditions"/> with be ignored.
        /// </summary>
        public bool AllowModified { get; set; }

        /// <summary>
        /// The position within the blob to begin the stream.
        /// Defaults to the beginning of the blob.
        /// </summary>
        public long Position { get; set; }

        /// <summary>
        /// The buffer size to use when the stream downloads parts
        /// of the blob.  Defaults to 4 MB.
        /// </summary>
        public int? BufferSize { get; set; }

        /// <summary>
        /// Optional <see cref="BlobRequestConditions"/> to add conditions on
        /// the download of the blob.
        /// </summary>
        public BlobRequestConditions Conditions { get; set; }
    }
}
