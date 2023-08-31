// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Represents the software inventory of the virtual machine. </summary>
    internal partial class SoftwaresList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SoftwaresList"/>. </summary>
        internal SoftwaresList()
        {
            Value = new ChangeTrackingList<SoftwareInventoryData>();
        }

        /// <summary> Initializes a new instance of <see cref="SoftwaresList"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> The URI to fetch the next page. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SoftwaresList(IReadOnlyList<SoftwareInventoryData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<SoftwareInventoryData> Value { get; }
        /// <summary> The URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}
