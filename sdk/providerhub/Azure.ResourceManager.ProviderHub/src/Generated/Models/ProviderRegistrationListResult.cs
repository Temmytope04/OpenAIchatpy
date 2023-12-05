// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ProviderHub;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ProviderRegistrationListResult. </summary>
    internal partial class ProviderRegistrationListResult
    {
        /// <summary> Initializes a new instance of <see cref="ProviderRegistrationListResult"/>. </summary>
        internal ProviderRegistrationListResult()
        {
            Value = new ChangeTrackingList<ProviderRegistrationData>();
        }

        /// <summary> Initializes a new instance of <see cref="ProviderRegistrationListResult"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> The URL to get to the next set of results, if there are any. </param>
        internal ProviderRegistrationListResult(IReadOnlyList<ProviderRegistrationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<ProviderRegistrationData> Value { get; }
        /// <summary> The URL to get to the next set of results, if there are any. </summary>
        public string NextLink { get; }
    }
}
