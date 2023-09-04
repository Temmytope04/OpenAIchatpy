// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> SSH connectivity endpoint details. </summary>
    public partial class SshConnectivityEndpoint
    {
        /// <summary> Initializes a new instance of SshConnectivityEndpoint. </summary>
        /// <param name="endpoint"> SSH connectivity endpoint. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        internal SshConnectivityEndpoint(string endpoint)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));

            Endpoint = endpoint;
        }

        /// <summary> SSH connectivity endpoint. </summary>
        public string Endpoint { get; }
    }
}
