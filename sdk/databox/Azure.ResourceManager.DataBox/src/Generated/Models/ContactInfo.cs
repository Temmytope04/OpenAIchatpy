// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Contact Info. </summary>
    public partial class ContactInfo
    {
        /// <summary> Initializes a new instance of ContactInfo. </summary>
        /// <param name="contactName"> Contact name of the person. </param>
        /// <param name="phone"> Phone number of the contact person. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contactName"/> or <paramref name="phone"/> is null. </exception>
        public ContactInfo(string contactName, string phone)
        {
            Argument.AssertNotNull(contactName, nameof(contactName));
            Argument.AssertNotNull(phone, nameof(phone));

            ContactName = contactName;
            Phone = phone;
        }

        /// <summary> Initializes a new instance of ContactInfo. </summary>
        /// <param name="contactName"> Contact name of the person. </param>
        /// <param name="phone"> Phone number of the contact person. </param>
        /// <param name="phoneExtension"> Phone extension number of the contact person. </param>
        /// <param name="mobile"> Mobile number of the contact person. </param>
        internal ContactInfo(string contactName, string phone, string phoneExtension, string mobile)
        {
            ContactName = contactName;
            Phone = phone;
            PhoneExtension = phoneExtension;
            Mobile = mobile;
        }

        /// <summary> Contact name of the person. </summary>
        public string ContactName { get; set; }
        /// <summary> Phone number of the contact person. </summary>
        public string Phone { get; set; }
        /// <summary> Phone extension number of the contact person. </summary>
        public string PhoneExtension { get; set; }
        /// <summary> Mobile number of the contact person. </summary>
        public string Mobile { get; set; }
    }
}
