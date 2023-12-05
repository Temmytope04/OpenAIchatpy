// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The properties for updating a timer trigger. </summary>
    public partial class ContainerRegistryTimerTriggerUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTimerTriggerUpdateContent"/>. </summary>
        /// <param name="name"> The name of the trigger. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ContainerRegistryTimerTriggerUpdateContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTimerTriggerUpdateContent"/>. </summary>
        /// <param name="schedule"> The CRON expression for the task schedule. </param>
        /// <param name="status"> The current status of trigger. </param>
        /// <param name="name"> The name of the trigger. </param>
        internal ContainerRegistryTimerTriggerUpdateContent(string schedule, ContainerRegistryTriggerStatus? status, string name)
        {
            Schedule = schedule;
            Status = status;
            Name = name;
        }

        /// <summary> The CRON expression for the task schedule. </summary>
        public string Schedule { get; set; }
        /// <summary> The current status of trigger. </summary>
        public ContainerRegistryTriggerStatus? Status { get; set; }
        /// <summary> The name of the trigger. </summary>
        public string Name { get; }
    }
}
