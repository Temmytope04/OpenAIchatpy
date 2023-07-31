// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> IP Extended Community Properties. </summary>
    public partial class ActionIPExtendedCommunityProperties : IPExtendedCommunityAddOperationProperties
    {
        /// <summary> Initializes a new instance of ActionIPExtendedCommunityProperties. </summary>
        public ActionIPExtendedCommunityProperties()
        {
        }

        /// <summary> Initializes a new instance of ActionIPExtendedCommunityProperties. </summary>
        /// <param name="add"> List of IP Extended Community IDs. </param>
        /// <param name="delete"> List of IP Extended Community IDs. </param>
        /// <param name="set"> List of IP Extended Community IDs. </param>
        internal ActionIPExtendedCommunityProperties(IPExtendedCommunityIdList @add, IPExtendedCommunityIdList delete, IPExtendedCommunityIdList @set) : base(@add)
        {
            Delete = delete;
            Set = @set;
        }

        /// <summary> List of IP Extended Community IDs. </summary>
        internal IPExtendedCommunityIdList Delete { get; set; }
        /// <summary> List of IP Extended Community resource IDs. </summary>
        public IList<ResourceIdentifier> DeleteIPExtendedCommunityIds
        {
            get
            {
                if (Delete is null)
                    Delete = new IPExtendedCommunityIdList();
                return Delete.IPExtendedCommunityIds;
            }
        }

        /// <summary> List of IP Extended Community IDs. </summary>
        internal IPExtendedCommunityIdList Set { get; set; }
        /// <summary> List of IP Extended Community resource IDs. </summary>
        public IList<ResourceIdentifier> SetIPExtendedCommunityIds
        {
            get
            {
                if (Set is null)
                    Set = new IPExtendedCommunityIdList();
                return Set.IPExtendedCommunityIds;
            }
        }
    }
}
