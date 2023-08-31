// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the move resource properties. </summary>
    public partial class MoverResourceProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MoverResourceProperties"/>. </summary>
        /// <param name="sourceId"> Gets or sets the Source ARM Id of the resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceId"/> is null. </exception>
        public MoverResourceProperties(ResourceIdentifier sourceId)
        {
            Argument.AssertNotNull(sourceId, nameof(sourceId));

            SourceId = sourceId;
            DependsOn = new ChangeTrackingList<MoverResourceDependency>();
            DependsOnOverrides = new ChangeTrackingList<MoverResourceDependencyOverride>();
        }

        /// <summary> Initializes a new instance of <see cref="MoverResourceProperties"/>. </summary>
        /// <param name="provisioningState"> Defines the provisioning states. </param>
        /// <param name="sourceId"> Gets or sets the Source ARM Id of the resource. </param>
        /// <param name="targetId"> Gets or sets the Target ARM Id of the resource. </param>
        /// <param name="existingTargetId"> Gets or sets the existing target ARM Id of the resource. </param>
        /// <param name="resourceSettings">
        /// Gets or sets the resource settings.
        /// Please note <see cref="MoverResourceSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MoverAvailabilitySetResourceSettings"/>, <see cref="DiskEncryptionSetResourceSettings"/>, <see cref="VirtualMachineResourceSettings"/>, <see cref="KeyVaultResourceSettings"/>, <see cref="LoadBalancerResourceSettings"/>, <see cref="NetworkInterfaceResourceSettings"/>, <see cref="NetworkSecurityGroupResourceSettings"/>, <see cref="PublicIPAddressResourceSettings"/>, <see cref="MoverVirtualNetworkResourceSettings"/>, <see cref="SqlServerResourceSettings"/>, <see cref="SqlDatabaseResourceSettings"/>, <see cref="SqlElasticPoolResourceSettings"/> and <see cref="ResourceGroupResourceSettings"/>.
        /// </param>
        /// <param name="sourceResourceSettings">
        /// Gets or sets the source resource settings.
        /// Please note <see cref="MoverResourceSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MoverAvailabilitySetResourceSettings"/>, <see cref="DiskEncryptionSetResourceSettings"/>, <see cref="VirtualMachineResourceSettings"/>, <see cref="KeyVaultResourceSettings"/>, <see cref="LoadBalancerResourceSettings"/>, <see cref="NetworkInterfaceResourceSettings"/>, <see cref="NetworkSecurityGroupResourceSettings"/>, <see cref="PublicIPAddressResourceSettings"/>, <see cref="MoverVirtualNetworkResourceSettings"/>, <see cref="SqlServerResourceSettings"/>, <see cref="SqlDatabaseResourceSettings"/>, <see cref="SqlElasticPoolResourceSettings"/> and <see cref="ResourceGroupResourceSettings"/>.
        /// </param>
        /// <param name="moveStatus"> Defines the move resource status. </param>
        /// <param name="dependsOn"> Gets or sets the move resource dependencies. </param>
        /// <param name="dependsOnOverrides"> Gets or sets the move resource dependencies overrides. </param>
        /// <param name="isResolveRequired"> Gets a value indicating whether the resolve action is required over the move collection. </param>
        /// <param name="errors"> Defines the move resource errors. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MoverResourceProperties(MoverProvisioningState? provisioningState, ResourceIdentifier sourceId, ResourceIdentifier targetId, ResourceIdentifier existingTargetId, MoverResourceSettings resourceSettings, MoverResourceSettings sourceResourceSettings, MoverResourcePropertiesMoveStatus moveStatus, IReadOnlyList<MoverResourceDependency> dependsOn, IList<MoverResourceDependencyOverride> dependsOnOverrides, bool? isResolveRequired, MoveResourcePropertiesErrors errors, Dictionary<string, BinaryData> rawData)
        {
            ProvisioningState = provisioningState;
            SourceId = sourceId;
            TargetId = targetId;
            ExistingTargetId = existingTargetId;
            ResourceSettings = resourceSettings;
            SourceResourceSettings = sourceResourceSettings;
            MoveStatus = moveStatus;
            DependsOn = dependsOn;
            DependsOnOverrides = dependsOnOverrides;
            IsResolveRequired = isResolveRequired;
            Errors = errors;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MoverResourceProperties"/> for deserialization. </summary>
        internal MoverResourceProperties()
        {
        }

        /// <summary> Defines the provisioning states. </summary>
        public MoverProvisioningState? ProvisioningState { get; }
        /// <summary> Gets or sets the Source ARM Id of the resource. </summary>
        public ResourceIdentifier SourceId { get; set; }
        /// <summary> Gets or sets the Target ARM Id of the resource. </summary>
        public ResourceIdentifier TargetId { get; }
        /// <summary> Gets or sets the existing target ARM Id of the resource. </summary>
        public ResourceIdentifier ExistingTargetId { get; set; }
        /// <summary>
        /// Gets or sets the resource settings.
        /// Please note <see cref="MoverResourceSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MoverAvailabilitySetResourceSettings"/>, <see cref="DiskEncryptionSetResourceSettings"/>, <see cref="VirtualMachineResourceSettings"/>, <see cref="KeyVaultResourceSettings"/>, <see cref="LoadBalancerResourceSettings"/>, <see cref="NetworkInterfaceResourceSettings"/>, <see cref="NetworkSecurityGroupResourceSettings"/>, <see cref="PublicIPAddressResourceSettings"/>, <see cref="MoverVirtualNetworkResourceSettings"/>, <see cref="SqlServerResourceSettings"/>, <see cref="SqlDatabaseResourceSettings"/>, <see cref="SqlElasticPoolResourceSettings"/> and <see cref="ResourceGroupResourceSettings"/>.
        /// </summary>
        public MoverResourceSettings ResourceSettings { get; set; }
        /// <summary>
        /// Gets or sets the source resource settings.
        /// Please note <see cref="MoverResourceSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MoverAvailabilitySetResourceSettings"/>, <see cref="DiskEncryptionSetResourceSettings"/>, <see cref="VirtualMachineResourceSettings"/>, <see cref="KeyVaultResourceSettings"/>, <see cref="LoadBalancerResourceSettings"/>, <see cref="NetworkInterfaceResourceSettings"/>, <see cref="NetworkSecurityGroupResourceSettings"/>, <see cref="PublicIPAddressResourceSettings"/>, <see cref="MoverVirtualNetworkResourceSettings"/>, <see cref="SqlServerResourceSettings"/>, <see cref="SqlDatabaseResourceSettings"/>, <see cref="SqlElasticPoolResourceSettings"/> and <see cref="ResourceGroupResourceSettings"/>.
        /// </summary>
        public MoverResourceSettings SourceResourceSettings { get; }
        /// <summary> Defines the move resource status. </summary>
        public MoverResourcePropertiesMoveStatus MoveStatus { get; }
        /// <summary> Gets or sets the move resource dependencies. </summary>
        public IReadOnlyList<MoverResourceDependency> DependsOn { get; }
        /// <summary> Gets or sets the move resource dependencies overrides. </summary>
        public IList<MoverResourceDependencyOverride> DependsOnOverrides { get; }
        /// <summary> Gets a value indicating whether the resolve action is required over the move collection. </summary>
        public bool? IsResolveRequired { get; }
        /// <summary> Defines the move resource errors. </summary>
        internal MoveResourcePropertiesErrors Errors { get; }
        /// <summary> The move resource error body. </summary>
        public ResponseError ErrorsProperties
        {
            get => Errors?.Properties;
        }
    }
}
