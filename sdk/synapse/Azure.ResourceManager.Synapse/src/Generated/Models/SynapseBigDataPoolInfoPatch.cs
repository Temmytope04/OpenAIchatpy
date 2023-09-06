// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Properties patch for a Big Data pool. </summary>
    public partial class SynapseBigDataPoolInfoPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SynapseBigDataPoolInfoPatch"/>. </summary>
        public SynapseBigDataPoolInfoPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseBigDataPoolInfoPatch"/>. </summary>
        /// <param name="tags"> Updated tags for the Big Data pool. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseBigDataPoolInfoPatch(IDictionary<string, string> tags, Dictionary<string, BinaryData> rawData)
        {
            Tags = tags;
            _rawData = rawData;
        }

        /// <summary> Updated tags for the Big Data pool. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
