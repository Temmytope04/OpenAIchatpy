// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Maps.Route
{
    /// <summary> Client options for RouteClient. </summary>
    public partial class MapsRouteClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V1_0;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "1.0". </summary>
            V1_0 = 1,
        }

        internal string Version { get; }

        internal Uri Endpoint { get; }

        /// <summary> Initializes new instance of MapsRouteClientOptions. </summary>
        /// <param name="version"> Route service version. </param>
        /// <param name="endpoint"> server parameter. </param>
        public MapsRouteClientOptions(ServiceVersion version = LatestVersion, Uri endpoint = null)
        {
            Version = version switch
            {
                ServiceVersion.V1_0 => "1.0",
                _ => throw new NotSupportedException()
            };

            Endpoint = endpoint;
        }
    }
}
