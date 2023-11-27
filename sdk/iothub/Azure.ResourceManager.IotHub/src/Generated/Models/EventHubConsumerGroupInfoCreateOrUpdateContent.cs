// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The EventHub consumer group. </summary>
    public partial class EventHubConsumerGroupInfoCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="EventHubConsumerGroupInfoCreateOrUpdateContent"/>. </summary>
        /// <param name="name"> EventHub consumer group name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public EventHubConsumerGroupInfoCreateOrUpdateContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> EventHub consumer group name. </summary>
        public string Name { get; }
    }
}
