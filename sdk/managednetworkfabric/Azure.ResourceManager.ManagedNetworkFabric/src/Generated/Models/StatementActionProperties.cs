// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Route policy action properties. </summary>
    public partial class StatementActionProperties
    {
        /// <summary> Initializes a new instance of <see cref="StatementActionProperties"/>. </summary>
        /// <param name="actionType"> Action type. Example: Permit | Deny | Continue. </param>
        public StatementActionProperties(RoutePolicyActionType actionType)
        {
            ActionType = actionType;
        }

        /// <summary> Initializes a new instance of <see cref="StatementActionProperties"/>. </summary>
        /// <param name="localPreference"> Local Preference of the route policy. </param>
        /// <param name="actionType"> Action type. Example: Permit | Deny | Continue. </param>
        /// <param name="ipCommunityProperties"> IP Community Properties. </param>
        /// <param name="ipExtendedCommunityProperties"> IP Extended Community Properties. </param>
        internal StatementActionProperties(long? localPreference, RoutePolicyActionType actionType, ActionIPCommunityProperties ipCommunityProperties, ActionIPExtendedCommunityProperties ipExtendedCommunityProperties)
        {
            LocalPreference = localPreference;
            ActionType = actionType;
            IPCommunityProperties = ipCommunityProperties;
            IPExtendedCommunityProperties = ipExtendedCommunityProperties;
        }

        /// <summary> Local Preference of the route policy. </summary>
        public long? LocalPreference { get; set; }
        /// <summary> Action type. Example: Permit | Deny | Continue. </summary>
        public RoutePolicyActionType ActionType { get; set; }
        /// <summary> IP Community Properties. </summary>
        public ActionIPCommunityProperties IPCommunityProperties { get; set; }
        /// <summary> IP Extended Community Properties. </summary>
        public ActionIPExtendedCommunityProperties IPExtendedCommunityProperties { get; set; }
    }
}
