// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Describes a managed rule definition. </summary>
    public partial class ManagedRuleDefinition
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagedRuleDefinition"/>. </summary>
        internal ManagedRuleDefinition()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedRuleDefinition"/>. </summary>
        /// <param name="ruleId"> Identifier for the managed rule. </param>
        /// <param name="description"> Describes the functionality of the managed rule. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedRuleDefinition(string ruleId, string description, Dictionary<string, BinaryData> rawData)
        {
            RuleId = ruleId;
            Description = description;
            _rawData = rawData;
        }

        /// <summary> Identifier for the managed rule. </summary>
        public string RuleId { get; }
        /// <summary> Describes the functionality of the managed rule. </summary>
        public string Description { get; }
    }
}
