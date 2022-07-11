// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The trigger based on base image dependency. </summary>
    public partial class BaseImageTrigger
    {
        /// <summary> Initializes a new instance of BaseImageTrigger. </summary>
        /// <param name="baseImageTriggerType"> The type of the auto trigger for base image dependency updates. </param>
        /// <param name="name"> The name of the trigger. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public BaseImageTrigger(BaseImageTriggerType baseImageTriggerType, string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            BaseImageTriggerType = baseImageTriggerType;
            Name = name;
        }

        /// <summary> Initializes a new instance of BaseImageTrigger. </summary>
        /// <param name="baseImageTriggerType"> The type of the auto trigger for base image dependency updates. </param>
        /// <param name="updateTriggerEndpoint"> The endpoint URL for receiving update triggers. </param>
        /// <param name="updateTriggerPayloadType"> Type of Payload body for Base image update triggers. </param>
        /// <param name="status"> The current status of trigger. </param>
        /// <param name="name"> The name of the trigger. </param>
        internal BaseImageTrigger(BaseImageTriggerType baseImageTriggerType, string updateTriggerEndpoint, UpdateTriggerPayloadType? updateTriggerPayloadType, TriggerStatus? status, string name)
        {
            BaseImageTriggerType = baseImageTriggerType;
            UpdateTriggerEndpoint = updateTriggerEndpoint;
            UpdateTriggerPayloadType = updateTriggerPayloadType;
            Status = status;
            Name = name;
        }

        /// <summary> The type of the auto trigger for base image dependency updates. </summary>
        public BaseImageTriggerType BaseImageTriggerType { get; set; }
        /// <summary> The endpoint URL for receiving update triggers. </summary>
        public string UpdateTriggerEndpoint { get; set; }
        /// <summary> Type of Payload body for Base image update triggers. </summary>
        public UpdateTriggerPayloadType? UpdateTriggerPayloadType { get; set; }
        /// <summary> The current status of trigger. </summary>
        public TriggerStatus? Status { get; set; }
        /// <summary> The name of the trigger. </summary>
        public string Name { get; set; }
    }
}
