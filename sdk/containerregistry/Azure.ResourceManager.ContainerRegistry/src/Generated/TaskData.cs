// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerRegistry.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary> A class representing the Task data model. </summary>
    public partial class TaskData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of TaskData. </summary>
        /// <param name="location"> The location. </param>
        public TaskData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of TaskData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Identity for the resource. </param>
        /// <param name="provisioningState"> The provisioning state of the task. </param>
        /// <param name="createdOn"> The creation date of task. </param>
        /// <param name="status"> The current status of task. </param>
        /// <param name="platform"> The platform properties against which the run has to happen. </param>
        /// <param name="agentConfiguration"> The machine configuration of the run agent. </param>
        /// <param name="agentPoolName"> The dedicated agent pool for the task. </param>
        /// <param name="timeout"> Run timeout in seconds. </param>
        /// <param name="step">
        /// The properties of a task step.
        /// Please note <see cref="TaskStepProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DockerBuildStep"/>, <see cref="EncodedTaskStep"/> and <see cref="FileTaskStep"/>.
        /// </param>
        /// <param name="trigger"> The properties that describe all triggers for the task. </param>
        /// <param name="credentials"> The properties that describes a set of credentials that will be used when this run is invoked. </param>
        /// <param name="logTemplate"> The template that describes the repository and tag information for run log artifact. </param>
        /// <param name="isSystemTask"> The value of this property indicates whether the task resource is system task or not. </param>
        internal TaskData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IdentityProperties identity, ProvisioningState? provisioningState, DateTimeOffset? createdOn, TaskStatus? status, PlatformProperties platform, AgentProperties agentConfiguration, string agentPoolName, int? timeout, TaskStepProperties step, TriggerProperties trigger, Credentials credentials, string logTemplate, bool? isSystemTask) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            ProvisioningState = provisioningState;
            CreatedOn = createdOn;
            Status = status;
            Platform = platform;
            AgentConfiguration = agentConfiguration;
            AgentPoolName = agentPoolName;
            Timeout = timeout;
            Step = step;
            Trigger = trigger;
            Credentials = credentials;
            LogTemplate = logTemplate;
            IsSystemTask = isSystemTask;
        }

        /// <summary> Identity for the resource. </summary>
        public IdentityProperties Identity { get; set; }
        /// <summary> The provisioning state of the task. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The creation date of task. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The current status of task. </summary>
        public TaskStatus? Status { get; set; }
        /// <summary> The platform properties against which the run has to happen. </summary>
        public PlatformProperties Platform { get; set; }
        /// <summary> The machine configuration of the run agent. </summary>
        internal AgentProperties AgentConfiguration { get; set; }
        /// <summary> The CPU configuration in terms of number of cores required for the run. </summary>
        public int? AgentCpu
        {
            get => AgentConfiguration is null ? default : AgentConfiguration.Cpu;
            set
            {
                if (AgentConfiguration is null)
                    AgentConfiguration = new AgentProperties();
                AgentConfiguration.Cpu = value;
            }
        }

        /// <summary> The dedicated agent pool for the task. </summary>
        public string AgentPoolName { get; set; }
        /// <summary> Run timeout in seconds. </summary>
        public int? Timeout { get; set; }
        /// <summary>
        /// The properties of a task step.
        /// Please note <see cref="TaskStepProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DockerBuildStep"/>, <see cref="EncodedTaskStep"/> and <see cref="FileTaskStep"/>.
        /// </summary>
        public TaskStepProperties Step { get; set; }
        /// <summary> The properties that describe all triggers for the task. </summary>
        public TriggerProperties Trigger { get; set; }
        /// <summary> The properties that describes a set of credentials that will be used when this run is invoked. </summary>
        public Credentials Credentials { get; set; }
        /// <summary> The template that describes the repository and tag information for run log artifact. </summary>
        public string LogTemplate { get; set; }
        /// <summary> The value of this property indicates whether the task resource is system task or not. </summary>
        public bool? IsSystemTask { get; set; }
    }
}
