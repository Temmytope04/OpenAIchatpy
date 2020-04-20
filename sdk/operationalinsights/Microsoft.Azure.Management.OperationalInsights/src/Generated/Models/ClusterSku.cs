// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The cluster sku definition.
    /// </summary>
    public partial class ClusterSku
    {
        /// <summary>
        /// Initializes a new instance of the ClusterSku class.
        /// </summary>
        public ClusterSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClusterSku class.
        /// </summary>
        /// <param name="capacity">The capacity value</param>
        /// <param name="name">The name of the SKU. Possible values include:
        /// 'CapacityReservation'</param>
        public ClusterSku(long? capacity = default(long?), string name = default(string))
        {
            Capacity = capacity;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the capacity value
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public long? Capacity { get; set; }

        /// <summary>
        /// Gets or sets the name of the SKU. Possible values include:
        /// 'CapacityReservation'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
