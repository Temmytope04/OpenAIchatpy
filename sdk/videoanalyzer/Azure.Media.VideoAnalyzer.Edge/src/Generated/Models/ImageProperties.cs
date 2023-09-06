// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Image transformations and formatting options to be applied to the video frame(s). </summary>
    public partial class ImageProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ImageProperties"/>. </summary>
        public ImageProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ImageProperties"/>. </summary>
        /// <param name="scale"> Image scaling mode. </param>
        /// <param name="format">
        /// Base class for image formatting properties.
        /// Please note <see cref="ImageFormatProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ImageFormatBmp"/>, <see cref="ImageFormatJpeg"/>, <see cref="ImageFormatPng"/> and <see cref="ImageFormatRaw"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ImageProperties(ImageScale scale, ImageFormatProperties format, Dictionary<string, BinaryData> rawData)
        {
            Scale = scale;
            Format = format;
            _rawData = rawData;
        }

        /// <summary> Image scaling mode. </summary>
        public ImageScale Scale { get; set; }
        /// <summary>
        /// Base class for image formatting properties.
        /// Please note <see cref="ImageFormatProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ImageFormatBmp"/>, <see cref="ImageFormatJpeg"/>, <see cref="ImageFormatPng"/> and <see cref="ImageFormatRaw"/>.
        /// </summary>
        public ImageFormatProperties Format { get; set; }
    }
}
