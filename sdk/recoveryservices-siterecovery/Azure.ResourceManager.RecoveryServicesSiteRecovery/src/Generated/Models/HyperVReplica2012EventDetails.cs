// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Model class for event details of a HyperVReplica E2E event. </summary>
    public partial class HyperVReplica2012EventDetails : SiteRecoveryEventProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of <see cref="HyperVReplica2012EventDetails"/>. </summary>
        internal HyperVReplica2012EventDetails()
        {
            InstanceType = "HyperVReplica2012";
        }

        /// <summary> Initializes a new instance of <see cref="HyperVReplica2012EventDetails"/>. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="containerName"> The container friendly name. </param>
        /// <param name="fabricName"> The fabric friendly name. </param>
        /// <param name="remoteContainerName"> The remote container name. </param>
        /// <param name="remoteFabricName"> The remote fabric name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HyperVReplica2012EventDetails(string instanceType, string containerName, string fabricName, string remoteContainerName, string remoteFabricName, Dictionary<string, BinaryData> rawData) : base(instanceType, rawData)
        {
            ContainerName = containerName;
            FabricName = fabricName;
            RemoteContainerName = remoteContainerName;
            RemoteFabricName = remoteFabricName;
            InstanceType = instanceType ?? "HyperVReplica2012";
        }

        /// <summary> The container friendly name. </summary>
        public string ContainerName { get; }
        /// <summary> The fabric friendly name. </summary>
        public string FabricName { get; }
        /// <summary> The remote container name. </summary>
        public string RemoteContainerName { get; }
        /// <summary> The remote fabric name. </summary>
        public string RemoteFabricName { get; }
    }
}
