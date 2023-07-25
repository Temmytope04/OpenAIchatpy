// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The OSImageNotificationProfile. </summary>
    public partial class OSImageNotificationProfile
    {
        /// <summary> Initializes a new instance of OSImageNotificationProfile. </summary>
        public OSImageNotificationProfile()
        {
        }

        /// <summary> Initializes a new instance of OSImageNotificationProfile. </summary>
        /// <param name="notBeforeTimeout"> Length of time a Virtual Machine being reimaged or having its OS upgraded will have to potentially approve the OS Image Scheduled Event before the event is auto approved (timed out). The configuration is specified in ISO 8601 format, and the value must be 15 minutes (PT15M). </param>
        /// <param name="enable"> Specifies whether the OS Image Scheduled event is enabled or disabled. </param>
        internal OSImageNotificationProfile(string notBeforeTimeout, bool? enable)
        {
            NotBeforeTimeout = notBeforeTimeout;
            Enable = enable;
        }

        /// <summary> Length of time a Virtual Machine being reimaged or having its OS upgraded will have to potentially approve the OS Image Scheduled Event before the event is auto approved (timed out). The configuration is specified in ISO 8601 format, and the value must be 15 minutes (PT15M). </summary>
        public string NotBeforeTimeout { get; set; }
        /// <summary> Specifies whether the OS Image Scheduled event is enabled or disabled. </summary>
        public bool? Enable { get; set; }
    }
}
