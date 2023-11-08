// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> User subscription quota response. </summary>
    public partial class IotHubUserSubscriptionQuota
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IotHubUserSubscriptionQuota"/>. </summary>
        internal IotHubUserSubscriptionQuota()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IotHubUserSubscriptionQuota"/>. </summary>
        /// <param name="iotHubTypeId"> IotHub type id. </param>
        /// <param name="userSubscriptionQuotaType"> Response type. </param>
        /// <param name="unit"> Unit of IotHub type. </param>
        /// <param name="currentValue"> Current number of IotHub type. </param>
        /// <param name="limit"> Numerical limit on IotHub type. </param>
        /// <param name="name"> IotHub type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotHubUserSubscriptionQuota(string iotHubTypeId, string userSubscriptionQuotaType, string unit, int? currentValue, int? limit, IotHubTypeName name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IotHubTypeId = iotHubTypeId;
            UserSubscriptionQuotaType = userSubscriptionQuotaType;
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> IotHub type id. </summary>
        public string IotHubTypeId { get; }
        /// <summary> Response type. </summary>
        public string UserSubscriptionQuotaType { get; }
        /// <summary> Unit of IotHub type. </summary>
        public string Unit { get; }
        /// <summary> Current number of IotHub type. </summary>
        public int? CurrentValue { get; }
        /// <summary> Numerical limit on IotHub type. </summary>
        public int? Limit { get; }
        /// <summary> IotHub type. </summary>
        public IotHubTypeName Name { get; }
    }
}
