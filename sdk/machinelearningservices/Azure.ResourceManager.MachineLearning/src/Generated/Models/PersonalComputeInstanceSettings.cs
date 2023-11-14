// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Settings for a personal compute instance. </summary>
    internal partial class PersonalComputeInstanceSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PersonalComputeInstanceSettings"/>. </summary>
        public PersonalComputeInstanceSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PersonalComputeInstanceSettings"/>. </summary>
        /// <param name="assignedUser"> A user explicitly assigned to a personal compute instance. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PersonalComputeInstanceSettings(MachineLearningComputeInstanceAssignedUser assignedUser, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AssignedUser = assignedUser;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A user explicitly assigned to a personal compute instance. </summary>
        public MachineLearningComputeInstanceAssignedUser AssignedUser { get; set; }
    }
}
