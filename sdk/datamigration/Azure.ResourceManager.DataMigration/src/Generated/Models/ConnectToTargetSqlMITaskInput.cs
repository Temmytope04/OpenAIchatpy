// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for the task that validates connection to Azure SQL Database Managed Instance. </summary>
    public partial class ConnectToTargetSqlMITaskInput
    {
        /// <summary> Initializes a new instance of ConnectToTargetSqlMITaskInput. </summary>
        /// <param name="targetConnectionInfo"> Connection information for target SQL Server. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetConnectionInfo"/> is null. </exception>
        public ConnectToTargetSqlMITaskInput(SqlConnectionInfo targetConnectionInfo)
        {
            if (targetConnectionInfo == null)
            {
                throw new ArgumentNullException(nameof(targetConnectionInfo));
            }

            TargetConnectionInfo = targetConnectionInfo;
        }

        /// <summary> Initializes a new instance of ConnectToTargetSqlMITaskInput. </summary>
        /// <param name="targetConnectionInfo"> Connection information for target SQL Server. </param>
        /// <param name="collectLogins"> Flag for whether to collect logins from target SQL MI server. </param>
        /// <param name="collectAgentJobs"> Flag for whether to collect agent jobs from target SQL MI server. </param>
        /// <param name="validateSsisCatalogOnly"> Flag for whether to validate SSIS catalog is reachable on the target SQL MI server. </param>
        internal ConnectToTargetSqlMITaskInput(SqlConnectionInfo targetConnectionInfo, bool? collectLogins, bool? collectAgentJobs, bool? validateSsisCatalogOnly)
        {
            TargetConnectionInfo = targetConnectionInfo;
            CollectLogins = collectLogins;
            CollectAgentJobs = collectAgentJobs;
            ValidateSsisCatalogOnly = validateSsisCatalogOnly;
        }

        /// <summary> Connection information for target SQL Server. </summary>
        public SqlConnectionInfo TargetConnectionInfo { get; set; }
        /// <summary> Flag for whether to collect logins from target SQL MI server. </summary>
        public bool? CollectLogins { get; set; }
        /// <summary> Flag for whether to collect agent jobs from target SQL MI server. </summary>
        public bool? CollectAgentJobs { get; set; }
        /// <summary> Flag for whether to validate SSIS catalog is reachable on the target SQL MI server. </summary>
        public bool? ValidateSsisCatalogOnly { get; set; }
    }
}
