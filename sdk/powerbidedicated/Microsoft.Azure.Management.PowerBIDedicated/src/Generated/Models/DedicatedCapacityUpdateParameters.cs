// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PowerBIDedicated.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Provision request specification
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DedicatedCapacityUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the DedicatedCapacityUpdateParameters
        /// class.
        /// </summary>
        public DedicatedCapacityUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DedicatedCapacityUpdateParameters
        /// class.
        /// </summary>
        /// <param name="sku">The SKU of the Dedicated capacity
        /// resource.</param>
        /// <param name="tags">Key-value pairs of additional provisioning
        /// properties.</param>
        /// <param name="administration">A collection of Dedicated capacity
        /// administrators</param>
        /// <param name="mode">The capacity mode. Possible values include:
        /// 'Gen1', 'Gen2'</param>
        public DedicatedCapacityUpdateParameters(CapacitySku sku = default(CapacitySku), IDictionary<string, string> tags = default(IDictionary<string, string>), DedicatedCapacityAdministrators administration = default(DedicatedCapacityAdministrators), string mode = default(string))
        {
            Sku = sku;
            Tags = tags;
            Administration = administration;
            Mode = mode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the SKU of the Dedicated capacity resource.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public CapacitySku Sku { get; set; }

        /// <summary>
        /// Gets or sets key-value pairs of additional provisioning properties.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets a collection of Dedicated capacity administrators
        /// </summary>
        [JsonProperty(PropertyName = "properties.administration")]
        public DedicatedCapacityAdministrators Administration { get; set; }

        /// <summary>
        /// Gets or sets the capacity mode. Possible values include: 'Gen1',
        /// 'Gen2'
        /// </summary>
        [JsonProperty(PropertyName = "properties.mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
