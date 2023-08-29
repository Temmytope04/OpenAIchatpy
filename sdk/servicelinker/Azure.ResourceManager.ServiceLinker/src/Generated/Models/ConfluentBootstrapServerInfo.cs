// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The service properties when target service type is ConfluentBootstrapServer. </summary>
    public partial class ConfluentBootstrapServerInfo : TargetServiceBaseInfo
    {
        /// <summary> Initializes a new instance of <see cref="ConfluentBootstrapServerInfo"/>. </summary>
        public ConfluentBootstrapServerInfo()
        {
            TargetServiceType = TargetServiceType.ConfluentBootstrapServer;
        }

        /// <summary> Initializes a new instance of <see cref="ConfluentBootstrapServerInfo"/>. </summary>
        /// <param name="targetServiceType"> The target service type. </param>
        /// <param name="endpoint"> The endpoint of service. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConfluentBootstrapServerInfo(TargetServiceType targetServiceType, string endpoint, Dictionary<string, BinaryData> rawData) : base(targetServiceType, rawData)
        {
            Endpoint = endpoint;
            TargetServiceType = targetServiceType;
        }

        /// <summary> The endpoint of service. </summary>
        public string Endpoint { get; set; }
    }
}
