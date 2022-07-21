// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.StoragePool.Models;

namespace Azure.ResourceManager.StoragePool
{
    /// <summary> A class representing the DiskPool data model. </summary>
    public partial class DiskPoolData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of DiskPoolData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> State of the operation on the resource. </param>
        /// <param name="availabilityZones"> Logical zone for Disk Pool resource; example: [&quot;1&quot;]. </param>
        /// <param name="status"> Operational status of the Disk Pool. </param>
        /// <param name="subnetId"> Azure Resource ID of a Subnet for the Disk Pool. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilityZones"/> or <paramref name="subnetId"/> is null. </exception>
        public DiskPoolData(AzureLocation location, ProvisioningState provisioningState, IEnumerable<string> availabilityZones, OperationalStatus status, ResourceIdentifier subnetId) : base(location)
        {
            if (availabilityZones == null)
            {
                throw new ArgumentNullException(nameof(availabilityZones));
            }
            if (subnetId == null)
            {
                throw new ArgumentNullException(nameof(subnetId));
            }

            ManagedByExtended = new ChangeTrackingList<string>();
            ProvisioningState = provisioningState;
            AvailabilityZones = availabilityZones.ToList();
            Status = status;
            Disks = new ChangeTrackingList<WritableSubResource>();
            SubnetId = subnetId;
            AdditionalCapabilities = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DiskPoolData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Determines the SKU of the Disk pool. </param>
        /// <param name="managedBy"> Azure resource id. Indicates if this resource is managed by another Azure resource. </param>
        /// <param name="managedByExtended"> List of Azure resource ids that manage this resource. </param>
        /// <param name="provisioningState"> State of the operation on the resource. </param>
        /// <param name="availabilityZones"> Logical zone for Disk Pool resource; example: [&quot;1&quot;]. </param>
        /// <param name="status"> Operational status of the Disk Pool. </param>
        /// <param name="disks"> List of Azure Managed Disks to attach to a Disk Pool. </param>
        /// <param name="subnetId"> Azure Resource ID of a Subnet for the Disk Pool. </param>
        /// <param name="additionalCapabilities"> List of additional capabilities for Disk Pool. </param>
        internal DiskPoolData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, StoragePoolSku sku, string managedBy, IReadOnlyList<string> managedByExtended, ProvisioningState provisioningState, IList<string> availabilityZones, OperationalStatus status, IList<WritableSubResource> disks, ResourceIdentifier subnetId, IList<string> additionalCapabilities) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            ManagedBy = managedBy;
            ManagedByExtended = managedByExtended;
            ProvisioningState = provisioningState;
            AvailabilityZones = availabilityZones;
            Status = status;
            Disks = disks;
            SubnetId = subnetId;
            AdditionalCapabilities = additionalCapabilities;
        }

        /// <summary> Determines the SKU of the Disk pool. </summary>
        public StoragePoolSku Sku { get; set; }
        /// <summary> Azure resource id. Indicates if this resource is managed by another Azure resource. </summary>
        public string ManagedBy { get; }
        /// <summary> List of Azure resource ids that manage this resource. </summary>
        public IReadOnlyList<string> ManagedByExtended { get; }
        /// <summary> State of the operation on the resource. </summary>
        public ProvisioningState ProvisioningState { get; }
        /// <summary> Logical zone for Disk Pool resource; example: [&quot;1&quot;]. </summary>
        public IList<string> AvailabilityZones { get; }
        /// <summary> Operational status of the Disk Pool. </summary>
        public OperationalStatus Status { get; set; }
        /// <summary> List of Azure Managed Disks to attach to a Disk Pool. </summary>
        public IList<WritableSubResource> Disks { get; }
        /// <summary> Azure Resource ID of a Subnet for the Disk Pool. </summary>
        public ResourceIdentifier SubnetId { get; set; }
        /// <summary> List of additional capabilities for Disk Pool. </summary>
        public IList<string> AdditionalCapabilities { get; }
    }
}
