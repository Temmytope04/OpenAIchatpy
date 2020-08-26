// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The target that a job execution is executed on. </summary>
    public partial class JobExecutionTarget
    {
        /// <summary> Initializes a new instance of JobExecutionTarget. </summary>
        internal JobExecutionTarget()
        {
        }

        /// <summary> Initializes a new instance of JobExecutionTarget. </summary>
        /// <param name="type"> The type of the target. </param>
        /// <param name="serverName"> The server name. </param>
        /// <param name="databaseName"> The database name. </param>
        internal JobExecutionTarget(JobTargetType? type, string serverName, string databaseName)
        {
            Type = type;
            ServerName = serverName;
            DatabaseName = databaseName;
        }

        /// <summary> The type of the target. </summary>
        public JobTargetType? Type { get; }
        /// <summary> The server name. </summary>
        public string ServerName { get; }
        /// <summary> The database name. </summary>
        public string DatabaseName { get; }
    }
}
