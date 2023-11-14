// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Describes the transcription tracks in the output of a live event, generated using speech-to-text transcription. This property is reserved for future use, any value set on this property will be ignored. </summary>
    public partial class LiveEventTranscription
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LiveEventTranscription"/>. </summary>
        public LiveEventTranscription()
        {
            InputTrackSelection = new ChangeTrackingList<LiveEventInputTrackSelection>();
        }

        /// <summary> Initializes a new instance of <see cref="LiveEventTranscription"/>. </summary>
        /// <param name="language"> Specifies the language (locale) to be used for speech-to-text transcription – it should match the spoken language in the audio track. The value should be in BCP-47 format (e.g: 'en-US'). See https://go.microsoft.com/fwlink/?linkid=2133742 for more information about the live transcription feature and the list of supported languages. </param>
        /// <param name="inputTrackSelection"> Provides a mechanism to select the audio track in the input live feed, to which speech-to-text transcription is applied. This property is reserved for future use, any value set on this property will be ignored. </param>
        /// <param name="outputTranscriptionTrack"> Describes a transcription track in the output of a live event, generated using speech-to-text transcription. This property is reserved for future use, any value set on this property will be ignored. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LiveEventTranscription(string language, IList<LiveEventInputTrackSelection> inputTrackSelection, LiveEventOutputTranscriptionTrack outputTranscriptionTrack, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Language = language;
            InputTrackSelection = inputTrackSelection;
            OutputTranscriptionTrack = outputTranscriptionTrack;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the language (locale) to be used for speech-to-text transcription – it should match the spoken language in the audio track. The value should be in BCP-47 format (e.g: 'en-US'). See https://go.microsoft.com/fwlink/?linkid=2133742 for more information about the live transcription feature and the list of supported languages. </summary>
        public string Language { get; set; }
        /// <summary> Provides a mechanism to select the audio track in the input live feed, to which speech-to-text transcription is applied. This property is reserved for future use, any value set on this property will be ignored. </summary>
        public IList<LiveEventInputTrackSelection> InputTrackSelection { get; }
        /// <summary> Describes a transcription track in the output of a live event, generated using speech-to-text transcription. This property is reserved for future use, any value set on this property will be ignored. </summary>
        internal LiveEventOutputTranscriptionTrack OutputTranscriptionTrack { get; set; }
        /// <summary> The output track name. This property is reserved for future use, any value set on this property will be ignored. </summary>
        public string TrackName
        {
            get => OutputTranscriptionTrack is null ? default : OutputTranscriptionTrack.TrackName;
            set => OutputTranscriptionTrack = new LiveEventOutputTranscriptionTrack(value);
        }
    }
}
