// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ProviderHubMetadataThirdPartyProviderAuthorization. </summary>
    public partial class ProviderHubMetadataThirdPartyProviderAuthorization : ThirdPartyProviderAuthorization
    {
        /// <summary> Initializes a new instance of ProviderHubMetadataThirdPartyProviderAuthorization. </summary>
        public ProviderHubMetadataThirdPartyProviderAuthorization()
        {
        }

        /// <summary> Initializes a new instance of ProviderHubMetadataThirdPartyProviderAuthorization. </summary>
        /// <param name="authorizations"></param>
        /// <param name="managedByTenantId"></param>
        internal ProviderHubMetadataThirdPartyProviderAuthorization(IList<LightHouseAuthorization> authorizations, string managedByTenantId) : base(authorizations, managedByTenantId)
        {
        }
    }
}
