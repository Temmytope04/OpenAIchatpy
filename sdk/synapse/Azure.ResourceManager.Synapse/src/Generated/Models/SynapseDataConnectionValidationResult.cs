// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The result returned from a data connection validation request. </summary>
    public partial class SynapseDataConnectionValidationResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SynapseDataConnectionValidationResult"/>. </summary>
        internal SynapseDataConnectionValidationResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseDataConnectionValidationResult"/>. </summary>
        /// <param name="errorMessage"> A message which indicates a problem in data connection validation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseDataConnectionValidationResult(string errorMessage, Dictionary<string, BinaryData> rawData)
        {
            ErrorMessage = errorMessage;
            _rawData = rawData;
        }

        /// <summary> A message which indicates a problem in data connection validation. </summary>
        public string ErrorMessage { get; }
    }
}
