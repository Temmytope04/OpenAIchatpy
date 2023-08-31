// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.AlphaIds.Models
{
    /// <summary>
    /// &lt;br&gt;Represents a collection of settings for configuring Alpha ID support for a specific resource.
    /// &lt;br&gt;
    ///             Initially, Alpha IDs were restricted to customers that had valid use cases for them, so this configuration could be leveraged to enable its usage.
    ///
    /// </summary>
    public partial class AlphaIdConfiguration
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AlphaIdConfiguration"/>. </summary>
        /// <param name="enabled"> Indicates whether the use of Alpha IDs is supported for a specific resource. </param>
        public AlphaIdConfiguration(bool enabled)
        {
            Enabled = enabled;
        }

        /// <summary> Initializes a new instance of <see cref="AlphaIdConfiguration"/>. </summary>
        /// <param name="enabled"> Indicates whether the use of Alpha IDs is supported for a specific resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AlphaIdConfiguration(bool enabled, Dictionary<string, BinaryData> rawData)
        {
            Enabled = enabled;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AlphaIdConfiguration"/> for deserialization. </summary>
        internal AlphaIdConfiguration()
        {
        }

        /// <summary> Indicates whether the use of Alpha IDs is supported for a specific resource. </summary>
        public bool Enabled { get; set; }
    }
}
