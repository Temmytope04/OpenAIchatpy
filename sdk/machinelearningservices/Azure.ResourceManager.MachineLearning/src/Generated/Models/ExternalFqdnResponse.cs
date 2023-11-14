// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The ExternalFqdnResponse. </summary>
    internal partial class ExternalFqdnResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExternalFqdnResponse"/>. </summary>
        internal ExternalFqdnResponse()
        {
            Value = new ChangeTrackingList<MachineLearningFqdnEndpoints>();
        }

        /// <summary> Initializes a new instance of <see cref="ExternalFqdnResponse"/>. </summary>
        /// <param name="value"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExternalFqdnResponse(IReadOnlyList<MachineLearningFqdnEndpoints> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<MachineLearningFqdnEndpoints> Value { get; }
    }
}
