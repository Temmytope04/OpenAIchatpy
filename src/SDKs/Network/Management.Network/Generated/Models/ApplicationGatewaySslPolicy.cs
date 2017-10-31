// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Application Gateway Ssl policy.
    /// </summary>
    public partial class ApplicationGatewaySslPolicy
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewaySslPolicy
        /// class.
        /// </summary>
        public ApplicationGatewaySslPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewaySslPolicy
        /// class.
        /// </summary>
        /// <param name="disabledSslProtocols">Ssl protocols to be disabled on
        /// application gateway.</param>
        /// <param name="policyType">Type of Ssl Policy. Possible values
        /// include: 'Predefined', 'Custom'</param>
        /// <param name="policyName">Name of Ssl predefined policy. Possible
        /// values include: 'AppGwSslPolicy20150501', 'AppGwSslPolicy20170401',
        /// 'AppGwSslPolicy20170401S'</param>
        /// <param name="cipherSuites">Ssl cipher suites to be enabled in the
        /// specified order to application gateway.</param>
        /// <param name="minProtocolVersion">Minimum version of Ssl protocol to
        /// be supported on application gateway. Possible values include:
        /// 'TLSv1_0', 'TLSv1_1', 'TLSv1_2'</param>
        public ApplicationGatewaySslPolicy(IList<string> disabledSslProtocols = default(IList<string>), string policyType = default(string), string policyName = default(string), IList<string> cipherSuites = default(IList<string>), string minProtocolVersion = default(string))
        {
            DisabledSslProtocols = disabledSslProtocols;
            PolicyType = policyType;
            PolicyName = policyName;
            CipherSuites = cipherSuites;
            MinProtocolVersion = minProtocolVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ssl protocols to be disabled on application gateway.
        /// </summary>
        [JsonProperty(PropertyName = "disabledSslProtocols")]
        public IList<string> DisabledSslProtocols { get; set; }

        /// <summary>
        /// Gets or sets type of Ssl Policy. Possible values include:
        /// 'Predefined', 'Custom'
        /// </summary>
        [JsonProperty(PropertyName = "policyType")]
        public string PolicyType { get; set; }

        /// <summary>
        /// Gets or sets name of Ssl predefined policy. Possible values
        /// include: 'AppGwSslPolicy20150501', 'AppGwSslPolicy20170401',
        /// 'AppGwSslPolicy20170401S'
        /// </summary>
        [JsonProperty(PropertyName = "policyName")]
        public string PolicyName { get; set; }

        /// <summary>
        /// Gets or sets ssl cipher suites to be enabled in the specified order
        /// to application gateway.
        /// </summary>
        [JsonProperty(PropertyName = "cipherSuites")]
        public IList<string> CipherSuites { get; set; }

        /// <summary>
        /// Gets or sets minimum version of Ssl protocol to be supported on
        /// application gateway. Possible values include: 'TLSv1_0', 'TLSv1_1',
        /// 'TLSv1_2'
        /// </summary>
        [JsonProperty(PropertyName = "minProtocolVersion")]
        public string MinProtocolVersion { get; set; }

    }
}
