// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Kusto;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The list Kusto sandbox custom images operation response. </summary>
    internal partial class SandboxCustomImagesListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SandboxCustomImagesListResult"/>. </summary>
        internal SandboxCustomImagesListResult()
        {
            Value = new ChangeTrackingList<SandboxCustomImageData>();
        }

        /// <summary> Initializes a new instance of <see cref="SandboxCustomImagesListResult"/>. </summary>
        /// <param name="nextLink"> Link to the next page of results. </param>
        /// <param name="value"> The list of Kusto sandbox custom images. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SandboxCustomImagesListResult(string nextLink, IReadOnlyList<SandboxCustomImageData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Link to the next page of results. </summary>
        public string NextLink { get; }
        /// <summary> The list of Kusto sandbox custom images. </summary>
        public IReadOnlyList<SandboxCustomImageData> Value { get; }
    }
}
