// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Base type for describing any cognitive service resource attached to a skillset. </summary>
    public partial class CognitiveServicesAccount
    {

        /// <summary> Initializes a new instance of CognitiveServicesAccount. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the cognitive service resource attached to a skillset. </param>
        /// <param name="description"> Description of the cognitive service resource attached to a skillset. </param>
        internal CognitiveServicesAccount(string oDataType, string description)
        {
            ODataType = oDataType;
            Description = description;
        }

        /// <summary> Identifies the concrete type of the cognitive service resource attached to a skillset. </summary>
        internal string ODataType { get; set; }
        /// <summary> Description of the cognitive service resource attached to a skillset. </summary>
        public string Description { get; set; }
    }
}
