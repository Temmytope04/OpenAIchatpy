// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary>
    /// The Azure Data Factory nested object which identifies data within different data stores, such as tables, files, folders, and documents.
    /// Please note <see cref="FactoryDatasetDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AmazonMwsObjectDataset"/>, <see cref="AmazonRdsForOracleTableDataset"/>, <see cref="AmazonRdsForSqlServerTableDataset"/>, <see cref="AmazonRedshiftTableDataset"/>, <see cref="AmazonS3Dataset"/>, <see cref="AvroDataset"/>, <see cref="AzureBlobDataset"/>, <see cref="AzureBlobFSDataset"/>, <see cref="AzureDataExplorerTableDataset"/>, <see cref="AzureDataLakeStoreDataset"/>, <see cref="AzureDatabricksDeltaLakeDataset"/>, <see cref="AzureMariaDBTableDataset"/>, <see cref="AzureMySqlTableDataset"/>, <see cref="AzurePostgreSqlTableDataset"/>, <see cref="AzureSearchIndexDataset"/>, <see cref="AzureSqlDWTableDataset"/>, <see cref="AzureSqlMITableDataset"/>, <see cref="AzureSqlTableDataset"/>, <see cref="AzureTableDataset"/>, <see cref="BinaryDataset"/>, <see cref="CassandraTableDataset"/>, <see cref="CommonDataServiceForAppsEntityDataset"/>, <see cref="ConcurObjectDataset"/>, <see cref="CosmosDBMongoDBApiCollectionDataset"/>, <see cref="CosmosDBSqlApiCollectionDataset"/>, <see cref="CouchbaseTableDataset"/>, <see cref="CustomDataset"/>, <see cref="Db2TableDataset"/>, <see cref="DelimitedTextDataset"/>, <see cref="DocumentDBCollectionDataset"/>, <see cref="DrillTableDataset"/>, <see cref="DynamicsAXResourceDataset"/>, <see cref="DynamicsCrmEntityDataset"/>, <see cref="DynamicsEntityDataset"/>, <see cref="EloquaObjectDataset"/>, <see cref="ExcelDataset"/>, <see cref="FileShareDataset"/>, <see cref="GoogleAdWordsObjectDataset"/>, <see cref="GoogleBigQueryObjectDataset"/>, <see cref="GreenplumTableDataset"/>, <see cref="HBaseObjectDataset"/>, <see cref="HiveObjectDataset"/>, <see cref="HttpFileDataset"/>, <see cref="HubspotObjectDataset"/>, <see cref="ImpalaObjectDataset"/>, <see cref="InformixTableDataset"/>, <see cref="JiraObjectDataset"/>, <see cref="JsonDataset"/>, <see cref="MagentoObjectDataset"/>, <see cref="MariaDBTableDataset"/>, <see cref="MarketoObjectDataset"/>, <see cref="MicrosoftAccessTableDataset"/>, <see cref="MongoDBAtlasCollectionDataset"/>, <see cref="MongoDBCollectionDataset"/>, <see cref="MongoDBV2CollectionDataset"/>, <see cref="MySqlTableDataset"/>, <see cref="NetezzaTableDataset"/>, <see cref="ODataResourceDataset"/>, <see cref="OdbcTableDataset"/>, <see cref="Office365Dataset"/>, <see cref="OracleServiceCloudObjectDataset"/>, <see cref="OracleTableDataset"/>, <see cref="OrcDataset"/>, <see cref="ParquetDataset"/>, <see cref="PaypalObjectDataset"/>, <see cref="PhoenixObjectDataset"/>, <see cref="PostgreSqlTableDataset"/>, <see cref="PrestoObjectDataset"/>, <see cref="QuickBooksObjectDataset"/>, <see cref="RelationalTableDataset"/>, <see cref="ResponsysObjectDataset"/>, <see cref="RestResourceDataset"/>, <see cref="SalesforceMarketingCloudObjectDataset"/>, <see cref="SalesforceObjectDataset"/>, <see cref="SalesforceServiceCloudObjectDataset"/>, <see cref="SapBwCubeDataset"/>, <see cref="SapCloudForCustomerResourceDataset"/>, <see cref="SapEccResourceDataset"/>, <see cref="SapHanaTableDataset"/>, <see cref="SapOdpResourceDataset"/>, <see cref="SapOpenHubTableDataset"/>, <see cref="SapTableResourceDataset"/>, <see cref="ServiceNowObjectDataset"/>, <see cref="SharePointOnlineListResourceDataset"/>, <see cref="ShopifyObjectDataset"/>, <see cref="SnowflakeDataset"/>, <see cref="SparkObjectDataset"/>, <see cref="SqlServerTableDataset"/>, <see cref="SquareObjectDataset"/>, <see cref="SybaseTableDataset"/>, <see cref="TeradataTableDataset"/>, <see cref="VerticaTableDataset"/>, <see cref="WebTableDataset"/>, <see cref="XeroObjectDataset"/>, <see cref="XmlDataset"/> and <see cref="ZohoObjectDataset"/>.
    /// </summary>
    public partial class FactoryDatasetDefinition
    {
        /// <summary> Initializes a new instance of FactoryDatasetDefinition. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public FactoryDatasetDefinition(FactoryLinkedServiceReference linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            LinkedServiceName = linkedServiceName;
            Parameters = new ChangeTrackingDictionary<string, EntityParameterSpecification>();
            Annotations = new ChangeTrackingList<BinaryData>();
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of FactoryDatasetDefinition. </summary>
        /// <param name="datasetType"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal FactoryDatasetDefinition(string datasetType, string description, BinaryData structure, BinaryData schema, FactoryLinkedServiceReference linkedServiceName, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, DatasetFolder folder, IDictionary<string, BinaryData> additionalProperties)
        {
            DatasetType = datasetType;
            Description = description;
            Structure = structure;
            Schema = schema;
            LinkedServiceName = linkedServiceName;
            Parameters = parameters;
            Annotations = annotations;
            Folder = folder;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Type of dataset. </summary>
        internal string DatasetType { get; set; }
        /// <summary> Dataset description. </summary>
        public string Description { get; set; }
        /// <summary> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </summary>
        public BinaryData Structure { get; set; }
        /// <summary> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </summary>
        public BinaryData Schema { get; set; }
        /// <summary> Linked service reference. </summary>
        public FactoryLinkedServiceReference LinkedServiceName { get; set; }
        /// <summary> Parameters for dataset. </summary>
        public IDictionary<string, EntityParameterSpecification> Parameters { get; }
        /// <summary> List of tags that can be used for describing the Dataset. </summary>
        public IList<BinaryData> Annotations { get; }
        /// <summary> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </summary>
        internal DatasetFolder Folder { get; set; }
        /// <summary> The name of the folder that this Dataset is in. </summary>
        public string FolderName
        {
            get => Folder is null ? default : Folder.Name;
            set
            {
                if (Folder is null)
                    Folder = new DatasetFolder();
                Folder.Name = value;
            }
        }

        /// <summary> Additional Properties. </summary>
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
