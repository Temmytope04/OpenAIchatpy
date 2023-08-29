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
    /// <summary> Defines the collection of SAP Application Server Instance resources. </summary>
    internal partial class SapApplicationServerInstanceList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SapApplicationServerInstanceList"/>. </summary>
        internal SapApplicationServerInstanceList()
        {
            Value = new ChangeTrackingList<SapApplicationServerInstanceData>();
        }

        /// <summary> Initializes a new instance of <see cref="SapApplicationServerInstanceList"/>. </summary>
        /// <param name="value"> Gets the list of SAP Application Server instance resources. </param>
        /// <param name="nextLink"> Gets the value of next link. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SapApplicationServerInstanceList(IReadOnlyList<SapApplicationServerInstanceData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Gets the list of SAP Application Server instance resources. </summary>
        public IReadOnlyList<SapApplicationServerInstanceData> Value { get; }
        /// <summary> Gets the value of next link. </summary>
        public string NextLink { get; }
    }
}
