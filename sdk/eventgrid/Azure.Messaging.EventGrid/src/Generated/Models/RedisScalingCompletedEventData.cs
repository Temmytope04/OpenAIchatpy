// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Messaging.EventGrid.Models
{
    /// <summary> Schema of the Data property of an EventGridEvent for an Microsoft.Cache.ScalingCompleted event. </summary>
    internal partial class RedisScalingCompletedEventData
    {
        /// <summary> Initializes a new instance of RedisScalingCompletedEventData. </summary>
        internal RedisScalingCompletedEventData()
        {
        }

        /// <summary> The time at which the event occurred. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> The name of this event. </summary>
        public string Name { get; }
        /// <summary> The status of this event. Failed or  succeeded. </summary>
        public string Status { get; }
    }
}
