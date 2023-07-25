// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing the AvsPrivateCloudDatastore data model.
    /// A datastore resource
    /// </summary>
    public partial class AvsPrivateCloudDatastoreData : ResourceData
    {
        /// <summary> Initializes a new instance of AvsPrivateCloudDatastoreData. </summary>
        public AvsPrivateCloudDatastoreData()
        {
        }

        /// <summary> Initializes a new instance of AvsPrivateCloudDatastoreData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The state of the datastore provisioning. </param>
        /// <param name="netAppVolume"> An Azure NetApp Files volume. </param>
        /// <param name="diskPoolVolume"> An iSCSI volume. </param>
        /// <param name="status"> The operational status of the datastore. </param>
        internal AvsPrivateCloudDatastoreData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AvsPrivateCloudDatastoreProvisioningState? provisioningState, WritableSubResource netAppVolume, DiskPoolVolume diskPoolVolume, DatastoreStatus? status) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            NetAppVolume = netAppVolume;
            DiskPoolVolume = diskPoolVolume;
            Status = status;
        }

        /// <summary> The state of the datastore provisioning. </summary>
        public AvsPrivateCloudDatastoreProvisioningState? ProvisioningState { get; }
        /// <summary> An Azure NetApp Files volume. </summary>
        internal WritableSubResource NetAppVolume { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier NetAppVolumeId
        {
            get => NetAppVolume is null ? default : NetAppVolume.Id;
            set
            {
                if (NetAppVolume is null)
                    NetAppVolume = new WritableSubResource();
                NetAppVolume.Id = value;
            }
        }

        /// <summary> An iSCSI volume. </summary>
        public DiskPoolVolume DiskPoolVolume { get; set; }
        /// <summary> The operational status of the datastore. </summary>
        public DatastoreStatus? Status { get; }
    }
}
