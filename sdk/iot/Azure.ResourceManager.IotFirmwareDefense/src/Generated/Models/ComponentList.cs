// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> List result for components. </summary>
    internal partial class ComponentList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ComponentList"/>. </summary>
        internal ComponentList()
        {
            Value = new ChangeTrackingList<SbomComponent>();
        }

        /// <summary> Initializes a new instance of <see cref="ComponentList"/>. </summary>
        /// <param name="value"> The list of components. </param>
        /// <param name="nextLink"> The uri to fetch the next page of asset. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComponentList(IReadOnlyList<SbomComponent> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of components. </summary>
        public IReadOnlyList<SbomComponent> Value { get; }
        /// <summary> The uri to fetch the next page of asset. </summary>
        public string NextLink { get; }
    }
}
