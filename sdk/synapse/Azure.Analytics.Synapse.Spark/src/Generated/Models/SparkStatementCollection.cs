// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Spark.Models
{
    /// <summary> The SparkStatementCollection. </summary>
    public partial class SparkStatementCollection
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SparkStatementCollection"/>. </summary>
        /// <param name="total"></param>
        internal SparkStatementCollection(int total)
        {
            Total = total;
            Statements = new ChangeTrackingList<SparkStatement>();
        }

        /// <summary> Initializes a new instance of <see cref="SparkStatementCollection"/>. </summary>
        /// <param name="total"></param>
        /// <param name="statements"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SparkStatementCollection(int total, IReadOnlyList<SparkStatement> statements, Dictionary<string, BinaryData> rawData)
        {
            Total = total;
            Statements = statements;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SparkStatementCollection"/> for deserialization. </summary>
        internal SparkStatementCollection()
        {
        }

        /// <summary> Gets the total. </summary>
        public int Total { get; }
        /// <summary> Gets the statements. </summary>
        public IReadOnlyList<SparkStatement> Statements { get; }
    }
}
