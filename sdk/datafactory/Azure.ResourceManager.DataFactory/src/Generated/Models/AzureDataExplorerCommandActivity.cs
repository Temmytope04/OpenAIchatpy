// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Azure Data Explorer command activity. </summary>
    public partial class AzureDataExplorerCommandActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of AzureDataExplorerCommandActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="command"> A control command, according to the Azure Data Explorer command syntax. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="command"/> is null. </exception>
        public AzureDataExplorerCommandActivity(string name, BinaryData command) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            Command = command;
            ActivityType = "AzureDataExplorerCommand";
        }

        /// <summary> Initializes a new instance of AzureDataExplorerCommandActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="command"> A control command, according to the Azure Data Explorer command syntax. Type: string (or Expression with resultType string). </param>
        /// <param name="commandTimeout"> Control command timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9]))..). </param>
        internal AzureDataExplorerCommandActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, FactoryLinkedServiceReference linkedServiceName, ActivityPolicy policy, BinaryData command, BinaryData commandTimeout) : base(name, activityType, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            Command = command;
            CommandTimeout = commandTimeout;
            ActivityType = activityType ?? "AzureDataExplorerCommand";
        }

        /// <summary> A control command, according to the Azure Data Explorer command syntax. Type: string (or Expression with resultType string). </summary>
        public BinaryData Command { get; set; }
        /// <summary> Control command timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9]))..). </summary>
        public BinaryData CommandTimeout { get; set; }
    }
}
