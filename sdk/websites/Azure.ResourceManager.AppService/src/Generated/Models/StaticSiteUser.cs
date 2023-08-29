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
    /// <summary> Static Site User ARM resource. </summary>
    public partial class StaticSiteUser : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StaticSiteUser"/>. </summary>
        public StaticSiteUser()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StaticSiteUser"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provider"> The identity provider for the static site user. </param>
        /// <param name="userId"> The user id for the static site user. </param>
        /// <param name="displayName"> The display name for the static site user. </param>
        /// <param name="roles"> The roles for the static site user, in free-form string format. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StaticSiteUser(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string provider, string userId, string displayName, string roles, string kind, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Provider = provider;
            UserId = userId;
            DisplayName = displayName;
            Roles = roles;
            Kind = kind;
            _rawData = rawData;
        }

        /// <summary> The identity provider for the static site user. </summary>
        public string Provider { get; }
        /// <summary> The user id for the static site user. </summary>
        public string UserId { get; }
        /// <summary> The display name for the static site user. </summary>
        public string DisplayName { get; }
        /// <summary> The roles for the static site user, in free-form string format. </summary>
        public string Roles { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
