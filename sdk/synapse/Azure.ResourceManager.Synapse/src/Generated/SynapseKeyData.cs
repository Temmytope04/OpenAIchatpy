// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapseKey data model.
    /// A workspace key
    /// </summary>
    public partial class SynapseKeyData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SynapseKeyData"/>. </summary>
        public SynapseKeyData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseKeyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="isActiveCmk"> Used to activate the workspace after a customer managed key is provided. </param>
        /// <param name="keyVaultUri"> The Key Vault Url of the workspace key. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseKeyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? isActiveCmk, Uri keyVaultUri, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            IsActiveCmk = isActiveCmk;
            KeyVaultUri = keyVaultUri;
            _rawData = rawData;
        }

        /// <summary> Used to activate the workspace after a customer managed key is provided. </summary>
        public bool? IsActiveCmk { get; set; }
        /// <summary> The Key Vault Url of the workspace key. </summary>
        public Uri KeyVaultUri { get; set; }
    }
}
