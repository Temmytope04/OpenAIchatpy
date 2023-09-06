// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Class representing the MPEG4 Configuration. </summary>
    public partial class VideoEncoderConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VideoEncoderConfiguration"/>. </summary>
        public VideoEncoderConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VideoEncoderConfiguration"/>. </summary>
        /// <param name="encoding"> The video codec used by the Media Profile. </param>
        /// <param name="quality"> Relative value representing the quality of the video. </param>
        /// <param name="resolution"> The Video Resolution. </param>
        /// <param name="rateControl"> The Video's rate control. </param>
        /// <param name="h264"> The H264 Configuration. </param>
        /// <param name="mpeg4"> The H264 Configuration. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VideoEncoderConfiguration(VideoEncoding? encoding, float? quality, VideoResolution resolution, RateControl rateControl, H264Configuration h264, Mpeg4Configuration mpeg4, Dictionary<string, BinaryData> rawData)
        {
            Encoding = encoding;
            Quality = quality;
            Resolution = resolution;
            RateControl = rateControl;
            H264 = h264;
            Mpeg4 = mpeg4;
            _rawData = rawData;
        }

        /// <summary> The video codec used by the Media Profile. </summary>
        public VideoEncoding? Encoding { get; set; }
        /// <summary> Relative value representing the quality of the video. </summary>
        public float? Quality { get; set; }
        /// <summary> The Video Resolution. </summary>
        public VideoResolution Resolution { get; set; }
        /// <summary> The Video's rate control. </summary>
        public RateControl RateControl { get; set; }
        /// <summary> The H264 Configuration. </summary>
        public H264Configuration H264 { get; set; }
        /// <summary> The H264 Configuration. </summary>
        public Mpeg4Configuration Mpeg4 { get; set; }
    }
}
