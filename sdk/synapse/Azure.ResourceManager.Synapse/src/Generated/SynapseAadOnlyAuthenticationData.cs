// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapseAadOnlyAuthentication data model.
    /// Azure Active Directory Only Authentication Info
    /// </summary>
    public partial class SynapseAadOnlyAuthenticationData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SynapseAadOnlyAuthenticationData"/>. </summary>
        public SynapseAadOnlyAuthenticationData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseAadOnlyAuthenticationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="isAadOnlyAuthenticationEnabled"> Azure Active Directory only Authentication enabled. </param>
        /// <param name="state"> property configuration state. </param>
        /// <param name="createdOn"> property configuration date. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseAadOnlyAuthenticationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? isAadOnlyAuthenticationEnabled, AadAuthenticationState? state, DateTimeOffset? createdOn, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            IsAadOnlyAuthenticationEnabled = isAadOnlyAuthenticationEnabled;
            State = state;
            CreatedOn = createdOn;
            _rawData = rawData;
        }

        /// <summary> Azure Active Directory only Authentication enabled. </summary>
        public bool? IsAadOnlyAuthenticationEnabled { get; set; }
        /// <summary> property configuration state. </summary>
        public AadAuthenticationState? State { get; }
        /// <summary> property configuration date. </summary>
        public DateTimeOffset? CreatedOn { get; }
    }
}
