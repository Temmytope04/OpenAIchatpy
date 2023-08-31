// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Remote debugging payload. </summary>
    public partial class ApplicationRemoteDebuggingContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationRemoteDebuggingContent"/>. </summary>
        public ApplicationRemoteDebuggingContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationRemoteDebuggingContent"/>. </summary>
        /// <param name="port"> Application debugging port. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationRemoteDebuggingContent(int? port, Dictionary<string, BinaryData> rawData)
        {
            Port = port;
            _rawData = rawData;
        }

        /// <summary> Application debugging port. </summary>
        public int? Port { get; set; }
    }
}
