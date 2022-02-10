// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> Describes scaling information of a SKU. </summary>
    public partial class ResourceSkuRestrictions
    {
        /// <summary> Initializes a new instance of ResourceSkuRestrictions. </summary>
        internal ResourceSkuRestrictions()
        {
            Values = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ResourceSkuRestrictions. </summary>
        /// <param name="type"> The type of restrictions. </param>
        /// <param name="values"> The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU is restricted. </param>
        /// <param name="restrictionInfo"> The information about the restriction where the SKU cannot be used. </param>
        /// <param name="reasonCode"> The reason for restriction. </param>
        internal ResourceSkuRestrictions(ResourceSkuRestrictionsType? type, IReadOnlyList<string> values, ResourceSkuRestrictionInfo restrictionInfo, ResourceSkuRestrictionsReasonCode? reasonCode)
        {
            Type = type;
            Values = values;
            RestrictionInfo = restrictionInfo;
            ReasonCode = reasonCode;
        }

        /// <summary> The type of restrictions. </summary>
        public ResourceSkuRestrictionsType? Type { get; }
        /// <summary> The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU is restricted. </summary>
        public IReadOnlyList<string> Values { get; }
        /// <summary> The information about the restriction where the SKU cannot be used. </summary>
        public ResourceSkuRestrictionInfo RestrictionInfo { get; }
        /// <summary> The reason for restriction. </summary>
        public ResourceSkuRestrictionsReasonCode? ReasonCode { get; }
    }
}
