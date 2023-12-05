// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.Rooms
{
    /// <summary> Request payload for creating new room. </summary>
    internal partial class CreateRoomRequest
    {
        /// <summary> Initializes a new instance of <see cref="CreateRoomRequest"/>. </summary>
        public CreateRoomRequest()
        {
            Participants = new ChangeTrackingDictionary<string, ParticipantProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="CreateRoomRequest"/>. </summary>
        /// <param name="validFrom"> The timestamp from when the room is open for joining. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. The default value is the current date time. </param>
        /// <param name="validUntil"> The timestamp from when the room can no longer be joined. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. The default value is the current date time plus 180 days. </param>
        /// <param name="pstnDialOutEnabled"> Set this flag to true if, at the time of the call, dial out to a PSTN number is enabled in a particular room. By default, this flag is set to false. </param>
        /// <param name="participants"> (Optional) Participants to be invited to the room. </param>
        internal CreateRoomRequest(DateTimeOffset? validFrom, DateTimeOffset? validUntil, bool? pstnDialOutEnabled, IDictionary<string, ParticipantProperties> participants)
        {
            ValidFrom = validFrom;
            ValidUntil = validUntil;
            PstnDialOutEnabled = pstnDialOutEnabled;
            Participants = participants;
        }

        /// <summary> The timestamp from when the room is open for joining. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. The default value is the current date time. </summary>
        public DateTimeOffset? ValidFrom { get; set; }
        /// <summary> The timestamp from when the room can no longer be joined. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. The default value is the current date time plus 180 days. </summary>
        public DateTimeOffset? ValidUntil { get; set; }
        /// <summary> Set this flag to true if, at the time of the call, dial out to a PSTN number is enabled in a particular room. By default, this flag is set to false. </summary>
        public bool? PstnDialOutEnabled { get; set; }
        /// <summary> (Optional) Participants to be invited to the room. </summary>
        public IDictionary<string, ParticipantProperties> Participants { get; }
    }
}
