// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the Identifier data model. </summary>
    public partial class IdentifierData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of IdentifierData. </summary>
        public IdentifierData()
        {
        }

        /// <summary> Initializes a new instance of IdentifierData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="value"> String representation of the identity. </param>
        internal IdentifierData(ResourceIdentifier id, string name, ResourceType type, string kind, string value) : base(id, name, type, kind)
        {
            Value = value;
        }

        /// <summary> String representation of the identity. </summary>
        public string Value { get; set; }
    }
}
