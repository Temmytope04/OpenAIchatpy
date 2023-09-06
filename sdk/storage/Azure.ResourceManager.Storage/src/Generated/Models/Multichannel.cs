// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Multichannel setting. Applies to Premium FileStorage only. </summary>
    internal partial class Multichannel
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="Multichannel"/>. </summary>
        public Multichannel()
        {
        }

        /// <summary> Initializes a new instance of <see cref="Multichannel"/>. </summary>
        /// <param name="isMultiChannelEnabled"> Indicates whether multichannel is enabled. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal Multichannel(bool? isMultiChannelEnabled, Dictionary<string, BinaryData> rawData)
        {
            IsMultiChannelEnabled = isMultiChannelEnabled;
            _rawData = rawData;
        }

        /// <summary> Indicates whether multichannel is enabled. </summary>
        public bool? IsMultiChannelEnabled { get; set; }
    }
}
