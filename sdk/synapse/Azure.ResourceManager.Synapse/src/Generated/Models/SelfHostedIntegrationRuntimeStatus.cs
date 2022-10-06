// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Self-hosted integration runtime status. </summary>
    public partial class SelfHostedIntegrationRuntimeStatus : IntegrationRuntimeStatus
    {
        /// <summary> Initializes a new instance of SelfHostedIntegrationRuntimeStatus. </summary>
        internal SelfHostedIntegrationRuntimeStatus()
        {
            Nodes = new ChangeTrackingList<SelfHostedIntegrationRuntimeNode>();
            Capabilities = new ChangeTrackingDictionary<string, string>();
            ServiceUrls = new ChangeTrackingList<string>();
            Links = new ChangeTrackingList<LinkedIntegrationRuntime>();
            NewerVersions = new ChangeTrackingList<string>();
            RuntimeType = IntegrationRuntimeType.SelfHosted;
        }

        /// <summary> Initializes a new instance of SelfHostedIntegrationRuntimeStatus. </summary>
        /// <param name="runtimeType"> Type of integration runtime. </param>
        /// <param name="dataFactoryName"> The workspace name which the integration runtime belong to. </param>
        /// <param name="state"> The state of integration runtime. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="createOn"> The time at which the integration runtime was created, in ISO8601 format. </param>
        /// <param name="taskQueueId"> The task queue id of the integration runtime. </param>
        /// <param name="nodeCommunicationChannelEncryptionMode"> The node communication Channel encryption mode. </param>
        /// <param name="internalChannelEncryption"> It is used to set the encryption mode for node-node communication channel (when more than 2 self-hosted integration runtime nodes exist). </param>
        /// <param name="version"> Version of the integration runtime. </param>
        /// <param name="nodes"> The list of nodes for this integration runtime. </param>
        /// <param name="scheduledUpdateOn"> The date at which the integration runtime will be scheduled to update, in ISO8601 format. </param>
        /// <param name="updateDelayOffset"> The time in the date scheduled by service to update the integration runtime, e.g., PT03H is 3 hours. </param>
        /// <param name="localTimeZoneOffset"> The local time zone offset in hours. </param>
        /// <param name="capabilities"> Object with additional information about integration runtime capabilities. </param>
        /// <param name="serviceUrls"> The URLs for the services used in integration runtime backend service. </param>
        /// <param name="autoUpdate"> Whether Self-hosted integration runtime auto update has been turned on. </param>
        /// <param name="versionStatus"> Status of the integration runtime version. </param>
        /// <param name="links"> The list of linked integration runtimes that are created to share with this integration runtime. </param>
        /// <param name="pushedVersion"> The version that the integration runtime is going to update to. </param>
        /// <param name="latestVersion"> The latest version on download center. </param>
        /// <param name="autoUpdateETA"> The estimated time when the self-hosted integration runtime will be updated. </param>
        /// <param name="serviceRegion"> The service region of the integration runtime. </param>
        /// <param name="newerVersions"> The newer versions on download center. </param>
        internal SelfHostedIntegrationRuntimeStatus(IntegrationRuntimeType runtimeType, string dataFactoryName, IntegrationRuntimeState? state, IReadOnlyDictionary<string, BinaryData> additionalProperties, DateTimeOffset? createOn, string taskQueueId, string nodeCommunicationChannelEncryptionMode, IntegrationRuntimeInternalChannelEncryptionMode? internalChannelEncryption, string version, IReadOnlyList<SelfHostedIntegrationRuntimeNode> nodes, DateTimeOffset? scheduledUpdateOn, string updateDelayOffset, string localTimeZoneOffset, IReadOnlyDictionary<string, string> capabilities, IReadOnlyList<string> serviceUrls, IntegrationRuntimeAutoUpdate? autoUpdate, string versionStatus, IReadOnlyList<LinkedIntegrationRuntime> links, string pushedVersion, string latestVersion, DateTimeOffset? autoUpdateETA, string serviceRegion, IReadOnlyList<string> newerVersions) : base(runtimeType, dataFactoryName, state, additionalProperties)
        {
            CreateOn = createOn;
            TaskQueueId = taskQueueId;
            NodeCommunicationChannelEncryptionMode = nodeCommunicationChannelEncryptionMode;
            InternalChannelEncryption = internalChannelEncryption;
            Version = version;
            Nodes = nodes;
            ScheduledUpdateOn = scheduledUpdateOn;
            UpdateDelayOffset = updateDelayOffset;
            LocalTimeZoneOffset = localTimeZoneOffset;
            Capabilities = capabilities;
            ServiceUrls = serviceUrls;
            AutoUpdate = autoUpdate;
            VersionStatus = versionStatus;
            Links = links;
            PushedVersion = pushedVersion;
            LatestVersion = latestVersion;
            AutoUpdateETA = autoUpdateETA;
            ServiceRegion = serviceRegion;
            NewerVersions = newerVersions;
            RuntimeType = runtimeType;
        }

        /// <summary> The time at which the integration runtime was created, in ISO8601 format. </summary>
        public DateTimeOffset? CreateOn { get; }
        /// <summary> The task queue id of the integration runtime. </summary>
        public string TaskQueueId { get; }
        /// <summary> The node communication Channel encryption mode. </summary>
        public string NodeCommunicationChannelEncryptionMode { get; }
        /// <summary> It is used to set the encryption mode for node-node communication channel (when more than 2 self-hosted integration runtime nodes exist). </summary>
        public IntegrationRuntimeInternalChannelEncryptionMode? InternalChannelEncryption { get; }
        /// <summary> Version of the integration runtime. </summary>
        public string Version { get; }
        /// <summary> The list of nodes for this integration runtime. </summary>
        public IReadOnlyList<SelfHostedIntegrationRuntimeNode> Nodes { get; }
        /// <summary> The date at which the integration runtime will be scheduled to update, in ISO8601 format. </summary>
        public DateTimeOffset? ScheduledUpdateOn { get; }
        /// <summary> The time in the date scheduled by service to update the integration runtime, e.g., PT03H is 3 hours. </summary>
        public string UpdateDelayOffset { get; }
        /// <summary> The local time zone offset in hours. </summary>
        public string LocalTimeZoneOffset { get; }
        /// <summary> Object with additional information about integration runtime capabilities. </summary>
        public IReadOnlyDictionary<string, string> Capabilities { get; }
        /// <summary> The URLs for the services used in integration runtime backend service. </summary>
        public IReadOnlyList<string> ServiceUrls { get; }
        /// <summary> Whether Self-hosted integration runtime auto update has been turned on. </summary>
        public IntegrationRuntimeAutoUpdate? AutoUpdate { get; }
        /// <summary> Status of the integration runtime version. </summary>
        public string VersionStatus { get; }
        /// <summary> The list of linked integration runtimes that are created to share with this integration runtime. </summary>
        public IReadOnlyList<LinkedIntegrationRuntime> Links { get; }
        /// <summary> The version that the integration runtime is going to update to. </summary>
        public string PushedVersion { get; }
        /// <summary> The latest version on download center. </summary>
        public string LatestVersion { get; }
        /// <summary> The estimated time when the self-hosted integration runtime will be updated. </summary>
        public DateTimeOffset? AutoUpdateETA { get; }
        /// <summary> The service region of the integration runtime. </summary>
        public string ServiceRegion { get; }
        /// <summary> The newer versions on download center. </summary>
        public IReadOnlyList<string> NewerVersions { get; }
    }
}
