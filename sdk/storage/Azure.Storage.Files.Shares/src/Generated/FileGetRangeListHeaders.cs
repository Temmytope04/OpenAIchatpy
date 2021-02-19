// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.Storage.Files.Shares
{
    internal partial class FileGetRangeListHeaders
    {
        private readonly Response _response;
        public FileGetRangeListHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> The date/time that the file was last modified. Any operation that modifies the file, including an update of the file&apos;s metadata or properties, changes the file&apos;s last modified time. </summary>
        public DateTimeOffset? LastModified => _response.Headers.TryGetValue("Last-Modified", out DateTimeOffset? value) ? value : null;
        /// <summary> The size of the file in bytes. </summary>
        public long? FileContentLength => _response.Headers.TryGetValue("x-ms-content-length", out long? value) ? value : null;
        /// <summary> Indicates the version of the File service used to execute the request. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
    }
}
