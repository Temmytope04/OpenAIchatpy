// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Configurable properties that the user can set locally via the azcmagent config command, or remotely via ARM. </summary>
    public partial class AgentConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AgentConfiguration"/>. </summary>
        internal AgentConfiguration()
        {
            IncomingConnectionsPorts = new ChangeTrackingList<string>();
            ExtensionsAllowList = new ChangeTrackingList<ConfigurationExtension>();
            ExtensionsBlockList = new ChangeTrackingList<ConfigurationExtension>();
            ProxyBypass = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AgentConfiguration"/>. </summary>
        /// <param name="proxyUri"> Specifies the URL of the proxy to be used. </param>
        /// <param name="incomingConnectionsPorts"> Specifies the list of ports that the agent will be able to listen on. </param>
        /// <param name="extensionsAllowList"> Array of extensions that are allowed to be installed or updated. </param>
        /// <param name="extensionsBlockList"> Array of extensions that are blocked (cannot be installed or updated). </param>
        /// <param name="proxyBypass"> List of service names which should not use the specified proxy server. </param>
        /// <param name="extensionsEnabled"> Specifies whether the extension service is enabled or disabled. </param>
        /// <param name="guestConfigurationEnabled"> Specified whether the guest configuration service is enabled or disabled. </param>
        /// <param name="configMode"> Name of configuration mode to use. Modes are pre-defined configurations of security controls, extension allowlists and guest configuration, maintained by Microsoft. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AgentConfiguration(Uri proxyUri, IReadOnlyList<string> incomingConnectionsPorts, IReadOnlyList<ConfigurationExtension> extensionsAllowList, IReadOnlyList<ConfigurationExtension> extensionsBlockList, IReadOnlyList<string> proxyBypass, string extensionsEnabled, string guestConfigurationEnabled, AgentConfigurationMode? configMode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProxyUri = proxyUri;
            IncomingConnectionsPorts = incomingConnectionsPorts;
            ExtensionsAllowList = extensionsAllowList;
            ExtensionsBlockList = extensionsBlockList;
            ProxyBypass = proxyBypass;
            ExtensionsEnabled = extensionsEnabled;
            GuestConfigurationEnabled = guestConfigurationEnabled;
            ConfigMode = configMode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the URL of the proxy to be used. </summary>
        public Uri ProxyUri { get; }
        /// <summary> Specifies the list of ports that the agent will be able to listen on. </summary>
        public IReadOnlyList<string> IncomingConnectionsPorts { get; }
        /// <summary> Array of extensions that are allowed to be installed or updated. </summary>
        public IReadOnlyList<ConfigurationExtension> ExtensionsAllowList { get; }
        /// <summary> Array of extensions that are blocked (cannot be installed or updated). </summary>
        public IReadOnlyList<ConfigurationExtension> ExtensionsBlockList { get; }
        /// <summary> List of service names which should not use the specified proxy server. </summary>
        public IReadOnlyList<string> ProxyBypass { get; }
        /// <summary> Specifies whether the extension service is enabled or disabled. </summary>
        public string ExtensionsEnabled { get; }
        /// <summary> Specified whether the guest configuration service is enabled or disabled. </summary>
        public string GuestConfigurationEnabled { get; }
        /// <summary> Name of configuration mode to use. Modes are pre-defined configurations of security controls, extension allowlists and guest configuration, maintained by Microsoft. </summary>
        public AgentConfigurationMode? ConfigMode { get; }
    }
}
