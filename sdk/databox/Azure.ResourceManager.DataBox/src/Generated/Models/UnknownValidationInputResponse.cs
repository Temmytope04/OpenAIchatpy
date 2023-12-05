// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The UnknownValidationInputResponse. </summary>
    internal partial class UnknownValidationInputResponse : DataBoxValidationInputResult
    {
        /// <summary> Initializes a new instance of <see cref="UnknownValidationInputResponse"/>. </summary>
        /// <param name="validationType"> Identifies the type of validation response. </param>
        /// <param name="error"> Error code and message of validation response. </param>
        internal UnknownValidationInputResponse(DataBoxValidationInputDiscriminator validationType, ResponseError error) : base(validationType, error)
        {
            ValidationType = validationType;
        }
    }
}
