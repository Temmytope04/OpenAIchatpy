// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridCompute;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> The List Extension Metadata response. </summary>
    internal partial class ExtensionValueListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExtensionValueListResult"/>. </summary>
        internal ExtensionValueListResult()
        {
            Value = new ChangeTrackingList<ExtensionValueData>();
        }

        /// <summary> Initializes a new instance of <see cref="ExtensionValueListResult"/>. </summary>
        /// <param name="value"> The list of extension metadata. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExtensionValueListResult(IReadOnlyList<ExtensionValueData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of extension metadata. </summary>
        public IReadOnlyList<ExtensionValueData> Value { get; }
    }
}
