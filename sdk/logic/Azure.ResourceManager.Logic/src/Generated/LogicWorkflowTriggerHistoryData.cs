// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Logic.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A class representing the LogicWorkflowTriggerHistory data model.
    /// The workflow trigger history.
    /// </summary>
    public partial class LogicWorkflowTriggerHistoryData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="LogicWorkflowTriggerHistoryData"/>. </summary>
        internal LogicWorkflowTriggerHistoryData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowTriggerHistoryData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="startOn"> Gets the start time. </param>
        /// <param name="endOn"> Gets the end time. </param>
        /// <param name="scheduledOn"> The scheduled time. </param>
        /// <param name="status"> Gets the status. </param>
        /// <param name="code"> Gets the code. </param>
        /// <param name="error"> Gets the error. </param>
        /// <param name="trackingId"> Gets the tracking id. </param>
        /// <param name="correlation"> The run correlation. </param>
        /// <param name="inputsLink"> Gets the link to input parameters. </param>
        /// <param name="outputsLink"> Gets the link to output parameters. </param>
        /// <param name="isFired"> The value indicating whether trigger was fired. </param>
        /// <param name="run"> Gets the reference to workflow run. </param>
        internal LogicWorkflowTriggerHistoryData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? startOn, DateTimeOffset? endOn, DateTimeOffset? scheduledOn, LogicWorkflowStatus? status, string code, BinaryData error, Guid? trackingId, Correlation correlation, LogicContentLink inputsLink, LogicContentLink outputsLink, bool? isFired, LogicResourceReference run) : base(id, name, resourceType, systemData)
        {
            StartOn = startOn;
            EndOn = endOn;
            ScheduledOn = scheduledOn;
            Status = status;
            Code = code;
            Error = error;
            TrackingId = trackingId;
            Correlation = correlation;
            InputsLink = inputsLink;
            OutputsLink = outputsLink;
            IsFired = isFired;
            Run = run;
        }

        /// <summary> Gets the start time. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Gets the end time. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> The scheduled time. </summary>
        public DateTimeOffset? ScheduledOn { get; }
        /// <summary> Gets the status. </summary>
        public LogicWorkflowStatus? Status { get; }
        /// <summary> Gets the code. </summary>
        public string Code { get; }
        /// <summary>
        /// Gets the error.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Error { get; }
        /// <summary> Gets the tracking id. </summary>
        public Guid? TrackingId { get; }
        /// <summary> The run correlation. </summary>
        internal Correlation Correlation { get; }
        /// <summary> The client tracking id. </summary>
        public string CorrelationClientTrackingId
        {
            get => Correlation?.ClientTrackingId;
        }

        /// <summary> Gets the link to input parameters. </summary>
        public LogicContentLink InputsLink { get; }
        /// <summary> Gets the link to output parameters. </summary>
        public LogicContentLink OutputsLink { get; }
        /// <summary> The value indicating whether trigger was fired. </summary>
        public bool? IsFired { get; }
        /// <summary> Gets the reference to workflow run. </summary>
        public LogicResourceReference Run { get; }
    }
}
