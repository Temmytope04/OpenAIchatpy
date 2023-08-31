// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> A cognitive service resource provisioned with a key that is attached to a skillset. </summary>
    public partial class CognitiveServicesAccountKey : CognitiveServicesAccount
    {
        /// <summary> Initializes a new instance of <see cref="CognitiveServicesAccountKey"/>. </summary>
        /// <param name="key"> The key used to provision the cognitive service resource attached to a skillset. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public CognitiveServicesAccountKey(string key)
        {
            Argument.AssertNotNull(key, nameof(key));

            Key = key;
            ODataType = "#Microsoft.Azure.Search.CognitiveServicesByKey";
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesAccountKey"/>. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the cognitive service resource attached to a skillset. </param>
        /// <param name="description"> Description of the cognitive service resource attached to a skillset. </param>
        /// <param name="key"> The key used to provision the cognitive service resource attached to a skillset. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CognitiveServicesAccountKey(string oDataType, string description, string key, Dictionary<string, BinaryData> rawData) : base(oDataType, description, rawData)
        {
            Key = key;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.CognitiveServicesByKey";
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesAccountKey"/> for deserialization. </summary>
        internal CognitiveServicesAccountKey()
        {
        }

        /// <summary> The key used to provision the cognitive service resource attached to a skillset. </summary>
        public string Key { get; set; }
    }
}
