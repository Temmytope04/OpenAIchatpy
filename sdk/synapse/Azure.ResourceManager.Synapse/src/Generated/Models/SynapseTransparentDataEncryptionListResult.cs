// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> A list of transparent data encryption configurations. </summary>
    internal partial class SynapseTransparentDataEncryptionListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SynapseTransparentDataEncryptionListResult"/>. </summary>
        internal SynapseTransparentDataEncryptionListResult()
        {
            Value = new ChangeTrackingList<SynapseTransparentDataEncryptionData>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseTransparentDataEncryptionListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseTransparentDataEncryptionListResult(IReadOnlyList<SynapseTransparentDataEncryptionData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SynapseTransparentDataEncryptionData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
