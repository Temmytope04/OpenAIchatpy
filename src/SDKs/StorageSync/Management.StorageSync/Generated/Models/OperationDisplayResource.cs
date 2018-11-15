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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Operation Display Resource object.
    /// </summary>
    public partial class OperationDisplayResource
    {
        /// <summary>
        /// Initializes a new instance of the OperationDisplayResource class.
        /// </summary>
        public OperationDisplayResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationDisplayResource class.
        /// </summary>
        /// <param name="provider">Operation Display Resource Provider.</param>
        /// <param name="resource">Operation Display Resource.</param>
        /// <param name="operation">Operation Display Resource
        /// Operation.</param>
        /// <param name="description">Operation Display Resource
        /// Description.</param>
        public OperationDisplayResource(string provider = default(string), string resource = default(string), string operation = default(string), string description = default(string))
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets operation Display Resource Provider.
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets operation Display Resource.
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Gets or sets operation Display Resource Operation.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or sets operation Display Resource Description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
