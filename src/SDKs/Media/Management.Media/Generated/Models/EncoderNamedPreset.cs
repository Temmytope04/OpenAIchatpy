// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for EncoderNamedPreset.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(EncoderNamedPresetConverter))]
    public struct EncoderNamedPreset : System.IEquatable<EncoderNamedPreset>
    {
        private EncoderNamedPreset(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// Produces an MP4 file where the video is encoded with H.264 codec at
        /// 2200 kbps and a picture height of 480 pixels, and the stereo audio
        /// is encoded with AAC-LC codec at 64 kbps.
        /// </summary>
        public static readonly EncoderNamedPreset H264SingleBitrateSD = "H264SingleBitrateSD";

        /// <summary>
        /// Produces an MP4 file where the video is encoded with H.264 codec at
        /// 4500 kbps and a picture height of 720 pixels, and the stereo audio
        /// is encoded with AAC-LC codec at 64 kbps.
        /// </summary>
        public static readonly EncoderNamedPreset H264SingleBitrate720p = "H264SingleBitrate720p";

        /// <summary>
        /// Produces an MP4 file where the video is encoded with H.264 codec at
        /// 6750 kbps and a picture height of 1080 pixels, and the stereo audio
        /// is encoded with AAC-LC codec at 64 kbps.
        /// </summary>
        public static readonly EncoderNamedPreset H264SingleBitrate1080p = "H264SingleBitrate1080p";

        /// <summary>
        /// Produces a set of GOP aligned MP4 files with H.264 video and stereo
        /// AAC audio. Auto-generates a bitrate ladder based on the input
        /// resolution and bitrate. The auto-generated preset will never exceed
        /// the input resolution and bitrate. For example, if the input is 720p
        /// at 3 Mbps, output will remain 720p at best, and will start at rates
        /// lower than 3 Mbps. The output will have video and audio in separate
        /// MP4 files, which is optimal for adaptive streaming.
        /// </summary>
        public static readonly EncoderNamedPreset AdaptiveStreaming = "AdaptiveStreaming";

        /// <summary>
        /// Produces a single MP4 file containing only stereo audio encoded at
        /// 192 kbps.
        /// </summary>
        public static readonly EncoderNamedPreset AACGoodQualityAudio = "AACGoodQualityAudio";

        /// <summary>
        /// Produces a set of 8 GOP-aligned MP4 files, ranging from 6000 kbps
        /// to 400 kbps, and stereo AAC audio. Resolution starts at 1080p and
        /// goes down to 360p.
        /// </summary>
        public static readonly EncoderNamedPreset H264MultipleBitrate1080p = "H264MultipleBitrate1080p";

        /// <summary>
        /// Produces a set of 6 GOP-aligned MP4 files, ranging from 3400 kbps
        /// to 400 kbps, and stereo AAC audio. Resolution starts at 720p and
        /// goes down to 360p.
        /// </summary>
        public static readonly EncoderNamedPreset H264MultipleBitrate720p = "H264MultipleBitrate720p";

        /// <summary>
        /// Produces a set of 5 GOP-aligned MP4 files, ranging from 1600kbps to
        /// 400 kbps, and stereo AAC audio. Resolution starts at 480p and goes
        /// down to 360p.
        /// </summary>
        public static readonly EncoderNamedPreset H264MultipleBitrateSD = "H264MultipleBitrateSD";


        /// <summary>
        /// Underlying value of enum EncoderNamedPreset
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for EncoderNamedPreset
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type EncoderNamedPreset
        /// </summary>
        public bool Equals(EncoderNamedPreset e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to EncoderNamedPreset
        /// </summary>
        public static implicit operator EncoderNamedPreset(string value)
        {
            return new EncoderNamedPreset(value);
        }

        /// <summary>
        /// Implicit operator to convert EncoderNamedPreset to string
        /// </summary>
        public static implicit operator string(EncoderNamedPreset e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum EncoderNamedPreset
        /// </summary>
        public static bool operator == (EncoderNamedPreset e1, EncoderNamedPreset e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum EncoderNamedPreset
        /// </summary>
        public static bool operator != (EncoderNamedPreset e1, EncoderNamedPreset e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for EncoderNamedPreset
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is EncoderNamedPreset && Equals((EncoderNamedPreset)obj);
        }

        /// <summary>
        /// Returns for hashCode EncoderNamedPreset
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
