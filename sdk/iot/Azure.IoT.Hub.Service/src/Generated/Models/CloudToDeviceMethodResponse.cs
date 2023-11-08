// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> Represents the Device Method Invocation Results. </summary>
    public partial class CloudToDeviceMethodResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CloudToDeviceMethodResponse"/>. </summary>
        internal CloudToDeviceMethodResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CloudToDeviceMethodResponse"/>. </summary>
        /// <param name="status"> Method invocation result status. </param>
        /// <param name="payload"> Method invocation result payload. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudToDeviceMethodResponse(int? status, object payload, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            Payload = payload;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Method invocation result status. </summary>
        public int? Status { get; }
        /// <summary> Method invocation result payload. </summary>
        public object Payload { get; }
    }
}
