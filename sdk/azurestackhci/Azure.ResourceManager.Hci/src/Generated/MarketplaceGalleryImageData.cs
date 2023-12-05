// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A class representing the MarketplaceGalleryImage data model.
    /// The marketplace gallery image resource definition.
    /// </summary>
    public partial class MarketplaceGalleryImageData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="MarketplaceGalleryImageData"/>. </summary>
        /// <param name="location"> The location. </param>
        public MarketplaceGalleryImageData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="MarketplaceGalleryImageData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extendedLocation of the resource. </param>
        /// <param name="containerId"> Storage ContainerID of the storage container to be used for marketplace gallery image. </param>
        /// <param name="osType"> Operating system type that the gallery image uses [Windows, Linux]. </param>
        /// <param name="cloudInitDataSource"> Datasource for the gallery image when provisioning with cloud-init [NoCloud, Azure]. </param>
        /// <param name="hyperVGeneration"> The hypervisor generation of the Virtual Machine [V1, V2]. </param>
        /// <param name="identifier"> This is the gallery image definition identifier. </param>
        /// <param name="version"> Specifies information about the gallery image version that you want to create or update. </param>
        /// <param name="provisioningState"> Provisioning state of the marketplace gallery image. </param>
        /// <param name="status"> The observed state of marketplace gallery images. </param>
        internal MarketplaceGalleryImageData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ArcVmExtendedLocation extendedLocation, ResourceIdentifier containerId, OperatingSystemType? osType, CloudInitDataSource? cloudInitDataSource, HyperVGeneration? hyperVGeneration, GalleryImageIdentifier identifier, GalleryImageVersion version, ProvisioningStateEnum? provisioningState, MarketplaceGalleryImageStatus status) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            ContainerId = containerId;
            OSType = osType;
            CloudInitDataSource = cloudInitDataSource;
            HyperVGeneration = hyperVGeneration;
            Identifier = identifier;
            Version = version;
            ProvisioningState = provisioningState;
            Status = status;
        }

        /// <summary> The extendedLocation of the resource. </summary>
        public ArcVmExtendedLocation ExtendedLocation { get; set; }
        /// <summary> Storage ContainerID of the storage container to be used for marketplace gallery image. </summary>
        public ResourceIdentifier ContainerId { get; set; }
        /// <summary> Operating system type that the gallery image uses [Windows, Linux]. </summary>
        public OperatingSystemType? OSType { get; set; }
        /// <summary> Datasource for the gallery image when provisioning with cloud-init [NoCloud, Azure]. </summary>
        public CloudInitDataSource? CloudInitDataSource { get; set; }
        /// <summary> The hypervisor generation of the Virtual Machine [V1, V2]. </summary>
        public HyperVGeneration? HyperVGeneration { get; set; }
        /// <summary> This is the gallery image definition identifier. </summary>
        public GalleryImageIdentifier Identifier { get; set; }
        /// <summary> Specifies information about the gallery image version that you want to create or update. </summary>
        public GalleryImageVersion Version { get; set; }
        /// <summary> Provisioning state of the marketplace gallery image. </summary>
        public ProvisioningStateEnum? ProvisioningState { get; }
        /// <summary> The observed state of marketplace gallery images. </summary>
        public MarketplaceGalleryImageStatus Status { get; }
    }
}
