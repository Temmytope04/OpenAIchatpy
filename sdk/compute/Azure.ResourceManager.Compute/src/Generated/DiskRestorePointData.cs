// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the DiskRestorePoint data model. </summary>
    public partial class DiskRestorePointData : ResourceData
    {
        /// <summary> Initializes a new instance of DiskRestorePointData. </summary>
        internal DiskRestorePointData()
        {
        }

        /// <summary> Initializes a new instance of DiskRestorePointData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="timeCreated"> The timestamp of restorePoint creation. </param>
        /// <param name="sourceResourceId"> arm id of source disk or source disk restore point. </param>
        /// <param name="osType"> The Operating System type. </param>
        /// <param name="hyperVGeneration"> The hypervisor generation of the Virtual Machine. Applicable to OS disks only. </param>
        /// <param name="purchasePlan"> Purchase plan information for the the image from which the OS disk was created. </param>
        /// <param name="supportedCapabilities"> List of supported capabilities (like accelerated networking) for the image from which the OS disk was created. </param>
        /// <param name="familyId"> id of the backing snapshot&apos;s MIS family. </param>
        /// <param name="sourceUniqueId"> unique incarnation id of the source disk. </param>
        /// <param name="encryption"> Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys. </param>
        /// <param name="supportsHibernation"> Indicates the OS on a disk supports hibernation. </param>
        /// <param name="networkAccessPolicy"> Policy for accessing the disk via network. </param>
        /// <param name="publicNetworkAccess"> Policy for controlling export on the disk. </param>
        /// <param name="diskAccessId"> ARM id of the DiskAccess resource for using private endpoints on disks. </param>
        /// <param name="completionPercent"> Percentage complete for the background copy of disk restore point when source resource is from a different region. </param>
        /// <param name="replicationState"> Replication state of disk restore point when source resource is from a different region. </param>
        /// <param name="sourceResourceLocation"> Location of source disk or source disk restore point when source resource is from a different region. </param>
        internal DiskRestorePointData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? timeCreated, ResourceIdentifier sourceResourceId, OperatingSystemTypes? osType, HyperVGeneration? hyperVGeneration, DiskPurchasePlan purchasePlan, SupportedCapabilities supportedCapabilities, string familyId, string sourceUniqueId, DiskEncryption encryption, bool? supportsHibernation, NetworkAccessPolicy? networkAccessPolicy, PublicNetworkAccess? publicNetworkAccess, ResourceIdentifier diskAccessId, float? completionPercent, string replicationState, AzureLocation? sourceResourceLocation) : base(id, name, resourceType, systemData)
        {
            TimeCreated = timeCreated;
            SourceResourceId = sourceResourceId;
            OSType = osType;
            HyperVGeneration = hyperVGeneration;
            PurchasePlan = purchasePlan;
            SupportedCapabilities = supportedCapabilities;
            FamilyId = familyId;
            SourceUniqueId = sourceUniqueId;
            Encryption = encryption;
            SupportsHibernation = supportsHibernation;
            NetworkAccessPolicy = networkAccessPolicy;
            PublicNetworkAccess = publicNetworkAccess;
            DiskAccessId = diskAccessId;
            CompletionPercent = completionPercent;
            ReplicationState = replicationState;
            SourceResourceLocation = sourceResourceLocation;
        }

        /// <summary> The timestamp of restorePoint creation. </summary>
        public DateTimeOffset? TimeCreated { get; }
        /// <summary> arm id of source disk or source disk restore point. </summary>
        public ResourceIdentifier SourceResourceId { get; }
        /// <summary> The Operating System type. </summary>
        public OperatingSystemTypes? OSType { get; }
        /// <summary> The hypervisor generation of the Virtual Machine. Applicable to OS disks only. </summary>
        public HyperVGeneration? HyperVGeneration { get; }
        /// <summary> Purchase plan information for the the image from which the OS disk was created. </summary>
        public DiskPurchasePlan PurchasePlan { get; }
        /// <summary> List of supported capabilities (like accelerated networking) for the image from which the OS disk was created. </summary>
        internal SupportedCapabilities SupportedCapabilities { get; }
        /// <summary> True if the image from which the OS disk is created supports accelerated networking. </summary>
        public bool? AcceleratedNetwork
        {
            get => SupportedCapabilities?.AcceleratedNetwork;
        }

        /// <summary> id of the backing snapshot&apos;s MIS family. </summary>
        public string FamilyId { get; }
        /// <summary> unique incarnation id of the source disk. </summary>
        public string SourceUniqueId { get; }
        /// <summary> Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys. </summary>
        public DiskEncryption Encryption { get; }
        /// <summary> Indicates the OS on a disk supports hibernation. </summary>
        public bool? SupportsHibernation { get; }
        /// <summary> Policy for accessing the disk via network. </summary>
        public NetworkAccessPolicy? NetworkAccessPolicy { get; }
        /// <summary> Policy for controlling export on the disk. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; }
        /// <summary> ARM id of the DiskAccess resource for using private endpoints on disks. </summary>
        public ResourceIdentifier DiskAccessId { get; }
        /// <summary> Percentage complete for the background copy of disk restore point when source resource is from a different region. </summary>
        public float? CompletionPercent { get; }
        /// <summary> Replication state of disk restore point when source resource is from a different region. </summary>
        public string ReplicationState { get; }
        /// <summary> Location of source disk or source disk restore point when source resource is from a different region. </summary>
        public AzureLocation? SourceResourceLocation { get; }
    }
}
