﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    // the base class here is mandatory for fixing the base class, otherwise the generator will change it
    [CodeGenSuppress("DeploymentMode")]
    public partial class ArmApplicationDefinitionData : ArmApplicationResourceData
    {
        /// <summary> The managed application deployment mode. </summary>
        public ArmApplicationDeploymentMode DeploymentMode
        {
            get => DeploymentPolicy is null ? ArmApplicationDeploymentMode.NotSpecified : DeploymentPolicy.DeploymentMode;
            set => DeploymentPolicy = new ArmApplicationDeploymentPolicy(value);
        }
    }
}
