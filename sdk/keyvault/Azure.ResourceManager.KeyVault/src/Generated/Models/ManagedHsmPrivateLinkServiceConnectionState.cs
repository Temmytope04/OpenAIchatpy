// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> An object that represents the approval state of the private link connection. </summary>
    public partial class ManagedHsmPrivateLinkServiceConnectionState
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedHsmPrivateLinkServiceConnectionState"/>. </summary>
        public ManagedHsmPrivateLinkServiceConnectionState()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedHsmPrivateLinkServiceConnectionState"/>. </summary>
        /// <param name="status"> Indicates whether the connection has been approved, rejected or removed by the key vault owner. </param>
        /// <param name="description"> The reason for approval or rejection. </param>
        /// <param name="actionsRequired"> A message indicating if changes on the service provider require any updates on the consumer. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedHsmPrivateLinkServiceConnectionState(ManagedHsmPrivateEndpointServiceConnectionStatus? status, string description, ManagedHsmActionsRequiredMessage? actionsRequired, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates whether the connection has been approved, rejected or removed by the key vault owner. </summary>
        public ManagedHsmPrivateEndpointServiceConnectionStatus? Status { get; set; }
        /// <summary> The reason for approval or rejection. </summary>
        public string Description { get; set; }
        /// <summary> A message indicating if changes on the service provider require any updates on the consumer. </summary>
        public ManagedHsmActionsRequiredMessage? ActionsRequired { get; set; }
    }
}
