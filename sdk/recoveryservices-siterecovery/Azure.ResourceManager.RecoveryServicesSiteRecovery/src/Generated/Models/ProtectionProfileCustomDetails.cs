// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Protection Profile custom input.
    /// Please note <see cref="ProtectionProfileCustomDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ExistingProtectionProfile"/> and <see cref="NewProtectionProfile"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownProtectionProfileCustomDetails))]
    public abstract partial class ProtectionProfileCustomDetails
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ProtectionProfileCustomDetails"/>. </summary>
        protected ProtectionProfileCustomDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProtectionProfileCustomDetails"/>. </summary>
        /// <param name="resourceType"> The class type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ProtectionProfileCustomDetails(string resourceType, Dictionary<string, BinaryData> rawData)
        {
            ResourceType = resourceType;
            _rawData = rawData;
        }

        /// <summary> The class type. </summary>
        internal string ResourceType { get; set; }
    }
}
