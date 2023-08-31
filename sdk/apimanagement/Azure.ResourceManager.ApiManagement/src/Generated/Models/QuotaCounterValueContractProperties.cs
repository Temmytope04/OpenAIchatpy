// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Quota counter value details. </summary>
    public partial class QuotaCounterValueContractProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="QuotaCounterValueContractProperties"/>. </summary>
        internal QuotaCounterValueContractProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="QuotaCounterValueContractProperties"/>. </summary>
        /// <param name="callsCount"> Number of times Counter was called. </param>
        /// <param name="kbTransferred"> Data Transferred in KiloBytes. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal QuotaCounterValueContractProperties(int? callsCount, double? kbTransferred, Dictionary<string, BinaryData> rawData)
        {
            CallsCount = callsCount;
            KbTransferred = kbTransferred;
            _rawData = rawData;
        }

        /// <summary> Number of times Counter was called. </summary>
        public int? CallsCount { get; }
        /// <summary> Data Transferred in KiloBytes. </summary>
        public double? KbTransferred { get; }
    }
}
