// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The sample queries for the connector. </summary>
    public partial class SampleQueries
    {
        /// <summary> Initializes a new instance of SampleQueries. </summary>
        public SampleQueries()
        {
        }

        /// <summary> Initializes a new instance of SampleQueries. </summary>
        /// <param name="description"> The sample query description. </param>
        /// <param name="query"> the sample query. </param>
        internal SampleQueries(string description, string query)
        {
            Description = description;
            Query = query;
        }

        /// <summary> The sample query description. </summary>
        public string Description { get; set; }
        /// <summary> the sample query. </summary>
        public string Query { get; set; }
    }
}
