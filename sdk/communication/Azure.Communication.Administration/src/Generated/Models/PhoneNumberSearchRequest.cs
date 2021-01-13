// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.Administration.Models
{
    /// <summary> The desired properties of a phone number for search. </summary>
    internal partial class PhoneNumberSearchRequest
    {
        /// <summary> Initializes a new instance of PhoneNumberSearchRequest. </summary>
        /// <param name="phoneNumberType"> The phone number type. </param>
        /// <param name="assignmentType"> The phone number&apos;s assignment type. </param>
        /// <param name="capabilities"> The phone number&apos;s capabilities. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilities"/> is null. </exception>
        public PhoneNumberSearchRequest(PhoneNumberType phoneNumberType, PhoneNumberAssignmentType assignmentType, PhoneNumberCapabilitiesRequest capabilities)
        {
            if (capabilities == null)
            {
                throw new ArgumentNullException(nameof(capabilities));
            }

            PhoneNumberType = phoneNumberType;
            AssignmentType = assignmentType;
            Capabilities = capabilities;
        }

        /// <summary> The phone number type. </summary>
        public PhoneNumberType PhoneNumberType { get; }
        /// <summary> The phone number&apos;s assignment type. </summary>
        public PhoneNumberAssignmentType AssignmentType { get; }
        /// <summary> The phone number&apos;s capabilities. </summary>
        public PhoneNumberCapabilitiesRequest Capabilities { get; }
        /// <summary> The desired area code. </summary>
        public string AreaCode { get; set; }
        /// <summary> The desired quantity of phone numbers. </summary>
        public int? Quantity { get; set; }
    }
}
