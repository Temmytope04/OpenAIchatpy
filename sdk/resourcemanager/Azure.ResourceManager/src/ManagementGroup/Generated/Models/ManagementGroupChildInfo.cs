// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagementGroups.Models
{
    /// <summary> The child information of a management group. </summary>
    public partial class ManagementGroupChildInfo
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagementGroupChildInfo"/>. </summary>
        internal ManagementGroupChildInfo()
        {
            Children = new ChangeTrackingList<ManagementGroupChildInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagementGroupChildInfo"/>. </summary>
        /// <param name="childType"> The fully qualified resource type which includes provider namespace (e.g. Microsoft.Management/managementGroups). </param>
        /// <param name="id"> The fully qualified ID for the child resource (management group or subscription).  For example, /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000. </param>
        /// <param name="name"> The name of the child entity. </param>
        /// <param name="displayName"> The friendly name of the child resource. </param>
        /// <param name="children"> The list of children. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagementGroupChildInfo(ManagementGroupChildType? childType, string id, string name, string displayName, IReadOnlyList<ManagementGroupChildInfo> children, Dictionary<string, BinaryData> rawData)
        {
            ChildType = childType;
            Id = id;
            Name = name;
            DisplayName = displayName;
            Children = children;
            _rawData = rawData;
        }

        /// <summary> The fully qualified resource type which includes provider namespace (e.g. Microsoft.Management/managementGroups). </summary>
        public ManagementGroupChildType? ChildType { get; }
        /// <summary> The fully qualified ID for the child resource (management group or subscription).  For example, /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000. </summary>
        public string Id { get; }
        /// <summary> The name of the child entity. </summary>
        public string Name { get; }
        /// <summary> The friendly name of the child resource. </summary>
        public string DisplayName { get; }
        /// <summary> The list of children. </summary>
        public IReadOnlyList<ManagementGroupChildInfo> Children { get; }
    }
}
