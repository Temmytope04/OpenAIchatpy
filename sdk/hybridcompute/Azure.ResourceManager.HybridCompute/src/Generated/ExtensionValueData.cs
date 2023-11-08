// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridCompute
{
    /// <summary>
    /// A class representing the ExtensionValue data model.
    /// Describes a Extension Metadata
    /// </summary>
    public partial class ExtensionValueData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExtensionValueData"/>. </summary>
        public ExtensionValueData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExtensionValueData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="version"> The version of the Extension being received. </param>
        /// <param name="extensionType"> The type of the Extension being received. </param>
        /// <param name="publisher"> The publisher of the Extension being received. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExtensionValueData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string version, string extensionType, string publisher, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Version = version;
            ExtensionType = extensionType;
            Publisher = publisher;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The version of the Extension being received. </summary>
        public string Version { get; }
        /// <summary> The type of the Extension being received. </summary>
        public string ExtensionType { get; }
        /// <summary> The publisher of the Extension being received. </summary>
        public string Publisher { get; }
    }
}
