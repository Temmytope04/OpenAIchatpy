// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Microsoft Azure SQL Database linked service. </summary>
    public partial class AzureSqlDatabaseLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="AzureSqlDatabaseLinkedService"/>. </summary>
        /// <param name="connectionString"> The connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionString"/> is null. </exception>
        public AzureSqlDatabaseLinkedService(DataFactoryElement<string> connectionString)
        {
            if (connectionString == null)
            {
                throw new ArgumentNullException(nameof(connectionString));
            }

            ConnectionString = connectionString;
            LinkedServiceType = "AzureSqlDatabase";
        }

        /// <summary> Initializes a new instance of <see cref="AzureSqlDatabaseLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="connectionString"> The connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="password"> The Azure key vault secret reference of password in connection string. </param>
        /// <param name="servicePrincipalId"> The ID of the service principal used to authenticate against Azure SQL Database. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey"> The key of the service principal used to authenticate against Azure SQL Database. </param>
        /// <param name="tenant"> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </param>
        /// <param name="azureCloudType"> Indicates the azure cloud type of the service principle auth. Allowed values are AzurePublic, AzureChina, AzureUsGovernment, AzureGermany. Default value is the data factory regions’ cloud type. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        /// <param name="alwaysEncryptedSettings"> Sql always encrypted properties. </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        internal AzureSqlDatabaseLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> connectionString, DataFactoryKeyVaultSecretReference password, DataFactoryElement<string> servicePrincipalId, DataFactorySecretBaseDefinition servicePrincipalKey, DataFactoryElement<string> tenant, DataFactoryElement<string> azureCloudType, string encryptedCredential, SqlAlwaysEncryptedProperties alwaysEncryptedSettings, DataFactoryCredentialReference credential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionString = connectionString;
            Password = password;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            AzureCloudType = azureCloudType;
            EncryptedCredential = encryptedCredential;
            AlwaysEncryptedSettings = alwaysEncryptedSettings;
            Credential = credential;
            LinkedServiceType = linkedServiceType ?? "AzureSqlDatabase";
        }

        /// <summary> Initializes a new instance of <see cref="AzureSqlDatabaseLinkedService"/> for deserialization. </summary>
        internal AzureSqlDatabaseLinkedService()
        {
        }

        /// <summary> The connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public DataFactoryElement<string> ConnectionString { get; set; }
        /// <summary> The Azure key vault secret reference of password in connection string. </summary>
        public DataFactoryKeyVaultSecretReference Password { get; set; }
        /// <summary> The ID of the service principal used to authenticate against Azure SQL Database. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ServicePrincipalId { get; set; }
        /// <summary> The key of the service principal used to authenticate against Azure SQL Database. </summary>
        public DataFactorySecretBaseDefinition ServicePrincipalKey { get; set; }
        /// <summary> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Tenant { get; set; }
        /// <summary> Indicates the azure cloud type of the service principle auth. Allowed values are AzurePublic, AzureChina, AzureUsGovernment, AzureGermany. Default value is the data factory regions’ cloud type. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> AzureCloudType { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
        /// <summary> Sql always encrypted properties. </summary>
        public SqlAlwaysEncryptedProperties AlwaysEncryptedSettings { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public DataFactoryCredentialReference Credential { get; set; }
    }
}
