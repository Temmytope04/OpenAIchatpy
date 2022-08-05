// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppConfiguration.Models
{
    /// <summary> The state of a private link service connection. </summary>
    public partial class AppConfigurationPrivateLinkServiceConnectionState
    {
        /// <summary> Initializes a new instance of AppConfigurationPrivateLinkServiceConnectionState. </summary>
        public AppConfigurationPrivateLinkServiceConnectionState()
        {
        }

        /// <summary> Initializes a new instance of AppConfigurationPrivateLinkServiceConnectionState. </summary>
        /// <param name="status"> The private link service connection status. </param>
        /// <param name="description"> The private link service connection description. </param>
        /// <param name="actionsRequired"> Any action that is required beyond basic workflow (approve/ reject/ disconnect). </param>
        internal AppConfigurationPrivateLinkServiceConnectionState(AppConfigurationPrivateLinkServiceConnectionStatus? status, string description, AppConfigurationActionsRequired? actionsRequired)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
        }

        /// <summary> The private link service connection status. </summary>
        public AppConfigurationPrivateLinkServiceConnectionStatus? Status { get; set; }
        /// <summary> The private link service connection description. </summary>
        public string Description { get; set; }
        /// <summary> Any action that is required beyond basic workflow (approve/ reject/ disconnect). </summary>
        public AppConfigurationActionsRequired? ActionsRequired { get; }
    }
}
