// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Resource metrics service provided by Microsoft.Insights resource provider. </summary>
    public partial class ServiceSpecification
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ServiceSpecification"/>. </summary>
        internal ServiceSpecification()
        {
            MetricSpecifications = new ChangeTrackingList<MetricSpecification>();
            LogSpecifications = new ChangeTrackingList<LogSpecification>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceSpecification"/>. </summary>
        /// <param name="metricSpecifications"></param>
        /// <param name="logSpecifications"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceSpecification(IReadOnlyList<MetricSpecification> metricSpecifications, IReadOnlyList<LogSpecification> logSpecifications, Dictionary<string, BinaryData> rawData)
        {
            MetricSpecifications = metricSpecifications;
            LogSpecifications = logSpecifications;
            _rawData = rawData;
        }

        /// <summary> Gets the metric specifications. </summary>
        public IReadOnlyList<MetricSpecification> MetricSpecifications { get; }
        /// <summary> Gets the log specifications. </summary>
        public IReadOnlyList<LogSpecification> LogSpecifications { get; }
    }
}
