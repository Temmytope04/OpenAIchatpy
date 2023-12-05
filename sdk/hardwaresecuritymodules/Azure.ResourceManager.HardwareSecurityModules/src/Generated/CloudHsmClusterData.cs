// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HardwareSecurityModules.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HardwareSecurityModules
{
    /// <summary>
    /// A class representing the CloudHsmCluster data model.
    /// Resource information with extended details.
    /// </summary>
    public partial class CloudHsmClusterData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="CloudHsmClusterData"/>. </summary>
        /// <param name="location"> The location. </param>
        public CloudHsmClusterData(AzureLocation location) : base(location)
        {
            Hsms = new ChangeTrackingList<CloudHsmProperties>();
            PrivateEndpointConnections = new ChangeTrackingList<HardwareSecurityModulesPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="CloudHsmClusterData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The Cloud HSM Cluster's provisioningState. </param>
        /// <param name="autoGeneratedDomainNameLabelScope"> The Cloud HSM Cluster's auto-generated Domain Name Label Scope. </param>
        /// <param name="securityDomain"> Security domain properties information for Cloud HSM cluster. </param>
        /// <param name="hsms"> An array of Cloud HSM Cluster's HSMs. </param>
        /// <param name="publicNetworkAccess"> The Cloud HSM Cluster public network access. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connection resources. </param>
        /// <param name="statusMessage"> Cloud HSM Cluster status message. </param>
        /// <param name="restoreProperties"> Cloud Hsm Cluster restore information. </param>
        /// <param name="backupProperties"> Cloud Hsm Cluster backup information. </param>
        /// <param name="sku"> SKU details. </param>
        /// <param name="identity"> Managed service identity (system assigned and/or user assigned identities). </param>
        internal CloudHsmClusterData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ProvisioningState? provisioningState, string autoGeneratedDomainNameLabelScope, CloudHsmClusterSecurityDomainProperties securityDomain, IList<CloudHsmProperties> hsms, string publicNetworkAccess, IList<HardwareSecurityModulesPrivateEndpointConnectionData> privateEndpointConnections, string statusMessage, RestoreProperties restoreProperties, BackupProperties backupProperties, CloudHsmClusterSku sku, ManagedServiceIdentity identity) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            AutoGeneratedDomainNameLabelScope = autoGeneratedDomainNameLabelScope;
            SecurityDomain = securityDomain;
            Hsms = hsms;
            PublicNetworkAccess = publicNetworkAccess;
            PrivateEndpointConnections = privateEndpointConnections;
            StatusMessage = statusMessage;
            RestoreProperties = restoreProperties;
            BackupProperties = backupProperties;
            Sku = sku;
            Identity = identity;
        }

        /// <summary> The Cloud HSM Cluster's provisioningState. </summary>
        public ProvisioningState? ProvisioningState { get; set; }
        /// <summary> The Cloud HSM Cluster's auto-generated Domain Name Label Scope. </summary>
        public string AutoGeneratedDomainNameLabelScope { get; set; }
        /// <summary> Security domain properties information for Cloud HSM cluster. </summary>
        public CloudHsmClusterSecurityDomainProperties SecurityDomain { get; set; }
        /// <summary> An array of Cloud HSM Cluster's HSMs. </summary>
        public IList<CloudHsmProperties> Hsms { get; }
        /// <summary> The Cloud HSM Cluster public network access. </summary>
        public string PublicNetworkAccess { get; set; }
        /// <summary> List of private endpoint connection resources. </summary>
        public IList<HardwareSecurityModulesPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> Cloud HSM Cluster status message. </summary>
        public string StatusMessage { get; }
        /// <summary> Cloud Hsm Cluster restore information. </summary>
        public RestoreProperties RestoreProperties { get; set; }
        /// <summary> Cloud Hsm Cluster backup information. </summary>
        public BackupProperties BackupProperties { get; set; }
        /// <summary> SKU details. </summary>
        public CloudHsmClusterSku Sku { get; set; }
        /// <summary> Managed service identity (system assigned and/or user assigned identities). </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
