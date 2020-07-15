// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Geographic and time constraints for Azure reachability report. </summary>
    public partial class AzureReachabilityReportParameters
    {
        /// <summary> Initializes a new instance of AzureReachabilityReportParameters. </summary>
        /// <param name="providerLocation"> Parameters that define a geographic location. </param>
        /// <param name="startTime"> The start time for the Azure reachability report. </param>
        /// <param name="endTime"> The end time for the Azure reachability report. </param>
        public AzureReachabilityReportParameters(AzureReachabilityReportLocation providerLocation, DateTimeOffset startTime, DateTimeOffset endTime)
        {
            if (providerLocation == null)
            {
                throw new ArgumentNullException(nameof(providerLocation));
            }

            ProviderLocation = providerLocation;
            Providers = new ChangeTrackingList<string>();
            AzureLocations = new ChangeTrackingList<string>();
            StartTime = startTime;
            EndTime = endTime;
        }

        /// <summary> Initializes a new instance of AzureReachabilityReportParameters. </summary>
        /// <param name="providerLocation"> Parameters that define a geographic location. </param>
        /// <param name="providers"> List of Internet service providers. </param>
        /// <param name="azureLocations"> Optional Azure regions to scope the query to. </param>
        /// <param name="startTime"> The start time for the Azure reachability report. </param>
        /// <param name="endTime"> The end time for the Azure reachability report. </param>
        internal AzureReachabilityReportParameters(AzureReachabilityReportLocation providerLocation, IList<string> providers, IList<string> azureLocations, DateTimeOffset startTime, DateTimeOffset endTime)
        {
            ProviderLocation = providerLocation;
            Providers = providers;
            AzureLocations = azureLocations;
            StartTime = startTime;
            EndTime = endTime;
        }

        /// <summary> Parameters that define a geographic location. </summary>
        public AzureReachabilityReportLocation ProviderLocation { get; }
        /// <summary> List of Internet service providers. </summary>
        public IList<string> Providers { get; }
        /// <summary> Optional Azure regions to scope the query to. </summary>
        public IList<string> AzureLocations { get; }
        /// <summary> The start time for the Azure reachability report. </summary>
        public DateTimeOffset StartTime { get; }
        /// <summary> The end time for the Azure reachability report. </summary>
        public DateTimeOffset EndTime { get; }
    }
}
