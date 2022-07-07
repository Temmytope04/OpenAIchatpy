// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Instance view statuses.
    /// </summary>
    public partial class InstanceViewStatusesSummary
    {
        /// <summary>
        /// Initializes a new instance of the InstanceViewStatusesSummary
        /// class.
        /// </summary>
        public InstanceViewStatusesSummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InstanceViewStatusesSummary
        /// class.
        /// </summary>
        /// <param name="statusesSummary">The summary.</param>
        public InstanceViewStatusesSummary(IList<StatusCodeCount> statusesSummary = default(IList<StatusCodeCount>))
        {
            StatusesSummary = statusesSummary;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the summary.
        /// </summary>
        [JsonProperty(PropertyName = "statusesSummary")]
        public IList<StatusCodeCount> StatusesSummary { get; private set; }

    }
}
