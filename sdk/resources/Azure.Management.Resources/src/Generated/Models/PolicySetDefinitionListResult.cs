// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Resources.Models
{
    /// <summary> List of policy set definitions. </summary>
    public partial class PolicySetDefinitionListResult
    {
        /// <summary> Initializes a new instance of PolicySetDefinitionListResult. </summary>
        internal PolicySetDefinitionListResult()
        {
        }

        /// <summary> Initializes a new instance of PolicySetDefinitionListResult. </summary>
        /// <param name="value"> An array of policy set definitions. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal PolicySetDefinitionListResult(IReadOnlyList<PolicySetDefinition> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of policy set definitions. </summary>
        public IReadOnlyList<PolicySetDefinition> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
