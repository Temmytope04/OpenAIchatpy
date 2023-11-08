// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Helm ReplicaSet status properties. </summary>
    public partial class KubernetesReplicaSet
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KubernetesReplicaSet"/>. </summary>
        internal KubernetesReplicaSet()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesReplicaSet"/>. </summary>
        /// <param name="name"> The name of the replicaSet. </param>
        /// <param name="namespace"> The namespace of the replicaSet. </param>
        /// <param name="desiredNumberOfPods"> Desired number of pods. </param>
        /// <param name="readyNumberOfPods"> Number of ready pods. </param>
        /// <param name="currentNumberOfPods"> Number of current pods. </param>
        /// <param name="createdOn"> Creation Time of replicaSet. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KubernetesReplicaSet(string name, string @namespace, int? desiredNumberOfPods, int? readyNumberOfPods, int? currentNumberOfPods, DateTimeOffset? createdOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Namespace = @namespace;
            DesiredNumberOfPods = desiredNumberOfPods;
            ReadyNumberOfPods = readyNumberOfPods;
            CurrentNumberOfPods = currentNumberOfPods;
            CreatedOn = createdOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the replicaSet. </summary>
        public string Name { get; }
        /// <summary> The namespace of the replicaSet. </summary>
        public string Namespace { get; }
        /// <summary> Desired number of pods. </summary>
        public int? DesiredNumberOfPods { get; }
        /// <summary> Number of ready pods. </summary>
        public int? ReadyNumberOfPods { get; }
        /// <summary> Number of current pods. </summary>
        public int? CurrentNumberOfPods { get; }
        /// <summary> Creation Time of replicaSet. </summary>
        public DateTimeOffset? CreatedOn { get; }
    }
}
