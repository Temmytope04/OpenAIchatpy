// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> The ConfigurationQueriesTestResponse. </summary>
    public partial class ConfigurationQueriesTestResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ConfigurationQueriesTestResponse"/>. </summary>
        internal ConfigurationQueriesTestResponse()
        {
            CustomMetricQueryErrors = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ConfigurationQueriesTestResponse"/>. </summary>
        /// <param name="targetConditionError"> The errors from running the target condition query. </param>
        /// <param name="customMetricQueryErrors"> The errors from running the custom metric query. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConfigurationQueriesTestResponse(string targetConditionError, IReadOnlyDictionary<string, string> customMetricQueryErrors, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TargetConditionError = targetConditionError;
            CustomMetricQueryErrors = customMetricQueryErrors;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The errors from running the target condition query. </summary>
        public string TargetConditionError { get; }
        /// <summary> The errors from running the custom metric query. </summary>
        public IReadOnlyDictionary<string, string> CustomMetricQueryErrors { get; }
    }
}
