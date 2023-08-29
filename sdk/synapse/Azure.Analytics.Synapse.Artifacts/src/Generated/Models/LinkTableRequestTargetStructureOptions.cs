// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The LinkTableRequestTargetStructureOptions. </summary>
    public partial class LinkTableRequestTargetStructureOptions
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LinkTableRequestTargetStructureOptions"/>. </summary>
        public LinkTableRequestTargetStructureOptions()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LinkTableRequestTargetStructureOptions"/>. </summary>
        /// <param name="type"> Target table structure type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LinkTableRequestTargetStructureOptions(string type, Dictionary<string, BinaryData> rawData)
        {
            Type = type;
            _rawData = rawData;
        }

        /// <summary> Target table structure type. </summary>
        public string Type { get; set; }
    }
}
