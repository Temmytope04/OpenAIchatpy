// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The CertificateOrderContact. </summary>
    public partial class CertificateOrderContact
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CertificateOrderContact"/>. </summary>
        internal CertificateOrderContact()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CertificateOrderContact"/>. </summary>
        /// <param name="email"></param>
        /// <param name="nameFirst"></param>
        /// <param name="nameLast"></param>
        /// <param name="phone"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CertificateOrderContact(string email, string nameFirst, string nameLast, string phone, Dictionary<string, BinaryData> rawData)
        {
            Email = email;
            NameFirst = nameFirst;
            NameLast = nameLast;
            Phone = phone;
            _rawData = rawData;
        }

        /// <summary> Gets the email. </summary>
        public string Email { get; }
        /// <summary> Gets the name first. </summary>
        public string NameFirst { get; }
        /// <summary> Gets the name last. </summary>
        public string NameLast { get; }
        /// <summary> Gets the phone. </summary>
        public string Phone { get; }
    }
}
