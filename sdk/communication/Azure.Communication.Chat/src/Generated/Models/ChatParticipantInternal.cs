// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Communication;

namespace Azure.Communication.Chat
{
    /// <summary> A participant of the chat thread. </summary>
    internal partial class ChatParticipantInternal
    {
        /// <summary> Initializes a new instance of <see cref="ChatParticipantInternal"/>. </summary>
        /// <param name="communicationIdentifier"> Identifies a participant in Azure Communication services. A participant is, for example, a phone number or an Azure communication user. This model is polymorphic: Apart from kind and rawId, at most one further property may be set which must match the kind enum value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationIdentifier"/> is null. </exception>
        public ChatParticipantInternal(CommunicationIdentifierModel communicationIdentifier)
        {
            if (communicationIdentifier == null)
            {
                throw new ArgumentNullException(nameof(communicationIdentifier));
            }

            CommunicationIdentifier = communicationIdentifier;
        }

        /// <summary> Initializes a new instance of <see cref="ChatParticipantInternal"/>. </summary>
        /// <param name="communicationIdentifier"> Identifies a participant in Azure Communication services. A participant is, for example, a phone number or an Azure communication user. This model is polymorphic: Apart from kind and rawId, at most one further property may be set which must match the kind enum value. </param>
        /// <param name="displayName"> Display name for the chat participant. </param>
        /// <param name="shareHistoryTime"> Time from which the chat history is shared with the participant. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        internal ChatParticipantInternal(CommunicationIdentifierModel communicationIdentifier, string displayName, DateTimeOffset? shareHistoryTime)
        {
            CommunicationIdentifier = communicationIdentifier;
            DisplayName = displayName;
            ShareHistoryTime = shareHistoryTime;
        }

        /// <summary> Identifies a participant in Azure Communication services. A participant is, for example, a phone number or an Azure communication user. This model is polymorphic: Apart from kind and rawId, at most one further property may be set which must match the kind enum value. </summary>
        public CommunicationIdentifierModel CommunicationIdentifier { get; set; }
        /// <summary> Display name for the chat participant. </summary>
        public string DisplayName { get; set; }
        /// <summary> Time from which the chat history is shared with the participant. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </summary>
        public DateTimeOffset? ShareHistoryTime { get; set; }
    }
}
