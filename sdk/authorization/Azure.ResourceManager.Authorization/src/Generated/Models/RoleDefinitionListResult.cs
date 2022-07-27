// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Authorization;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary>
    /// Role definition list operation result.
    /// Serialized Name: RoleDefinitionListResult
    /// </summary>
    internal partial class RoleDefinitionListResult
    {
        /// <summary> Initializes a new instance of RoleDefinitionListResult. </summary>
        internal RoleDefinitionListResult()
        {
            Value = new ChangeTrackingList<RoleDefinitionData>();
        }

        /// <summary> Initializes a new instance of RoleDefinitionListResult. </summary>
        /// <param name="value">
        /// Role definition list.
        /// Serialized Name: RoleDefinitionListResult.value
        /// </param>
        /// <param name="nextLink">
        /// The URL to use for getting the next set of results.
        /// Serialized Name: RoleDefinitionListResult.nextLink
        /// </param>
        internal RoleDefinitionListResult(IReadOnlyList<RoleDefinitionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Role definition list.
        /// Serialized Name: RoleDefinitionListResult.value
        /// </summary>
        public IReadOnlyList<RoleDefinitionData> Value { get; }
        /// <summary>
        /// The URL to use for getting the next set of results.
        /// Serialized Name: RoleDefinitionListResult.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
