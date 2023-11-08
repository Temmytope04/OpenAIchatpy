// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownAssetReferenceBase. </summary>
    internal partial class UnknownAssetReferenceBase : MachineLearningAssetReferenceBase
    {
        /// <summary> Initializes a new instance of <see cref="UnknownAssetReferenceBase"/>. </summary>
        /// <param name="referenceType"> [Required] Specifies the type of asset reference. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownAssetReferenceBase(ReferenceType referenceType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(referenceType, serializedAdditionalRawData)
        {
            ReferenceType = referenceType;
        }
    }
}
