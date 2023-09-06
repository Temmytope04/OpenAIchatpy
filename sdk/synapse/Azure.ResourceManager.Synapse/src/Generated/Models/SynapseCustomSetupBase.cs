// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary>
    /// The base definition of the custom setup.
    /// Please note <see cref="SynapseCustomSetupBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SynapseCmdkeySetup"/>, <see cref="SynapseComponentSetup"/> and <see cref="SynapseEnvironmentVariableSetup"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownCustomSetupBase))]
    public abstract partial class SynapseCustomSetupBase
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SynapseCustomSetupBase"/>. </summary>
        protected SynapseCustomSetupBase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseCustomSetupBase"/>. </summary>
        /// <param name="customSetupBaseType"> The type of custom setup. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseCustomSetupBase(string customSetupBaseType, Dictionary<string, BinaryData> rawData)
        {
            CustomSetupBaseType = customSetupBaseType;
            _rawData = rawData;
        }

        /// <summary> The type of custom setup. </summary>
        internal string CustomSetupBaseType { get; set; }
    }
}
