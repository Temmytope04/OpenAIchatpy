// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary>
    /// Base class for named lines.
    /// Please note <see cref="NamedLineBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="NamedLineString"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownNamedLineBase))]
    public abstract partial class NamedLineBase
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NamedLineBase"/>. </summary>
        /// <param name="name"> Line name. Must be unique within the node. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        protected NamedLineBase(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="NamedLineBase"/>. </summary>
        /// <param name="type"> The Type discriminator for the derived types. </param>
        /// <param name="name"> Line name. Must be unique within the node. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NamedLineBase(string type, string name, Dictionary<string, BinaryData> rawData)
        {
            Type = type;
            Name = name;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="NamedLineBase"/> for deserialization. </summary>
        internal NamedLineBase()
        {
        }

        /// <summary> The Type discriminator for the derived types. </summary>
        internal string Type { get; set; }
        /// <summary> Line name. Must be unique within the node. </summary>
        public string Name { get; set; }
    }
}
