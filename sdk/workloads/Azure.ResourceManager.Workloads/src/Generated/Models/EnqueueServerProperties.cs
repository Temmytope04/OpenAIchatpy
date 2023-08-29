// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Defines the SAP Enqueue Server properties. </summary>
    public partial class EnqueueServerProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EnqueueServerProperties"/>. </summary>
        public EnqueueServerProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EnqueueServerProperties"/>. </summary>
        /// <param name="hostname"> Enqueue Server SAP Hostname. </param>
        /// <param name="ipAddress"> Enqueue Server SAP IP Address. </param>
        /// <param name="port"> Enqueue Server Port. </param>
        /// <param name="health"> Defines the health of SAP Instances. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EnqueueServerProperties(string hostname, string ipAddress, long? port, SapHealthState? health, Dictionary<string, BinaryData> rawData)
        {
            Hostname = hostname;
            IPAddress = ipAddress;
            Port = port;
            Health = health;
            _rawData = rawData;
        }

        /// <summary> Enqueue Server SAP Hostname. </summary>
        public string Hostname { get; }
        /// <summary> Enqueue Server SAP IP Address. </summary>
        public string IPAddress { get; }
        /// <summary> Enqueue Server Port. </summary>
        public long? Port { get; }
        /// <summary> Defines the health of SAP Instances. </summary>
        public SapHealthState? Health { get; }
    }
}
