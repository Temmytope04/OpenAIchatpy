// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The native cloud connection configuration. </summary>
    public partial class DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection"/>. </summary>
        public DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection"/>. </summary>
        /// <param name="serviceAccountEmailAddress"> The data collection service account email address in GCP for this offering. </param>
        /// <param name="workloadIdentityProviderId"> The data collection GCP workload identity provider id for this offering. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection(string serviceAccountEmailAddress, string workloadIdentityProviderId, Dictionary<string, BinaryData> rawData)
        {
            ServiceAccountEmailAddress = serviceAccountEmailAddress;
            WorkloadIdentityProviderId = workloadIdentityProviderId;
            _rawData = rawData;
        }

        /// <summary> The data collection service account email address in GCP for this offering. </summary>
        public string ServiceAccountEmailAddress { get; set; }
        /// <summary> The data collection GCP workload identity provider id for this offering. </summary>
        public string WorkloadIdentityProviderId { get; set; }
    }
}
