// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PowerBIDedicated.Models
{
    /// <summary> An object that represents enumerating SKUs for existing resources. </summary>
    internal partial class SkuEnumerationForExistingResourceResult
    {
        /// <summary> Initializes a new instance of SkuEnumerationForExistingResourceResult. </summary>
        internal SkuEnumerationForExistingResourceResult()
        {
            Value = new ChangeTrackingList<SkuDetailsForExistingResource>();
        }

        /// <summary> Initializes a new instance of SkuEnumerationForExistingResourceResult. </summary>
        /// <param name="value"> The collection of available SKUs for existing resources. </param>
        internal SkuEnumerationForExistingResourceResult(IReadOnlyList<SkuDetailsForExistingResource> value)
        {
            Value = value;
        }

        /// <summary> The collection of available SKUs for existing resources. </summary>
        public IReadOnlyList<SkuDetailsForExistingResource> Value { get; }
    }
}
