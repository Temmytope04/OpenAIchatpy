// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> Parameter group. </summary>
    public partial class BlobHttpHeaders
    {
        /// <summary> Initializes a new instance of BlobHttpHeaders. </summary>
        public BlobHttpHeaders()
        {
        }

        /// <summary> Optional. Sets the blob&apos;s cache control. If specified, this property is stored with the blob and returned with a read request. </summary>
        public string BlobCacheControl { get; set; }
        /// <summary> Optional. Sets the blob&apos;s content type. If specified, this property is stored with the blob and returned with a read request. </summary>
        public string BlobContentType { get; set; }
        /// <summary> Optional. An MD5 hash of the blob content. Note that this hash is not validated, as the hashes for the individual blocks were validated when each was uploaded. </summary>
        public byte[] BlobContentMD5 { get; set; }
        /// <summary> Optional. Sets the blob&apos;s content encoding. If specified, this property is stored with the blob and returned with a read request. </summary>
        public string BlobContentEncoding { get; set; }
        /// <summary> Optional. Set the blob&apos;s content language. If specified, this property is stored with the blob and returned with a read request. </summary>
        public string BlobContentLanguage { get; set; }
        /// <summary> Optional. Sets the blob&apos;s Content-Disposition header. </summary>
        public string BlobContentDisposition { get; set; }
    }
}
