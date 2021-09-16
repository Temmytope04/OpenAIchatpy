// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.Storage.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An access key for the storage account.
    /// </summary>
    public partial class StorageAccountKey
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountKey class.
        /// </summary>
        public StorageAccountKey()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccountKey class.
        /// </summary>
        /// <param name="keyName">Name of the key.</param>
        /// <param name="value">Base 64-encoded value of the key.</param>
        /// <param name="permissions">Permissions for the key -- read-only or
        /// full permissions. Possible values include: 'Read', 'Full'</param>
        public StorageAccountKey(string keyName = default(string), string value = default(string), KeyPermission? permissions = default(KeyPermission?))
        {
            KeyName = keyName;
            Value = value;
            Permissions = permissions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the key.
        /// </summary>
        [JsonProperty(PropertyName = "keyName")]
        public string KeyName { get; private set; }

        /// <summary>
        /// Gets base 64-encoded value of the key.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; private set; }

        /// <summary>
        /// Gets permissions for the key -- read-only or full permissions.
        /// Possible values include: 'Read', 'Full'
        /// </summary>
        [JsonProperty(PropertyName = "permissions")]
        public KeyPermission? Permissions { get; private set; }

    }
}
