// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The parameters for updating a machine learning workspace. </summary>
    public partial class MachineLearningWorkspacePatch
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningWorkspacePatch"/>. </summary>
        public MachineLearningWorkspacePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Managed service identity (system assigned and/or user assigned identities). </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Optional. This field is required to be implemented by the RP because AML is supporting more than one tier. </summary>
        public MachineLearningSku Sku { get; set; }
        /// <summary> The resource tags for the machine learning workspace. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> ARM id of the application insights associated with this workspace. </summary>
        public string ApplicationInsights { get; set; }
        /// <summary> ARM id of the container registry associated with this workspace. </summary>
        public string ContainerRegistry { get; set; }
        /// <summary> The description of this workspace. </summary>
        public string Description { get; set; }
        /// <summary> Gets or sets the enable data isolation. </summary>
        public bool? EnableDataIsolation { get; set; }
        /// <summary> Gets or sets the encryption. </summary>
        internal EncryptionUpdateProperties Encryption { get; set; }
        /// <summary> Gets or sets the key identifier. </summary>
        public string KeyIdentifier
        {
            get => Encryption is null ? default : Encryption.KeyIdentifier;
            set => Encryption = new EncryptionUpdateProperties(value);
        }

        /// <summary> Settings for feature store type workspace. </summary>
        public FeatureStoreSettings FeatureStoreSettings { get; set; }
        /// <summary> The friendly name for this workspace. This name in mutable. </summary>
        public string FriendlyName { get; set; }
        /// <summary> The compute name for image build. </summary>
        public string ImageBuildCompute { get; set; }
        /// <summary> Managed Network settings for a machine learning workspace. </summary>
        public ManagedNetworkSettings ManagedNetwork { get; set; }
        /// <summary> The user assigned identity resource id that represents the workspace identity. </summary>
        public string PrimaryUserAssignedIdentity { get; set; }
        /// <summary> Whether requests from Public Network are allowed. </summary>
        public MachineLearningPublicNetworkAccessType? PublicNetworkAccessType { get; set; }
        /// <summary> The service managed resource settings. </summary>
        internal ServiceManagedResourcesSettings ServiceManagedResourcesSettings { get; set; }
        /// <summary> Gets or sets the cosmos db collections throughput. </summary>
        public int? CosmosDbCollectionsThroughput
        {
            get => ServiceManagedResourcesSettings is null ? default : ServiceManagedResourcesSettings.CosmosDbCollectionsThroughput;
            set
            {
                if (ServiceManagedResourcesSettings is null)
                    ServiceManagedResourcesSettings = new ServiceManagedResourcesSettings();
                ServiceManagedResourcesSettings.CosmosDbCollectionsThroughput = value;
            }
        }

        /// <summary> Retention time in days after workspace get soft deleted. </summary>
        public int? SoftDeleteRetentionInDays { get; set; }
        /// <summary> Enabling v1_legacy_mode may prevent you from using features provided by the v2 API. </summary>
        public bool? V1LegacyMode { get; set; }
    }
}
