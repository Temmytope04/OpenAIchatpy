// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.NewResources
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ArmClientExtensions
    {
        #region PolicyAssignment
        /// <summary> Gets an object representing a PolicyAssignmentContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope of the resource that is the target of operations. </param>
        /// <returns> Returns a <see cref="PolicyAssignmentContainer" /> object. </returns>
        public static PolicyAssignmentContainer GetPolicyAssignmentContainer(this ArmClient armClient, ResourceIdentifier scope)
        {
            return new PolicyAssignmentContainer(armClient.Tenant, scope);
        }
        #endregion
    }
}
