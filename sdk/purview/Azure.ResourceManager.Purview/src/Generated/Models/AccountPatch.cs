// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Purview.Models
{
    /// <summary> The account update properties. </summary>
    public partial class AccountPatch
    {
        /// <summary> Initializes a new instance of AccountPatch. </summary>
        public AccountPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Identity related info to add/remove userAssignedIdentities. Current supported identity types: None, SystemAssigned, UserAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The account properties. </summary>
        public AccountProperties Properties { get; set; }
        /// <summary> Tags on the azure resource. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
