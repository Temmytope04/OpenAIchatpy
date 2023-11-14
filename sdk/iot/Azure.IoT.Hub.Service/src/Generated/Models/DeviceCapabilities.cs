// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> The status of capabilities enabled on the device. </summary>
    public partial class DeviceCapabilities
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DeviceCapabilities"/>. </summary>
        public DeviceCapabilities()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeviceCapabilities"/>. </summary>
        /// <param name="isIotEdgeDevice"> The property that determines if the device is an edge device or not. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceCapabilities(bool? isIotEdgeDevice, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsIotEdgeDevice = isIotEdgeDevice;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}
