// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> User identity configuration. </summary>
    public partial class MachineLearningUserIdentity : MachineLearningIdentityConfiguration
    {
        /// <summary> Initializes a new instance of MachineLearningUserIdentity. </summary>
        public MachineLearningUserIdentity()
        {
            IdentityType = IdentityConfigurationType.UserIdentity;
        }

        /// <summary> Initializes a new instance of MachineLearningUserIdentity. </summary>
        /// <param name="identityType"> [Required] Specifies the type of identity framework. </param>
        internal MachineLearningUserIdentity(IdentityConfigurationType identityType) : base(identityType)
        {
            IdentityType = identityType;
        }
    }
}
