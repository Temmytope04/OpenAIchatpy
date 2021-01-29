// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.Storage.Blobs.Models;

namespace Azure.Storage.Blobs
{
    internal class PageBlobCopyIncrementalHeaders
    {
        private readonly Response _response;
        public PageBlobCopyIncrementalHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Returns the date and time the container was last modified. Any operation that modifies the blob, including an update of the blob&apos;s metadata or properties, changes the last-modified time of the blob. </summary>
        public DateTimeOffset? LastModified => _response.Headers.TryGetValue("Last-Modified", out DateTimeOffset? value) ? value : null;
        /// <summary> Indicates the version of the Blob service used to execute the request. This header is returned for requests made against version 2009-09-19 and above. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
        /// <summary> String identifier for this copy operation. Use with Get Blob Properties to check the status of this copy operation, or pass to Abort Copy Blob to abort a pending copy. </summary>
        public string CopyId => _response.Headers.TryGetValue("x-ms-copy-id", out string value) ? value : null;
        /// <summary> State of the copy operation identified by x-ms-copy-id. </summary>
        public CopyStatusType? CopyStatus => _response.Headers.TryGetValue("x-ms-copy-status", out string value) ? value.ToCopyStatusType() : (CopyStatusType?)null;
    }
}
