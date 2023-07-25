// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Organization Info of the NewRelic account. </summary>
    internal partial class NewRelicObservabilityOrganizationInfo
    {
        /// <summary> Initializes a new instance of NewRelicObservabilityOrganizationInfo. </summary>
        public NewRelicObservabilityOrganizationInfo()
        {
        }

        /// <summary> Initializes a new instance of NewRelicObservabilityOrganizationInfo. </summary>
        /// <param name="organizationId"> Organization id. </param>
        internal NewRelicObservabilityOrganizationInfo(string organizationId)
        {
            OrganizationId = organizationId;
        }

        /// <summary> Organization id. </summary>
        public string OrganizationId { get; set; }
    }
}
