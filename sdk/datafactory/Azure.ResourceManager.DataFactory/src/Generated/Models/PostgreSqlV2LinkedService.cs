// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Linked service for PostgreSQLV2 data source. </summary>
    public partial class PostgreSqlV2LinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="PostgreSqlV2LinkedService"/>. </summary>
        /// <param name="server"> Server name for connection. Type: string. </param>
        /// <param name="username"> Username for authentication. Type: string. </param>
        /// <param name="database"> Database name for connection. Type: string. </param>
        /// <param name="sslMode"> SSL mode for connection. Type: integer. 0: disable, 1:allow, 2: prefer, 3: require, 4: verify-ca, 5: verify-full. Type: integer. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="server"/>, <paramref name="username"/>, <paramref name="database"/> or <paramref name="sslMode"/> is null. </exception>
        public PostgreSqlV2LinkedService(DataFactoryElement<string> server, DataFactoryElement<string> username, DataFactoryElement<string> database, DataFactoryElement<int> sslMode)
        {
            Argument.AssertNotNull(server, nameof(server));
            Argument.AssertNotNull(username, nameof(username));
            Argument.AssertNotNull(database, nameof(database));
            Argument.AssertNotNull(sslMode, nameof(sslMode));

            Server = server;
            Username = username;
            Database = database;
            SslMode = sslMode;
            LinkedServiceType = "PostgreSqlV2";
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlV2LinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="server"> Server name for connection. Type: string. </param>
        /// <param name="port"> The port for the connection. Type: integer. </param>
        /// <param name="username"> Username for authentication. Type: string. </param>
        /// <param name="database"> Database name for connection. Type: string. </param>
        /// <param name="sslMode"> SSL mode for connection. Type: integer. 0: disable, 1:allow, 2: prefer, 3: require, 4: verify-ca, 5: verify-full. Type: integer. </param>
        /// <param name="schema"> Sets the schema search path. Type: string. </param>
        /// <param name="pooling"> Whether connection pooling should be used. Type: boolean. </param>
        /// <param name="connectionTimeout"> The time to wait (in seconds) while trying to establish a connection before terminating the attempt and generating an error. Type: integer. </param>
        /// <param name="commandTimeout"> The time to wait (in seconds) while trying to execute a command before terminating the attempt and generating an error. Set to zero for infinity. Type: integer. </param>
        /// <param name="trustServerCertificate"> Whether to trust the server certificate without validating it. Type: boolean. </param>
        /// <param name="sslCertificate"> Location of a client certificate to be sent to the server. Type: string. </param>
        /// <param name="sslKey"> Location of a client key for a client certificate to be sent to the server. Type: string. </param>
        /// <param name="sslPassword"> Password for a key for a client certificate. Type: string. </param>
        /// <param name="readBufferSize"> Determines the size of the internal buffer uses when reading. Increasing may improve performance if transferring large values from the database. Type: integer. </param>
        /// <param name="logParameters"> When enabled, parameter values are logged when commands are executed. Type: boolean. </param>
        /// <param name="timezone"> Gets or sets the session timezone. Type: string. </param>
        /// <param name="encoding"> Gets or sets the .NET encoding that will be used to encode/decode PostgreSQL string data. Type: string. </param>
        /// <param name="password"> The Azure key vault secret reference of password in connection string. Type: string. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal PostgreSqlV2LinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> server, DataFactoryElement<int> port, DataFactoryElement<string> username, DataFactoryElement<string> database, DataFactoryElement<int> sslMode, DataFactoryElement<string> schema, DataFactoryElement<bool> pooling, DataFactoryElement<int> connectionTimeout, DataFactoryElement<int> commandTimeout, DataFactoryElement<bool> trustServerCertificate, DataFactoryElement<string> sslCertificate, DataFactoryElement<string> sslKey, DataFactoryElement<string> sslPassword, DataFactoryElement<int> readBufferSize, DataFactoryElement<bool> logParameters, DataFactoryElement<string> timezone, DataFactoryElement<string> encoding, DataFactoryKeyVaultSecret password, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Server = server;
            Port = port;
            Username = username;
            Database = database;
            SslMode = sslMode;
            Schema = schema;
            Pooling = pooling;
            ConnectionTimeout = connectionTimeout;
            CommandTimeout = commandTimeout;
            TrustServerCertificate = trustServerCertificate;
            SslCertificate = sslCertificate;
            SslKey = sslKey;
            SslPassword = sslPassword;
            ReadBufferSize = readBufferSize;
            LogParameters = logParameters;
            Timezone = timezone;
            Encoding = encoding;
            Password = password;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "PostgreSqlV2";
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlV2LinkedService"/> for deserialization. </summary>
        internal PostgreSqlV2LinkedService()
        {
        }

        /// <summary> Server name for connection. Type: string. </summary>
        public DataFactoryElement<string> Server { get; set; }
        /// <summary> The port for the connection. Type: integer. </summary>
        public DataFactoryElement<int> Port { get; set; }
        /// <summary> Username for authentication. Type: string. </summary>
        public DataFactoryElement<string> Username { get; set; }
        /// <summary> Database name for connection. Type: string. </summary>
        public DataFactoryElement<string> Database { get; set; }
        /// <summary> SSL mode for connection. Type: integer. 0: disable, 1:allow, 2: prefer, 3: require, 4: verify-ca, 5: verify-full. Type: integer. </summary>
        public DataFactoryElement<int> SslMode { get; set; }
        /// <summary> Sets the schema search path. Type: string. </summary>
        public DataFactoryElement<string> Schema { get; set; }
        /// <summary> Whether connection pooling should be used. Type: boolean. </summary>
        public DataFactoryElement<bool> Pooling { get; set; }
        /// <summary> The time to wait (in seconds) while trying to establish a connection before terminating the attempt and generating an error. Type: integer. </summary>
        public DataFactoryElement<int> ConnectionTimeout { get; set; }
        /// <summary> The time to wait (in seconds) while trying to execute a command before terminating the attempt and generating an error. Set to zero for infinity. Type: integer. </summary>
        public DataFactoryElement<int> CommandTimeout { get; set; }
        /// <summary> Whether to trust the server certificate without validating it. Type: boolean. </summary>
        public DataFactoryElement<bool> TrustServerCertificate { get; set; }
        /// <summary> Location of a client certificate to be sent to the server. Type: string. </summary>
        public DataFactoryElement<string> SslCertificate { get; set; }
        /// <summary> Location of a client key for a client certificate to be sent to the server. Type: string. </summary>
        public DataFactoryElement<string> SslKey { get; set; }
        /// <summary> Password for a key for a client certificate. Type: string. </summary>
        public DataFactoryElement<string> SslPassword { get; set; }
        /// <summary> Determines the size of the internal buffer uses when reading. Increasing may improve performance if transferring large values from the database. Type: integer. </summary>
        public DataFactoryElement<int> ReadBufferSize { get; set; }
        /// <summary> When enabled, parameter values are logged when commands are executed. Type: boolean. </summary>
        public DataFactoryElement<bool> LogParameters { get; set; }
        /// <summary> Gets or sets the session timezone. Type: string. </summary>
        public DataFactoryElement<string> Timezone { get; set; }
        /// <summary> Gets or sets the .NET encoding that will be used to encode/decode PostgreSQL string data. Type: string. </summary>
        public DataFactoryElement<string> Encoding { get; set; }
        /// <summary> The Azure key vault secret reference of password in connection string. Type: string. </summary>
        public DataFactoryKeyVaultSecret Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
