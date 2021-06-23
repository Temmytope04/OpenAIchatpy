// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The properties of a stateful service resource for patch operations.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Stateful")]
    public partial class StatefulServiceUpdateProperties : ServiceResourceUpdateProperties
    {
        /// <summary>
        /// Initializes a new instance of the StatefulServiceUpdateProperties
        /// class.
        /// </summary>
        public StatefulServiceUpdateProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StatefulServiceUpdateProperties
        /// class.
        /// </summary>
        /// <param name="placementConstraints">The placement constraints as a
        /// string. Placement constraints are boolean expressions on node
        /// properties and allow for restricting a service to particular nodes
        /// based on the service requirements. For example, to place a service
        /// on nodes where NodeType is blue specify the following: "NodeColor
        /// == blue)".</param>
        /// <param name="defaultMoveCost">Possible values include: 'Zero',
        /// 'Low', 'Medium', 'High'</param>
        /// <param name="targetReplicaSetSize">The target replica set size as a
        /// number.</param>
        /// <param name="minReplicaSetSize">The minimum replica set size as a
        /// number.</param>
        /// <param name="replicaRestartWaitDuration">The duration between when
        /// a replica goes down and when a new replica is created, represented
        /// in ISO 8601 format (hh:mm:ss.s).</param>
        /// <param name="quorumLossWaitDuration">The maximum duration for which
        /// a partition is allowed to be in a state of quorum loss, represented
        /// in ISO 8601 format (hh:mm:ss.s).</param>
        /// <param name="standByReplicaKeepDuration">The definition on how long
        /// StandBy replicas should be maintained before being removed,
        /// represented in ISO 8601 format (hh:mm:ss.s).</param>
        public StatefulServiceUpdateProperties(string placementConstraints = default(string), IList<ServiceCorrelationDescription> correlationScheme = default(IList<ServiceCorrelationDescription>), IList<ServiceLoadMetricDescription> serviceLoadMetrics = default(IList<ServiceLoadMetricDescription>), IList<ServicePlacementPolicyDescription> servicePlacementPolicies = default(IList<ServicePlacementPolicyDescription>), string defaultMoveCost = default(string), int? targetReplicaSetSize = default(int?), int? minReplicaSetSize = default(int?), System.DateTime? replicaRestartWaitDuration = default(System.DateTime?), System.DateTime? quorumLossWaitDuration = default(System.DateTime?), System.DateTime? standByReplicaKeepDuration = default(System.DateTime?))
            : base(placementConstraints, correlationScheme, serviceLoadMetrics, servicePlacementPolicies, defaultMoveCost)
        {
            TargetReplicaSetSize = targetReplicaSetSize;
            MinReplicaSetSize = minReplicaSetSize;
            ReplicaRestartWaitDuration = replicaRestartWaitDuration;
            QuorumLossWaitDuration = quorumLossWaitDuration;
            StandByReplicaKeepDuration = standByReplicaKeepDuration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the target replica set size as a number.
        /// </summary>
        [JsonProperty(PropertyName = "targetReplicaSetSize")]
        public int? TargetReplicaSetSize { get; set; }

        /// <summary>
        /// Gets or sets the minimum replica set size as a number.
        /// </summary>
        [JsonProperty(PropertyName = "minReplicaSetSize")]
        public int? MinReplicaSetSize { get; set; }

        /// <summary>
        /// Gets or sets the duration between when a replica goes down and when
        /// a new replica is created, represented in ISO 8601 format
        /// (hh:mm:ss.s).
        /// </summary>
        [JsonProperty(PropertyName = "replicaRestartWaitDuration")]
        public System.DateTime? ReplicaRestartWaitDuration { get; set; }

        /// <summary>
        /// Gets or sets the maximum duration for which a partition is allowed
        /// to be in a state of quorum loss, represented in ISO 8601 format
        /// (hh:mm:ss.s).
        /// </summary>
        [JsonProperty(PropertyName = "quorumLossWaitDuration")]
        public System.DateTime? QuorumLossWaitDuration { get; set; }

        /// <summary>
        /// Gets or sets the definition on how long StandBy replicas should be
        /// maintained before being removed, represented in ISO 8601 format
        /// (hh:mm:ss.s).
        /// </summary>
        [JsonProperty(PropertyName = "standByReplicaKeepDuration")]
        public System.DateTime? StandByReplicaKeepDuration { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TargetReplicaSetSize < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "TargetReplicaSetSize", 1);
            }
            if (MinReplicaSetSize < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MinReplicaSetSize", 1);
            }
        }
    }
}
