// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Support;

namespace Azure.ResourceManager.Support.Models
{
    /// <summary> Collection of Communication resources. </summary>
    internal partial class CommunicationsListResult
    {
        /// <summary> Initializes a new instance of CommunicationsListResult. </summary>
        internal CommunicationsListResult()
        {
            Value = new ChangeTrackingList<SupportTicketCommunicationData>();
        }

        /// <summary> Initializes a new instance of CommunicationsListResult. </summary>
        /// <param name="value"> List of Communication resources. </param>
        /// <param name="nextLink"> The URI to fetch the next page of Communication resources. </param>
        internal CommunicationsListResult(IReadOnlyList<SupportTicketCommunicationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Communication resources. </summary>
        public IReadOnlyList<SupportTicketCommunicationData> Value { get; }
        /// <summary> The URI to fetch the next page of Communication resources. </summary>
        public string NextLink { get; }
    }
}
