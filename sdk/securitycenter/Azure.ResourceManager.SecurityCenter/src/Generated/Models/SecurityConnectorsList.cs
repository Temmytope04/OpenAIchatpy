// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> List of security connectors response. </summary>
    internal partial class SecurityConnectorsList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SecurityConnectorsList"/>. </summary>
        /// <param name="value"> The list of security connectors under the given scope. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SecurityConnectorsList(IEnumerable<SecurityConnectorData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityConnectorsList"/>. </summary>
        /// <param name="value"> The list of security connectors under the given scope. </param>
        /// <param name="nextLink"> The URI to fetch the next page. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityConnectorsList(IReadOnlyList<SecurityConnectorData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityConnectorsList"/> for deserialization. </summary>
        internal SecurityConnectorsList()
        {
        }

        /// <summary> The list of security connectors under the given scope. </summary>
        public IReadOnlyList<SecurityConnectorData> Value { get; }
        /// <summary> The URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}
