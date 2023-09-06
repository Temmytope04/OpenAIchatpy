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
    /// <summary> Static sites user roles invitation resource. </summary>
    public partial class StaticSiteUserInvitationContent : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StaticSiteUserInvitationContent"/>. </summary>
        public StaticSiteUserInvitationContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StaticSiteUserInvitationContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="domain"> The domain name for the static site custom domain. </param>
        /// <param name="provider"> The identity provider for the static site user. </param>
        /// <param name="userDetails"> The user id for the static site user. </param>
        /// <param name="roles"> The roles for the static site user, in free-form string format. </param>
        /// <param name="numHoursToExpiration"> The number of hours the sas token stays valid. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StaticSiteUserInvitationContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string domain, string provider, string userDetails, string roles, int? numHoursToExpiration, string kind, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Domain = domain;
            Provider = provider;
            UserDetails = userDetails;
            Roles = roles;
            NumHoursToExpiration = numHoursToExpiration;
            Kind = kind;
            _rawData = rawData;
        }

        /// <summary> The domain name for the static site custom domain. </summary>
        public string Domain { get; set; }
        /// <summary> The identity provider for the static site user. </summary>
        public string Provider { get; set; }
        /// <summary> The user id for the static site user. </summary>
        public string UserDetails { get; set; }
        /// <summary> The roles for the static site user, in free-form string format. </summary>
        public string Roles { get; set; }
        /// <summary> The number of hours the sas token stays valid. </summary>
        public int? NumHoursToExpiration { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
