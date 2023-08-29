// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Purview Configuration. </summary>
    internal partial class PurviewConfiguration
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PurviewConfiguration"/>. </summary>
        public PurviewConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PurviewConfiguration"/>. </summary>
        /// <param name="purviewResourceId"> Purview Resource ID. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PurviewConfiguration(ResourceIdentifier purviewResourceId, Dictionary<string, BinaryData> rawData)
        {
            PurviewResourceId = purviewResourceId;
            _rawData = rawData;
        }

        /// <summary> Purview Resource ID. </summary>
        public ResourceIdentifier PurviewResourceId { get; set; }
    }
}
