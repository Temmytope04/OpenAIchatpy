// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Defines a Spatial Analysis person line crossing operation. This requires the Azure Cognitive Services Spatial analysis module to be deployed alongside the Video Analyzer module, please see https://aka.ms/ava-spatial-analysis for more information. </summary>
    public partial class SpatialAnalysisPersonLineCrossingOperation : SpatialAnalysisTypedOperationBase
    {
        /// <summary> Initializes a new instance of <see cref="SpatialAnalysisPersonLineCrossingOperation"/>. </summary>
        /// <param name="lines"> The list of lines with optional events. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="lines"/> is null. </exception>
        public SpatialAnalysisPersonLineCrossingOperation(IEnumerable<SpatialAnalysisPersonLineCrossingLineEvents> lines)
        {
            Argument.AssertNotNull(lines, nameof(lines));

            Lines = lines.ToList();
            Type = "#Microsoft.VideoAnalyzer.SpatialAnalysisPersonLineCrossingOperation";
        }

        /// <summary> Initializes a new instance of <see cref="SpatialAnalysisPersonLineCrossingOperation"/>. </summary>
        /// <param name="type"> The Type discriminator for the derived types. </param>
        /// <param name="debug"> If set to 'true', enables debugging mode for this operation. </param>
        /// <param name="calibrationConfiguration"> Advanced calibration configuration. </param>
        /// <param name="cameraConfiguration"> Advanced camera configuration. </param>
        /// <param name="cameraCalibratorNodeConfiguration"> Advanced camera calibrator configuration. </param>
        /// <param name="detectorNodeConfiguration"> Advanced detector node configuration. </param>
        /// <param name="trackerNodeConfiguration"> Advanced tracker node configuration. </param>
        /// <param name="enableFaceMaskClassifier"> If set to 'true', enables face mask detection for this operation. </param>
        /// <param name="lines"> The list of lines with optional events. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SpatialAnalysisPersonLineCrossingOperation(string type, string debug, string calibrationConfiguration, string cameraConfiguration, string cameraCalibratorNodeConfiguration, string detectorNodeConfiguration, string trackerNodeConfiguration, string enableFaceMaskClassifier, IList<SpatialAnalysisPersonLineCrossingLineEvents> lines, Dictionary<string, BinaryData> rawData) : base(type, debug, calibrationConfiguration, cameraConfiguration, cameraCalibratorNodeConfiguration, detectorNodeConfiguration, trackerNodeConfiguration, enableFaceMaskClassifier, rawData)
        {
            Lines = lines;
            Type = type ?? "#Microsoft.VideoAnalyzer.SpatialAnalysisPersonLineCrossingOperation";
        }

        /// <summary> Initializes a new instance of <see cref="SpatialAnalysisPersonLineCrossingOperation"/> for deserialization. </summary>
        internal SpatialAnalysisPersonLineCrossingOperation()
        {
        }

        /// <summary> The list of lines with optional events. </summary>
        public IList<SpatialAnalysisPersonLineCrossingLineEvents> Lines { get; }
    }
}
