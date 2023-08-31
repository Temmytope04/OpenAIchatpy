// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Read-write endpoint of the failover group instance. </summary>
    public partial class FailoverGroupReadWriteEndpoint
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FailoverGroupReadWriteEndpoint"/>. </summary>
        /// <param name="failoverPolicy"> Failover policy of the read-write endpoint for the failover group. If failoverPolicy is Automatic then failoverWithDataLossGracePeriodMinutes is required. </param>
        public FailoverGroupReadWriteEndpoint(ReadWriteEndpointFailoverPolicy failoverPolicy)
        {
            FailoverPolicy = failoverPolicy;
        }

        /// <summary> Initializes a new instance of <see cref="FailoverGroupReadWriteEndpoint"/>. </summary>
        /// <param name="failoverPolicy"> Failover policy of the read-write endpoint for the failover group. If failoverPolicy is Automatic then failoverWithDataLossGracePeriodMinutes is required. </param>
        /// <param name="failoverWithDataLossGracePeriodMinutes"> Grace period before failover with data loss is attempted for the read-write endpoint. If failoverPolicy is Automatic then failoverWithDataLossGracePeriodMinutes is required. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FailoverGroupReadWriteEndpoint(ReadWriteEndpointFailoverPolicy failoverPolicy, int? failoverWithDataLossGracePeriodMinutes, Dictionary<string, BinaryData> rawData)
        {
            FailoverPolicy = failoverPolicy;
            FailoverWithDataLossGracePeriodMinutes = failoverWithDataLossGracePeriodMinutes;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="FailoverGroupReadWriteEndpoint"/> for deserialization. </summary>
        internal FailoverGroupReadWriteEndpoint()
        {
        }

        /// <summary> Failover policy of the read-write endpoint for the failover group. If failoverPolicy is Automatic then failoverWithDataLossGracePeriodMinutes is required. </summary>
        public ReadWriteEndpointFailoverPolicy FailoverPolicy { get; set; }
        /// <summary> Grace period before failover with data loss is attempted for the read-write endpoint. If failoverPolicy is Automatic then failoverWithDataLossGracePeriodMinutes is required. </summary>
        public int? FailoverWithDataLossGracePeriodMinutes { get; set; }
    }
}
