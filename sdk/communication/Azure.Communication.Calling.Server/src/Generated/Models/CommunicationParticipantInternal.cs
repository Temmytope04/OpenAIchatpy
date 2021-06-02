// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Communication;

namespace Azure.Communication.Calling.Server
{
    /// <summary> Class to represent entry in roster. </summary>
    internal partial class CommunicationParticipantInternal
    {
        /// <summary> Initializes a new instance of CommunicationParticipantInternal. </summary>
        internal CommunicationParticipantInternal()
        {
        }

        /// <summary> Initializes a new instance of CommunicationParticipantInternal. </summary>
        /// <param name="identifier"> ACS communication identifier. </param>
        /// <param name="participantId"> Participant Id. </param>
        /// <param name="isMuted"> Is participant muted. </param>
        internal CommunicationParticipantInternal(CommunicationIdentifierModel identifier, string participantId, bool? isMuted)
        {
            Identifier = identifier;
            ParticipantId = participantId;
            IsMuted = isMuted;
        }

        /// <summary> ACS communication identifier. </summary>
        public CommunicationIdentifierModel Identifier { get; }
        /// <summary> Participant Id. </summary>
        public string ParticipantId { get; }
        /// <summary> Is participant muted. </summary>
        public bool? IsMuted { get; }
    }
}
