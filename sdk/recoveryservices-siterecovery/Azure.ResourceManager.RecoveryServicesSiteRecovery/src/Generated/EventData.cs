// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary> A class representing the Event data model. </summary>
    public partial class EventData : ResourceData
    {
        /// <summary> Initializes a new instance of EventData. </summary>
        internal EventData()
        {
        }

        /// <summary> Initializes a new instance of EventData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Event related data. </param>
        /// <param name="location"> Resource Location. </param>
        internal EventData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, EventProperties properties, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Location = location;
        }

        /// <summary> Event related data. </summary>
        public EventProperties Properties { get; }
        /// <summary> Resource Location. </summary>
        public AzureLocation? Location { get; }
    }
}
