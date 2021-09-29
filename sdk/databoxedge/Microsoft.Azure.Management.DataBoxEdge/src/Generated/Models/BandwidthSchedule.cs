// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The bandwidth schedule details.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BandwidthSchedule : ARMBaseModel
    {
        /// <summary>
        /// Initializes a new instance of the BandwidthSchedule class.
        /// </summary>
        public BandwidthSchedule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BandwidthSchedule class.
        /// </summary>
        /// <param name="start">The start time of the schedule in UTC.</param>
        /// <param name="stop">The stop time of the schedule in UTC.</param>
        /// <param name="rateInMbps">The bandwidth rate in Mbps.</param>
        /// <param name="days">The days of the week when this schedule is
        /// applicable.</param>
        /// <param name="id">The path ID that uniquely identifies the
        /// object.</param>
        /// <param name="name">The object name.</param>
        /// <param name="type">The hierarchical type of the object.</param>
        /// <param name="systemData">Bandwidth object related to ASE
        /// resource</param>
        public BandwidthSchedule(string start, string stop, int rateInMbps, IList<string> days, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData))
            : base(id, name, type)
        {
            SystemData = systemData;
            Start = start;
            Stop = stop;
            RateInMbps = rateInMbps;
            Days = days;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets bandwidth object related to ASE resource
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; set; }

        /// <summary>
        /// Gets or sets the start time of the schedule in UTC.
        /// </summary>
        [JsonProperty(PropertyName = "properties.start")]
        public string Start { get; set; }

        /// <summary>
        /// Gets or sets the stop time of the schedule in UTC.
        /// </summary>
        [JsonProperty(PropertyName = "properties.stop")]
        public string Stop { get; set; }

        /// <summary>
        /// Gets or sets the bandwidth rate in Mbps.
        /// </summary>
        [JsonProperty(PropertyName = "properties.rateInMbps")]
        public int RateInMbps { get; set; }

        /// <summary>
        /// Gets or sets the days of the week when this schedule is applicable.
        /// </summary>
        [JsonProperty(PropertyName = "properties.days")]
        public IList<string> Days { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Start == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Start");
            }
            if (Stop == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Stop");
            }
            if (Days == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Days");
            }
        }
    }
}
