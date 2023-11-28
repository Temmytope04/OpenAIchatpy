// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownNCrossValidations. </summary>
    internal partial class UnknownNCrossValidations : NCrossValidations
    {
        /// <summary> Initializes a new instance of <see cref="UnknownNCrossValidations"/>. </summary>
        /// <param name="mode"> [Required] Mode for determining N-Cross validations. </param>
        internal UnknownNCrossValidations(NCrossValidationsMode mode) : base(mode)
        {
            Mode = mode;
        }
    }
}
