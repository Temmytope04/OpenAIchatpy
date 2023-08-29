// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Defines how often media is submitted to the extension plugin. </summary>
    public partial class SamplingOptions
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SamplingOptions"/>. </summary>
        public SamplingOptions()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SamplingOptions"/>. </summary>
        /// <param name="skipSamplesWithoutAnnotation"> When set to 'true', prevents frames without upstream inference data to be sent to the extension plugin. This is useful to limit the frames sent to the extension to pre-analyzed frames only. For example, when used downstream from a motion detector, this can enable for only frames in which motion has been detected to be further analyzed. </param>
        /// <param name="maximumSamplesPerSecond"> Maximum rate of samples submitted to the extension. This prevents an extension plugin to be overloaded with data. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SamplingOptions(string skipSamplesWithoutAnnotation, string maximumSamplesPerSecond, Dictionary<string, BinaryData> rawData)
        {
            SkipSamplesWithoutAnnotation = skipSamplesWithoutAnnotation;
            MaximumSamplesPerSecond = maximumSamplesPerSecond;
            _rawData = rawData;
        }

        /// <summary> When set to 'true', prevents frames without upstream inference data to be sent to the extension plugin. This is useful to limit the frames sent to the extension to pre-analyzed frames only. For example, when used downstream from a motion detector, this can enable for only frames in which motion has been detected to be further analyzed. </summary>
        public string SkipSamplesWithoutAnnotation { get; set; }
        /// <summary> Maximum rate of samples submitted to the extension. This prevents an extension plugin to be overloaded with data. </summary>
        public string MaximumSamplesPerSecond { get; set; }
    }
}
