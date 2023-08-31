// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The azure resource info when target service type is AzureResource. </summary>
    public partial class AzureResourceInfo : TargetServiceBaseInfo
    {
        /// <summary> Initializes a new instance of <see cref="AzureResourceInfo"/>. </summary>
        public AzureResourceInfo()
        {
            TargetServiceType = TargetServiceType.AzureResource;
        }

        /// <summary> Initializes a new instance of <see cref="AzureResourceInfo"/>. </summary>
        /// <param name="targetServiceType"> The target service type. </param>
        /// <param name="id"> The Id of azure resource. </param>
        /// <param name="resourceProperties">
        /// The azure resource connection related properties.
        /// Please note <see cref="AzureResourceBaseProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultProperties"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureResourceInfo(TargetServiceType targetServiceType, ResourceIdentifier id, AzureResourceBaseProperties resourceProperties, Dictionary<string, BinaryData> rawData) : base(targetServiceType, rawData)
        {
            Id = id;
            ResourceProperties = resourceProperties;
            TargetServiceType = targetServiceType;
        }

        /// <summary> The Id of azure resource. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary>
        /// The azure resource connection related properties.
        /// Please note <see cref="AzureResourceBaseProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultProperties"/>.
        /// </summary>
        public AzureResourceBaseProperties ResourceProperties { get; set; }
    }
}
