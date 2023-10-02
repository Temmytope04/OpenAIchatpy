// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Represents an indexer. </summary>
    public partial class SearchIndexer
    {
        /// <summary> Initializes a new instance of SearchIndexer. </summary>
        /// <param name="name"> The name of the indexer. </param>
        /// <param name="dataSourceName"> The name of the datasource from which this indexer reads data. </param>
        /// <param name="targetIndexName"> The name of the index to which this indexer writes data. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="dataSourceName"/> or <paramref name="targetIndexName"/> is null. </exception>
        public SearchIndexer(string name, string dataSourceName, string targetIndexName)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(dataSourceName, nameof(dataSourceName));
            Argument.AssertNotNull(targetIndexName, nameof(targetIndexName));

            Name = name;
            DataSourceName = dataSourceName;
            TargetIndexName = targetIndexName;
            FieldMappings = new ChangeTrackingList<FieldMapping>();
            OutputFieldMappings = new ChangeTrackingList<FieldMapping>();
        }

        /// <summary> Initializes a new instance of SearchIndexer. </summary>
        /// <param name="name"> The name of the indexer. </param>
        /// <param name="description"> The description of the indexer. </param>
        /// <param name="dataSourceName"> The name of the datasource from which this indexer reads data. </param>
        /// <param name="skillsetName"> The name of the skillset executing with this indexer. </param>
        /// <param name="targetIndexName"> The name of the index to which this indexer writes data. </param>
        /// <param name="schedule"> The schedule for this indexer. </param>
        /// <param name="parameters"> Parameters for indexer execution. </param>
        /// <param name="fieldMappings"> Defines mappings between fields in the data source and corresponding target fields in the index. </param>
        /// <param name="outputFieldMappings"> Output field mappings are applied after enrichment and immediately before indexing. </param>
        /// <param name="isDisabled"> A value indicating whether the indexer is disabled. Default is false. </param>
        /// <param name="etag"> The ETag of the indexer. </param>
        /// <param name="encryptionKey"> A description of an encryption key that you create in Azure Key Vault. This key is used to provide an additional level of encryption-at-rest for your indexer definition (as well as indexer execution status) when you want full assurance that no one, not even Microsoft, can decrypt them in Azure Cognitive Search. Once you have encrypted your indexer definition, it will always remain encrypted. Azure Cognitive Search will ignore attempts to set this property to null. You can change this property as needed if you want to rotate your encryption key; Your indexer definition (and indexer execution status) will be unaffected. Encryption with customer-managed keys is not available for free search services, and is only available for paid services created on or after January 1, 2019. </param>
        internal SearchIndexer(string name, string description, string dataSourceName, string skillsetName, string targetIndexName, IndexingSchedule schedule, IndexingParameters parameters, IList<FieldMapping> fieldMappings, IList<FieldMapping> outputFieldMappings, bool? isDisabled, string etag, SearchResourceEncryptionKey encryptionKey)
        {
            Name = name;
            Description = description;
            DataSourceName = dataSourceName;
            SkillsetName = skillsetName;
            TargetIndexName = targetIndexName;
            Schedule = schedule;
            Parameters = parameters;
            FieldMappings = fieldMappings;
            OutputFieldMappings = outputFieldMappings;
            IsDisabled = isDisabled;
            _etag = etag;
            EncryptionKey = encryptionKey;
        }

        /// <summary> The name of the indexer. </summary>
        public string Name { get; set; }
        /// <summary> The description of the indexer. </summary>
        public string Description { get; set; }
        /// <summary> The name of the datasource from which this indexer reads data. </summary>
        public string DataSourceName { get; set; }
        /// <summary> The name of the skillset executing with this indexer. </summary>
        public string SkillsetName { get; set; }
        /// <summary> The name of the index to which this indexer writes data. </summary>
        public string TargetIndexName { get; set; }
        /// <summary> The schedule for this indexer. </summary>
        public IndexingSchedule Schedule { get; set; }
        /// <summary> Parameters for indexer execution. </summary>
        public IndexingParameters Parameters { get; set; }
        /// <summary> A value indicating whether the indexer is disabled. Default is false. </summary>
        public bool? IsDisabled { get; set; }
        /// <summary> A description of an encryption key that you create in Azure Key Vault. This key is used to provide an additional level of encryption-at-rest for your indexer definition (as well as indexer execution status) when you want full assurance that no one, not even Microsoft, can decrypt them in Azure Cognitive Search. Once you have encrypted your indexer definition, it will always remain encrypted. Azure Cognitive Search will ignore attempts to set this property to null. You can change this property as needed if you want to rotate your encryption key; Your indexer definition (and indexer execution status) will be unaffected. Encryption with customer-managed keys is not available for free search services, and is only available for paid services created on or after January 1, 2019. </summary>
        public SearchResourceEncryptionKey EncryptionKey { get; set; }
    }
}
