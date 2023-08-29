// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Defines the request body for updating SAP monitor resource. </summary>
    public partial class SapMonitorPatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SapMonitorPatch"/>. </summary>
        public SapMonitorPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="SapMonitorPatch"/>. </summary>
        /// <param name="tags"> Gets or sets the Resource tags. </param>
        /// <param name="identity"> [currently not in use] Managed service identity(user assigned identities). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SapMonitorPatch(IDictionary<string, string> tags, UserAssignedServiceIdentity identity, Dictionary<string, BinaryData> rawData)
        {
            Tags = tags;
            Identity = identity;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> [currently not in use] Managed service identity(user assigned identities). </summary>
        public UserAssignedServiceIdentity Identity { get; set; }
    }
}
