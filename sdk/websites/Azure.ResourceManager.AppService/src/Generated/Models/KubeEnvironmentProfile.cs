// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Specification for a Kubernetes Environment to use for this resource. </summary>
    public partial class KubeEnvironmentProfile
    {
        /// <summary> Initializes a new instance of KubeEnvironmentProfile. </summary>
        public KubeEnvironmentProfile()
        {
        }

        /// <summary> Initializes a new instance of KubeEnvironmentProfile. </summary>
        /// <param name="id"> Resource ID of the Kubernetes Environment. </param>
        /// <param name="name"> Name of the Kubernetes Environment. </param>
        /// <param name="resourceType"> Resource type of the Kubernetes Environment. </param>
        internal KubeEnvironmentProfile(ResourceIdentifier id, string name, ResourceType? resourceType)
        {
            Id = id;
            Name = name;
            ResourceType = resourceType;
        }

        /// <summary> Resource ID of the Kubernetes Environment. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> Name of the Kubernetes Environment. </summary>
        public string Name { get; }
        /// <summary> Resource type of the Kubernetes Environment. </summary>
        public ResourceType? ResourceType { get; }
    }
}
