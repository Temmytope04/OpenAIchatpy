// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> the quick query body. </summary>
    public partial class QueryRequest
    {
        /// <summary> Initializes a new instance of QueryRequest. </summary>
        /// <param name="expression"> a query statement. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="expression"/> is null. </exception>
        public QueryRequest(string expression)
        {
            if (expression == null)
            {
                throw new ArgumentNullException(nameof(expression));
            }

            QueryType = "SQL";
            Expression = expression;
        }

        /// <summary> the query type. </summary>
        public string QueryType { get; }
        /// <summary> a query statement. </summary>
        public string Expression { get; }
        public QuerySerialization InputSerialization { get; set; }
        public QuerySerialization OutputSerialization { get; set; }
    }
}
