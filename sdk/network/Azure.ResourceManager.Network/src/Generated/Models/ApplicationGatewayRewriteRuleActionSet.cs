// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Set of actions in the Rewrite Rule in Application Gateway. </summary>
    public partial class ApplicationGatewayRewriteRuleActionSet
    {
        /// <summary> Initializes a new instance of ApplicationGatewayRewriteRuleActionSet. </summary>
        public ApplicationGatewayRewriteRuleActionSet()
        {
        }

        /// <summary> Initializes a new instance of ApplicationGatewayRewriteRuleActionSet. </summary>
        /// <param name="requestHeaderConfigurations"> Request Header Actions in the Action Set. </param>
        /// <param name="responseHeaderConfigurations"> Response Header Actions in the Action Set. </param>
        /// <param name="urlConfiguration"> Url Configuration Action in the Action Set. </param>
        internal ApplicationGatewayRewriteRuleActionSet(IList<ApplicationGatewayHeaderConfiguration> requestHeaderConfigurations, IList<ApplicationGatewayHeaderConfiguration> responseHeaderConfigurations, ApplicationGatewayUrlConfiguration urlConfiguration)
        {
            RequestHeaderConfigurations = requestHeaderConfigurations;
            ResponseHeaderConfigurations = responseHeaderConfigurations;
            UrlConfiguration = urlConfiguration;
        }

        /// <summary> Request Header Actions in the Action Set. </summary>
        public IList<ApplicationGatewayHeaderConfiguration> RequestHeaderConfigurations { get; set; }
        /// <summary> Response Header Actions in the Action Set. </summary>
        public IList<ApplicationGatewayHeaderConfiguration> ResponseHeaderConfigurations { get; set; }
        /// <summary> Url Configuration Action in the Action Set. </summary>
        public ApplicationGatewayUrlConfiguration UrlConfiguration { get; set; }
    }
}
