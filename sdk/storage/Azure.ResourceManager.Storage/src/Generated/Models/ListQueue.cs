// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The ListQueue. </summary>
    internal partial class ListQueue : ResourceData
    {
        /// <summary> Initializes a new instance of ListQueue. </summary>
        public ListQueue()
        {
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of ListQueue. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="metadata"> A name-value pair that represents queue metadata. </param>
        internal ListQueue(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> metadata) : base(id, name, type, systemData)
        {
            Metadata = metadata;
        }

        /// <summary> A name-value pair that represents queue metadata. </summary>
        public IDictionary<string, string> Metadata { get; }
    }
}
