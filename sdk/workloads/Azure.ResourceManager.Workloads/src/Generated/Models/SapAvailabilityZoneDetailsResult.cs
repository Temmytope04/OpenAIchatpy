// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The list of supported availability zone pairs which are part of SAP HA deployment. </summary>
    public partial class SapAvailabilityZoneDetailsResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SapAvailabilityZoneDetailsResult"/>. </summary>
        internal SapAvailabilityZoneDetailsResult()
        {
            AvailabilityZonePairs = new ChangeTrackingList<SapAvailabilityZonePair>();
        }

        /// <summary> Initializes a new instance of <see cref="SapAvailabilityZoneDetailsResult"/>. </summary>
        /// <param name="availabilityZonePairs"> Gets the list of availability zone pairs. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SapAvailabilityZoneDetailsResult(IReadOnlyList<SapAvailabilityZonePair> availabilityZonePairs, Dictionary<string, BinaryData> rawData)
        {
            AvailabilityZonePairs = availabilityZonePairs;
            _rawData = rawData;
        }

        /// <summary> Gets the list of availability zone pairs. </summary>
        public IReadOnlyList<SapAvailabilityZonePair> AvailabilityZonePairs { get; }
    }
}
