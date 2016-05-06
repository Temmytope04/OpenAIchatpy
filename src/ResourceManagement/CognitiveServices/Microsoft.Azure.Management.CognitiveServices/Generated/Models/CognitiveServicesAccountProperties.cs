// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class CognitiveServicesAccountProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CognitiveServicesAccountProperties class.
        /// </summary>
        public CognitiveServicesAccountProperties() { }

        /// <summary>
        /// Initializes a new instance of the
        /// CognitiveServicesAccountProperties class.
        /// </summary>
        public CognitiveServicesAccountProperties(ProvisioningState? provisioningState = default(ProvisioningState?), string endpoint = default(string))
        {
            ProvisioningState = provisioningState;
            Endpoint = endpoint;
        }

        /// <summary>
        /// Gets the status of the cognitive services account at the time the
        /// operation was called. Possible values include: 'Creating',
        /// 'ResolvingDNS', 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public ProvisioningState? ProvisioningState { get; private set; }

        /// <summary>
        /// Endpoint of the created account
        /// </summary>
        [JsonProperty(PropertyName = "endpoint")]
        public string Endpoint { get; set; }

    }
}
