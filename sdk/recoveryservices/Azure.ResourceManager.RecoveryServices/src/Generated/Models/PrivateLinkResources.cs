// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServices;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Class which represent the stamps associated with the vault. </summary>
    internal partial class PrivateLinkResources
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PrivateLinkResources"/>. </summary>
        internal PrivateLinkResources()
        {
            Value = new ChangeTrackingList<RecoveryServicesPrivateLinkResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="PrivateLinkResources"/>. </summary>
        /// <param name="value"> A collection of private link resources. </param>
        /// <param name="nextLink"> Link to the next chunk of the response. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateLinkResources(IReadOnlyList<RecoveryServicesPrivateLinkResourceData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> A collection of private link resources. </summary>
        public IReadOnlyList<RecoveryServicesPrivateLinkResourceData> Value { get; }
        /// <summary> Link to the next chunk of the response. </summary>
        public string NextLink { get; }
    }
}
