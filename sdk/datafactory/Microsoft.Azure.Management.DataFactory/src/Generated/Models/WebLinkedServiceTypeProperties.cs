// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Base definition of WebLinkedServiceTypeProperties, this typeProperties
    /// is polymorphic based on authenticationType, so not flattened in SDK
    /// models.
    /// </summary>
    public partial class WebLinkedServiceTypeProperties
    {
        /// <summary>
        /// Initializes a new instance of the WebLinkedServiceTypeProperties
        /// class.
        /// </summary>
        public WebLinkedServiceTypeProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebLinkedServiceTypeProperties
        /// class.
        /// </summary>
        /// <param name="url">The URL of the web service endpoint, e.g.
        /// https://www.microsoft.com . Type: string (or Expression with
        /// resultType string).</param>
        public WebLinkedServiceTypeProperties(object url)
        {
            Url = url;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL of the web service endpoint, e.g.
        /// https://www.microsoft.com . Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public object Url { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
        }
    }
}
