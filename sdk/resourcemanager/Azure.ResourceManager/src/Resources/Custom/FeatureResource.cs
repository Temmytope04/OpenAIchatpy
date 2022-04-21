// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

[assembly:CodeGenSuppressType("ErrorDefinition")]
[assembly:CodeGenSuppressType("FeatureErrorResponse")]
namespace Azure.ResourceManager.Resources
{
    /// <summary> A Class representing a Feature along with the instance operations that can be performed on it. </summary>
    public partial class FeatureResource : ArmResource
    {
        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType.GetLastType() != "features")
            {
                throw new InvalidOperationException($"Invalid resourcetype found when intializing FeatureOperations: {id.ResourceType}");
            }
        }
    }
}
