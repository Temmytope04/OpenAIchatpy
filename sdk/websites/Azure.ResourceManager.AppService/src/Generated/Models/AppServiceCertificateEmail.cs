// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> SSL certificate email. </summary>
    public partial class AppServiceCertificateEmail : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceCertificateEmail"/>. </summary>
        public AppServiceCertificateEmail()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceCertificateEmail"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="emailId"> Email id. </param>
        /// <param name="timeStamp"> Time stamp. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceCertificateEmail(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string emailId, DateTimeOffset? timeStamp, string kind, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            EmailId = emailId;
            TimeStamp = timeStamp;
            Kind = kind;
            _rawData = rawData;
        }

        /// <summary> Email id. </summary>
        public string EmailId { get; set; }
        /// <summary> Time stamp. </summary>
        public DateTimeOffset? TimeStamp { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
