// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Component container definition.
    /// &lt;see href="https://docs.microsoft.com/en-us/azure/machine-learning/reference-yaml-component-command" /&gt;
    /// </summary>
    public partial class MachineLearningComponentContainerProperties : MachineLearningAssetContainer
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningComponentContainerProperties"/>. </summary>
        public MachineLearningComponentContainerProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningComponentContainerProperties"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="latestVersion"> The latest version inside this container. </param>
        /// <param name="nextVersion"> The next auto incremental version. </param>
        /// <param name="provisioningState"> Provisioning state for the component container. </param>
        internal MachineLearningComponentContainerProperties(string description, IDictionary<string, string> tags, IDictionary<string, string> properties, IDictionary<string, BinaryData> serializedAdditionalRawData, bool? isArchived, string latestVersion, string nextVersion, RegistryAssetProvisioningState? provisioningState) : base(description, tags, properties, serializedAdditionalRawData, isArchived, latestVersion, nextVersion)
        {
            ProvisioningState = provisioningState;
        }

        /// <summary> Provisioning state for the component container. </summary>
        [WirePath("provisioningState")]
        public RegistryAssetProvisioningState? ProvisioningState { get; }
    }
}
