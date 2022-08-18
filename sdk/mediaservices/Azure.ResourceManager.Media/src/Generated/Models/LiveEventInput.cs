// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The live event input. </summary>
    public partial class LiveEventInput
    {
        /// <summary> Initializes a new instance of LiveEventInput. </summary>
        /// <param name="streamingProtocol"> The input protocol for the live event. This is specified at creation time and cannot be updated. </param>
        public LiveEventInput(LiveEventInputProtocol streamingProtocol)
        {
            StreamingProtocol = streamingProtocol;
            Endpoints = new ChangeTrackingList<LiveEventEndpoint>();
        }

        /// <summary> Initializes a new instance of LiveEventInput. </summary>
        /// <param name="streamingProtocol"> The input protocol for the live event. This is specified at creation time and cannot be updated. </param>
        /// <param name="accessControl"> Access control for live event input. </param>
        /// <param name="keyFrameInterval"> ISO 8601 time duration of the key frame interval duration of the input. This value sets the EXT-X-TARGETDURATION property in the HLS output. For example, use PT2S to indicate 2 seconds. Leave the value empty for encoding live events. </param>
        /// <param name="accessToken"> A UUID in string form to uniquely identify the stream. This can be specified at creation time but cannot be updated. If omitted, the service will generate a unique value. </param>
        /// <param name="endpoints"> The input endpoints for the live event. </param>
        internal LiveEventInput(LiveEventInputProtocol streamingProtocol, LiveEventInputAccessControl accessControl, string keyFrameInterval, string accessToken, IList<LiveEventEndpoint> endpoints)
        {
            StreamingProtocol = streamingProtocol;
            AccessControl = accessControl;
            KeyFrameInterval = keyFrameInterval;
            AccessToken = accessToken;
            Endpoints = endpoints;
        }

        /// <summary> The input protocol for the live event. This is specified at creation time and cannot be updated. </summary>
        public LiveEventInputProtocol StreamingProtocol { get; set; }
        /// <summary> Access control for live event input. </summary>
        internal LiveEventInputAccessControl AccessControl { get; set; }
        /// <summary> The IP allow list. </summary>
        public IList<IPRange> IPAllowedIPs
        {
            get
            {
                if (AccessControl is null)
                    AccessControl = new LiveEventInputAccessControl();
                return AccessControl.IPAllowedIPs;
            }
        }

        /// <summary> ISO 8601 time duration of the key frame interval duration of the input. This value sets the EXT-X-TARGETDURATION property in the HLS output. For example, use PT2S to indicate 2 seconds. Leave the value empty for encoding live events. </summary>
        public string KeyFrameInterval { get; set; }
        /// <summary> A UUID in string form to uniquely identify the stream. This can be specified at creation time but cannot be updated. If omitted, the service will generate a unique value. </summary>
        public string AccessToken { get; set; }
        /// <summary> The input endpoints for the live event. </summary>
        public IList<LiveEventEndpoint> Endpoints { get; }
    }
}
