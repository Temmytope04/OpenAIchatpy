// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> A processor that allows the pipeline topology to send video frames to a Cognitive Services Vision extension. Inference results are relayed to downstream nodes. </summary>
    public partial class CognitiveServicesVisionProcessor : ProcessorNodeBase
    {
        /// <summary> Initializes a new instance of <see cref="CognitiveServicesVisionProcessor"/>. </summary>
        /// <param name="name"> Node name. Must be unique within the topology. </param>
        /// <param name="inputs"> An array of upstream node references within the topology to be used as inputs for this node. </param>
        /// <param name="endpoint">
        /// Endpoint to which this processor should connect.
        /// Please note <see cref="EndpointBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="TlsEndpoint"/> and <see cref="UnsecuredEndpoint"/>.
        /// </param>
        /// <param name="operation">
        /// Describes the Spatial Analysis operation to be used in the Cognitive Services Vision processor.
        /// Please note <see cref="SpatialAnalysisOperationBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SpatialAnalysisCustomOperation"/>, <see cref="SpatialAnalysisPersonCountOperation"/>, <see cref="SpatialAnalysisPersonDistanceOperation"/>, <see cref="SpatialAnalysisPersonLineCrossingOperation"/>, <see cref="SpatialAnalysisPersonZoneCrossingOperation"/> and <see cref="SpatialAnalysisTypedOperationBase"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="inputs"/>, <paramref name="endpoint"/> or <paramref name="operation"/> is null. </exception>
        public CognitiveServicesVisionProcessor(string name, IEnumerable<NodeInput> inputs, EndpointBase endpoint, SpatialAnalysisOperationBase operation) : base(name, inputs)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(inputs, nameof(inputs));
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(operation, nameof(operation));

            Endpoint = endpoint;
            Operation = operation;
            Type = "#Microsoft.VideoAnalyzer.CognitiveServicesVisionProcessor";
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesVisionProcessor"/>. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        /// <param name="name"> Node name. Must be unique within the topology. </param>
        /// <param name="inputs"> An array of upstream node references within the topology to be used as inputs for this node. </param>
        /// <param name="endpoint">
        /// Endpoint to which this processor should connect.
        /// Please note <see cref="EndpointBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="TlsEndpoint"/> and <see cref="UnsecuredEndpoint"/>.
        /// </param>
        /// <param name="image"> Describes the parameters of the image that is sent as input to the endpoint. </param>
        /// <param name="samplingOptions"> Describes the sampling options to be applied when forwarding samples to the extension. </param>
        /// <param name="operation">
        /// Describes the Spatial Analysis operation to be used in the Cognitive Services Vision processor.
        /// Please note <see cref="SpatialAnalysisOperationBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SpatialAnalysisCustomOperation"/>, <see cref="SpatialAnalysisPersonCountOperation"/>, <see cref="SpatialAnalysisPersonDistanceOperation"/>, <see cref="SpatialAnalysisPersonLineCrossingOperation"/>, <see cref="SpatialAnalysisPersonZoneCrossingOperation"/> and <see cref="SpatialAnalysisTypedOperationBase"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CognitiveServicesVisionProcessor(string type, string name, IList<NodeInput> inputs, EndpointBase endpoint, ImageProperties image, SamplingOptions samplingOptions, SpatialAnalysisOperationBase operation, Dictionary<string, BinaryData> rawData) : base(type, name, inputs, rawData)
        {
            Endpoint = endpoint;
            Image = image;
            SamplingOptions = samplingOptions;
            Operation = operation;
            Type = type ?? "#Microsoft.VideoAnalyzer.CognitiveServicesVisionProcessor";
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesVisionProcessor"/> for deserialization. </summary>
        internal CognitiveServicesVisionProcessor()
        {
        }

        /// <summary>
        /// Endpoint to which this processor should connect.
        /// Please note <see cref="EndpointBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="TlsEndpoint"/> and <see cref="UnsecuredEndpoint"/>.
        /// </summary>
        public EndpointBase Endpoint { get; set; }
        /// <summary> Describes the parameters of the image that is sent as input to the endpoint. </summary>
        public ImageProperties Image { get; set; }
        /// <summary> Describes the sampling options to be applied when forwarding samples to the extension. </summary>
        public SamplingOptions SamplingOptions { get; set; }
        /// <summary>
        /// Describes the Spatial Analysis operation to be used in the Cognitive Services Vision processor.
        /// Please note <see cref="SpatialAnalysisOperationBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SpatialAnalysisCustomOperation"/>, <see cref="SpatialAnalysisPersonCountOperation"/>, <see cref="SpatialAnalysisPersonDistanceOperation"/>, <see cref="SpatialAnalysisPersonLineCrossingOperation"/>, <see cref="SpatialAnalysisPersonZoneCrossingOperation"/> and <see cref="SpatialAnalysisTypedOperationBase"/>.
        /// </summary>
        public SpatialAnalysisOperationBase Operation { get; set; }
    }
}
