// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.KeyVault.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameters for patching a secret
    /// </summary>
    public partial class SecretPatchParameters : IResource
    {
        /// <summary>
        /// Initializes a new instance of the SecretPatchParameters class.
        /// </summary>
        public SecretPatchParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecretPatchParameters class.
        /// </summary>
        /// <param name="tags">The tags that will be assigned to the secret.
        /// </param>
        /// <param name="properties">Properties of the secret</param>
        public SecretPatchParameters(IDictionary<string, string> tags = default(IDictionary<string, string>), SecretPatchProperties properties = default(SecretPatchProperties))
        {
            Tags = tags;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the tags that will be assigned to the secret.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets properties of the secret
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public SecretPatchProperties Properties { get; set; }

    }
}
