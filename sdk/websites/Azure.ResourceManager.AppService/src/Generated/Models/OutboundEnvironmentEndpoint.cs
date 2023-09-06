// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Endpoints accessed for a common purpose that the App Service Environment requires outbound network access to. </summary>
    public partial class OutboundEnvironmentEndpoint
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="OutboundEnvironmentEndpoint"/>. </summary>
        internal OutboundEnvironmentEndpoint()
        {
            Endpoints = new ChangeTrackingList<AppServiceEndpointDependency>();
        }

        /// <summary> Initializes a new instance of <see cref="OutboundEnvironmentEndpoint"/>. </summary>
        /// <param name="category"> The type of service accessed by the App Service Environment, e.g., Azure Storage, Azure SQL Database, and Azure Active Directory. </param>
        /// <param name="endpoints"> The endpoints that the App Service Environment reaches the service at. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal OutboundEnvironmentEndpoint(string category, IReadOnlyList<AppServiceEndpointDependency> endpoints, Dictionary<string, BinaryData> rawData)
        {
            Category = category;
            Endpoints = endpoints;
            _rawData = rawData;
        }

        /// <summary> The type of service accessed by the App Service Environment, e.g., Azure Storage, Azure SQL Database, and Azure Active Directory. </summary>
        public string Category { get; }
        /// <summary> The endpoints that the App Service Environment reaches the service at. </summary>
        public IReadOnlyList<AppServiceEndpointDependency> Endpoints { get; }
    }
}
