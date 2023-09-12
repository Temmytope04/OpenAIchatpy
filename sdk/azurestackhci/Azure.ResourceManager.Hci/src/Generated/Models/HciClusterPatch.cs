// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Cluster details to update. </summary>
    public partial class HciClusterPatch
    {
        /// <summary> Initializes a new instance of HciClusterPatch. </summary>
        public HciClusterPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            UserAssignedIdentities = new ChangeTrackingDictionary<string, UserAssignedIdentity>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Endpoint configured for management from the Azure portal. </summary>
        public string CloudManagementEndpoint { get; set; }
        /// <summary> App id of cluster AAD identity. </summary>
        public Guid? AadClientId { get; set; }
        /// <summary> Tenant id of cluster AAD identity. </summary>
        public Guid? AadTenantId { get; set; }
        /// <summary> Desired properties of the cluster. </summary>
        public HciClusterDesiredProperties DesiredProperties { get; set; }
        /// <summary> The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity. </summary>
        public Guid? PrincipalId { get; }
        /// <summary> The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity. </summary>
        public Guid? TenantId { get; }
        /// <summary> Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed). </summary>
        public HciManagedServiceIdentityType? HciManagedServiceIdentityType { get; set; }
        /// <summary> The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}. The dictionary values can be empty objects ({}) in requests. </summary>
        public IDictionary<string, UserAssignedIdentity> UserAssignedIdentities { get; }
    }
}
