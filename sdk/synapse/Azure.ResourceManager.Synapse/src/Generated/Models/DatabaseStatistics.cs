// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> A class that contains database statistics information. </summary>
    internal partial class DatabaseStatistics
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DatabaseStatistics"/>. </summary>
        internal DatabaseStatistics()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseStatistics"/>. </summary>
        /// <param name="size"> The database size - the total size of compressed data and index in bytes. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DatabaseStatistics(float? size, Dictionary<string, BinaryData> rawData)
        {
            Size = size;
            _rawData = rawData;
        }

        /// <summary> The database size - the total size of compressed data and index in bytes. </summary>
        public float? Size { get; }
    }
}
