// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Communication;

namespace Azure.Communication.CallingServer
{
    /// <summary> The AddParticipantsRequest. </summary>
    internal partial class AddParticipantsRequestInternal
    {
        /// <summary> Initializes a new instance of AddParticipantsRequestInternal. </summary>
        /// <param name="participantsToAdd"> The participants to invite. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="participantsToAdd"/> is null. </exception>
        public AddParticipantsRequestInternal(IEnumerable<CommunicationIdentifierModel> participantsToAdd)
        {
            if (participantsToAdd == null)
            {
                throw new ArgumentNullException(nameof(participantsToAdd));
            }

            ParticipantsToAdd = participantsToAdd.ToList();
        }

        /// <summary> The source caller Id that&apos;s shown to the PSTN participant being invited. Required only when inviting a PSTN participant. </summary>
        public PhoneNumberIdentifierModel SourceCallerId { get; set; }
        /// <summary> The participants to invite. </summary>
        public IList<CommunicationIdentifierModel> ParticipantsToAdd { get; }
        /// <summary>
        /// Gets or sets the timeout to wait for the invited participant to pickup.
        /// The maximum value of this is 180 seconds
        /// </summary>
        public int? InvitationTimeoutInSeconds { get; set; }
        /// <summary> The operation context. </summary>
        public string OperationContext { get; set; }
    }
}
