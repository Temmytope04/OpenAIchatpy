// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Single topology parameter declaration. Declared parameters can and must be referenced throughout the topology and can optionally have default values to be used when they are not defined in the pipeline instances. </summary>
    public partial class ParameterDeclaration
    {
        /// <summary> Initializes a new instance of <see cref="ParameterDeclaration"/>. </summary>
        /// <param name="name"> Name of the parameter. </param>
        /// <param name="type"> Type of the parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ParameterDeclaration(string name, ParameterType type)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            Type = type;
        }

        /// <summary> Initializes a new instance of <see cref="ParameterDeclaration"/>. </summary>
        /// <param name="name"> Name of the parameter. </param>
        /// <param name="type"> Type of the parameter. </param>
        /// <param name="description"> Description of the parameter. </param>
        /// <param name="default"> The default value for the parameter to be used if the live pipeline does not specify a value. </param>
        internal ParameterDeclaration(string name, ParameterType type, string description, string @default)
        {
            Name = name;
            Type = type;
            Description = description;
            Default = @default;
        }

        /// <summary> Name of the parameter. </summary>
        public string Name { get; set; }
        /// <summary> Type of the parameter. </summary>
        public ParameterType Type { get; set; }
        /// <summary> Description of the parameter. </summary>
        public string Description { get; set; }
        /// <summary> The default value for the parameter to be used if the live pipeline does not specify a value. </summary>
        public string Default { get; set; }
    }
}
