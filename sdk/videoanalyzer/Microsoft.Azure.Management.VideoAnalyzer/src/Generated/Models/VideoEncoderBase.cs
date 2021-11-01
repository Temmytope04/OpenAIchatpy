// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Base type for all video encoding presets, which define the recipe or
    /// instructions on how the input video should be processed.
    /// </summary>
    public partial class VideoEncoderBase
    {
        /// <summary>
        /// Initializes a new instance of the VideoEncoderBase class.
        /// </summary>
        public VideoEncoderBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VideoEncoderBase class.
        /// </summary>
        /// <param name="bitrateKbps">The maximum bitrate, in kilobits per
        /// second or Kbps, at which video should be encoded. If omitted,
        /// encoder sets it automatically to try and match the quality of the
        /// input video.</param>
        /// <param name="frameRate">The frame rate (in frames per second) of
        /// the encoded video. The value must be greater than zero, and less
        /// than or equal to 300. If omitted, the encoder uses the average
        /// frame rate of the input video.</param>
        /// <param name="scale">Describes the resolution of the encoded video.
        /// If omitted, the encoder uses the resolution of the input
        /// video.</param>
        public VideoEncoderBase(string bitrateKbps = default(string), string frameRate = default(string), VideoScale scale = default(VideoScale))
        {
            BitrateKbps = bitrateKbps;
            FrameRate = frameRate;
            Scale = scale;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the maximum bitrate, in kilobits per second or Kbps,
        /// at which video should be encoded. If omitted, encoder sets it
        /// automatically to try and match the quality of the input video.
        /// </summary>
        [JsonProperty(PropertyName = "bitrateKbps")]
        public string BitrateKbps { get; set; }

        /// <summary>
        /// Gets or sets the frame rate (in frames per second) of the encoded
        /// video. The value must be greater than zero, and less than or equal
        /// to 300. If omitted, the encoder uses the average frame rate of the
        /// input video.
        /// </summary>
        [JsonProperty(PropertyName = "frameRate")]
        public string FrameRate { get; set; }

        /// <summary>
        /// Gets or sets describes the resolution of the encoded video. If
        /// omitted, the encoder uses the resolution of the input video.
        /// </summary>
        [JsonProperty(PropertyName = "scale")]
        public VideoScale Scale { get; set; }

    }
}
