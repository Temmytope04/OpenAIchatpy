// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> Workspaces resource specific properties. </summary>
    public partial class WorkspaceProperties
    {
        /// <summary> Initializes a new instance of WorkspaceProperties. </summary>
        public WorkspaceProperties()
        {
            PrivateEndpointConnections = new ChangeTrackingList<ServicePrivateEndpointConnectionCreateOrUpdateContent>();
        }

        /// <summary> Initializes a new instance of WorkspaceProperties. </summary>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="privateEndpointConnections"> The list of private endpoint connections that are set up for this resource. </param>
        /// <param name="publicNetworkAccess"> Control permission for data plane traffic coming from public networks while private endpoint is enabled. </param>
        internal WorkspaceProperties(ProvisioningState? provisioningState, IReadOnlyList<ServicePrivateEndpointConnectionCreateOrUpdateContent> privateEndpointConnections, PublicNetworkAccess? publicNetworkAccess)
        {
            ProvisioningState = provisioningState;
            PrivateEndpointConnections = privateEndpointConnections;
            PublicNetworkAccess = publicNetworkAccess;
        }

        /// <summary> The provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The list of private endpoint connections that are set up for this resource. </summary>
        public IReadOnlyList<ServicePrivateEndpointConnectionCreateOrUpdateContent> PrivateEndpointConnections { get; }
        /// <summary> Control permission for data plane traffic coming from public networks while private endpoint is enabled. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }
    }
}
