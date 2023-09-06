// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary>
    /// Base class for topology processor nodes.
    /// Please note <see cref="ProcessorNodeBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="CognitiveServicesVisionProcessor"/>, <see cref="ExtensionProcessorBase"/>, <see cref="GrpcExtension"/>, <see cref="HttpExtension"/>, <see cref="LineCrossingProcessor"/>, <see cref="MotionDetectionProcessor"/>, <see cref="ObjectTrackingProcessor"/> and <see cref="SignalGateProcessor"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownProcessorNodeBase))]
    public abstract partial class ProcessorNodeBase
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ProcessorNodeBase"/>. </summary>
        /// <param name="name"> Node name. Must be unique within the topology. </param>
        /// <param name="inputs"> An array of upstream node references within the topology to be used as inputs for this node. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="inputs"/> is null. </exception>
        protected ProcessorNodeBase(string name, IEnumerable<NodeInput> inputs)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(inputs, nameof(inputs));

            Name = name;
            Inputs = inputs.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ProcessorNodeBase"/>. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        /// <param name="name"> Node name. Must be unique within the topology. </param>
        /// <param name="inputs"> An array of upstream node references within the topology to be used as inputs for this node. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ProcessorNodeBase(string type, string name, IList<NodeInput> inputs, Dictionary<string, BinaryData> rawData)
        {
            Type = type;
            Name = name;
            Inputs = inputs;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ProcessorNodeBase"/> for deserialization. </summary>
        internal ProcessorNodeBase()
        {
        }

        /// <summary> Type discriminator for the derived types. </summary>
        internal string Type { get; set; }
        /// <summary> Node name. Must be unique within the topology. </summary>
        public string Name { get; set; }
        /// <summary> An array of upstream node references within the topology to be used as inputs for this node. </summary>
        public IList<NodeInput> Inputs { get; }
    }
}
