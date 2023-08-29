// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageMover.Models
{
    /// <summary> The StorageMoverAgentPropertiesErrorDetails. </summary>
    public partial class StorageMoverAgentPropertiesErrorDetails
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StorageMoverAgentPropertiesErrorDetails"/>. </summary>
        internal StorageMoverAgentPropertiesErrorDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageMoverAgentPropertiesErrorDetails"/>. </summary>
        /// <param name="code"> Error code reported by Agent. </param>
        /// <param name="message"> Expanded description of reported error code. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageMoverAgentPropertiesErrorDetails(string code, string message, Dictionary<string, BinaryData> rawData)
        {
            Code = code;
            Message = message;
            _rawData = rawData;
        }

        /// <summary> Error code reported by Agent. </summary>
        public string Code { get; }
        /// <summary> Expanded description of reported error code. </summary>
        public string Message { get; }
    }
}
