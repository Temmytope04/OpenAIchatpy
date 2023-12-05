// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Properties of a private link resource. </summary>
    public partial class SqlPrivateLinkResourceProperties
    {
        /// <summary> Initializes a new instance of <see cref="SqlPrivateLinkResourceProperties"/>. </summary>
        internal SqlPrivateLinkResourceProperties()
        {
            RequiredMembers = new ChangeTrackingList<string>();
            RequiredZoneNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SqlPrivateLinkResourceProperties"/>. </summary>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        /// <param name="requiredZoneNames"> The private link resource required zone names. </param>
        internal SqlPrivateLinkResourceProperties(string groupId, IReadOnlyList<string> requiredMembers, IReadOnlyList<string> requiredZoneNames)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
        }

        /// <summary> The private link resource group id. </summary>
        public string GroupId { get; }
        /// <summary> The private link resource required member names. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
        /// <summary> The private link resource required zone names. </summary>
        public IReadOnlyList<string> RequiredZoneNames { get; }
    }
}
