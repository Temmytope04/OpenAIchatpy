// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The list of integration account certificates. </summary>
    internal partial class IntegrationAccountCertificateListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountCertificateListResult"/>. </summary>
        internal IntegrationAccountCertificateListResult()
        {
            Value = new ChangeTrackingList<IntegrationAccountCertificateData>();
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountCertificateListResult"/>. </summary>
        /// <param name="value"> The list of integration account certificates. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IntegrationAccountCertificateListResult(IReadOnlyList<IntegrationAccountCertificateData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of integration account certificates. </summary>
        public IReadOnlyList<IntegrationAccountCertificateData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
