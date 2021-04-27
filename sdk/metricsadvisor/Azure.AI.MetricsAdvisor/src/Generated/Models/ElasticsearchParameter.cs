// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The ElasticsearchParameter. </summary>
    internal partial class ElasticsearchParameter
    {
        /// <summary> Initializes a new instance of ElasticsearchParameter. </summary>
        /// <param name="host"> Host. </param>
        /// <param name="port"> Port. </param>
        /// <param name="authHeader"> Authorization header. </param>
        /// <param name="query"> Query. </param>
        public ElasticsearchParameter(string host, string port, string authHeader, string query)
        {
            Host = host;
            Port = port;
            AuthHeader = authHeader;
            Query = query;
        }

        /// <summary> Host. </summary>
        public string Host { get; set; }
        /// <summary> Port. </summary>
        public string Port { get; set; }
        /// <summary> Authorization header. </summary>
        public string AuthHeader { get; set; }
        /// <summary> Query. </summary>
        public string Query { get; set; }
    }
}
