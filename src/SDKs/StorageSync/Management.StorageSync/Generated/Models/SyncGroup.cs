// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Sync Group object.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SyncGroup : Resource
    {
        /// <summary>
        /// Initializes a new instance of the SyncGroup class.
        /// </summary>
        public SyncGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SyncGroup class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="uniqueId">Unique Id</param>
        /// <param name="syncGroupStatus">Sync group status</param>
        public SyncGroup(string id = default(string), string name = default(string), string type = default(string), string uniqueId = default(string), string syncGroupStatus = default(string))
            : base(id, name, type)
        {
            UniqueId = uniqueId;
            SyncGroupStatus = syncGroupStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique Id
        /// </summary>
        [JsonProperty(PropertyName = "properties.uniqueId")]
        public string UniqueId { get; set; }

        /// <summary>
        /// Gets sync group status
        /// </summary>
        [JsonProperty(PropertyName = "properties.syncGroupStatus")]
        public string SyncGroupStatus { get; private set; }

    }
}
