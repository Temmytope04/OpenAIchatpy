// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Private endpoint details. </summary>
    public partial class PrivateEndpoint
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PrivateEndpoint"/>. </summary>
        public PrivateEndpoint()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PrivateEndpoint"/>. </summary>
        /// <param name="id"> Resource id of the private endpoint. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateEndpoint(string id, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            _rawData = rawData;
        }

        /// <summary> Resource id of the private endpoint. </summary>
        public string Id { get; }
    }
}
