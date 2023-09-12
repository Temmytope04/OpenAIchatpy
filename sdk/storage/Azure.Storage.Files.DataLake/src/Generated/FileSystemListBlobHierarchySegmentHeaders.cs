// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.Storage.Files.DataLake
{
    internal partial class FileSystemListBlobHierarchySegmentHeaders
    {
        private readonly Response _response;
        public FileSystemListBlobHierarchySegmentHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> The media type of the body of the response. For List Blobs this is 'application/xml'. </summary>
        public string ContentType => _response.Headers.TryGetValue("Content-Type", out string value) ? value : null;
        /// <summary> Indicates the version of the Blob service used to execute the request. This header is returned for requests made against version 2009-09-19 and above. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
    }
}
