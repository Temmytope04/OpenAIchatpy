﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Communication.CallingServer
{
    /// <summary>
    /// Streaming audio.
    /// </summary>
    public class MediaStreamingAudio : MediaStreamingPackageBase
    {
        internal MediaStreamingAudio(BinaryData data, DateTime timestamp, string participantId, bool isSilence)
        {
            Data = data;
            Timestamp = timestamp;
            ParticipantId = participantId;
            IsSilence = isSilence;
        }

        /// <summary>
        /// The audio data.
        /// </summary>
        public BinaryData Data { get; }

        /// <summary>
        /// The timestamp of thwn the media was sourced.
        /// </summary>
        public DateTime Timestamp { get; }
        /// <summary>
        /// Participant ID
        /// </summary>
        public string ParticipantId { get; }
        /// <summary>
        /// Indicates if the received audio buffer contains only silence.
        /// </summary>
        public bool IsSilence { get; }
    }
}
