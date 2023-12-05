// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a device life cycle event (DeviceCreated, DeviceDeleted). </summary>
    public partial class DeviceLifeCycleEventProperties
    {
        /// <summary> Initializes a new instance of <see cref="DeviceLifeCycleEventProperties"/>. </summary>
        internal DeviceLifeCycleEventProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeviceLifeCycleEventProperties"/>. </summary>
        /// <param name="deviceId"> The unique identifier of the device. This case-sensitive string can be up to 128 characters long, and supports ASCII 7-bit alphanumeric characters plus the following special characters: - : . + % _ &amp;#35; * ? ! ( ) , = @ ; $ '. </param>
        /// <param name="hubName"> Name of the IoT Hub where the device was created or deleted. </param>
        /// <param name="twin"> Information about the device twin, which is the cloud representation of application device metadata. </param>
        internal DeviceLifeCycleEventProperties(string deviceId, string hubName, DeviceTwinInfo twin)
        {
            DeviceId = deviceId;
            HubName = hubName;
            Twin = twin;
        }

        /// <summary> The unique identifier of the device. This case-sensitive string can be up to 128 characters long, and supports ASCII 7-bit alphanumeric characters plus the following special characters: - : . + % _ &amp;#35; * ? ! ( ) , = @ ; $ '. </summary>
        public string DeviceId { get; }
        /// <summary> Name of the IoT Hub where the device was created or deleted. </summary>
        public string HubName { get; }
        /// <summary> Information about the device twin, which is the cloud representation of application device metadata. </summary>
        public DeviceTwinInfo Twin { get; }
    }
}
