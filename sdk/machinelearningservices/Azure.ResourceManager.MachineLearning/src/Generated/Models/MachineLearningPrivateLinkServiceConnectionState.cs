// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> A collection of information about the state of the connection between service consumer and provider. </summary>
    public partial class MachineLearningPrivateLinkServiceConnectionState
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningPrivateLinkServiceConnectionState"/>. </summary>
        public MachineLearningPrivateLinkServiceConnectionState()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningPrivateLinkServiceConnectionState"/>. </summary>
        /// <param name="actionsRequired"> Some RP chose "None". Other RPs use this for region expansion. </param>
        /// <param name="description"> User-defined message that, per NRP doc, may be used for approval-related message. </param>
        /// <param name="status"> Connection status of the service consumer with the service provider. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningPrivateLinkServiceConnectionState(string actionsRequired, string description, MachineLearningPrivateEndpointServiceConnectionStatus? status, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ActionsRequired = actionsRequired;
            Description = description;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Some RP chose "None". Other RPs use this for region expansion. </summary>
        public string ActionsRequired { get; set; }
        /// <summary> User-defined message that, per NRP doc, may be used for approval-related message. </summary>
        public string Description { get; set; }
        /// <summary> Connection status of the service consumer with the service provider. </summary>
        public MachineLearningPrivateEndpointServiceConnectionStatus? Status { get; set; }
    }
}
