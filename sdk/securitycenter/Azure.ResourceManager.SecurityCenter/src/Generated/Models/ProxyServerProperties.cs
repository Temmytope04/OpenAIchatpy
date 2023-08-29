// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> For a non-Azure machine that is not connected directly to the internet, specify a proxy server that the non-Azure machine can use. </summary>
    public partial class ProxyServerProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ProxyServerProperties"/>. </summary>
        public ProxyServerProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProxyServerProperties"/>. </summary>
        /// <param name="ip"> Proxy server IP. </param>
        /// <param name="port"> Proxy server port. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ProxyServerProperties(string ip, string port, Dictionary<string, BinaryData> rawData)
        {
            IP = ip;
            Port = port;
            _rawData = rawData;
        }

        /// <summary> Proxy server IP. </summary>
        public string IP { get; set; }
        /// <summary> Proxy server port. </summary>
        public string Port { get; set; }
    }
}
