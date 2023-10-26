// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Model representing a http get request. </summary>
    public partial class HttpGet
    {
        /// <summary> Initializes a new instance of HttpGet. </summary>
        /// <param name="uri"> URL to make HTTP GET request against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public HttpGet(Uri uri)
        {
            Argument.AssertNotNull(uri, nameof(uri));

            Uri = uri;
            Headers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of HttpGet. </summary>
        /// <param name="uri"> URL to make HTTP GET request against. </param>
        /// <param name="fileName"> Name of the file that the request should be saved to. </param>
        /// <param name="headers"> List of headers to send with the request. </param>
        internal HttpGet(Uri uri, string fileName, IList<string> headers)
        {
            Uri = uri;
            FileName = fileName;
            Headers = headers;
        }

        /// <summary> URL to make HTTP GET request against. </summary>
        public Uri Uri { get; set; }
        /// <summary> Name of the file that the request should be saved to. </summary>
        public string FileName { get; set; }
        /// <summary> List of headers to send with the request. </summary>
        public IList<string> Headers { get; }
    }
}
