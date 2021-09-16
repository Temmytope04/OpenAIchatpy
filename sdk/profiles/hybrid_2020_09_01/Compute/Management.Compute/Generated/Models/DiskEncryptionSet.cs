// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.Compute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// disk encryption set resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DiskEncryptionSet : Resource
    {
        /// <summary>
        /// Initializes a new instance of the DiskEncryptionSet class.
        /// </summary>
        public DiskEncryptionSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiskEncryptionSet class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="activeKey">The key vault key which is currently used
        /// by this disk encryption set.</param>
        /// <param name="previousKeys">A readonly collection of key vault keys
        /// previously used by this disk encryption set while a key rotation is
        /// in progress. It will be empty if there is no ongoing key
        /// rotation.</param>
        /// <param name="provisioningState">The disk encryption set
        /// provisioning state.</param>
        public DiskEncryptionSet(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), EncryptionSetIdentity identity = default(EncryptionSetIdentity), KeyVaultAndKeyReference activeKey = default(KeyVaultAndKeyReference), IList<KeyVaultAndKeyReference> previousKeys = default(IList<KeyVaultAndKeyReference>), string provisioningState = default(string))
            : base(location, id, name, type, tags)
        {
            Identity = identity;
            ActiveKey = activeKey;
            PreviousKeys = previousKeys;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public EncryptionSetIdentity Identity { get; set; }

        /// <summary>
        /// Gets or sets the key vault key which is currently used by this disk
        /// encryption set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.activeKey")]
        public KeyVaultAndKeyReference ActiveKey { get; set; }

        /// <summary>
        /// Gets a readonly collection of key vault keys previously used by
        /// this disk encryption set while a key rotation is in progress. It
        /// will be empty if there is no ongoing key rotation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.previousKeys")]
        public IList<KeyVaultAndKeyReference> PreviousKeys { get; private set; }

        /// <summary>
        /// Gets the disk encryption set provisioning state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (ActiveKey != null)
            {
                ActiveKey.Validate();
            }
            if (PreviousKeys != null)
            {
                foreach (var element in PreviousKeys)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
