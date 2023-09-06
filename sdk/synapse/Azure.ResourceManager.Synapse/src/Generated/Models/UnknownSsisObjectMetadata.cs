// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The UnknownSsisObjectMetadata. </summary>
    internal partial class UnknownSsisObjectMetadata : SynapseSsisObjectMetadata
    {
        /// <summary> Initializes a new instance of <see cref="UnknownSsisObjectMetadata"/>. </summary>
        /// <param name="metadataType"> Type of metadata. </param>
        /// <param name="id"> Metadata id. </param>
        /// <param name="name"> Metadata name. </param>
        /// <param name="description"> Metadata description. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownSsisObjectMetadata(SynapseSsisObjectMetadataType metadataType, long? id, string name, string description, Dictionary<string, BinaryData> rawData) : base(metadataType, id, name, description, rawData)
        {
            MetadataType = metadataType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownSsisObjectMetadata"/> for deserialization. </summary>
        internal UnknownSsisObjectMetadata()
        {
        }
    }
}
