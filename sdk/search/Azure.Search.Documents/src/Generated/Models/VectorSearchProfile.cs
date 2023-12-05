// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Defines a combination of configurations to use with vector search. </summary>
    public partial class VectorSearchProfile
    {
        /// <summary> Initializes a new instance of <see cref="VectorSearchProfile"/>. </summary>
        /// <param name="name"> The name to associate with this particular vector search profile. </param>
        /// <param name="algorithmConfigurationName"> The name of the vector search algorithm configuration that specifies the algorithm and optional parameters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="algorithmConfigurationName"/> is null. </exception>
        public VectorSearchProfile(string name, string algorithmConfigurationName)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(algorithmConfigurationName, nameof(algorithmConfigurationName));

            Name = name;
            AlgorithmConfigurationName = algorithmConfigurationName;
        }

        /// <summary> The name to associate with this particular vector search profile. </summary>
        public string Name { get; set; }
        /// <summary> The name of the vector search algorithm configuration that specifies the algorithm and optional parameters. </summary>
        public string AlgorithmConfigurationName { get; set; }
    }
}
