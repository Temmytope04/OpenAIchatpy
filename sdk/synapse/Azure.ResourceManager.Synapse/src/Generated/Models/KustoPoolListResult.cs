// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The list Kusto pools operation response. </summary>
    internal partial class KustoPoolListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KustoPoolListResult"/>. </summary>
        internal KustoPoolListResult()
        {
            Value = new ChangeTrackingList<SynapseKustoPoolData>();
        }

        /// <summary> Initializes a new instance of <see cref="KustoPoolListResult"/>. </summary>
        /// <param name="value"> The list of Kusto pools. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KustoPoolListResult(IReadOnlyList<SynapseKustoPoolData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The list of Kusto pools. </summary>
        public IReadOnlyList<SynapseKustoPoolData> Value { get; }
    }
}
