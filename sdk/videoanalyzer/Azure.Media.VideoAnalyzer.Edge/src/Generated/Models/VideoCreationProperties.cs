// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Optional video properties to be used in case a new video resource needs to be created on the service. These will not take effect if the video already exists. </summary>
    public partial class VideoCreationProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VideoCreationProperties"/>. </summary>
        public VideoCreationProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VideoCreationProperties"/>. </summary>
        /// <param name="title"> Optional video title provided by the user. Value can be up to 256 characters long. </param>
        /// <param name="description"> Optional video description provided by the user. Value can be up to 2048 characters long. </param>
        /// <param name="segmentLength"> Video segment length indicates the length of individual video files (segments) which are persisted to storage. Smaller segments provide lower archive playback latency but generate larger volume of storage transactions. Larger segments reduce the amount of storage transactions while increasing the archive playback latency. Value must be specified in ISO8601 duration format (i.e. "PT30S" equals 30 seconds) and can vary between 30 seconds to 5 minutes, in 30 seconds increments. Changing this value after the video is initially created can lead to errors when uploading media to the archive. Default value is 30 seconds. </param>
        /// <param name="retentionPeriod"> Video retention period indicates how long the video is kept in storage, and must be a multiple of 1 day. For example, if this is set to 30 days, then content older than 30 days will be deleted. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VideoCreationProperties(string title, string description, string segmentLength, string retentionPeriod, Dictionary<string, BinaryData> rawData)
        {
            Title = title;
            Description = description;
            SegmentLength = segmentLength;
            RetentionPeriod = retentionPeriod;
            _rawData = rawData;
        }

        /// <summary> Optional video title provided by the user. Value can be up to 256 characters long. </summary>
        public string Title { get; set; }
        /// <summary> Optional video description provided by the user. Value can be up to 2048 characters long. </summary>
        public string Description { get; set; }
        /// <summary> Video segment length indicates the length of individual video files (segments) which are persisted to storage. Smaller segments provide lower archive playback latency but generate larger volume of storage transactions. Larger segments reduce the amount of storage transactions while increasing the archive playback latency. Value must be specified in ISO8601 duration format (i.e. "PT30S" equals 30 seconds) and can vary between 30 seconds to 5 minutes, in 30 seconds increments. Changing this value after the video is initially created can lead to errors when uploading media to the archive. Default value is 30 seconds. </summary>
        public string SegmentLength { get; set; }
        /// <summary> Video retention period indicates how long the video is kept in storage, and must be a multiple of 1 day. For example, if this is set to 30 days, then content older than 30 days will be deleted. </summary>
        public string RetentionPeriod { get; set; }
    }
}
