// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Authorization.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details of the principal
    /// </summary>
    public partial class ExpandedPropertiesPrincipal
    {
        /// <summary>
        /// Initializes a new instance of the ExpandedPropertiesPrincipal
        /// class.
        /// </summary>
        public ExpandedPropertiesPrincipal()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExpandedPropertiesPrincipal
        /// class.
        /// </summary>
        /// <param name="id">Id of the principal</param>
        /// <param name="displayName">Display name of the principal</param>
        /// <param name="email">Email id of the principal</param>
        /// <param name="type">Type of the principal</param>
        public ExpandedPropertiesPrincipal(string id = default(string), string displayName = default(string), string email = default(string), string type = default(string))
        {
            Id = id;
            DisplayName = displayName;
            Email = email;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of the principal
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets display name of the principal
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets email id of the principal
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets type of the principal
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
