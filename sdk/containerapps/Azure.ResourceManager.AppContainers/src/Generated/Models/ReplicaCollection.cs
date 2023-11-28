// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Container App Revision Replicas collection ARM resource. </summary>
    internal partial class ReplicaCollection
    {
        /// <summary> Initializes a new instance of <see cref="ReplicaCollection"/>. </summary>
        /// <param name="value"> Collection of resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ReplicaCollection(IEnumerable<ContainerAppReplicaData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ReplicaCollection"/>. </summary>
        /// <param name="value"> Collection of resources. </param>
        internal ReplicaCollection(IReadOnlyList<ContainerAppReplicaData> value)
        {
            Value = value;
        }

        /// <summary> Collection of resources. </summary>
        public IReadOnlyList<ContainerAppReplicaData> Value { get; }
    }
}
