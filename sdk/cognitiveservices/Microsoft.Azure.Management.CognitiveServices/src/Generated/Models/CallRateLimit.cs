// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The call rate limit Cognitive Services account.
    /// </summary>
    public partial class CallRateLimit
    {
        /// <summary>
        /// Initializes a new instance of the CallRateLimit class.
        /// </summary>
        public CallRateLimit()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CallRateLimit class.
        /// </summary>
        /// <param name="count">The count value of Call Rate Limit.</param>
        /// <param name="renewalPeriod">The renewal period in seconds of Call
        /// Rate Limit.</param>
        public CallRateLimit(double? count = default(double?), double? renewalPeriod = default(double?), IList<ThrottlingRule> rules = default(IList<ThrottlingRule>))
        {
            Count = count;
            RenewalPeriod = renewalPeriod;
            Rules = rules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the count value of Call Rate Limit.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public double? Count { get; set; }

        /// <summary>
        /// Gets or sets the renewal period in seconds of Call Rate Limit.
        /// </summary>
        [JsonProperty(PropertyName = "renewalPeriod")]
        public double? RenewalPeriod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<ThrottlingRule> Rules { get; set; }

    }
}
