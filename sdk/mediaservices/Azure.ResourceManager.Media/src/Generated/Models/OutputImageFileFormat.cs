// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary>
    /// Describes the properties for an output image file.
    /// Please note <see cref="OutputImageFileFormat"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="JpgFormat"/> and <see cref="PngFormat"/>.
    /// </summary>
    public partial class OutputImageFileFormat : MediaFormatBase
    {
        /// <summary> Initializes a new instance of <see cref="OutputImageFileFormat"/>. </summary>
        /// <param name="filenamePattern"> The file naming pattern used for the creation of output files. The following macros are supported in the file name: {Basename} - An expansion macro that will use the name of the input video file. If the base name(the file suffix is not included) of the input video file is less than 32 characters long, the base name of input video files will be used. If the length of base name of the input video file exceeds 32 characters, the base name is truncated to the first 32 characters in total length. {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {AudioStream} - string "Audio" plus audio stream number(start from 1). {Bitrate} - The audio/video bitrate in kbps. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. {Resolution} - The video resolution. Any unsubstituted macros will be collapsed and removed from the filename. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filenamePattern"/> is null. </exception>
        public OutputImageFileFormat(string filenamePattern) : base(filenamePattern)
        {
            Argument.AssertNotNull(filenamePattern, nameof(filenamePattern));

            OdataType = "#Microsoft.Media.ImageFormat";
        }

        /// <summary> Initializes a new instance of <see cref="OutputImageFileFormat"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="filenamePattern"> The file naming pattern used for the creation of output files. The following macros are supported in the file name: {Basename} - An expansion macro that will use the name of the input video file. If the base name(the file suffix is not included) of the input video file is less than 32 characters long, the base name of input video files will be used. If the length of base name of the input video file exceeds 32 characters, the base name is truncated to the first 32 characters in total length. {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {AudioStream} - string "Audio" plus audio stream number(start from 1). {Bitrate} - The audio/video bitrate in kbps. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. {Resolution} - The video resolution. Any unsubstituted macros will be collapsed and removed from the filename. </param>
        internal OutputImageFileFormat(string odataType, string filenamePattern) : base(odataType, filenamePattern)
        {
            OdataType = odataType ?? "#Microsoft.Media.ImageFormat";
        }
    }
}
