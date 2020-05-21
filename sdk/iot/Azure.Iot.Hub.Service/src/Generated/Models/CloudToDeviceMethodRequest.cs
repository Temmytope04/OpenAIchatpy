// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> Parameters to execute a direct method on the device. </summary>
    public partial class CloudToDeviceMethodRequest
    {
        /// <summary> Initializes a new instance of CloudToDeviceMethodRequest. </summary>
        public CloudToDeviceMethodRequest()
        {
        }

        /// <summary> Initializes a new instance of CloudToDeviceMethodRequest. </summary>
        /// <param name="methodName"> Method to run. </param>
        /// <param name="payload"> Payload. </param>
        /// <param name="responseTimeoutInSeconds"> . </param>
        /// <param name="connectTimeoutInSeconds"> . </param>
        internal CloudToDeviceMethodRequest(string methodName, object payload, int? responseTimeoutInSeconds, int? connectTimeoutInSeconds)
        {
            MethodName = methodName;
            Payload = payload;
            ResponseTimeoutInSeconds = responseTimeoutInSeconds;
            ConnectTimeoutInSeconds = connectTimeoutInSeconds;
        }

        /// <summary> Method to run. </summary>
        public string MethodName { get; set; }
        /// <summary> Payload. </summary>
        public object Payload { get; set; }
        public int? ResponseTimeoutInSeconds { get; set; }
        public int? ConnectTimeoutInSeconds { get; set; }
    }
}
