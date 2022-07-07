// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The properties of the feedback queue for cloud-to-device messages. </summary>
    public partial class FeedbackProperties
    {
        /// <summary> Initializes a new instance of FeedbackProperties. </summary>
        public FeedbackProperties()
        {
        }

        /// <summary> Initializes a new instance of FeedbackProperties. </summary>
        /// <param name="lockDurationAsIso8601"> The lock duration for the feedback queue. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages. </param>
        /// <param name="ttlAsIso8601"> The period of time for which a message is available to consume before it is expired by the IoT hub. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages. </param>
        /// <param name="maxDeliveryCount"> The number of times the IoT hub attempts to deliver a message on the feedback queue. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages. </param>
        internal FeedbackProperties(TimeSpan? lockDurationAsIso8601, TimeSpan? ttlAsIso8601, int? maxDeliveryCount)
        {
            LockDurationAsIso8601 = lockDurationAsIso8601;
            TtlAsIso8601 = ttlAsIso8601;
            MaxDeliveryCount = maxDeliveryCount;
        }

        /// <summary> The lock duration for the feedback queue. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages. </summary>
        public TimeSpan? LockDurationAsIso8601 { get; set; }
        /// <summary> The period of time for which a message is available to consume before it is expired by the IoT hub. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages. </summary>
        public TimeSpan? TtlAsIso8601 { get; set; }
        /// <summary> The number of times the IoT hub attempts to deliver a message on the feedback queue. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages. </summary>
        public int? MaxDeliveryCount { get; set; }
    }
}
