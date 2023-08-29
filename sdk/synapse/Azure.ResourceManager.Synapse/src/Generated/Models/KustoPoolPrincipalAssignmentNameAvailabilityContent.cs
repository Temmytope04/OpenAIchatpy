// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> A principal assignment check name availability request. </summary>
    public partial class KustoPoolPrincipalAssignmentNameAvailabilityContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KustoPoolPrincipalAssignmentNameAvailabilityContent"/>. </summary>
        /// <param name="name"> Principal Assignment resource name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public KustoPoolPrincipalAssignmentNameAvailabilityContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            ResourceType = SynapsePrincipalAssignmentType.MicrosoftSynapseWorkspacesKustoPoolsPrincipalAssignments;
        }

        /// <summary> Initializes a new instance of <see cref="KustoPoolPrincipalAssignmentNameAvailabilityContent"/>. </summary>
        /// <param name="name"> Principal Assignment resource name. </param>
        /// <param name="resourceType"> The type of resource, Microsoft.Synapse/workspaces/kustoPools/principalAssignments. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KustoPoolPrincipalAssignmentNameAvailabilityContent(string name, SynapsePrincipalAssignmentType resourceType, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            ResourceType = resourceType;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="KustoPoolPrincipalAssignmentNameAvailabilityContent"/> for deserialization. </summary>
        internal KustoPoolPrincipalAssignmentNameAvailabilityContent()
        {
        }

        /// <summary> Principal Assignment resource name. </summary>
        public string Name { get; }
        /// <summary> The type of resource, Microsoft.Synapse/workspaces/kustoPools/principalAssignments. </summary>
        public SynapsePrincipalAssignmentType ResourceType { get; }
    }
}
