// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Information on the configuration of flow log and traffic analytics (optional) . </summary>
    public partial class FlowLogInformation
    {
        /// <summary> Initializes a new instance of FlowLogInformation. </summary>
        /// <param name="targetResourceId"> The ID of the resource to configure for flow log and traffic analytics (optional) . </param>
        /// <param name="storageId"> ID of the storage account which is used to store the flow log. </param>
        /// <param name="enabled"> Flag to enable/disable flow logging. </param>
        public FlowLogInformation(string targetResourceId, string storageId, bool enabled)
        {
            if (targetResourceId == null)
            {
                throw new ArgumentNullException(nameof(targetResourceId));
            }
            if (storageId == null)
            {
                throw new ArgumentNullException(nameof(storageId));
            }

            TargetResourceId = targetResourceId;
            StorageId = storageId;
            Enabled = enabled;
        }

        /// <summary> Initializes a new instance of FlowLogInformation. </summary>
        /// <param name="targetResourceId"> The ID of the resource to configure for flow log and traffic analytics (optional) . </param>
        /// <param name="flowAnalyticsConfiguration"> Parameters that define the configuration of traffic analytics. </param>
        /// <param name="storageId"> ID of the storage account which is used to store the flow log. </param>
        /// <param name="enabled"> Flag to enable/disable flow logging. </param>
        /// <param name="retentionPolicy"> Parameters that define the retention policy for flow log. </param>
        /// <param name="format"> Parameters that define the flow log format. </param>
        internal FlowLogInformation(string targetResourceId, TrafficAnalyticsProperties flowAnalyticsConfiguration, string storageId, bool enabled, RetentionPolicyParameters retentionPolicy, FlowLogFormatParameters format)
        {
            TargetResourceId = targetResourceId;
            FlowAnalyticsConfiguration = flowAnalyticsConfiguration;
            StorageId = storageId;
            Enabled = enabled;
            RetentionPolicy = retentionPolicy;
            Format = format;
        }

        /// <summary> The ID of the resource to configure for flow log and traffic analytics (optional) . </summary>
        public string TargetResourceId { get; set; }
        /// <summary> Parameters that define the configuration of traffic analytics. </summary>
        public TrafficAnalyticsProperties FlowAnalyticsConfiguration { get; set; }
        /// <summary> ID of the storage account which is used to store the flow log. </summary>
        public string StorageId { get; set; }
        /// <summary> Flag to enable/disable flow logging. </summary>
        public bool Enabled { get; set; }
        /// <summary> Parameters that define the retention policy for flow log. </summary>
        public RetentionPolicyParameters RetentionPolicy { get; set; }
        /// <summary> Parameters that define the flow log format. </summary>
        public FlowLogFormatParameters Format { get; set; }
    }
}
