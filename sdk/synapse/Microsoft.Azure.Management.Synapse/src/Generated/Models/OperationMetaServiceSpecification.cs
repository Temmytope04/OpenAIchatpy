// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// What is this?
    /// </summary>
    public partial class OperationMetaServiceSpecification
    {
        /// <summary>
        /// Initializes a new instance of the OperationMetaServiceSpecification
        /// class.
        /// </summary>
        public OperationMetaServiceSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationMetaServiceSpecification
        /// class.
        /// </summary>
        /// <param name="metricSpecifications">Service metric
        /// specifications</param>
        /// <param name="logSpecifications">Service log specifications</param>
        public OperationMetaServiceSpecification(IList<OperationMetaMetricSpecification> metricSpecifications = default(IList<OperationMetaMetricSpecification>), IList<OperationMetaLogSpecification> logSpecifications = default(IList<OperationMetaLogSpecification>))
        {
            MetricSpecifications = metricSpecifications;
            LogSpecifications = logSpecifications;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets service metric specifications
        /// </summary>
        [JsonProperty(PropertyName = "metricSpecifications")]
        public IList<OperationMetaMetricSpecification> MetricSpecifications { get; set; }

        /// <summary>
        /// Gets or sets service log specifications
        /// </summary>
        [JsonProperty(PropertyName = "logSpecifications")]
        public IList<OperationMetaLogSpecification> LogSpecifications { get; set; }

    }
}
