// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Config server git properties payload. </summary>
    public partial class AppPlatformConfigServerProperties
    {
        /// <summary> Initializes a new instance of AppPlatformConfigServerProperties. </summary>
        public AppPlatformConfigServerProperties()
        {
        }

        /// <summary> Initializes a new instance of AppPlatformConfigServerProperties. </summary>
        /// <param name="provisioningState"> State of the config server. </param>
        /// <param name="error"> Error when apply config server settings. </param>
        /// <param name="configServer"> Settings of config server. </param>
        internal AppPlatformConfigServerProperties(AppPlatformConfigServerState? provisioningState, AppPlatformErrorInfo error, ConfigServerSettings configServer)
        {
            ProvisioningState = provisioningState;
            Error = error;
            ConfigServer = configServer;
        }

        /// <summary> State of the config server. </summary>
        public AppPlatformConfigServerState? ProvisioningState { get; }
        /// <summary> Error when apply config server settings. </summary>
        public AppPlatformErrorInfo Error { get; set; }
        /// <summary> Settings of config server. </summary>
        internal ConfigServerSettings ConfigServer { get; set; }
        /// <summary> Property of git environment. </summary>
        public AppPlatformConfigServerGitProperty ConfigServerGitProperty
        {
            get => ConfigServer is null ? default : ConfigServer.GitProperty;
            set
            {
                if (ConfigServer is null)
                    ConfigServer = new ConfigServerSettings();
                ConfigServer.GitProperty = value;
            }
        }
    }
}
