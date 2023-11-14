// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The Edifact one way agreement. </summary>
    public partial class EdifactOneWayAgreement
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EdifactOneWayAgreement"/>. </summary>
        /// <param name="senderBusinessIdentity"> The sender business identity. </param>
        /// <param name="receiverBusinessIdentity"> The receiver business identity. </param>
        /// <param name="protocolSettings"> The EDIFACT protocol settings. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="senderBusinessIdentity"/>, <paramref name="receiverBusinessIdentity"/> or <paramref name="protocolSettings"/> is null. </exception>
        public EdifactOneWayAgreement(IntegrationAccountBusinessIdentity senderBusinessIdentity, IntegrationAccountBusinessIdentity receiverBusinessIdentity, EdifactProtocolSettings protocolSettings)
        {
            Argument.AssertNotNull(senderBusinessIdentity, nameof(senderBusinessIdentity));
            Argument.AssertNotNull(receiverBusinessIdentity, nameof(receiverBusinessIdentity));
            Argument.AssertNotNull(protocolSettings, nameof(protocolSettings));

            SenderBusinessIdentity = senderBusinessIdentity;
            ReceiverBusinessIdentity = receiverBusinessIdentity;
            ProtocolSettings = protocolSettings;
        }

        /// <summary> Initializes a new instance of <see cref="EdifactOneWayAgreement"/>. </summary>
        /// <param name="senderBusinessIdentity"> The sender business identity. </param>
        /// <param name="receiverBusinessIdentity"> The receiver business identity. </param>
        /// <param name="protocolSettings"> The EDIFACT protocol settings. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EdifactOneWayAgreement(IntegrationAccountBusinessIdentity senderBusinessIdentity, IntegrationAccountBusinessIdentity receiverBusinessIdentity, EdifactProtocolSettings protocolSettings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SenderBusinessIdentity = senderBusinessIdentity;
            ReceiverBusinessIdentity = receiverBusinessIdentity;
            ProtocolSettings = protocolSettings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EdifactOneWayAgreement"/> for deserialization. </summary>
        internal EdifactOneWayAgreement()
        {
        }

        /// <summary> The sender business identity. </summary>
        public IntegrationAccountBusinessIdentity SenderBusinessIdentity { get; set; }
        /// <summary> The receiver business identity. </summary>
        public IntegrationAccountBusinessIdentity ReceiverBusinessIdentity { get; set; }
        /// <summary> The EDIFACT protocol settings. </summary>
        public EdifactProtocolSettings ProtocolSettings { get; set; }
    }
}
