// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Elastic.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Microsoft.Elastic SKU.
    /// </summary>
    public partial class ResourceSku
    {
        /// <summary>
        /// Initializes a new instance of the ResourceSku class.
        /// </summary>
        public ResourceSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceSku class.
        /// </summary>
        /// <param name="name">Name of the SKU.</param>
        public ResourceSku(string name)
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the SKU.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
