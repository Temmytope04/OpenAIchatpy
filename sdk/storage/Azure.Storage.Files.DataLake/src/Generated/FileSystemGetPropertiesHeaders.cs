// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Storage.Files.DataLake
{
    internal partial class FileSystemGetPropertiesHeaders
    {
        private readonly Response _response;
        public FileSystemGetPropertiesHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> The data and time the filesystem was last modified.  Changes to filesystem properties update the last modified time, but operations on files and directories do not. </summary>
        public DateTimeOffset? LastModified => _response.Headers.TryGetValue("Last-Modified", out DateTimeOffset? value) ? value : null;
        /// <summary> The version of the REST protocol used to process the request. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
        /// <summary> The user-defined properties associated with the filesystem.  A comma-separated list of name and value pairs in the format "n1=v1, n2=v2, ...", where each value is a base64 encoded string. Note that the string may only contain ASCII characters in the ISO-8859-1 character set. </summary>
        public string Properties => _response.Headers.TryGetValue("x-ms-properties", out string value) ? value : null;
        /// <summary> A bool string indicates whether the namespace feature is enabled. If "true", the namespace is enabled for the filesystem. </summary>
        public string NamespaceEnabled => _response.Headers.TryGetValue("x-ms-namespace-enabled", out string value) ? value : null;
    }
}
