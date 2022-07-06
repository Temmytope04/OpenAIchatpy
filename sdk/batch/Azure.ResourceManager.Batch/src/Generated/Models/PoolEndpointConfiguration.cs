// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The endpoint configuration for a pool. </summary>
    internal partial class PoolEndpointConfiguration
    {
        /// <summary> Initializes a new instance of PoolEndpointConfiguration. </summary>
        /// <param name="inboundNatPools"> The maximum number of inbound NAT pools per Batch pool is 5. If the maximum number of inbound NAT pools is exceeded the request fails with HTTP status code 400. This cannot be specified if the IPAddressProvisioningType is NoPublicIPAddresses. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatPools"/> is null. </exception>
        public PoolEndpointConfiguration(IEnumerable<InboundNatPool> inboundNatPools)
        {
            if (inboundNatPools == null)
            {
                throw new ArgumentNullException(nameof(inboundNatPools));
            }

            InboundNatPools = inboundNatPools.ToList();
        }

        /// <summary> Initializes a new instance of PoolEndpointConfiguration. </summary>
        /// <param name="inboundNatPools"> The maximum number of inbound NAT pools per Batch pool is 5. If the maximum number of inbound NAT pools is exceeded the request fails with HTTP status code 400. This cannot be specified if the IPAddressProvisioningType is NoPublicIPAddresses. </param>
        internal PoolEndpointConfiguration(IList<InboundNatPool> inboundNatPools)
        {
            InboundNatPools = inboundNatPools;
        }

        /// <summary> The maximum number of inbound NAT pools per Batch pool is 5. If the maximum number of inbound NAT pools is exceeded the request fails with HTTP status code 400. This cannot be specified if the IPAddressProvisioningType is NoPublicIPAddresses. </summary>
        public IList<InboundNatPool> InboundNatPools { get; }
    }
}
