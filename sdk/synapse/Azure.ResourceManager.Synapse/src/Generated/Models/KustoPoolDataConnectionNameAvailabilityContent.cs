// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> A data connection check name availability request. </summary>
    public partial class KustoPoolDataConnectionNameAvailabilityContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KustoPoolDataConnectionNameAvailabilityContent"/>. </summary>
        /// <param name="name"> Data Connection name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public KustoPoolDataConnectionNameAvailabilityContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            ResourceType = SynapseDataConnectionType.MicrosoftSynapseWorkspacesKustoPoolsDatabasesDataConnections;
        }

        /// <summary> Initializes a new instance of <see cref="KustoPoolDataConnectionNameAvailabilityContent"/>. </summary>
        /// <param name="name"> Data Connection name. </param>
        /// <param name="resourceType"> The type of resource, Microsoft.Synapse/workspaces/kustoPools/databases/dataConnections. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KustoPoolDataConnectionNameAvailabilityContent(string name, SynapseDataConnectionType resourceType, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            ResourceType = resourceType;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="KustoPoolDataConnectionNameAvailabilityContent"/> for deserialization. </summary>
        internal KustoPoolDataConnectionNameAvailabilityContent()
        {
        }

        /// <summary> Data Connection name. </summary>
        public string Name { get; }
        /// <summary> The type of resource, Microsoft.Synapse/workspaces/kustoPools/databases/dataConnections. </summary>
        public SynapseDataConnectionType ResourceType { get; }
    }
}
