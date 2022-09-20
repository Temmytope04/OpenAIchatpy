// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.LabServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.LabServices
{
    /// <summary> A class representing the LabPlan data model. </summary>
    public partial class LabPlanData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of LabPlanData. </summary>
        /// <param name="location"> The location. </param>
        public LabPlanData(AzureLocation location) : base(location)
        {
            AllowedRegions = new ChangeTrackingList<AzureLocation>();
        }

        /// <summary> Initializes a new instance of LabPlanData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity">
        /// Managed Identity Information
        /// Serialized Name: LabPlan.identity. Current supported identity types: SystemAssigned
        /// </param>
        /// <param name="defaultConnectionProfile">
        /// The default lab connection profile. This can be changed on a lab resource and only provides a default profile.
        /// Serialized Name: LabPlan.properties.defaultConnectionProfile
        /// </param>
        /// <param name="defaultAutoShutdownProfile">
        /// The default lab shutdown profile. This can be changed on a lab resource and only provides a default profile.
        /// Serialized Name: LabPlan.properties.defaultAutoShutdownProfile
        /// </param>
        /// <param name="defaultNetworkProfile">
        /// The lab plan network profile. To enforce lab network policies they must be defined here and cannot be changed when there are existing labs associated with this lab plan.
        /// Serialized Name: LabPlan.properties.defaultNetworkProfile
        /// </param>
        /// <param name="allowedRegions">
        /// The allowed regions for the lab creator to use when creating labs using this lab plan.
        /// Serialized Name: LabPlan.properties.allowedRegions
        /// </param>
        /// <param name="sharedGalleryId">
        /// Resource ID of the Shared Image Gallery attached to this lab plan. When saving a lab template virtual machine image it will be persisted in this gallery. Shared images from the gallery can be made available to use when creating new labs.
        /// Serialized Name: LabPlan.properties.sharedGalleryId
        /// </param>
        /// <param name="supportInfo">
        /// Support contact information and instructions for users of the lab plan. This information is displayed to lab owners and virtual machine users for all labs in the lab plan.
        /// Serialized Name: LabPlan.properties.supportInfo
        /// </param>
        /// <param name="linkedLmsInstance">
        /// Base Url of the lms instance this lab plan can link lab rosters against.
        /// Serialized Name: LabPlan.properties.linkedLmsInstance
        /// </param>
        /// <param name="provisioningState">
        /// Current provisioning state of the lab plan.
        /// Serialized Name: LabPlan.properties.provisioningState
        /// </param>
        internal LabPlanData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, LabVirtualMachineConnectionProfile defaultConnectionProfile, AutoShutdownProfile defaultAutoShutdownProfile, LabPlanNetworkProfile defaultNetworkProfile, IList<AzureLocation> allowedRegions, ResourceIdentifier sharedGalleryId, SupportInfo supportInfo, Uri linkedLmsInstance, ProvisioningState? provisioningState) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            DefaultConnectionProfile = defaultConnectionProfile;
            DefaultAutoShutdownProfile = defaultAutoShutdownProfile;
            DefaultNetworkProfile = defaultNetworkProfile;
            AllowedRegions = allowedRegions;
            SharedGalleryId = sharedGalleryId;
            SupportInfo = supportInfo;
            LinkedLmsInstance = linkedLmsInstance;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// Managed Identity Information
        /// Serialized Name: LabPlan.identity. Current supported identity types: SystemAssigned
        /// </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary>
        /// The default lab connection profile. This can be changed on a lab resource and only provides a default profile.
        /// Serialized Name: LabPlan.properties.defaultConnectionProfile
        /// </summary>
        public LabVirtualMachineConnectionProfile DefaultConnectionProfile { get; set; }
        /// <summary>
        /// The default lab shutdown profile. This can be changed on a lab resource and only provides a default profile.
        /// Serialized Name: LabPlan.properties.defaultAutoShutdownProfile
        /// </summary>
        public AutoShutdownProfile DefaultAutoShutdownProfile { get; set; }
        /// <summary>
        /// The lab plan network profile. To enforce lab network policies they must be defined here and cannot be changed when there are existing labs associated with this lab plan.
        /// Serialized Name: LabPlan.properties.defaultNetworkProfile
        /// </summary>
        internal LabPlanNetworkProfile DefaultNetworkProfile { get; set; }
        /// <summary>
        /// The external subnet resource id
        /// Serialized Name: LabPlanNetworkProfile.subnetId
        /// </summary>
        public ResourceIdentifier DefaultNetworkSubnetId
        {
            get => DefaultNetworkProfile is null ? default : DefaultNetworkProfile.SubnetId;
            set
            {
                if (DefaultNetworkProfile is null)
                    DefaultNetworkProfile = new LabPlanNetworkProfile();
                DefaultNetworkProfile.SubnetId = value;
            }
        }

        /// <summary>
        /// The allowed regions for the lab creator to use when creating labs using this lab plan.
        /// Serialized Name: LabPlan.properties.allowedRegions
        /// </summary>
        public IList<AzureLocation> AllowedRegions { get; }
        /// <summary>
        /// Resource ID of the Shared Image Gallery attached to this lab plan. When saving a lab template virtual machine image it will be persisted in this gallery. Shared images from the gallery can be made available to use when creating new labs.
        /// Serialized Name: LabPlan.properties.sharedGalleryId
        /// </summary>
        public ResourceIdentifier SharedGalleryId { get; set; }
        /// <summary>
        /// Support contact information and instructions for users of the lab plan. This information is displayed to lab owners and virtual machine users for all labs in the lab plan.
        /// Serialized Name: LabPlan.properties.supportInfo
        /// </summary>
        public SupportInfo SupportInfo { get; set; }
        /// <summary>
        /// Base Url of the lms instance this lab plan can link lab rosters against.
        /// Serialized Name: LabPlan.properties.linkedLmsInstance
        /// </summary>
        public Uri LinkedLmsInstance { get; set; }
        /// <summary>
        /// Current provisioning state of the lab plan.
        /// Serialized Name: LabPlan.properties.provisioningState
        /// </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
