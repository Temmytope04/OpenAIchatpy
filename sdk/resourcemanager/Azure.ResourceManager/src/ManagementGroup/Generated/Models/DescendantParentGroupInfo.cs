// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagementGroups.Models
{
    /// <summary> The ID of the parent management group. </summary>
    internal partial class DescendantParentGroupInfo
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DescendantParentGroupInfo"/>. </summary>
        internal DescendantParentGroupInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DescendantParentGroupInfo"/>. </summary>
        /// <param name="id"> The fully qualified ID for the parent management group.  For example, /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DescendantParentGroupInfo(ResourceIdentifier id, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            _rawData = rawData;
        }

        /// <summary> The fully qualified ID for the parent management group.  For example, /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000. </summary>
        public ResourceIdentifier Id { get; }
    }
}
