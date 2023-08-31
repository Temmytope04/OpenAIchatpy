// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Attestation;

namespace Azure.ResourceManager.Attestation.Models
{
    /// <summary> List of private endpoint connection associated with the specified storage account. </summary>
    internal partial class AttestationPrivateEndpointConnectionListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AttestationPrivateEndpointConnectionListResult"/>. </summary>
        internal AttestationPrivateEndpointConnectionListResult()
        {
            Value = new ChangeTrackingList<AttestationPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="AttestationPrivateEndpointConnectionListResult"/>. </summary>
        /// <param name="value"> Array of private endpoint connections. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AttestationPrivateEndpointConnectionListResult(IReadOnlyList<AttestationPrivateEndpointConnectionData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Array of private endpoint connections. </summary>
        public IReadOnlyList<AttestationPrivateEndpointConnectionData> Value { get; }
    }
}
