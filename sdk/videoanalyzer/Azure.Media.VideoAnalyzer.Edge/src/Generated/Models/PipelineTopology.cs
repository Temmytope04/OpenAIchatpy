// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary>
    /// Pipeline topology describes the processing steps to be applied when processing media for a particular outcome. The topology should be defined according to the scenario to be achieved and can be reused across many pipeline instances which share the same processing characteristics. For instance, a pipeline topology which acquires data from a RTSP camera, process it with an specific AI model and stored the data on the cloud can be reused across many different cameras, as long as the same processing should be applied across all the cameras. Individual instance properties can be defined through the use of user-defined parameters, which allow for a topology to be parameterized, thus allowing individual pipelines to refer to different values, such as individual cameras RTSP endpoints and credentials. Overall a topology is composed of the following:
    ///
    ///   - Parameters: list of user defined parameters that can be references across the topology nodes.
    ///   - Sources: list of one or more data sources nodes such as an RTSP source which allows for media to be ingested from cameras.
    ///   - Processors: list of nodes which perform data analysis or transformations.
    ///   -Sinks: list of one or more data sinks which allow for data to be stored or exported to other destinations.
    /// </summary>
    public partial class PipelineTopology
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PipelineTopology"/>. </summary>
        /// <param name="name"> Pipeline topology unique identifier. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public PipelineTopology(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="PipelineTopology"/>. </summary>
        /// <param name="name"> Pipeline topology unique identifier. </param>
        /// <param name="systemData"> Read-only system metadata associated with this object. </param>
        /// <param name="properties"> Pipeline topology properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PipelineTopology(string name, SystemData systemData, PipelineTopologyProperties properties, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            SystemData = systemData;
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PipelineTopology"/> for deserialization. </summary>
        internal PipelineTopology()
        {
        }

        /// <summary> Pipeline topology unique identifier. </summary>
        public string Name { get; set; }
        /// <summary> Read-only system metadata associated with this object. </summary>
        public SystemData SystemData { get; set; }
        /// <summary> Pipeline topology properties. </summary>
        public PipelineTopologyProperties Properties { get; set; }
    }
}
