// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of the runbook property type. </summary>
    public partial class AutomationContentHash
    {
        /// <summary> Initializes a new instance of <see cref="AutomationContentHash"/>. </summary>
        /// <param name="algorithm"> Gets or sets the content hash algorithm used to hash the content. </param>
        /// <param name="value"> Gets or sets expected hash value of the content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="algorithm"/> or <paramref name="value"/> is null. </exception>
        public AutomationContentHash(string algorithm, string value)
        {
            Argument.AssertNotNull(algorithm, nameof(algorithm));
            Argument.AssertNotNull(value, nameof(value));

            Algorithm = algorithm;
            Value = value;
        }

        /// <summary> Gets or sets the content hash algorithm used to hash the content. </summary>
        public string Algorithm { get; set; }
        /// <summary> Gets or sets expected hash value of the content. </summary>
        public string Value { get; set; }
    }
}
