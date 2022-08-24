// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MixedReality.Models
{
    /// <summary>
    /// Check Name Availability Request
    /// Serialized Name: CheckNameAvailabilityRequest
    /// </summary>
    public partial class CheckNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of CheckNameAvailabilityContent. </summary>
        /// <param name="name">
        /// Resource Name To Verify
        /// Serialized Name: CheckNameAvailabilityRequest.name
        /// </param>
        /// <param name="resourceType">
        /// Fully qualified resource type which includes provider namespace
        /// Serialized Name: CheckNameAvailabilityRequest.type
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="resourceType"/> is null. </exception>
        public CheckNameAvailabilityContent(string name, string resourceType)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (resourceType == null)
            {
                throw new ArgumentNullException(nameof(resourceType));
            }

            Name = name;
            ResourceType = resourceType;
        }

        /// <summary>
        /// Resource Name To Verify
        /// Serialized Name: CheckNameAvailabilityRequest.name
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Fully qualified resource type which includes provider namespace
        /// Serialized Name: CheckNameAvailabilityRequest.type
        /// </summary>
        public string ResourceType { get; }
    }
}
