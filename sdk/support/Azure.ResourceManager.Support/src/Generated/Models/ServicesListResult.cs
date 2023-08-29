// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Support;

namespace Azure.ResourceManager.Support.Models
{
    /// <summary> Collection of Service resources. </summary>
    internal partial class ServicesListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ServicesListResult"/>. </summary>
        internal ServicesListResult()
        {
            Value = new ChangeTrackingList<SupportAzureServiceData>();
        }

        /// <summary> Initializes a new instance of <see cref="ServicesListResult"/>. </summary>
        /// <param name="value"> List of Service resources. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ServicesListResult(IReadOnlyList<SupportAzureServiceData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> List of Service resources. </summary>
        public IReadOnlyList<SupportAzureServiceData> Value { get; }
    }
}
