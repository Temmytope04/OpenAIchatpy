// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Defines the OS and SAP Configurations for Deployment. </summary>
    public partial class OSSapConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="OSSapConfiguration"/>. </summary>
        public OSSapConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OSSapConfiguration"/>. </summary>
        /// <param name="deployerVmPackages"> The url and storage account ID where deployer VM packages are uploaded. </param>
        /// <param name="sapFqdn"> The FQDN to set for the SAP system. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal OSSapConfiguration(DeployerVmPackages deployerVmPackages, string sapFqdn, Dictionary<string, BinaryData> rawData)
        {
            DeployerVmPackages = deployerVmPackages;
            SapFqdn = sapFqdn;
            _rawData = rawData;
        }

        /// <summary> The url and storage account ID where deployer VM packages are uploaded. </summary>
        public DeployerVmPackages DeployerVmPackages { get; set; }
        /// <summary> The FQDN to set for the SAP system. </summary>
        public string SapFqdn { get; set; }
    }
}
