// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Hyper-V host details. </summary>
    public partial class HyperVHostDetails
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HyperVHostDetails"/>. </summary>
        internal HyperVHostDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HyperVHostDetails"/>. </summary>
        /// <param name="id"> The Hyper-V host Id. </param>
        /// <param name="name"> The Hyper-V host name. </param>
        /// <param name="marsAgentVersion"> The Mars agent version. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HyperVHostDetails(string id, string name, string marsAgentVersion, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Name = name;
            MarsAgentVersion = marsAgentVersion;
            _rawData = rawData;
        }

        /// <summary> The Hyper-V host Id. </summary>
        public string Id { get; }
        /// <summary> The Hyper-V host name. </summary>
        public string Name { get; }
        /// <summary> The Mars agent version. </summary>
        public string MarsAgentVersion { get; }
    }
}
