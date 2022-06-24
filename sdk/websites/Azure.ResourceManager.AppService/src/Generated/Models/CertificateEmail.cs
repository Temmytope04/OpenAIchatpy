// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> SSL certificate email. </summary>
    public partial class CertificateEmail
    {
        /// <summary> Initializes a new instance of CertificateEmail. </summary>
        internal CertificateEmail()
        {
        }

        /// <summary> Initializes a new instance of CertificateEmail. </summary>
        /// <param name="emailId"> Email id. </param>
        /// <param name="timeStamp"> Time stamp. </param>
        internal CertificateEmail(string emailId, DateTimeOffset? timeStamp)
        {
            EmailId = emailId;
            TimeStamp = timeStamp;
        }

        /// <summary> Email id. </summary>
        public string EmailId { get; }
        /// <summary> Time stamp. </summary>
        public DateTimeOffset? TimeStamp { get; }
    }
}
