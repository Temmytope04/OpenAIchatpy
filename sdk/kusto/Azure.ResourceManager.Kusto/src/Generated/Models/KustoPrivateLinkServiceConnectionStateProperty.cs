// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> Connection State of the Private Endpoint Connection. </summary>
    public partial class KustoPrivateLinkServiceConnectionStateProperty
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KustoPrivateLinkServiceConnectionStateProperty"/>. </summary>
        public KustoPrivateLinkServiceConnectionStateProperty()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KustoPrivateLinkServiceConnectionStateProperty"/>. </summary>
        /// <param name="status"> The private link service connection status. </param>
        /// <param name="description"> The private link service connection description. </param>
        /// <param name="actionsRequired"> Any action that is required beyond basic workflow (approve/ reject/ disconnect). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KustoPrivateLinkServiceConnectionStateProperty(string status, string description, string actionsRequired, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The private link service connection status. </summary>
        public string Status { get; set; }
        /// <summary> The private link service connection description. </summary>
        public string Description { get; set; }
        /// <summary> Any action that is required beyond basic workflow (approve/ reject/ disconnect). </summary>
        public string ActionsRequired { get; }
    }
}
