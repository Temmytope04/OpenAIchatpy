// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Azure Synapse nested debug resource. </summary>
    public partial class SubResourceDebugResource
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SubResourceDebugResource"/>. </summary>
        public SubResourceDebugResource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SubResourceDebugResource"/>. </summary>
        /// <param name="name"> The resource name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SubResourceDebugResource(string name, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            _rawData = rawData;
        }

        /// <summary> The resource name. </summary>
        public string Name { get; set; }
    }
}
