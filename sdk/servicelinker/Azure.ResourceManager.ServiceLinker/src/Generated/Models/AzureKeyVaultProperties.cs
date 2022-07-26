// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The resource properties when type is Azure Key Vault. </summary>
    public partial class AzureKeyVaultProperties : AzureResourceBaseProperties
    {
        /// <summary> Initializes a new instance of AzureKeyVaultProperties. </summary>
        public AzureKeyVaultProperties()
        {
            AzureResourceType = AzureResourceType.KeyVault;
        }

        /// <summary> Initializes a new instance of AzureKeyVaultProperties. </summary>
        /// <param name="azureResourceType"> The azure resource type. </param>
        /// <param name="doesConnectAsKubernetesCsiDriver"> True if connect via Kubernetes CSI Driver. </param>
        internal AzureKeyVaultProperties(AzureResourceType azureResourceType, bool? doesConnectAsKubernetesCsiDriver) : base(azureResourceType)
        {
            DoesConnectAsKubernetesCsiDriver = doesConnectAsKubernetesCsiDriver;
            AzureResourceType = azureResourceType;
        }

        /// <summary> True if connect via Kubernetes CSI Driver. </summary>
        public bool? DoesConnectAsKubernetesCsiDriver { get; set; }
    }
}
