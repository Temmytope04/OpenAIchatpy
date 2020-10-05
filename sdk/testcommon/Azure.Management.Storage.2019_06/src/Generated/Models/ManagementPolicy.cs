// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.Storage.Models
{
    /// <summary> The Get Storage Account ManagementPolicies operation response. </summary>
    public partial class ManagementPolicy : Resource
    {
        /// <summary> Initializes a new instance of ManagementPolicy. </summary>
        public ManagementPolicy()
        {
        }

        /// <summary> Initializes a new instance of ManagementPolicy. </summary>
        /// <param name="id"> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts. </param>
        /// <param name="lastModifiedTime"> Returns the date and time the ManagementPolicies was last modified. </param>
        /// <param name="policy"> The Storage Account ManagementPolicy, in JSON format. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts. </param>
        internal ManagementPolicy(string id, string name, string type, DateTimeOffset? lastModifiedTime, ManagementPolicySchema policy) : base(id, name, type)
        {
            LastModifiedTime = lastModifiedTime;
            Policy = policy;
        }

        /// <summary> Returns the date and time the ManagementPolicies was last modified. </summary>
        public DateTimeOffset? LastModifiedTime { get; }
        /// <summary> The Storage Account ManagementPolicy, in JSON format. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts. </summary>
        public ManagementPolicySchema Policy { get; set; }
    }
}
