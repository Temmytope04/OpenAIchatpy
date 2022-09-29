// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Container extended information. </summary>
    public partial class GenericContainerExtendedInfo
    {
        /// <summary> Initializes a new instance of GenericContainerExtendedInfo. </summary>
        public GenericContainerExtendedInfo()
        {
            ServiceEndpoints = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of GenericContainerExtendedInfo. </summary>
        /// <param name="rawCertData"> Public key of container cert. </param>
        /// <param name="containerIdentityInfo"> Container identity information. </param>
        /// <param name="serviceEndpoints"> Azure Backup Service Endpoints for the container. </param>
        internal GenericContainerExtendedInfo(string rawCertData, ContainerIdentityInfo containerIdentityInfo, IDictionary<string, string> serviceEndpoints)
        {
            RawCertData = rawCertData;
            ContainerIdentityInfo = containerIdentityInfo;
            ServiceEndpoints = serviceEndpoints;
        }

        /// <summary> Public key of container cert. </summary>
        public string RawCertData { get; set; }
        /// <summary> Container identity information. </summary>
        public ContainerIdentityInfo ContainerIdentityInfo { get; set; }
        /// <summary> Azure Backup Service Endpoints for the container. </summary>
        public IDictionary<string, string> ServiceEndpoints { get; }
    }
}
