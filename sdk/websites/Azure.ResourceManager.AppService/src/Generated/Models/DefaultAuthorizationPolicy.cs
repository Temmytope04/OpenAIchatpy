// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the Azure Active Directory default authorization policy. </summary>
    public partial class DefaultAuthorizationPolicy
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DefaultAuthorizationPolicy"/>. </summary>
        public DefaultAuthorizationPolicy()
        {
            AllowedApplications = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DefaultAuthorizationPolicy"/>. </summary>
        /// <param name="allowedPrincipals"> The configuration settings of the Azure Active Directory allowed principals. </param>
        /// <param name="allowedApplications"> The configuration settings of the Azure Active Directory allowed applications. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DefaultAuthorizationPolicy(AppServiceAadAllowedPrincipals allowedPrincipals, IList<string> allowedApplications, Dictionary<string, BinaryData> rawData)
        {
            AllowedPrincipals = allowedPrincipals;
            AllowedApplications = allowedApplications;
            _rawData = rawData;
        }

        /// <summary> The configuration settings of the Azure Active Directory allowed principals. </summary>
        public AppServiceAadAllowedPrincipals AllowedPrincipals { get; set; }
        /// <summary> The configuration settings of the Azure Active Directory allowed applications. </summary>
        public IList<string> AllowedApplications { get; }
    }
}
