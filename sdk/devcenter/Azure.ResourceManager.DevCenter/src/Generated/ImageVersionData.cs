// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevCenter
{
    /// <summary> A class representing the ImageVersion data model. </summary>
    public partial class ImageVersionData : ResourceData
    {
        /// <summary> Initializes a new instance of ImageVersionData. </summary>
        public ImageVersionData()
        {
        }

        /// <summary> Initializes a new instance of ImageVersionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="namePropertiesName"> The semantic version string. </param>
        /// <param name="publishedOn"> The datetime that the backing image version was published. </param>
        /// <param name="excludeFromLatest"> If the version should be excluded from being treated as the latest version. </param>
        /// <param name="osDiskImageSizeInGb"> The size of the OS disk image, in GB. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        internal ImageVersionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string namePropertiesName, DateTimeOffset? publishedOn, bool? excludeFromLatest, int? osDiskImageSizeInGb, string provisioningState) : base(id, name, resourceType, systemData)
        {
            NamePropertiesName = namePropertiesName;
            PublishedOn = publishedOn;
            ExcludeFromLatest = excludeFromLatest;
            OSDiskImageSizeInGb = osDiskImageSizeInGb;
            ProvisioningState = provisioningState;
        }

        /// <summary> The semantic version string. </summary>
        public string NamePropertiesName { get; }
        /// <summary> The datetime that the backing image version was published. </summary>
        public DateTimeOffset? PublishedOn { get; }
        /// <summary> If the version should be excluded from being treated as the latest version. </summary>
        public bool? ExcludeFromLatest { get; }
        /// <summary> The size of the OS disk image, in GB. </summary>
        public int? OSDiskImageSizeInGb { get; }
        /// <summary> The provisioning state of the resource. </summary>
        public string ProvisioningState { get; }
    }
}
