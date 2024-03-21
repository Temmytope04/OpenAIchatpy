// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Describes the settings for producing JPEG thumbnails. </summary>
    public partial class JpgFormat : OutputImageFileFormat
    {
        /// <summary> Initializes a new instance of <see cref="JpgFormat"/>. </summary>
        /// <param name="filenamePattern"> The file naming pattern used for the creation of output files. The following macros are supported in the file name: {Basename} - An expansion macro that will use the name of the input video file. If the base name(the file suffix is not included) of the input video file is less than 32 characters long, the base name of input video files will be used. If the length of base name of the input video file exceeds 32 characters, the base name is truncated to the first 32 characters in total length. {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {AudioStream} - string "Audio" plus audio stream number(start from 1). {Bitrate} - The audio/video bitrate in kbps. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. {Resolution} - The video resolution. Any unsubstituted macros will be collapsed and removed from the filename. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filenamePattern"/> is null. </exception>
        public JpgFormat(string filenamePattern) : base(filenamePattern)
        {
            Argument.AssertNotNull(filenamePattern, nameof(filenamePattern));

            OdataType = "#Microsoft.Media.JpgFormat";
        }

        /// <summary> Initializes a new instance of <see cref="JpgFormat"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="filenamePattern"> The file naming pattern used for the creation of output files. The following macros are supported in the file name: {Basename} - An expansion macro that will use the name of the input video file. If the base name(the file suffix is not included) of the input video file is less than 32 characters long, the base name of input video files will be used. If the length of base name of the input video file exceeds 32 characters, the base name is truncated to the first 32 characters in total length. {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {AudioStream} - string "Audio" plus audio stream number(start from 1). {Bitrate} - The audio/video bitrate in kbps. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. {Resolution} - The video resolution. Any unsubstituted macros will be collapsed and removed from the filename. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal JpgFormat(string odataType, string filenamePattern, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(odataType, filenamePattern, serializedAdditionalRawData)
        {
            OdataType = odataType ?? "#Microsoft.Media.JpgFormat";
        }

        /// <summary> Initializes a new instance of <see cref="JpgFormat"/> for deserialization. </summary>
        internal JpgFormat()
        {
        }
    }
}
