// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> AzureResource(IaaS VM) Specific feature support request. </summary>
    public partial class AzureVmResourceFeatureSupportRequest : FeatureSupportContent
    {
        /// <summary> Initializes a new instance of AzureVmResourceFeatureSupportRequest. </summary>
        public AzureVmResourceFeatureSupportRequest()
        {
            FeatureType = "AzureVMResourceBackup";
        }

        /// <summary> Size of the resource: VM size(A/D series etc) in case of IaasVM. </summary>
        public string VmSize { get; set; }
        /// <summary> SKUs (Premium/Managed etc) in case of IaasVM. </summary>
        public string VmSku { get; set; }
    }
}
