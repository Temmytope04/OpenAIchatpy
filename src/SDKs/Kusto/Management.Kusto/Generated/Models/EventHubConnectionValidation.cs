// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Class representing an event hub connection validation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class EventHubConnectionValidation
    {
        /// <summary>
        /// Initializes a new instance of the EventHubConnectionValidation
        /// class.
        /// </summary>
        public EventHubConnectionValidation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventHubConnectionValidation
        /// class.
        /// </summary>
        /// <param name="eventHubResourceId">The resource ID of the event hub
        /// to be used to create a data connection.</param>
        /// <param name="consumerGroup">The event hub consumer group.</param>
        /// <param name="eventhubConnectionName">The name of the event hub
        /// connection.</param>
        /// <param name="tableName">The table where the data should be
        /// ingested. Optionally the table information can be added to each
        /// message.</param>
        /// <param name="mappingRuleName">The mapping rule to be used to ingest
        /// the data. Optionally the mapping information can be added to each
        /// message.</param>
        /// <param name="dataFormat">The data format of the message. Optionally
        /// the data format can be added to each message. Possible values
        /// include: 'MULTIJSON', 'JSON', 'CSV'</param>
        public EventHubConnectionValidation(string eventHubResourceId, string consumerGroup, string eventhubConnectionName = default(string), string tableName = default(string), string mappingRuleName = default(string), string dataFormat = default(string))
        {
            EventhubConnectionName = eventhubConnectionName;
            EventHubResourceId = eventHubResourceId;
            ConsumerGroup = consumerGroup;
            TableName = tableName;
            MappingRuleName = mappingRuleName;
            DataFormat = dataFormat;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the event hub connection.
        /// </summary>
        [JsonProperty(PropertyName = "eventhubConnectionName")]
        public string EventhubConnectionName { get; set; }

        /// <summary>
        /// Gets or sets the resource ID of the event hub to be used to create
        /// a data connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.eventHubResourceId")]
        public string EventHubResourceId { get; set; }

        /// <summary>
        /// Gets or sets the event hub consumer group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.consumerGroup")]
        public string ConsumerGroup { get; set; }

        /// <summary>
        /// Gets or sets the table where the data should be ingested.
        /// Optionally the table information can be added to each message.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tableName")]
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets the mapping rule to be used to ingest the data.
        /// Optionally the mapping information can be added to each message.
        /// </summary>
        [JsonProperty(PropertyName = "properties.mappingRuleName")]
        public string MappingRuleName { get; set; }

        /// <summary>
        /// Gets or sets the data format of the message. Optionally the data
        /// format can be added to each message. Possible values include:
        /// 'MULTIJSON', 'JSON', 'CSV'
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataFormat")]
        public string DataFormat { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EventHubResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EventHubResourceId");
            }
            if (ConsumerGroup == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConsumerGroup");
            }
        }
    }
}
