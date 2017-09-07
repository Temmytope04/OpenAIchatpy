// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.WebSites;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Function secrets.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FunctionSecrets : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the FunctionSecrets class.
        /// </summary>
        public FunctionSecrets()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FunctionSecrets class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="key">Secret key.</param>
        /// <param name="triggerUrl">Trigger URL.</param>
        public FunctionSecrets(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string key = default(string), string triggerUrl = default(string))
            : base(id, name, kind, type)
        {
            Key = key;
            TriggerUrl = triggerUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets secret key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets trigger URL.
        /// </summary>
        [JsonProperty(PropertyName = "properties.triggerUrl")]
        public string TriggerUrl { get; set; }

    }
}
