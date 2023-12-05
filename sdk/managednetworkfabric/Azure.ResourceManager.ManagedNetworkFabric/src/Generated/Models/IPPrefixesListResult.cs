// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> List of IP Prefixes. </summary>
    internal partial class IPPrefixesListResult
    {
        /// <summary> Initializes a new instance of <see cref="IPPrefixesListResult"/>. </summary>
        internal IPPrefixesListResult()
        {
            Value = new ChangeTrackingList<NetworkFabricIPPrefixData>();
        }

        /// <summary> Initializes a new instance of <see cref="IPPrefixesListResult"/>. </summary>
        /// <param name="value"> List of IP Prefix resources. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        internal IPPrefixesListResult(IReadOnlyList<NetworkFabricIPPrefixData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of IP Prefix resources. </summary>
        public IReadOnlyList<NetworkFabricIPPrefixData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}
