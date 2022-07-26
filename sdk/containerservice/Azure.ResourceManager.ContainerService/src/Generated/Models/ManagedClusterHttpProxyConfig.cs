// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Cluster HTTP proxy configuration. </summary>
    public partial class ManagedClusterHttpProxyConfig
    {
        /// <summary> Initializes a new instance of ManagedClusterHttpProxyConfig. </summary>
        public ManagedClusterHttpProxyConfig()
        {
            NoProxy = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ManagedClusterHttpProxyConfig. </summary>
        /// <param name="httpProxy"> The HTTP proxy server endpoint to use. </param>
        /// <param name="httpsProxy"> The HTTPS proxy server endpoint to use. </param>
        /// <param name="noProxy"> The endpoints that should not go through proxy. </param>
        /// <param name="trustedCA"> Alternative CA cert to use for connecting to proxy servers. </param>
        internal ManagedClusterHttpProxyConfig(string httpProxy, string httpsProxy, IList<string> noProxy, string trustedCA)
        {
            HttpProxy = httpProxy;
            HttpsProxy = httpsProxy;
            NoProxy = noProxy;
            TrustedCA = trustedCA;
        }

        /// <summary> The HTTP proxy server endpoint to use. </summary>
        public string HttpProxy { get; set; }
        /// <summary> The HTTPS proxy server endpoint to use. </summary>
        public string HttpsProxy { get; set; }
        /// <summary> The endpoints that should not go through proxy. </summary>
        public IList<string> NoProxy { get; }
        /// <summary> Alternative CA cert to use for connecting to proxy servers. </summary>
        public string TrustedCA { get; set; }
    }
}
