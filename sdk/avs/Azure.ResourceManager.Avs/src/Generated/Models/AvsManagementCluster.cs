// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The properties of a management cluster. </summary>
    public partial class AvsManagementCluster : CommonClusterProperties
    {
        /// <summary> Initializes a new instance of AvsManagementCluster. </summary>
        public AvsManagementCluster()
        {
        }

        /// <summary> Initializes a new instance of AvsManagementCluster. </summary>
        /// <param name="clusterSize"> The cluster size. </param>
        /// <param name="provisioningState"> The state of the cluster provisioning. </param>
        /// <param name="clusterId"> The identity. </param>
        /// <param name="hosts"> The hosts. </param>
        internal AvsManagementCluster(int? clusterSize, AvsPrivateCloudClusterProvisioningState? provisioningState, int? clusterId, IList<string> hosts) : base(clusterSize, provisioningState, clusterId, hosts)
        {
        }
    }
}
