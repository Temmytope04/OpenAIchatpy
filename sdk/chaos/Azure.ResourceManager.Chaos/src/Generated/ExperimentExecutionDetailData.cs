// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Chaos.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Chaos
{
    /// <summary>
    /// A class representing the ExperimentExecutionDetail data model.
    /// Model that represents the execution details of a Experiment.
    /// </summary>
    public partial class ExperimentExecutionDetailData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ExperimentExecutionDetailData"/>. </summary>
        internal ExperimentExecutionDetailData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExperimentExecutionDetailData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="experimentId"> The id of the experiment. </param>
        /// <param name="status"> The value of the status of the experiment execution. </param>
        /// <param name="failureReason"> The reason why the execution failed. </param>
        /// <param name="createdOn"> String that represents the created date time. </param>
        /// <param name="lastActionOn"> String that represents the last action date time. </param>
        /// <param name="startOn"> String that represents the start date time. </param>
        /// <param name="stopOn"> String that represents the stop date time. </param>
        /// <param name="runInformation"> The information of the experiment run. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ExperimentExecutionDetailData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string experimentId, string status, string failureReason, DateTimeOffset? createdOn, DateTimeOffset? lastActionOn, DateTimeOffset? startOn, DateTimeOffset? stopOn, ExperimentExecutionDetailsPropertiesRunInformation runInformation, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            ExperimentId = experimentId;
            Status = status;
            FailureReason = failureReason;
            CreatedOn = createdOn;
            LastActionOn = lastActionOn;
            StartOn = startOn;
            StopOn = stopOn;
            RunInformation = runInformation;
            _rawData = rawData;
        }

        /// <summary> The id of the experiment. </summary>
        public string ExperimentId { get; }
        /// <summary> The value of the status of the experiment execution. </summary>
        public string Status { get; }
        /// <summary> The reason why the execution failed. </summary>
        public string FailureReason { get; }
        /// <summary> String that represents the created date time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> String that represents the last action date time. </summary>
        public DateTimeOffset? LastActionOn { get; }
        /// <summary> String that represents the start date time. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> String that represents the stop date time. </summary>
        public DateTimeOffset? StopOn { get; }
        /// <summary> The information of the experiment run. </summary>
        internal ExperimentExecutionDetailsPropertiesRunInformation RunInformation { get; }
        /// <summary> The steps of the experiment run. </summary>
        public IReadOnlyList<StepStatus> RunInformationSteps
        {
            get => RunInformation?.Steps;
        }
    }
}
