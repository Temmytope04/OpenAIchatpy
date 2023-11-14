// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningFqdnEndpoint. </summary>
    public partial class MachineLearningFqdnEndpoint
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningFqdnEndpoint"/>. </summary>
        internal MachineLearningFqdnEndpoint()
        {
            EndpointDetails = new ChangeTrackingList<MachineLearningFqdnEndpointDetail>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningFqdnEndpoint"/>. </summary>
        /// <param name="domainName"></param>
        /// <param name="endpointDetails"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningFqdnEndpoint(string domainName, IReadOnlyList<MachineLearningFqdnEndpointDetail> endpointDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DomainName = domainName;
            EndpointDetails = endpointDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the domain name. </summary>
        public string DomainName { get; }
        /// <summary> Gets the endpoint details. </summary>
        public IReadOnlyList<MachineLearningFqdnEndpointDetail> EndpointDetails { get; }
    }
}
