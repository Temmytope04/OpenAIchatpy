// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    /// <summary> AppInsights credentials. </summary>
    public partial class AppInsightsCredentials
    {
        /// <summary> Initializes a new instance of <see cref="AppInsightsCredentials"/>. </summary>
        internal AppInsightsCredentials()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppInsightsCredentials"/>. </summary>
        /// <param name="appId"> The AppInsights application ID. </param>
        /// <param name="instrumentationKey"> The AppInsights instrumentation key. This is not returned in response of GET/PUT on the resource. To see this please call listKeys API. </param>
        internal AppInsightsCredentials(string appId, string instrumentationKey)
        {
            AppId = appId;
            InstrumentationKey = instrumentationKey;
        }

        /// <summary> The AppInsights application ID. </summary>
        public string AppId { get; }
        /// <summary> The AppInsights instrumentation key. This is not returned in response of GET/PUT on the resource. To see this please call listKeys API. </summary>
        public string InstrumentationKey { get; }
    }
}
