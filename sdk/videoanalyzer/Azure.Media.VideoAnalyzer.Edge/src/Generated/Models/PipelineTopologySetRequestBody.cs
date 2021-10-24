// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

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
    internal partial class PipelineTopologySetRequestBody : MethodRequest
    {
        /// <summary> Initializes a new instance of PipelineTopologySetRequestBody. </summary>
        /// <param name="name"> Pipeline topology unique identifier. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public PipelineTopologySetRequestBody(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            MethodName = "PipelineTopologySetRequestBody";
        }

        /// <summary> Initializes a new instance of PipelineTopologySetRequestBody. </summary>
        /// <param name="methodName"> Direct method method name. </param>
        /// <param name="apiVersion"> Video Analyzer API version. </param>
        /// <param name="name"> Pipeline topology unique identifier. </param>
        /// <param name="systemData"> Read-only system metadata associated with this object. </param>
        /// <param name="properties"> Pipeline topology properties. </param>
        internal PipelineTopologySetRequestBody(string methodName, string apiVersion, string name, SystemData systemData, PipelineTopologyProperties properties) : base(methodName, apiVersion)
        {
            Name = name;
            SystemData = systemData;
            Properties = properties;
            MethodName = methodName ?? "PipelineTopologySetRequestBody";
        }

        /// <summary> Pipeline topology unique identifier. </summary>
        public string Name { get; set; }
        /// <summary> Read-only system metadata associated with this object. </summary>
        public SystemData SystemData { get; set; }
        /// <summary> Pipeline topology properties. </summary>
        public PipelineTopologyProperties Properties { get; set; }
    }
}
