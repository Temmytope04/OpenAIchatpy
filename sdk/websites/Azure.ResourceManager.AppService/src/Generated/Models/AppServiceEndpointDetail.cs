// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Current TCP connectivity information from the App Service Environment to a single endpoint. </summary>
    public partial class AppServiceEndpointDetail
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceEndpointDetail"/>. </summary>
        internal AppServiceEndpointDetail()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceEndpointDetail"/>. </summary>
        /// <param name="ipAddress"> An IP Address that Domain Name currently resolves to. </param>
        /// <param name="port"> The port an endpoint is connected to. </param>
        /// <param name="latency"> The time in milliseconds it takes for a TCP connection to be created from the App Service Environment to this IpAddress at this Port. </param>
        /// <param name="isAccessible"> Whether it is possible to create a TCP connection from the App Service Environment to this IpAddress at this Port. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceEndpointDetail(IPAddress ipAddress, int? port, double? latency, bool? isAccessible, Dictionary<string, BinaryData> rawData)
        {
            IPAddress = ipAddress;
            Port = port;
            Latency = latency;
            IsAccessible = isAccessible;
            _rawData = rawData;
        }

        /// <summary> An IP Address that Domain Name currently resolves to. </summary>
        public IPAddress IPAddress { get; }
        /// <summary> The port an endpoint is connected to. </summary>
        public int? Port { get; }
        /// <summary> The time in milliseconds it takes for a TCP connection to be created from the App Service Environment to this IpAddress at this Port. </summary>
        public double? Latency { get; }
        /// <summary> Whether it is possible to create a TCP connection from the App Service Environment to this IpAddress at this Port. </summary>
        public bool? IsAccessible { get; }
    }
}
