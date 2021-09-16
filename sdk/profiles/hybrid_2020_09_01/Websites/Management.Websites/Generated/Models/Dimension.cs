// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Dimension of a resource metric. For e.g. instance specific HTTP
    /// requests for a web app,
    /// where instance name is dimension of the metric HTTP request
    /// </summary>
    public partial class Dimension
    {
        /// <summary>
        /// Initializes a new instance of the Dimension class.
        /// </summary>
        public Dimension()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Dimension class.
        /// </summary>
        public Dimension(string name = default(string), string displayName = default(string), string internalName = default(string), bool? toBeExportedForShoebox = default(bool?))
        {
            Name = name;
            DisplayName = displayName;
            InternalName = internalName;
            ToBeExportedForShoebox = toBeExportedForShoebox;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "internalName")]
        public string InternalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "toBeExportedForShoebox")]
        public bool? ToBeExportedForShoebox { get; set; }

    }
}
