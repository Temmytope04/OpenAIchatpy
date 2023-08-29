// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> An object to provide order by options for listing runs. </summary>
    public partial class RunQueryOrderBy
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RunQueryOrderBy"/>. </summary>
        /// <param name="orderBy"> Parameter name to be used for order by. The allowed parameters to order by for pipeline runs are PipelineName, RunStart, RunEnd and Status; for activity runs are ActivityName, ActivityRunStart, ActivityRunEnd and Status; for trigger runs are TriggerName, TriggerRunTimestamp and Status. </param>
        /// <param name="order"> Sorting order of the parameter. </param>
        public RunQueryOrderBy(RunQueryOrderByField orderBy, RunQueryOrder order)
        {
            OrderBy = orderBy;
            Order = order;
        }

        /// <summary> Initializes a new instance of <see cref="RunQueryOrderBy"/>. </summary>
        /// <param name="orderBy"> Parameter name to be used for order by. The allowed parameters to order by for pipeline runs are PipelineName, RunStart, RunEnd and Status; for activity runs are ActivityName, ActivityRunStart, ActivityRunEnd and Status; for trigger runs are TriggerName, TriggerRunTimestamp and Status. </param>
        /// <param name="order"> Sorting order of the parameter. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RunQueryOrderBy(RunQueryOrderByField orderBy, RunQueryOrder order, Dictionary<string, BinaryData> rawData)
        {
            OrderBy = orderBy;
            Order = order;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="RunQueryOrderBy"/> for deserialization. </summary>
        internal RunQueryOrderBy()
        {
        }

        /// <summary> Parameter name to be used for order by. The allowed parameters to order by for pipeline runs are PipelineName, RunStart, RunEnd and Status; for activity runs are ActivityName, ActivityRunStart, ActivityRunEnd and Status; for trigger runs are TriggerName, TriggerRunTimestamp and Status. </summary>
        public RunQueryOrderByField OrderBy { get; }
        /// <summary> Sorting order of the parameter. </summary>
        public RunQueryOrder Order { get; }
    }
}
