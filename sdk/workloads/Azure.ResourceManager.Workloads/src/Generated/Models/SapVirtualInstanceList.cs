// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Workloads;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Defines the collection of Virtual Instance for SAP solutions resources. </summary>
    internal partial class SapVirtualInstanceList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SapVirtualInstanceList"/>. </summary>
        internal SapVirtualInstanceList()
        {
            Value = new ChangeTrackingList<SapVirtualInstanceData>();
        }

        /// <summary> Initializes a new instance of <see cref="SapVirtualInstanceList"/>. </summary>
        /// <param name="value"> Gets the list of Virtual Instances for SAP solutions resources. </param>
        /// <param name="nextLink"> Gets the value of next link. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SapVirtualInstanceList(IReadOnlyList<SapVirtualInstanceData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Gets the list of Virtual Instances for SAP solutions resources. </summary>
        public IReadOnlyList<SapVirtualInstanceData> Value { get; }
        /// <summary> Gets the value of next link. </summary>
        public string NextLink { get; }
    }
}
