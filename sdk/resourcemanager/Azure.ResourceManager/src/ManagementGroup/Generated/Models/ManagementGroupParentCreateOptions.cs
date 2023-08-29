// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ManagementGroups.Models
{
    /// <summary> (Optional) The ID of the parent management group used during creation. </summary>
    public partial class ManagementGroupParentCreateOptions
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagementGroupParentCreateOptions"/>. </summary>
        public ManagementGroupParentCreateOptions()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagementGroupParentCreateOptions"/>. </summary>
        /// <param name="id"> The fully qualified ID for the parent management group.  For example, /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000. </param>
        /// <param name="name"> The name of the parent management group. </param>
        /// <param name="displayName"> The friendly name of the parent management group. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagementGroupParentCreateOptions(string id, string name, string displayName, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Name = name;
            DisplayName = displayName;
            _rawData = rawData;
        }

        /// <summary> The fully qualified ID for the parent management group.  For example, /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000. </summary>
        public string Id { get; set; }
        /// <summary> The name of the parent management group. </summary>
        public string Name { get; }
        /// <summary> The friendly name of the parent management group. </summary>
        public string DisplayName { get; }
    }
}
