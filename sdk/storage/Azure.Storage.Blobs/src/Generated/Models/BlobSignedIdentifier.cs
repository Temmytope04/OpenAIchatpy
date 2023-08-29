// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> signed identifier. </summary>
    public partial class BlobSignedIdentifier
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BlobSignedIdentifier"/>. </summary>
        /// <param name="id"> a unique id. </param>
        /// <param name="accessPolicy"> An Access policy. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BlobSignedIdentifier(string id, BlobAccessPolicy accessPolicy, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            AccessPolicy = accessPolicy;
            _rawData = rawData;
        }

        /// <summary> a unique id. </summary>
        public string Id { get; set; }
        /// <summary> An Access policy. </summary>
        public BlobAccessPolicy AccessPolicy { get; set; }
    }
}
