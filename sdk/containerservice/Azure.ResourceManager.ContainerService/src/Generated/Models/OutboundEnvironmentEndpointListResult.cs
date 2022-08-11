// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Collection of OutboundEnvironmentEndpoint. </summary>
    internal partial class OutboundEnvironmentEndpointListResult
    {
        /// <summary> Initializes a new instance of OutboundEnvironmentEndpointListResult. </summary>
        /// <param name="value"> Collection of resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal OutboundEnvironmentEndpointListResult(IEnumerable<ContainerServiceOutboundEnvironmentEndpoint> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of OutboundEnvironmentEndpointListResult. </summary>
        /// <param name="value"> Collection of resources. </param>
        /// <param name="nextLink"> Link to next page of resources. </param>
        internal OutboundEnvironmentEndpointListResult(IReadOnlyList<ContainerServiceOutboundEnvironmentEndpoint> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of resources. </summary>
        public IReadOnlyList<ContainerServiceOutboundEnvironmentEndpoint> Value { get; }
        /// <summary> Link to next page of resources. </summary>
        public string NextLink { get; }
    }
}
