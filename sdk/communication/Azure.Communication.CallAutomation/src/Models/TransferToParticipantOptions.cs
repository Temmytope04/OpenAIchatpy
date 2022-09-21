﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.Communication.CallAutomation
{
    /// <summary>
    /// The transfer call to participant operation options.
    /// </summary>
    public class TransferToParticipantOptions: RepeatabilityHeaders
    {
        /// <summary>
        /// Creates a new TransferToParticipantOptions object.
        /// </summary>
        /// <param name="targetParticipant"></param>
        /// <param name="repeatabilityRequestId"></param>
        /// <param name="repeatablityFirstSent"></param>
        public TransferToParticipantOptions(CommunicationIdentifier targetParticipant, Guid? repeatabilityRequestId = null, string repeatablityFirstSent = default)
        {
            TargetParticipant = targetParticipant;
            RepeatabilityRequestId = repeatabilityRequestId;
            RepeatabilityFirstSent = repeatablityFirstSent;
        }

        /// <summary>
        /// The target participant to transfer the call to.
        /// </summary>
        public CommunicationIdentifier TargetParticipant { get; }

        /// <summary>
        /// The caller id of the source.
        /// </summary>
        public PhoneNumberIdentifier SourceCallerId { get; set; }

        /// <summary>
        /// The UserToUserInformation.
        /// </summary>
        public string UserToUserInformation { get; set; }

        /// <summary>
        /// The operationContext for this transfer call.
        /// </summary>
        public string OperationContext { get; set; }
    }
}
