// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.Administration.Models
{
    /// <summary> Represents a phone plan. </summary>
    public partial class PhonePlan
    {
        /// <summary> Initializes a new instance of PhonePlan. </summary>
        /// <param name="phonePlanId"> The phone plan id. </param>
        /// <param name="localizedName"> The name of the phone plan. </param>
        /// <param name="locationType"> The location type of the phone plan. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phonePlanId"/> or <paramref name="localizedName"/> is null. </exception>
        internal PhonePlan(string phonePlanId, string localizedName, LocationType locationType)
        {
            if (phonePlanId == null)
            {
                throw new ArgumentNullException(nameof(phonePlanId));
            }
            if (localizedName == null)
            {
                throw new ArgumentNullException(nameof(localizedName));
            }

            PhonePlanId = phonePlanId;
            LocalizedName = localizedName;
            LocationType = locationType;
            AreaCodes = new ChangeTrackingList<string>();
            Capabilities = new ChangeTrackingList<PhoneNumberCapability>();
        }

        /// <summary> Initializes a new instance of PhonePlan. </summary>
        /// <param name="phonePlanId"> The phone plan id. </param>
        /// <param name="localizedName"> The name of the phone plan. </param>
        /// <param name="locationType"> The location type of the phone plan. </param>
        /// <param name="areaCodes"> The list of available area codes in the phone plan. </param>
        /// <param name="capabilities"> Capabilities of the phone plan. </param>
        /// <param name="maximumSearchSize"> The maximum number of phone numbers one can acquire in a search in this phone plan. </param>
        internal PhonePlan(string phonePlanId, string localizedName, LocationType locationType, IReadOnlyList<string> areaCodes, IReadOnlyList<PhoneNumberCapability> capabilities, int? maximumSearchSize)
        {
            PhonePlanId = phonePlanId;
            LocalizedName = localizedName;
            LocationType = locationType;
            AreaCodes = areaCodes;
            Capabilities = capabilities;
            MaximumSearchSize = maximumSearchSize;
        }

        /// <summary> The phone plan id. </summary>
        public string PhonePlanId { get; }
        /// <summary> The name of the phone plan. </summary>
        public string LocalizedName { get; }
        /// <summary> The location type of the phone plan. </summary>
        public LocationType LocationType { get; }
        /// <summary> The list of available area codes in the phone plan. </summary>
        public IReadOnlyList<string> AreaCodes { get; }
        /// <summary> Capabilities of the phone plan. </summary>
        public IReadOnlyList<PhoneNumberCapability> Capabilities { get; }
        /// <summary> The maximum number of phone numbers one can acquire in a search in this phone plan. </summary>
        public int? MaximumSearchSize { get; }
    }
}
