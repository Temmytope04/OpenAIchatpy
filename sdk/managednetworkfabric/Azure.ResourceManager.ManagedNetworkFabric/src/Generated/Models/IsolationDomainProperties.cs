// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Isolation Domain Properties. </summary>
    public partial class IsolationDomainProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IsolationDomainProperties"/>. </summary>
        public IsolationDomainProperties()
        {
            NeighborGroupIds = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of <see cref="IsolationDomainProperties"/>. </summary>
        /// <param name="encapsulation"> Type of encapsulation. </param>
        /// <param name="neighborGroupIds"> List of Neighbor Group IDs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IsolationDomainProperties(IsolationDomainEncapsulationType? encapsulation, IList<ResourceIdentifier> neighborGroupIds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Encapsulation = encapsulation;
            NeighborGroupIds = neighborGroupIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of encapsulation. </summary>
        public IsolationDomainEncapsulationType? Encapsulation { get; set; }
        /// <summary> List of Neighbor Group IDs. </summary>
        public IList<ResourceIdentifier> NeighborGroupIds { get; }
    }
}
