// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Enabled configuration. </summary>
    internal partial class WebAppEnabledConfig
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WebAppEnabledConfig"/>. </summary>
        public WebAppEnabledConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WebAppEnabledConfig"/>. </summary>
        /// <param name="enabled"> True if configuration is enabled, false if it is disabled and null if configuration is not set. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WebAppEnabledConfig(bool? enabled, Dictionary<string, BinaryData> rawData)
        {
            Enabled = enabled;
            _rawData = rawData;
        }

        /// <summary> True if configuration is enabled, false if it is disabled and null if configuration is not set. </summary>
        public bool? Enabled { get; set; }
    }
}
