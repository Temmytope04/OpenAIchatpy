// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> Result of the List private link resources operation. </summary>
    internal partial class PrivateLinkResourcesListResult
    {
        /// <summary> Initializes a new instance of <see cref="PrivateLinkResourcesListResult"/>. </summary>
        internal PrivateLinkResourcesListResult()
        {
            Value = new ChangeTrackingList<ServiceBusPrivateLinkResource>();
        }

        /// <summary> Initializes a new instance of <see cref="PrivateLinkResourcesListResult"/>. </summary>
        /// <param name="value"> A collection of private link resources. </param>
        /// <param name="nextLink"> A link for the next page of private link resources. </param>
        internal PrivateLinkResourcesListResult(IReadOnlyList<ServiceBusPrivateLinkResource> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A collection of private link resources. </summary>
        public IReadOnlyList<ServiceBusPrivateLinkResource> Value { get; }
        /// <summary> A link for the next page of private link resources. </summary>
        public string NextLink { get; }
    }
}
