// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing the SoftwareUpdateConfiguration data model.
    /// Software update configuration properties.
    /// </summary>
    public partial class SoftwareUpdateConfigurationData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SoftwareUpdateConfigurationData"/>. </summary>
        /// <param name="updateConfiguration"> update specific properties for the Software update configuration. </param>
        /// <param name="scheduleInfo"> Schedule information for the Software update configuration. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="updateConfiguration"/> or <paramref name="scheduleInfo"/> is null. </exception>
        public SoftwareUpdateConfigurationData(SoftwareUpdateConfigurationSpecificProperties updateConfiguration, SoftwareUpdateConfigurationScheduleProperties scheduleInfo)
        {
            Argument.AssertNotNull(updateConfiguration, nameof(updateConfiguration));
            Argument.AssertNotNull(scheduleInfo, nameof(scheduleInfo));

            UpdateConfiguration = updateConfiguration;
            ScheduleInfo = scheduleInfo;
        }

        /// <summary> Initializes a new instance of <see cref="SoftwareUpdateConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="updateConfiguration"> update specific properties for the Software update configuration. </param>
        /// <param name="scheduleInfo"> Schedule information for the Software update configuration. </param>
        /// <param name="provisioningState"> Provisioning state for the software update configuration, which only appears in the response. </param>
        /// <param name="error"> Details of provisioning error. </param>
        /// <param name="createdOn"> Creation time of the resource, which only appears in the response. </param>
        /// <param name="createdBy"> CreatedBy property, which only appears in the response. </param>
        /// <param name="lastModifiedOn"> Last time resource was modified, which only appears in the response. </param>
        /// <param name="lastModifiedBy"> LastModifiedBy property, which only appears in the response. </param>
        /// <param name="tasks"> Tasks information for the Software update configuration. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SoftwareUpdateConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SoftwareUpdateConfigurationSpecificProperties updateConfiguration, SoftwareUpdateConfigurationScheduleProperties scheduleInfo, string provisioningState, AutomationResponseError error, DateTimeOffset? createdOn, string createdBy, DateTimeOffset? lastModifiedOn, string lastModifiedBy, SoftwareUpdateConfigurationTasks tasks, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            UpdateConfiguration = updateConfiguration;
            ScheduleInfo = scheduleInfo;
            ProvisioningState = provisioningState;
            Error = error;
            CreatedOn = createdOn;
            CreatedBy = createdBy;
            LastModifiedOn = lastModifiedOn;
            LastModifiedBy = lastModifiedBy;
            Tasks = tasks;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SoftwareUpdateConfigurationData"/> for deserialization. </summary>
        internal SoftwareUpdateConfigurationData()
        {
        }

        /// <summary> update specific properties for the Software update configuration. </summary>
        public SoftwareUpdateConfigurationSpecificProperties UpdateConfiguration { get; set; }
        /// <summary> Schedule information for the Software update configuration. </summary>
        public SoftwareUpdateConfigurationScheduleProperties ScheduleInfo { get; set; }
        /// <summary> Provisioning state for the software update configuration, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> Details of provisioning error. </summary>
        public AutomationResponseError Error { get; set; }
        /// <summary> Creation time of the resource, which only appears in the response. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> CreatedBy property, which only appears in the response. </summary>
        public string CreatedBy { get; }
        /// <summary> Last time resource was modified, which only appears in the response. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> LastModifiedBy property, which only appears in the response. </summary>
        public string LastModifiedBy { get; }
        /// <summary> Tasks information for the Software update configuration. </summary>
        public SoftwareUpdateConfigurationTasks Tasks { get; set; }
    }
}
