﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary>
    /// Authenticates to a SQL server via connection string.
    /// </summary>
    [CodeGenModel("AzureSQLConnectionStringCredential")]
    [CodeGenSuppress(nameof(SqlConnectionStringDatasourceCredential), typeof(string), typeof(AzureSQLConnectionStringParam))]
    public partial class SqlConnectionStringDatasourceCredential
    {
        private string _connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlConnectionStringDatasourceCredential"/> class.
        /// </summary>
        /// <param name="name">A custom unique name for this <see cref="SqlConnectionStringDatasourceCredential"/> to be displayed on the web portal.</param>
        /// <param name="connectionString">The connection string to be used for authentication.</param>
        public SqlConnectionStringDatasourceCredential(string name, string connectionString) : base(name)
        {
            Argument.AssertNotNullOrEmpty(connectionString, nameof(connectionString));

            DataSourceCredentialType = DataSourceCredentialType.AzureSQLConnectionString;
            ConnectionString = connectionString;
        }

        internal SqlConnectionStringDatasourceCredential(DataSourceCredentialType dataSourceCredentialType, string id, string name, string description, AzureSQLConnectionStringParam parameters) : base(dataSourceCredentialType, id, name, description)
        {
            DataSourceCredentialType = dataSourceCredentialType;
            ConnectionString = parameters.ConnectionString;
        }

        internal string ConnectionString
        {
            get => Volatile.Read(ref _connectionString);
            set => Volatile.Write(ref _connectionString, value);
        }

        /// <summary>
        /// Used by CodeGen during serialization.
        /// </summary>
        internal AzureSQLConnectionStringParam Parameters => new AzureSQLConnectionStringParam() { ConnectionString = ConnectionString };

        /// <summary>
        /// Updates the connection string.
        /// </summary>
        /// <param name="connectionString">The new connection string to be used for authentication.</param>
        /// <exception cref="ArgumentNullException"><paramref name="connectionString"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="connectionString"/> is empty.</exception>
        public void UpdateConnectionString(string connectionString)
        {
            Argument.AssertNotNullOrEmpty(connectionString, nameof(connectionString));
            ConnectionString = connectionString;
        }
    }
}
