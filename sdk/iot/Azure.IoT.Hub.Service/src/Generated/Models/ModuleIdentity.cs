// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> The module identity on a device. </summary>
    public partial class ModuleIdentity
    {
        /// <summary> Initializes a new instance of ModuleIdentity. </summary>
        public ModuleIdentity()
        {
        }

        /// <summary> Initializes a new instance of ModuleIdentity. </summary>
        /// <param name="moduleId"> The unique identifier of the module. </param>
        /// <param name="managedBy"> Identifies who manages this module. For instance, this value is \&quot;IotEdge\&quot; if the edge runtime owns this module. </param>
        /// <param name="deviceId"> The unique identifier of the device. </param>
        /// <param name="generationId"> The IoT Hub generated, case-sensitive string up to 128 characters long. This value is used to distinguish modules with the same moduleId, when they have been deleted and re-created. </param>
        /// <param name="etag"> The string representing a weak ETag for the module identity, as per RFC7232. </param>
        /// <param name="connectionState"> The connection state of the device. </param>
        /// <param name="connectionStateUpdatedTime"> The date and time the connection state was last updated. </param>
        /// <param name="lastActivityTime"> The date and time the device last connected, received, or sent a message. </param>
        /// <param name="cloudToDeviceMessageCount"> The number of cloud-to-module messages currently queued to be sent to the module. </param>
        /// <param name="authentication"> The authentication mechanism used by the module when connecting to the service and edge hub. </param>
        internal ModuleIdentity(string moduleId, string managedBy, string deviceId, string generationId, string etag, ModuleConnectionState? connectionState, DateTimeOffset? connectionStateUpdatedTime, DateTimeOffset? lastActivityTime, int? cloudToDeviceMessageCount, AuthenticationMechanism authentication)
        {
            ModuleId = moduleId;
            ManagedBy = managedBy;
            DeviceId = deviceId;
            GenerationId = generationId;
            Etag = etag;
            ConnectionState = connectionState;
            ConnectionStateUpdatedTime = connectionStateUpdatedTime;
            LastActivityTime = lastActivityTime;
            CloudToDeviceMessageCount = cloudToDeviceMessageCount;
            Authentication = authentication;
        }

        /// <summary> The unique identifier of the module. </summary>
        public string ModuleId { get; set; }
        /// <summary> Identifies who manages this module. For instance, this value is \&quot;IotEdge\&quot; if the edge runtime owns this module. </summary>
        public string ManagedBy { get; set; }
        /// <summary> The unique identifier of the device. </summary>
        public string DeviceId { get; set; }
        /// <summary> The IoT Hub generated, case-sensitive string up to 128 characters long. This value is used to distinguish modules with the same moduleId, when they have been deleted and re-created. </summary>
        public string GenerationId { get; set; }
        /// <summary> The string representing a weak ETag for the module identity, as per RFC7232. </summary>
        public string Etag { get; set; }
        /// <summary> The connection state of the device. </summary>
        public ModuleConnectionState? ConnectionState { get; set; }
        /// <summary> The date and time the connection state was last updated. </summary>
        public DateTimeOffset? ConnectionStateUpdatedTime { get; set; }
        /// <summary> The date and time the device last connected, received, or sent a message. </summary>
        public DateTimeOffset? LastActivityTime { get; set; }
        /// <summary> The number of cloud-to-module messages currently queued to be sent to the module. </summary>
        public int? CloudToDeviceMessageCount { get; set; }
        /// <summary> The authentication mechanism used by the module when connecting to the service and edge hub. </summary>
        public AuthenticationMechanism Authentication { get; set; }
    }
}
