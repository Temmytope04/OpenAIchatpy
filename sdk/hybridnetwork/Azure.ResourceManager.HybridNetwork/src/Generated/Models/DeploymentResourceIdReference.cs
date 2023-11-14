// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary>
    /// The azure resource reference which is used for deployment.
    /// Please note <see cref="DeploymentResourceIdReference"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="OpenDeploymentResourceReference"/> and <see cref="SecretDeploymentResourceReference"/>.
    /// </summary>
    public abstract partial class DeploymentResourceIdReference
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DeploymentResourceIdReference"/>. </summary>
        protected DeploymentResourceIdReference()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeploymentResourceIdReference"/>. </summary>
        /// <param name="idType"> The resource reference arm id type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeploymentResourceIdReference(IdType idType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IdType = idType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The resource reference arm id type. </summary>
        internal IdType IdType { get; set; }
    }
}
