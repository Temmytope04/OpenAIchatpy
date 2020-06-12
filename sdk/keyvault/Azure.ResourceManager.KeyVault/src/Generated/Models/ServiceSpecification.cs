// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> One property of operation, include log specifications. </summary>
    public partial class ServiceSpecification
    {
        /// <summary> Initializes a new instance of ServiceSpecification. </summary>
        internal ServiceSpecification()
        {
        }

        /// <summary> Initializes a new instance of ServiceSpecification. </summary>
        /// <param name="logSpecifications"> Log specifications of operation. </param>
        internal ServiceSpecification(IReadOnlyList<LogSpecification> logSpecifications)
        {
            LogSpecifications = logSpecifications;
        }

        /// <summary> Log specifications of operation. </summary>
        public IReadOnlyList<LogSpecification> LogSpecifications { get; }
    }
}
