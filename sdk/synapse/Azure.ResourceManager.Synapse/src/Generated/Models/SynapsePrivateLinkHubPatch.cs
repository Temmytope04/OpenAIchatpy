// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> PrivateLinkHub patch details. </summary>
    public partial class SynapsePrivateLinkHubPatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SynapsePrivateLinkHubPatch"/>. </summary>
        public SynapsePrivateLinkHubPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapsePrivateLinkHubPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapsePrivateLinkHubPatch(IDictionary<string, string> tags, Dictionary<string, BinaryData> rawData)
        {
            Tags = tags;
            _rawData = rawData;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
