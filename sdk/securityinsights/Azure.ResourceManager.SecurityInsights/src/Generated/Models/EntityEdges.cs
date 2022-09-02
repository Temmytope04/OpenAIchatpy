// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The edge that connects the entity to the other entity. </summary>
    public partial class EntityEdges
    {
        /// <summary> Initializes a new instance of EntityEdges. </summary>
        internal EntityEdges()
        {
            AdditionalData = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of EntityEdges. </summary>
        /// <param name="targetEntityId"> The target entity Id. </param>
        /// <param name="additionalData"> A bag of custom fields that should be part of the entity and will be presented to the user. </param>
        internal EntityEdges(string targetEntityId, IReadOnlyDictionary<string, BinaryData> additionalData)
        {
            TargetEntityId = targetEntityId;
            AdditionalData = additionalData;
        }

        /// <summary> The target entity Id. </summary>
        public string TargetEntityId { get; }
        /// <summary> A bag of custom fields that should be part of the entity and will be presented to the user. </summary>
        public IReadOnlyDictionary<string, BinaryData> AdditionalData { get; }
    }
}
