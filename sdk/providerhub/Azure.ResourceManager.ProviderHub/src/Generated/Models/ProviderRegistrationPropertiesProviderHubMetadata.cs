// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ProviderRegistrationPropertiesProviderHubMetadata. </summary>
    public partial class ProviderRegistrationPropertiesProviderHubMetadata : ProviderHubMetadata
    {
        /// <summary> Initializes a new instance of ProviderRegistrationPropertiesProviderHubMetadata. </summary>
        public ProviderRegistrationPropertiesProviderHubMetadata()
        {
        }

        /// <summary> Initializes a new instance of ProviderRegistrationPropertiesProviderHubMetadata. </summary>
        /// <param name="providerAuthorizations"></param>
        /// <param name="providerAuthentication"></param>
        /// <param name="thirdPartyProviderAuthorization"></param>
        internal ProviderRegistrationPropertiesProviderHubMetadata(IList<ResourceProviderAuthorization> providerAuthorizations, ProviderHubMetadataProviderAuthentication providerAuthentication, ProviderHubMetadataThirdPartyProviderAuthorization thirdPartyProviderAuthorization) : base(providerAuthorizations, providerAuthentication, thirdPartyProviderAuthorization)
        {
        }
    }
}
