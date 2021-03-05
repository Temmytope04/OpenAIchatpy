// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Tenant Ids information. </summary>
    internal partial class TenantListResult
    {
        /// <summary> Initializes a new instance of TenantListResult. </summary>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        internal TenantListResult(string nextLink)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            Value = new ChangeTrackingList<TenantIdDescription>();
            NextLink = nextLink;
        }

        /// <summary> Initializes a new instance of TenantListResult. </summary>
        /// <param name="value"> An array of tenants. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal TenantListResult(IReadOnlyList<TenantIdDescription> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of tenants. </summary>
        public IReadOnlyList<TenantIdDescription> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
