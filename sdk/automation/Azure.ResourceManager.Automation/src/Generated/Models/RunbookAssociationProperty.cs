// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The runbook property associated with the entity. </summary>
    public partial class RunbookAssociationProperty
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RunbookAssociationProperty"/>. </summary>
        public RunbookAssociationProperty()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RunbookAssociationProperty"/>. </summary>
        /// <param name="name"> Gets or sets the name of the runbook. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RunbookAssociationProperty(string name, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the name of the runbook. </summary>
        public string Name { get; set; }
    }
}
