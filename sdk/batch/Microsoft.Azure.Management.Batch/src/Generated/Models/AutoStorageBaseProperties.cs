// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties related to the auto-storage account.
    /// </summary>
    public partial class AutoStorageBaseProperties
    {
        /// <summary>
        /// Initializes a new instance of the AutoStorageBaseProperties class.
        /// </summary>
        public AutoStorageBaseProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutoStorageBaseProperties class.
        /// </summary>
        /// <param name="storageAccountId">The resource ID of the storage
        /// account to be used for auto-storage account.</param>
        /// <param name="authenticationMode">The authentication mode which the
        /// Batch service will use to manage the auto-storage account. Possible
        /// values include: 'StorageKeys',
        /// 'BatchAccountManagedIdentity'</param>
        /// <param name="nodeIdentityReference">The reference to the user
        /// assigned identity which compute nodes will use to access
        /// auto-storage.</param>
        public AutoStorageBaseProperties(string storageAccountId, AutoStorageAuthenticationMode? authenticationMode = default(AutoStorageAuthenticationMode?), ComputeNodeIdentityReference nodeIdentityReference = default(ComputeNodeIdentityReference))
        {
            StorageAccountId = storageAccountId;
            AuthenticationMode = authenticationMode;
            NodeIdentityReference = nodeIdentityReference;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource ID of the storage account to be used for
        /// auto-storage account.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountId")]
        public string StorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the authentication mode which the Batch service will
        /// use to manage the auto-storage account. Possible values include:
        /// 'StorageKeys', 'BatchAccountManagedIdentity'
        /// </summary>
        [JsonProperty(PropertyName = "authenticationMode")]
        public AutoStorageAuthenticationMode? AuthenticationMode { get; set; }

        /// <summary>
        /// Gets or sets the reference to the user assigned identity which
        /// compute nodes will use to access auto-storage.
        /// </summary>
        /// <remarks>
        /// The identity referenced here must be assigned to pools which have
        /// compute nodes that need access to auto-storage.
        /// </remarks>
        [JsonProperty(PropertyName = "nodeIdentityReference")]
        public ComputeNodeIdentityReference NodeIdentityReference { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageAccountId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageAccountId");
            }
        }
    }
}
