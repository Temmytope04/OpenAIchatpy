// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The details of metric specifications.
    /// </summary>
    public partial class MetricSpecifications
    {
        /// <summary>
        /// Initializes a new instance of the MetricSpecifications class.
        /// </summary>
        public MetricSpecifications()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricSpecifications class.
        /// </summary>
        /// <param name="name">The name of the metric specification.</param>
        /// <param name="displayName">The display name of the metric
        /// specification.</param>
        /// <param name="displayDescription">The display description of the
        /// metric specification.</param>
        /// <param name="unit">The unit of the metric specification.</param>
        /// <param name="aggregationType">The aggregation type of the metric
        /// specification.</param>
        /// <param name="supportedAggregationTypes">The supported aggregation
        /// types of the metric specification.</param>
        /// <param name="supportedTimeGrainTypes">The supported time grain
        /// types of the metric specification.</param>
        /// <param name="enableRegionalMdmAccount">The flag indicates whether
        /// enable regional mdm account or not.</param>
        /// <param name="sourceMdmAccount">The source mdm account.</param>
        /// <param name="sourceMdmNamespace">The source mdm namespace.</param>
        /// <param name="metricFilterPattern">The metric filter
        /// pattern.</param>
        /// <param name="fillGapWithZero">The flag indicates whether filling
        /// gap with zero.</param>
        /// <param name="category">The category of the metric.</param>
        /// <param name="resourceIdDimensionNameOverride">The override name of
        /// resource id dimension name.</param>
        /// <param name="isInternal">The flag indicates whether the metric is
        /// internal or not.</param>
        /// <param name="delegateMetricNameOverride">The override name of
        /// delegate metric.</param>
        /// <param name="dimensions">The dimensions of the metric
        /// specification.</param>
        public MetricSpecifications(string name = default(string), string displayName = default(string), string displayDescription = default(string), string unit = default(string), string aggregationType = default(string), IList<string> supportedAggregationTypes = default(IList<string>), IList<string> supportedTimeGrainTypes = default(IList<string>), bool? enableRegionalMdmAccount = default(bool?), string sourceMdmAccount = default(string), string sourceMdmNamespace = default(string), string metricFilterPattern = default(string), bool? fillGapWithZero = default(bool?), string category = default(string), string resourceIdDimensionNameOverride = default(string), bool? isInternal = default(bool?), string delegateMetricNameOverride = default(string), IList<Dimension> dimensions = default(IList<Dimension>))
        {
            Name = name;
            DisplayName = displayName;
            DisplayDescription = displayDescription;
            Unit = unit;
            AggregationType = aggregationType;
            SupportedAggregationTypes = supportedAggregationTypes;
            SupportedTimeGrainTypes = supportedTimeGrainTypes;
            EnableRegionalMdmAccount = enableRegionalMdmAccount;
            SourceMdmAccount = sourceMdmAccount;
            SourceMdmNamespace = sourceMdmNamespace;
            MetricFilterPattern = metricFilterPattern;
            FillGapWithZero = fillGapWithZero;
            Category = category;
            ResourceIdDimensionNameOverride = resourceIdDimensionNameOverride;
            IsInternal = isInternal;
            DelegateMetricNameOverride = delegateMetricNameOverride;
            Dimensions = dimensions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the metric specification.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display name of the metric specification.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the display description of the metric specification.
        /// </summary>
        [JsonProperty(PropertyName = "displayDescription")]
        public string DisplayDescription { get; set; }

        /// <summary>
        /// Gets or sets the unit of the metric specification.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets the aggregation type of the metric specification.
        /// </summary>
        [JsonProperty(PropertyName = "aggregationType")]
        public string AggregationType { get; set; }

        /// <summary>
        /// Gets or sets the supported aggregation types of the metric
        /// specification.
        /// </summary>
        [JsonProperty(PropertyName = "supportedAggregationTypes")]
        public IList<string> SupportedAggregationTypes { get; set; }

        /// <summary>
        /// Gets or sets the supported time grain types of the metric
        /// specification.
        /// </summary>
        [JsonProperty(PropertyName = "supportedTimeGrainTypes")]
        public IList<string> SupportedTimeGrainTypes { get; set; }

        /// <summary>
        /// Gets or sets the flag indicates whether enable regional mdm account
        /// or not.
        /// </summary>
        [JsonProperty(PropertyName = "enableRegionalMdmAccount")]
        public bool? EnableRegionalMdmAccount { get; set; }

        /// <summary>
        /// Gets or sets the source mdm account.
        /// </summary>
        [JsonProperty(PropertyName = "sourceMdmAccount")]
        public string SourceMdmAccount { get; set; }

        /// <summary>
        /// Gets or sets the source mdm namespace.
        /// </summary>
        [JsonProperty(PropertyName = "sourceMdmNamespace")]
        public string SourceMdmNamespace { get; set; }

        /// <summary>
        /// Gets or sets the metric filter pattern.
        /// </summary>
        [JsonProperty(PropertyName = "metricFilterPattern")]
        public string MetricFilterPattern { get; set; }

        /// <summary>
        /// Gets or sets the flag indicates whether filling gap with zero.
        /// </summary>
        [JsonProperty(PropertyName = "fillGapWithZero")]
        public bool? FillGapWithZero { get; set; }

        /// <summary>
        /// Gets or sets the category of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the override name of resource id dimension name.
        /// </summary>
        [JsonProperty(PropertyName = "resourceIdDimensionNameOverride")]
        public string ResourceIdDimensionNameOverride { get; set; }

        /// <summary>
        /// Gets or sets the flag indicates whether the metric is internal or
        /// not.
        /// </summary>
        [JsonProperty(PropertyName = "isInternal")]
        public bool? IsInternal { get; set; }

        /// <summary>
        /// Gets or sets the override name of delegate metric.
        /// </summary>
        [JsonProperty(PropertyName = "delegateMetricNameOverride")]
        public string DelegateMetricNameOverride { get; set; }

        /// <summary>
        /// Gets or sets the dimensions of the metric specification.
        /// </summary>
        [JsonProperty(PropertyName = "dimensions")]
        public IList<Dimension> Dimensions { get; set; }

    }
}
