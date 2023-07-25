// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridData.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridData
{
    /// <summary>
    /// A class representing the HybridDataJobDefinition data model.
    /// Job Definition.
    /// </summary>
    public partial class HybridDataJobDefinitionData : ResourceData
    {
        /// <summary> Initializes a new instance of HybridDataJobDefinitionData. </summary>
        /// <param name="dataSourceId"> Data Source Id associated to the job definition. </param>
        /// <param name="dataSinkId"> Data Sink Id associated to the job definition. </param>
        /// <param name="state"> State of the job definition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceId"/> or <paramref name="dataSinkId"/> is null. </exception>
        public HybridDataJobDefinitionData(string dataSourceId, string dataSinkId, HybridDataState state)
        {
            Argument.AssertNotNull(dataSourceId, nameof(dataSourceId));
            Argument.AssertNotNull(dataSinkId, nameof(dataSinkId));

            DataSourceId = dataSourceId;
            DataSinkId = dataSinkId;
            Schedules = new ChangeTrackingList<HybridDataJobRunSchedule>();
            State = state;
            CustomerSecrets = new ChangeTrackingList<HybridDataCustomerSecret>();
        }

        /// <summary> Initializes a new instance of HybridDataJobDefinitionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="dataSourceId"> Data Source Id associated to the job definition. </param>
        /// <param name="dataSinkId"> Data Sink Id associated to the job definition. </param>
        /// <param name="schedules"> Schedule for running the job definition. </param>
        /// <param name="state"> State of the job definition. </param>
        /// <param name="lastModifiedOn"> Last modified time of the job definition. </param>
        /// <param name="runLocation"> This is the preferred geo location for the job to run. </param>
        /// <param name="userConfirmation"> Enum to detect if user confirmation is required. If not passed will default to NotRequired. </param>
        /// <param name="dataServiceInput"> A generic json used differently by each data service type. </param>
        /// <param name="customerSecrets"> List of customer secrets containing a key identifier and key value. The key identifier is a way for the specific data source to understand the key. Value contains customer secret encrypted by the encryptionKeys. </param>
        internal HybridDataJobDefinitionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string dataSourceId, string dataSinkId, IList<HybridDataJobRunSchedule> schedules, HybridDataState state, DateTimeOffset? lastModifiedOn, HybridDataJobRunLocation? runLocation, UserConfirmationSetting? userConfirmation, BinaryData dataServiceInput, IList<HybridDataCustomerSecret> customerSecrets) : base(id, name, resourceType, systemData)
        {
            DataSourceId = dataSourceId;
            DataSinkId = dataSinkId;
            Schedules = schedules;
            State = state;
            LastModifiedOn = lastModifiedOn;
            RunLocation = runLocation;
            UserConfirmation = userConfirmation;
            DataServiceInput = dataServiceInput;
            CustomerSecrets = customerSecrets;
        }

        /// <summary> Data Source Id associated to the job definition. </summary>
        public string DataSourceId { get; set; }
        /// <summary> Data Sink Id associated to the job definition. </summary>
        public string DataSinkId { get; set; }
        /// <summary> Schedule for running the job definition. </summary>
        public IList<HybridDataJobRunSchedule> Schedules { get; }
        /// <summary> State of the job definition. </summary>
        public HybridDataState State { get; set; }
        /// <summary> Last modified time of the job definition. </summary>
        public DateTimeOffset? LastModifiedOn { get; set; }
        /// <summary> This is the preferred geo location for the job to run. </summary>
        public HybridDataJobRunLocation? RunLocation { get; set; }
        /// <summary> Enum to detect if user confirmation is required. If not passed will default to NotRequired. </summary>
        public UserConfirmationSetting? UserConfirmation { get; set; }
        /// <summary>
        /// A generic json used differently by each data service type.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData DataServiceInput { get; set; }
        /// <summary> List of customer secrets containing a key identifier and key value. The key identifier is a way for the specific data source to understand the key. Value contains customer secret encrypted by the encryptionKeys. </summary>
        public IList<HybridDataCustomerSecret> CustomerSecrets { get; }
    }
}
