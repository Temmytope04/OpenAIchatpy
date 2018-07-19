// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.TrafficManager.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class representing a Traffic Manager HeatMap traffic flow properties.
    /// </summary>
    public partial class TrafficFlow
    {
        /// <summary>
        /// Initializes a new instance of the TrafficFlow class.
        /// </summary>
        public TrafficFlow()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TrafficFlow class.
        /// </summary>
        /// <param name="sourceIp">The IP address that this query experience
        /// originated from.</param>
        /// <param name="latitude">The approximate latitude that these queries
        /// originated from.</param>
        /// <param name="longitude">The approximate longitude that these
        /// queries originated from.</param>
        /// <param name="queryExperiences">The query experiences produced in
        /// this HeatMap calculation.</param>
        public TrafficFlow(string sourceIp = default(string), double? latitude = default(double?), double? longitude = default(double?), IList<QueryExperience> queryExperiences = default(IList<QueryExperience>))
        {
            SourceIp = sourceIp;
            Latitude = latitude;
            Longitude = longitude;
            QueryExperiences = queryExperiences;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the IP address that this query experience originated
        /// from.
        /// </summary>
        [JsonProperty(PropertyName = "sourceIp")]
        public string SourceIp { get; set; }

        /// <summary>
        /// Gets or sets the approximate latitude that these queries originated
        /// from.
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// Gets or sets the approximate longitude that these queries
        /// originated from.
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public double? Longitude { get; set; }

        /// <summary>
        /// Gets or sets the query experiences produced in this HeatMap
        /// calculation.
        /// </summary>
        [JsonProperty(PropertyName = "queryExperiences")]
        public IList<QueryExperience> QueryExperiences { get; set; }

    }
}
