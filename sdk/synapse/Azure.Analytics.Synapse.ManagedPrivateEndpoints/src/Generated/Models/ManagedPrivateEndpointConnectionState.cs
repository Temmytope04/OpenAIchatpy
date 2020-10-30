// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.ManagedPrivateEndpoints.Models
{
    /// <summary> The connection state of a managed private endpoint. </summary>
    public partial class ManagedPrivateEndpointConnectionState
    {
        /// <summary> Initializes a new instance of ManagedPrivateEndpointConnectionState. </summary>
        public ManagedPrivateEndpointConnectionState()
        {
        }

        /// <summary> Initializes a new instance of ManagedPrivateEndpointConnectionState. </summary>
        /// <param name="status"> The approval status. </param>
        /// <param name="description"> The managed private endpoint description. </param>
        /// <param name="actionsRequired"> The actions required on the managed private endpoint. </param>
        internal ManagedPrivateEndpointConnectionState(string status, string description, string actionsRequired)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
        }

        /// <summary> The approval status. </summary>
        public string Status { get; }
        /// <summary> The managed private endpoint description. </summary>
        public string Description { get; set; }
        /// <summary> The actions required on the managed private endpoint. </summary>
        public string ActionsRequired { get; set; }
    }
}
