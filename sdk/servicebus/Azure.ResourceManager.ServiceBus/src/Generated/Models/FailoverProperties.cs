// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> Safe failover is to indicate the service should wait for pending replication to finish before switching to the secondary. </summary>
    public partial class FailoverProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FailoverProperties"/>. </summary>
        public FailoverProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FailoverProperties"/>. </summary>
        /// <param name="isSafeFailover"> Safe failover is to indicate the service should wait for pending replication to finish before switching to the secondary. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FailoverProperties(bool? isSafeFailover, Dictionary<string, BinaryData> rawData)
        {
            IsSafeFailover = isSafeFailover;
            _rawData = rawData;
        }

        /// <summary> Safe failover is to indicate the service should wait for pending replication to finish before switching to the secondary. </summary>
        public bool? IsSafeFailover { get; set; }
    }
}
