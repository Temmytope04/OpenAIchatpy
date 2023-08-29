// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> An error response from the Virtual Instance for SAP Workload service. </summary>
    internal partial class SapVirtualInstanceError
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SapVirtualInstanceError"/>. </summary>
        internal SapVirtualInstanceError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SapVirtualInstanceError"/>. </summary>
        /// <param name="properties"> The Virtual Instance for SAP error body. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SapVirtualInstanceError(SapVirtualInstanceErrorDetail properties, Dictionary<string, BinaryData> rawData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> The Virtual Instance for SAP error body. </summary>
        public SapVirtualInstanceErrorDetail Properties { get; }
    }
}
