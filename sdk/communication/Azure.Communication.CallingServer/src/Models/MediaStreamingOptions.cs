﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.Communication.CallingServer
{
    /// <summary> The MediaStreamingOptions. </summary>
    public class MediaStreamingOptions
    {
        /// <summary> Initializes a new instance of MediaStreamingOptions. </summary>
        public MediaStreamingOptions(Uri transportUri, MediaStreamingTransportType transportType,
            MediaStreamingContentType contentType, MediaStreamingAudioChannelType audioChannelType)
        {
            TransportUri = transportUri;
            MediaStreamingTransport = transportType;
            MediaStreamingContent = contentType;
            MediaStreamingAudioChannel = audioChannelType;
        }

        /// <summary> Transport URL for media streaming. </summary>
        public Uri TransportUri { get; }
        /// <summary> The type of tranport to be used for media streaming, eg. Websocket. </summary>
        public MediaStreamingTransportType MediaStreamingTransport { get; }
        /// <summary> Content type to stream, eg. audio, audio/video. </summary>
        public MediaStreamingContentType MediaStreamingContent { get; }
        /// <summary> Audio channel type to stream, eg. unmixed audio, mixed audio. </summary>
        public MediaStreamingAudioChannelType MediaStreamingAudioChannel { get; }
    }
}
