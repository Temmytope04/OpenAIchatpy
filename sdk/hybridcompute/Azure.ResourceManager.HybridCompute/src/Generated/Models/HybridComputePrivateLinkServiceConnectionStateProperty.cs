// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> State of the private endpoint connection. </summary>
    public partial class HybridComputePrivateLinkServiceConnectionStateProperty
    {
        /// <summary> Initializes a new instance of <see cref="HybridComputePrivateLinkServiceConnectionStateProperty"/>. </summary>
        /// <param name="status"> The private link service connection status. </param>
        /// <param name="description"> The private link service connection description. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="status"/> or <paramref name="description"/> is null. </exception>
        public HybridComputePrivateLinkServiceConnectionStateProperty(string status, string description)
        {
            Argument.AssertNotNull(status, nameof(status));
            Argument.AssertNotNull(description, nameof(description));

            Status = status;
            Description = description;
        }

        /// <summary> Initializes a new instance of <see cref="HybridComputePrivateLinkServiceConnectionStateProperty"/>. </summary>
        /// <param name="status"> The private link service connection status. </param>
        /// <param name="description"> The private link service connection description. </param>
        /// <param name="actionsRequired"> The actions required for private link service connection. </param>
        internal HybridComputePrivateLinkServiceConnectionStateProperty(string status, string description, string actionsRequired)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
        }

        /// <summary> The private link service connection status. </summary>
        public string Status { get; set; }
        /// <summary> The private link service connection description. </summary>
        public string Description { get; set; }
        /// <summary> The actions required for private link service connection. </summary>
        public string ActionsRequired { get; }
    }
}
