// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Class for EnvelopeEncryption encryption scheme. </summary>
    public partial class EnvelopeEncryption
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EnvelopeEncryption"/>. </summary>
        public EnvelopeEncryption()
        {
            ClearTracks = new ChangeTrackingList<MediaTrackSelection>();
        }

        /// <summary> Initializes a new instance of <see cref="EnvelopeEncryption"/>. </summary>
        /// <param name="enabledProtocols"> Representing supported protocols. </param>
        /// <param name="clearTracks"> Representing which tracks should not be encrypted. </param>
        /// <param name="contentKeys"> Representing default content key for each encryption scheme and separate content keys for specific tracks. </param>
        /// <param name="customKeyAcquisitionUriTemplate"> Template for the URL of the custom service delivering keys to end user players.  Not required when using Azure Media Services for issuing keys.  The template supports replaceable tokens that the service will update at runtime with the value specific to the request.  The currently supported token values are {AlternativeMediaId}, which is replaced with the value of StreamingLocatorId.AlternativeMediaId, and {ContentKeyId}, which is replaced with the value of identifier of the key being requested. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EnvelopeEncryption(MediaEnabledProtocols enabledProtocols, IList<MediaTrackSelection> clearTracks, StreamingPolicyContentKeys contentKeys, string customKeyAcquisitionUriTemplate, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EnabledProtocols = enabledProtocols;
            ClearTracks = clearTracks;
            ContentKeys = contentKeys;
            CustomKeyAcquisitionUriTemplate = customKeyAcquisitionUriTemplate;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Representing supported protocols. </summary>
        public MediaEnabledProtocols EnabledProtocols { get; set; }
        /// <summary> Representing which tracks should not be encrypted. </summary>
        public IList<MediaTrackSelection> ClearTracks { get; }
        /// <summary> Representing default content key for each encryption scheme and separate content keys for specific tracks. </summary>
        public StreamingPolicyContentKeys ContentKeys { get; set; }
        /// <summary> Template for the URL of the custom service delivering keys to end user players.  Not required when using Azure Media Services for issuing keys.  The template supports replaceable tokens that the service will update at runtime with the value specific to the request.  The currently supported token values are {AlternativeMediaId}, which is replaced with the value of StreamingLocatorId.AlternativeMediaId, and {ContentKeyId}, which is replaced with the value of identifier of the key being requested. </summary>
        public string CustomKeyAcquisitionUriTemplate { get; set; }
    }
}
