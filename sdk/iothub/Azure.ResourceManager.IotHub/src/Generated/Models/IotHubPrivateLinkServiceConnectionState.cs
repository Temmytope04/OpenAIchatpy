// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The current state of a private endpoint connection. </summary>
    public partial class IotHubPrivateLinkServiceConnectionState
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IotHubPrivateLinkServiceConnectionState"/>. </summary>
        /// <param name="status"> The status of a private endpoint connection. </param>
        /// <param name="description"> The description for the current state of a private endpoint connection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="description"/> is null. </exception>
        public IotHubPrivateLinkServiceConnectionState(IotHubPrivateLinkServiceConnectionStatus status, string description)
        {
            Argument.AssertNotNull(description, nameof(description));

            Status = status;
            Description = description;
        }

        /// <summary> Initializes a new instance of <see cref="IotHubPrivateLinkServiceConnectionState"/>. </summary>
        /// <param name="status"> The status of a private endpoint connection. </param>
        /// <param name="description"> The description for the current state of a private endpoint connection. </param>
        /// <param name="actionsRequired"> Actions required for a private endpoint connection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotHubPrivateLinkServiceConnectionState(IotHubPrivateLinkServiceConnectionStatus status, string description, string actionsRequired, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IotHubPrivateLinkServiceConnectionState"/> for deserialization. </summary>
        internal IotHubPrivateLinkServiceConnectionState()
        {
        }

        /// <summary> The status of a private endpoint connection. </summary>
        public IotHubPrivateLinkServiceConnectionStatus Status { get; set; }
        /// <summary> The description for the current state of a private endpoint connection. </summary>
        public string Description { get; set; }
        /// <summary> Actions required for a private endpoint connection. </summary>
        public string ActionsRequired { get; set; }
    }
}
