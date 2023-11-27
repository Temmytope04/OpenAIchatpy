// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.IotHub;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The JSON-serialized array of IotHubDescription objects with a next link. </summary>
    internal partial class IotHubDescriptionListResult
    {
        /// <summary> Initializes a new instance of <see cref="IotHubDescriptionListResult"/>. </summary>
        internal IotHubDescriptionListResult()
        {
            Value = new ChangeTrackingList<IotHubDescriptionData>();
        }

        /// <summary> Initializes a new instance of <see cref="IotHubDescriptionListResult"/>. </summary>
        /// <param name="value"> The array of IotHubDescription objects. </param>
        /// <param name="nextLink"> The next link. </param>
        internal IotHubDescriptionListResult(IReadOnlyList<IotHubDescriptionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The array of IotHubDescription objects. </summary>
        public IReadOnlyList<IotHubDescriptionData> Value { get; }
        /// <summary> The next link. </summary>
        public string NextLink { get; }
    }
}
