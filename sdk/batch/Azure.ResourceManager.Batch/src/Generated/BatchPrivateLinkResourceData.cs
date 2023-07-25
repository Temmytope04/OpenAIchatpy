// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Batch
{
    /// <summary>
    /// A class representing the BatchPrivateLinkResource data model.
    /// Contains information about a private link resource.
    /// </summary>
    public partial class BatchPrivateLinkResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of BatchPrivateLinkResourceData. </summary>
        public BatchPrivateLinkResourceData()
        {
            RequiredMembers = new ChangeTrackingList<string>();
            RequiredZoneNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of BatchPrivateLinkResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"> The group id is used to establish the private link connection. </param>
        /// <param name="requiredMembers"> The list of required members that are used to establish the private link connection. </param>
        /// <param name="requiredZoneNames"> The list of required zone names for the private DNS resource name. </param>
        /// <param name="etag"> The ETag of the resource, used for concurrency statements. </param>
        internal BatchPrivateLinkResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string groupId, IReadOnlyList<string> requiredMembers, IReadOnlyList<string> requiredZoneNames, ETag? etag) : base(id, name, resourceType, systemData)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
            ETag = etag;
        }

        /// <summary> The group id is used to establish the private link connection. </summary>
        public string GroupId { get; }
        /// <summary> The list of required members that are used to establish the private link connection. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
        /// <summary> The list of required zone names for the private DNS resource name. </summary>
        public IReadOnlyList<string> RequiredZoneNames { get; }
        /// <summary> The ETag of the resource, used for concurrency statements. </summary>
        public ETag? ETag { get; }
    }
}
