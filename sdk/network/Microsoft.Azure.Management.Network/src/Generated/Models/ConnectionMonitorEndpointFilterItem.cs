// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the connection monitor endpoint filter item.
    /// </summary>
    public partial class ConnectionMonitorEndpointFilterItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ConnectionMonitorEndpointFilterItem class.
        /// </summary>
        public ConnectionMonitorEndpointFilterItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ConnectionMonitorEndpointFilterItem class.
        /// </summary>
        /// <param name="type">The type of item included in the filter.
        /// Currently only 'AgentAddress' is supported. Possible values
        /// include: 'AgentAddress'</param>
        /// <param name="address">The address of the filter item.</param>
        public ConnectionMonitorEndpointFilterItem(string type = default(string), string address = default(string))
        {
            Type = type;
            Address = address;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of item included in the filter. Currently
        /// only 'AgentAddress' is supported. Possible values include:
        /// 'AgentAddress'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the address of the filter item.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

    }
}
