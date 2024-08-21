// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Unknown version of DataConnector. </summary>
    internal partial class UnknownDataConnector : SecurityInsightsDataConnectorData
    {
        /// <summary> Initializes a new instance of <see cref="UnknownDataConnector"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind">
        /// The data connector kind
        /// Serialized Name: DataConnector.kind
        /// </param>
        /// <param name="etag">
        /// Etag of the azure resource
        /// Serialized Name: ResourceWithEtag.etag
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownDataConnector(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataConnectorKind kind, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, kind, etag, serializedAdditionalRawData)
        {
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownDataConnector"/> for deserialization. </summary>
        internal UnknownDataConnector()
        {
        }
    }
}
