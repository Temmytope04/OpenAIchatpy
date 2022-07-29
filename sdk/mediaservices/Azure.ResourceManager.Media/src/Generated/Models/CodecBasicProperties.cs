// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary>
    /// Describes the basic properties of all codecs.
    /// Please note <see cref="CodecBasicProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AacAudio"/>, <see cref="AudiocommonProperties"/>, <see cref="CopyAudio"/>, <see cref="CopyVideo"/>, <see cref="H264Video"/>, <see cref="H265Video"/>, <see cref="ImageBasicProperties"/>, <see cref="JpgImage"/>, <see cref="PngImage"/> and <see cref="InputVideoEncodingProperties"/>.
    /// </summary>
    public partial class CodecBasicProperties
    {
        /// <summary> Initializes a new instance of CodecBasicProperties. </summary>
        public CodecBasicProperties()
        {
        }

        /// <summary> Initializes a new instance of CodecBasicProperties. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="label"> An optional label for the codec. The label can be used to control muxing behavior. </param>
        internal CodecBasicProperties(string odataType, string label)
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
