// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Details of the customer managed key associated with the workspace. </summary>
    public partial class WorkspaceCustomerManagedKeyDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WorkspaceCustomerManagedKeyDetails"/>. </summary>
        public WorkspaceCustomerManagedKeyDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WorkspaceCustomerManagedKeyDetails"/>. </summary>
        /// <param name="status"> The customer managed key status on the workspace. </param>
        /// <param name="key"> The key object of the workspace. </param>
        /// <param name="kekIdentity"> Key encryption key. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkspaceCustomerManagedKeyDetails(string status, SynapseWorkspaceKeyDetails key, KekIdentityProperties kekIdentity, Dictionary<string, BinaryData> rawData)
        {
            Status = status;
            Key = key;
            KekIdentity = kekIdentity;
            _rawData = rawData;
        }

        /// <summary> The customer managed key status on the workspace. </summary>
        public string Status { get; }
        /// <summary> The key object of the workspace. </summary>
        public SynapseWorkspaceKeyDetails Key { get; set; }
        /// <summary> Key encryption key. </summary>
        public KekIdentityProperties KekIdentity { get; set; }
    }
}
