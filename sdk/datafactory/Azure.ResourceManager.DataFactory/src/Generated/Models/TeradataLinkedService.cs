// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Linked service for Teradata data source. </summary>
    public partial class TeradataLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="TeradataLinkedService"/>. </summary>
        public TeradataLinkedService()
        {
            LinkedServiceType = "Teradata";
        }

        /// <summary> Initializes a new instance of <see cref="TeradataLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="linkedServiceVersion"> Version of the linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="connectionString"> Teradata ODBC connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="server"> Server name for connection. Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> AuthenticationType to be used for connection. </param>
        /// <param name="username"> Username for authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> Password for authentication. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal TeradataLinkedService(string linkedServiceType, string linkedServiceVersion, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> connectionString, DataFactoryElement<string> server, TeradataAuthenticationType? authenticationType, DataFactoryElement<string> username, DataFactorySecret password, string encryptedCredential) : base(linkedServiceType, linkedServiceVersion, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionString = connectionString;
            Server = server;
            AuthenticationType = authenticationType;
            Username = username;
            Password = password;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "Teradata";
        }

        /// <summary> Teradata ODBC connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public DataFactoryElement<string> ConnectionString { get; set; }
        /// <summary> Server name for connection. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Server { get; set; }
        /// <summary> AuthenticationType to be used for connection. </summary>
        public TeradataAuthenticationType? AuthenticationType { get; set; }
        /// <summary> Username for authentication. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Username { get; set; }
        /// <summary> Password for authentication. </summary>
        public DataFactorySecret Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
