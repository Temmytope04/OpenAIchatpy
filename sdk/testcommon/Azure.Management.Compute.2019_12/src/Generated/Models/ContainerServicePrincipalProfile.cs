// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.Compute.Models
{
    /// <summary> Information about a service principal identity for the cluster to use for manipulating Azure APIs. </summary>
    public partial class ContainerServicePrincipalProfile
    {
        /// <summary> Initializes a new instance of ContainerServicePrincipalProfile. </summary>
        /// <param name="clientId"> The ID for the service principal. </param>
        /// <param name="secret"> The secret password associated with the service principal. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientId"/> or <paramref name="secret"/> is null. </exception>
        public ContainerServicePrincipalProfile(string clientId, string secret)
        {
            if (clientId == null)
            {
                throw new ArgumentNullException(nameof(clientId));
            }
            if (secret == null)
            {
                throw new ArgumentNullException(nameof(secret));
            }

            ClientId = clientId;
            Secret = secret;
        }

        /// <summary> The ID for the service principal. </summary>
        public string ClientId { get; set; }
        /// <summary> The secret password associated with the service principal. </summary>
        public string Secret { get; set; }
    }
}
