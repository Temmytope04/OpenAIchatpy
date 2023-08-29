// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Contains the information necessary to perform a resource move (rename). </summary>
    public partial class SynapseResourceMoveDefinition
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SynapseResourceMoveDefinition"/>. </summary>
        /// <param name="id"> The target ID for the resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public SynapseResourceMoveDefinition(ResourceIdentifier id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
        }

        /// <summary> Initializes a new instance of <see cref="SynapseResourceMoveDefinition"/>. </summary>
        /// <param name="id"> The target ID for the resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseResourceMoveDefinition(ResourceIdentifier id, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SynapseResourceMoveDefinition"/> for deserialization. </summary>
        internal SynapseResourceMoveDefinition()
        {
        }

        /// <summary> The target ID for the resource. </summary>
        public ResourceIdentifier Id { get; }
    }
}
