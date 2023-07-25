// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary>
    /// Describes the named polygon.
    /// Please note <see cref="NamedPolygonBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="NamedPolygonString"/>.
    /// </summary>
    public abstract partial class NamedPolygonBase
    {
        /// <summary> Initializes a new instance of NamedPolygonBase. </summary>
        /// <param name="name"> Polygon name. Must be unique within the node. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        protected NamedPolygonBase(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of NamedPolygonBase. </summary>
        /// <param name="type"> The Type discriminator for the derived types. </param>
        /// <param name="name"> Polygon name. Must be unique within the node. </param>
        internal NamedPolygonBase(string type, string name)
        {
            Type = type;
            Name = name;
        }

        /// <summary> The Type discriminator for the derived types. </summary>
        internal string Type { get; set; }
        /// <summary> Polygon name. Must be unique within the node. </summary>
        public string Name { get; set; }
    }
}
