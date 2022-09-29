// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary>
    /// Describes the basic properties of all codecs.
    /// Please note <see cref="MediaCodecBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AacAudio"/>, <see cref="MediaAudioBase"/>, <see cref="CodecCopyAudio"/>, <see cref="CodecCopyVideo"/>, <see cref="H264Video"/>, <see cref="H265Video"/>, <see cref="MediaImageBase"/>, <see cref="JpgImage"/>, <see cref="PngImage"/> and <see cref="MediaVideoBase"/>.
    /// </summary>
    public abstract partial class MediaCodecBase
    {
        /// <summary> Initializes a new instance of MediaCodecBase. </summary>
        protected MediaCodecBase()
        {
        }

        /// <summary> Initializes a new instance of MediaCodecBase. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="label"> An optional label for the codec. The label can be used to control muxing behavior. </param>
        internal MediaCodecBase(string odataType, string label)
        {
            OdataType = odataType;
            Label = label;
        }

        /// <summary> The discriminator for derived types. </summary>
        internal string OdataType { get; set; }
        /// <summary> An optional label for the codec. The label can be used to control muxing behavior. </summary>
        public string Label { get; set; }
    }
}
