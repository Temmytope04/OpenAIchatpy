// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The UnknownAwsOrganizationalData. </summary>
    internal partial class UnknownAwsOrganizationalData : AwsOrganizationalInfo
    {
        /// <summary> Initializes a new instance of <see cref="UnknownAwsOrganizationalData"/>. </summary>
        /// <param name="organizationMembershipType"> The multi cloud account's membership type in the organization. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownAwsOrganizationalData(OrganizationMembershipType organizationMembershipType, Dictionary<string, BinaryData> rawData) : base(organizationMembershipType, rawData)
        {
            OrganizationMembershipType = organizationMembershipType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownAwsOrganizationalData"/> for deserialization. </summary>
        internal UnknownAwsOrganizationalData()
        {
        }
    }
}
