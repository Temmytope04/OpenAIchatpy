// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> Gateway settings. </summary>
    public partial class HDInsightClusterGatewaySettings
    {
        /// <summary> Initializes a new instance of HDInsightClusterGatewaySettings. </summary>
        internal HDInsightClusterGatewaySettings()
        {
        }

        /// <summary> Initializes a new instance of HDInsightClusterGatewaySettings. </summary>
        /// <param name="isCredentialEnabled"> Indicates whether or not the gateway settings based authorization is enabled. </param>
        /// <param name="userName"> The gateway settings user name. </param>
        /// <param name="password"> The gateway settings user password. </param>
        internal HDInsightClusterGatewaySettings(string isCredentialEnabled, string userName, string password)
        {
            IsCredentialEnabled = isCredentialEnabled;
            UserName = userName;
            Password = password;
        }

        /// <summary> Indicates whether or not the gateway settings based authorization is enabled. </summary>
        public string IsCredentialEnabled { get; }
        /// <summary> The gateway settings user name. </summary>
        public string UserName { get; }
        /// <summary> The gateway settings user password. </summary>
        public string Password { get; }
    }
}
