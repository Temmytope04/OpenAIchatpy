// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> An indication of Cache health. Gives more information about health than just that related to provisioning. </summary>
    public partial class StorageCacheHealth
    {
        /// <summary> Initializes a new instance of StorageCacheHealth. </summary>
        internal StorageCacheHealth()
        {
            Conditions = new ChangeTrackingList<OutstandingCondition>();
        }

        /// <summary> Initializes a new instance of StorageCacheHealth. </summary>
        /// <param name="state"> List of Cache health states. </param>
        /// <param name="statusDescription"> Describes explanation of state. </param>
        /// <param name="conditions"> Outstanding conditions that need to be investigated and resolved. </param>
        internal StorageCacheHealth(StorageCacheHealthStateType? state, string statusDescription, IReadOnlyList<OutstandingCondition> conditions)
        {
            State = state;
            StatusDescription = statusDescription;
            Conditions = conditions;
        }

        /// <summary> List of Cache health states. </summary>
        public StorageCacheHealthStateType? State { get; }
        /// <summary> Describes explanation of state. </summary>
        public string StatusDescription { get; }
        /// <summary> Outstanding conditions that need to be investigated and resolved. </summary>
        public IReadOnlyList<OutstandingCondition> Conditions { get; }
    }
}
