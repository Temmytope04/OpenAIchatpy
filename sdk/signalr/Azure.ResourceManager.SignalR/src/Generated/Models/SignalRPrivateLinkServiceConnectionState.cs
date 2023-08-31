// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Connection state of the private endpoint connection. </summary>
    public partial class SignalRPrivateLinkServiceConnectionState
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SignalRPrivateLinkServiceConnectionState"/>. </summary>
        public SignalRPrivateLinkServiceConnectionState()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SignalRPrivateLinkServiceConnectionState"/>. </summary>
        /// <param name="status"> Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service. </param>
        /// <param name="description"> The reason for approval/rejection of the connection. </param>
        /// <param name="actionsRequired"> A message indicating if changes on the service provider require any updates on the consumer. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SignalRPrivateLinkServiceConnectionState(PrivateLinkServiceConnectionStatus? status, string description, string actionsRequired, Dictionary<string, BinaryData> rawData)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
            _rawData = rawData;
        }

        /// <summary> Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service. </summary>
        public PrivateLinkServiceConnectionStatus? Status { get; set; }
        /// <summary> The reason for approval/rejection of the connection. </summary>
        public string Description { get; set; }
        /// <summary> A message indicating if changes on the service provider require any updates on the consumer. </summary>
        public string ActionsRequired { get; set; }
    }
}
