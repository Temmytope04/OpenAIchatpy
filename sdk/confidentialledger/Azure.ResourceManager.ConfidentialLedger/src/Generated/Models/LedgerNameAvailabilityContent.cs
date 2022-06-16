// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    /// <summary> The check availability request body. </summary>
    public partial class LedgerNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of LedgerNameAvailabilityContent. </summary>
        public LedgerNameAvailabilityContent()
        {
        }

        /// <summary> The name of the resource for which availability needs to be checked. </summary>
        public string Name { get; set; }
        /// <summary> The resource type. </summary>
        public string ResourceType { get; set; }
    }
}
