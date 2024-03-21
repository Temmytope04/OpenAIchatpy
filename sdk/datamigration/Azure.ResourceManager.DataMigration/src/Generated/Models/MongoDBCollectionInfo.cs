// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Describes a supported collection within a MongoDB database. </summary>
    public partial class MongoDBCollectionInfo : MongoDBObjectInfo
    {
        /// <summary> Initializes a new instance of <see cref="MongoDBCollectionInfo"/>. </summary>
        /// <param name="averageDocumentSize"> The average document size, or -1 if the average size is unknown. </param>
        /// <param name="dataSize"> The estimated total data size, in bytes, or -1 if the size is unknown. </param>
        /// <param name="documentCount"> The estimated total number of documents, or -1 if the document count is unknown. </param>
        /// <param name="name"> The unqualified name of the database or collection. </param>
        /// <param name="qualifiedName"> The qualified name of the database or collection. For a collection, this is the database-qualified name. </param>
        /// <param name="databaseName"> The name of the database containing the collection. </param>
        /// <param name="isCapped"> Whether the collection is a capped collection (i.e. whether it has a fixed size and acts like a circular buffer). </param>
        /// <param name="isSystemCollection"> Whether the collection is system collection. </param>
        /// <param name="isView"> Whether the collection is a view of another collection. </param>
        /// <param name="supportsSharding"> Whether the database has sharding enabled. Note that the migration task will enable sharding on the target if necessary. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="qualifiedName"/> or <paramref name="databaseName"/> is null. </exception>
        internal MongoDBCollectionInfo(long averageDocumentSize, long dataSize, long documentCount, string name, string qualifiedName, string databaseName, bool isCapped, bool isSystemCollection, bool isView, bool supportsSharding) : base(averageDocumentSize, dataSize, documentCount, name, qualifiedName)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(qualifiedName, nameof(qualifiedName));
            Argument.AssertNotNull(databaseName, nameof(databaseName));

            DatabaseName = databaseName;
            IsCapped = isCapped;
            IsSystemCollection = isSystemCollection;
            IsView = isView;
            SupportsSharding = supportsSharding;
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBCollectionInfo"/>. </summary>
        /// <param name="averageDocumentSize"> The average document size, or -1 if the average size is unknown. </param>
        /// <param name="dataSize"> The estimated total data size, in bytes, or -1 if the size is unknown. </param>
        /// <param name="documentCount"> The estimated total number of documents, or -1 if the document count is unknown. </param>
        /// <param name="name"> The unqualified name of the database or collection. </param>
        /// <param name="qualifiedName"> The qualified name of the database or collection. For a collection, this is the database-qualified name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="databaseName"> The name of the database containing the collection. </param>
        /// <param name="isCapped"> Whether the collection is a capped collection (i.e. whether it has a fixed size and acts like a circular buffer). </param>
        /// <param name="isSystemCollection"> Whether the collection is system collection. </param>
        /// <param name="isView"> Whether the collection is a view of another collection. </param>
        /// <param name="shardKey"> The shard key on the collection, or null if the collection is not sharded. </param>
        /// <param name="supportsSharding"> Whether the database has sharding enabled. Note that the migration task will enable sharding on the target if necessary. </param>
        /// <param name="viewOf"> The name of the collection that this is a view of, if IsView is true. </param>
        internal MongoDBCollectionInfo(long averageDocumentSize, long dataSize, long documentCount, string name, string qualifiedName, IDictionary<string, BinaryData> serializedAdditionalRawData, string databaseName, bool isCapped, bool isSystemCollection, bool isView, MongoDBShardKeyInfo shardKey, bool supportsSharding, string viewOf) : base(averageDocumentSize, dataSize, documentCount, name, qualifiedName, serializedAdditionalRawData)
        {
            DatabaseName = databaseName;
            IsCapped = isCapped;
            IsSystemCollection = isSystemCollection;
            IsView = isView;
            ShardKey = shardKey;
            SupportsSharding = supportsSharding;
            ViewOf = viewOf;
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBCollectionInfo"/> for deserialization. </summary>
        internal MongoDBCollectionInfo()
        {
        }

        /// <summary> The name of the database containing the collection. </summary>
        public string DatabaseName { get; }
        /// <summary> Whether the collection is a capped collection (i.e. whether it has a fixed size and acts like a circular buffer). </summary>
        public bool IsCapped { get; }
        /// <summary> Whether the collection is system collection. </summary>
        public bool IsSystemCollection { get; }
        /// <summary> Whether the collection is a view of another collection. </summary>
        public bool IsView { get; }
        /// <summary> The shard key on the collection, or null if the collection is not sharded. </summary>
        public MongoDBShardKeyInfo ShardKey { get; }
        /// <summary> Whether the database has sharding enabled. Note that the migration task will enable sharding on the target if necessary. </summary>
        public bool SupportsSharding { get; }
        /// <summary> The name of the collection that this is a view of, if IsView is true. </summary>
        public string ViewOf { get; }
    }
}
