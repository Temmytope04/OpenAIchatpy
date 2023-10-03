// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.HybridCompute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridCompute
{
    /// <summary>
    /// A class representing the HybridComputeMachine data model.
    /// Describes a hybrid machine.
    /// </summary>
    public partial class HybridComputeMachineData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of HybridComputeMachineData. </summary>
        /// <param name="location"> The location. </param>
        public HybridComputeMachineData(AzureLocation location) : base(location)
        {
            Resources = new ChangeTrackingList<HybridComputeMachineExtensionData>();
            ErrorDetails = new ChangeTrackingList<ResponseError>();
            Extensions = new ChangeTrackingList<MachineExtensionInstanceView>();
            DetectedProperties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of HybridComputeMachineData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="resources"> The list of extensions affiliated to the machine. </param>
        /// <param name="identity"> Identity for the resource. Current supported identity types: SystemAssigned. </param>
        /// <param name="locationData"> Metadata pertaining to the geographic location of the resource. </param>
        /// <param name="agentConfiguration"> Configurable properties that the user can set locally via the azcmagent config command, or remotely via ARM. </param>
        /// <param name="serviceStatuses"> Statuses of dependent services that are reported back to ARM. </param>
        /// <param name="cloudMetadata"> The metadata of the cloud environment (Azure/GCP/AWS/OCI...). </param>
        /// <param name="agentUpgrade"> The info of the machine w.r.t Agent Upgrade. </param>
        /// <param name="osProfile"> Specifies the operating system settings for the hybrid machine. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="status"> The status of the hybrid machine agent. </param>
        /// <param name="lastStatusChange"> The time of the last status change. </param>
        /// <param name="errorDetails"> Details about the error state. </param>
        /// <param name="agentVersion"> The hybrid machine agent full version. </param>
        /// <param name="vmId"> Specifies the hybrid machine unique ID. </param>
        /// <param name="displayName"> Specifies the hybrid machine display name. </param>
        /// <param name="machineFqdn"> Specifies the hybrid machine FQDN. </param>
        /// <param name="clientPublicKey"> Public Key that the client provides to be used during initial resource onboarding. </param>
        /// <param name="osName"> The Operating System running on the hybrid machine. </param>
        /// <param name="osVersion"> The version of Operating System running on the hybrid machine. </param>
        /// <param name="osType"> The type of Operating System (windows/linux). </param>
        /// <param name="vmUuid"> Specifies the Arc Machine's unique SMBIOS ID. </param>
        /// <param name="extensions"> Machine Extensions information (deprecated field). </param>
        /// <param name="osSku"> Specifies the Operating System product SKU. </param>
        /// <param name="domainName"> Specifies the Windows domain name. </param>
        /// <param name="adFqdn"> Specifies the AD fully qualified display name. </param>
        /// <param name="dnsFqdn"> Specifies the DNS fully qualified display name. </param>
        /// <param name="privateLinkScopeResourceId"> The resource id of the private link scope this machine is assigned to, if any. </param>
        /// <param name="parentClusterResourceId"> The resource id of the parent cluster (Azure HCI) this machine is assigned to, if any. </param>
        /// <param name="MsSqlDiscovered"> Specifies whether any MS SQL instance is discovered on the machine. </param>
        /// <param name="detectedProperties"> Detected properties from the machine. </param>
        internal HybridComputeMachineData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IReadOnlyList<HybridComputeMachineExtensionData> resources, ManagedServiceIdentity identity, LocationData locationData, AgentConfiguration agentConfiguration, HybridComputeServiceStatuses serviceStatuses, CloudMetadata cloudMetadata, AgentUpgrade agentUpgrade, OSProfile osProfile, string provisioningState, HybridComputeStatusType? status, DateTimeOffset? lastStatusChange, IReadOnlyList<ResponseError> errorDetails, string agentVersion, Guid? vmId, string displayName, string machineFqdn, string clientPublicKey, string osName, string osVersion, string osType, Guid? vmUuid, IList<MachineExtensionInstanceView> extensions, string osSku, string domainName, string adFqdn, string dnsFqdn, string privateLinkScopeResourceId, string parentClusterResourceId, string MsSqlDiscovered, IReadOnlyDictionary<string, string> detectedProperties) : base(id, name, resourceType, systemData, tags, location)
        {
            Resources = resources;
            Identity = identity;
            LocationData = locationData;
            AgentConfiguration = agentConfiguration;
            ServiceStatuses = serviceStatuses;
            CloudMetadata = cloudMetadata;
            AgentUpgrade = agentUpgrade;
            OSProfile = osProfile;
            ProvisioningState = provisioningState;
            Status = status;
            LastStatusChange = lastStatusChange;
            ErrorDetails = errorDetails;
            AgentVersion = agentVersion;
            VmId = vmId;
            DisplayName = displayName;
            MachineFqdn = machineFqdn;
            ClientPublicKey = clientPublicKey;
            OSName = osName;
            OSVersion = osVersion;
            OSType = osType;
            VmUuid = vmUuid;
            Extensions = extensions;
            OSSku = osSku;
            DomainName = domainName;
            AdFqdn = adFqdn;
            DnsFqdn = dnsFqdn;
            PrivateLinkScopeResourceId = privateLinkScopeResourceId;
            ParentClusterResourceId = parentClusterResourceId;
            MsSqlDiscovered = MsSqlDiscovered;
            DetectedProperties = detectedProperties;
        }

        /// <summary> The list of extensions affiliated to the machine. </summary>
        public IReadOnlyList<HybridComputeMachineExtensionData> Resources { get; }
        /// <summary> Identity for the resource. Current supported identity types: SystemAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Metadata pertaining to the geographic location of the resource. </summary>
        public LocationData LocationData { get; set; }
        /// <summary> Configurable properties that the user can set locally via the azcmagent config command, or remotely via ARM. </summary>
        public AgentConfiguration AgentConfiguration { get; }
        /// <summary> Statuses of dependent services that are reported back to ARM. </summary>
        public HybridComputeServiceStatuses ServiceStatuses { get; set; }
        /// <summary> The metadata of the cloud environment (Azure/GCP/AWS/OCI...). </summary>
        internal CloudMetadata CloudMetadata { get; set; }
        /// <summary> Specifies the cloud provider (Azure/AWS/GCP...). </summary>
        public string CloudMetadataProvider
        {
            get => CloudMetadata is null ? default : CloudMetadata.Provider;
        }

        /// <summary> The info of the machine w.r.t Agent Upgrade. </summary>
        public AgentUpgrade AgentUpgrade { get; set; }
        /// <summary> Specifies the operating system settings for the hybrid machine. </summary>
        public OSProfile OSProfile { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> The status of the hybrid machine agent. </summary>
        public HybridComputeStatusType? Status { get; }
        /// <summary> The time of the last status change. </summary>
        public DateTimeOffset? LastStatusChange { get; }
        /// <summary> Details about the error state. </summary>
        public IReadOnlyList<ResponseError> ErrorDetails { get; }
        /// <summary> The hybrid machine agent full version. </summary>
        public string AgentVersion { get; }
        /// <summary> Specifies the hybrid machine unique ID. </summary>
        public Guid? VmId { get; set; }
        /// <summary> Specifies the hybrid machine display name. </summary>
        public string DisplayName { get; }
        /// <summary> Specifies the hybrid machine FQDN. </summary>
        public string MachineFqdn { get; }
        /// <summary> Public Key that the client provides to be used during initial resource onboarding. </summary>
        public string ClientPublicKey { get; set; }
        /// <summary> The Operating System running on the hybrid machine. </summary>
        public string OSName { get; }
        /// <summary> The version of Operating System running on the hybrid machine. </summary>
        public string OSVersion { get; }
        /// <summary> The type of Operating System (windows/linux). </summary>
        public string OSType { get; set; }
        /// <summary> Specifies the Arc Machine's unique SMBIOS ID. </summary>
        public Guid? VmUuid { get; }
        /// <summary> Machine Extensions information (deprecated field). </summary>
        public IList<MachineExtensionInstanceView> Extensions { get; }
        /// <summary> Specifies the Operating System product SKU. </summary>
        public string OSSku { get; }
        /// <summary> Specifies the Windows domain name. </summary>
        public string DomainName { get; }
        /// <summary> Specifies the AD fully qualified display name. </summary>
        public string AdFqdn { get; }
        /// <summary> Specifies the DNS fully qualified display name. </summary>
        public string DnsFqdn { get; }
        /// <summary> The resource id of the private link scope this machine is assigned to, if any. </summary>
        public string PrivateLinkScopeResourceId { get; set; }
        /// <summary> The resource id of the parent cluster (Azure HCI) this machine is assigned to, if any. </summary>
        public string ParentClusterResourceId { get; set; }
        /// <summary> Specifies whether any MS SQL instance is discovered on the machine. </summary>
        public string MsSqlDiscovered { get; set; }
        /// <summary> Detected properties from the machine. </summary>
        public IReadOnlyDictionary<string, string> DetectedProperties { get; }
    }
}
