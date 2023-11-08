// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The AgentPoolProvisioningStatusError. </summary>
    public partial class AgentPoolProvisioningStatusError
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AgentPoolProvisioningStatusError"/>. </summary>
        public AgentPoolProvisioningStatusError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AgentPoolProvisioningStatusError"/>. </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AgentPoolProvisioningStatusError(string code, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the code. </summary>
        public string Code { get; set; }
        /// <summary> Gets or sets the message. </summary>
        public string Message { get; set; }
    }
}
