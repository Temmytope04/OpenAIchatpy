// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing the ClusterManager data model.
    /// ClusterManager represents a control-plane to manage one or more on-premises clusters.
    /// </summary>
    public partial class ClusterManagerData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ClusterManagerData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="fabricControllerId"> The resource ID of the fabric controller that has one to one mapping with the cluster manager. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fabricControllerId"/> is null. </exception>
        public ClusterManagerData(AzureLocation location, string fabricControllerId) : base(location)
        {
            Argument.AssertNotNull(fabricControllerId, nameof(fabricControllerId));

            AvailabilityZones = new ChangeTrackingList<string>();
            ClusterVersions = new ChangeTrackingList<ClusterAvailableVersion>();
            FabricControllerId = fabricControllerId;
        }

        /// <summary> Initializes a new instance of ClusterManagerData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="analyticsWorkspaceId"> The resource ID of the Log Analytics workspace that is used for the logs collection. </param>
        /// <param name="availabilityZones"> Field deprecated, this value will no longer influence the cluster manager allocation process and will be removed in a future version. The Azure availability zones within the region that will be used to support the cluster manager resource. </param>
        /// <param name="clusterVersions"> The list of the cluster versions the manager supports. It is used as input in clusterVersion property of a cluster resource. </param>
        /// <param name="detailedStatus"> The detailed status that provides additional information about the cluster manager. </param>
        /// <param name="detailedStatusMessage"> The descriptive message about the current detailed status. </param>
        /// <param name="fabricControllerId"> The resource ID of the fabric controller that has one to one mapping with the cluster manager. </param>
        /// <param name="managedResourceGroupConfiguration"> The configuration of the managed resource group associated with the resource. </param>
        /// <param name="managerExtendedLocation"> The extended location (custom location) that represents the cluster manager's control plane location. This extended location is used when creating cluster and rack manifest resources. </param>
        /// <param name="provisioningState"> The provisioning state of the cluster manager. </param>
        /// <param name="vmSize"> Field deprecated, this value will no longer influence the cluster manager allocation process and will be removed in a future version. The size of the Azure virtual machines to use for hosting the cluster manager resource. </param>
        internal ClusterManagerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string analyticsWorkspaceId, IList<string> availabilityZones, IReadOnlyList<ClusterAvailableVersion> clusterVersions, ClusterManagerDetailedStatus? detailedStatus, string detailedStatusMessage, string fabricControllerId, ManagedResourceGroupConfiguration managedResourceGroupConfiguration, ExtendedLocation managerExtendedLocation, ClusterManagerProvisioningState? provisioningState, string vmSize) : base(id, name, resourceType, systemData, tags, location)
        {
            AnalyticsWorkspaceId = analyticsWorkspaceId;
            AvailabilityZones = availabilityZones;
            ClusterVersions = clusterVersions;
            DetailedStatus = detailedStatus;
            DetailedStatusMessage = detailedStatusMessage;
            FabricControllerId = fabricControllerId;
            ManagedResourceGroupConfiguration = managedResourceGroupConfiguration;
            ManagerExtendedLocation = managerExtendedLocation;
            ProvisioningState = provisioningState;
            VmSize = vmSize;
        }

        /// <summary> The resource ID of the Log Analytics workspace that is used for the logs collection. </summary>
        public string AnalyticsWorkspaceId { get; set; }
        /// <summary> Field deprecated, this value will no longer influence the cluster manager allocation process and will be removed in a future version. The Azure availability zones within the region that will be used to support the cluster manager resource. </summary>
        public IList<string> AvailabilityZones { get; }
        /// <summary> The list of the cluster versions the manager supports. It is used as input in clusterVersion property of a cluster resource. </summary>
        public IReadOnlyList<ClusterAvailableVersion> ClusterVersions { get; }
        /// <summary> The detailed status that provides additional information about the cluster manager. </summary>
        public ClusterManagerDetailedStatus? DetailedStatus { get; }
        /// <summary> The descriptive message about the current detailed status. </summary>
        public string DetailedStatusMessage { get; }
        /// <summary> The resource ID of the fabric controller that has one to one mapping with the cluster manager. </summary>
        public string FabricControllerId { get; set; }
        /// <summary> The configuration of the managed resource group associated with the resource. </summary>
        public ManagedResourceGroupConfiguration ManagedResourceGroupConfiguration { get; set; }
        /// <summary> The extended location (custom location) that represents the cluster manager's control plane location. This extended location is used when creating cluster and rack manifest resources. </summary>
        public ExtendedLocation ManagerExtendedLocation { get; }
        /// <summary> The provisioning state of the cluster manager. </summary>
        public ClusterManagerProvisioningState? ProvisioningState { get; }
        /// <summary> Field deprecated, this value will no longer influence the cluster manager allocation process and will be removed in a future version. The size of the Azure virtual machines to use for hosting the cluster manager resource. </summary>
        public string VmSize { get; set; }
    }
}
