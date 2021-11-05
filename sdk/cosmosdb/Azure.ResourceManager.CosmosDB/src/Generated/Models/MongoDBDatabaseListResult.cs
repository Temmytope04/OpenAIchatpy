// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The List operation response, that contains the MongoDB databases and their properties. </summary>
    internal partial class MongoDBDatabaseListResult
    {
        /// <summary> Initializes a new instance of MongoDBDatabaseListResult. </summary>
        internal MongoDBDatabaseListResult()
        {
            Value = new ChangeTrackingList<MongoDBDatabaseGetResults>();
        }

        /// <summary> Initializes a new instance of MongoDBDatabaseListResult. </summary>
        /// <param name="value"> List of MongoDB databases and their properties. </param>
        internal MongoDBDatabaseListResult(IReadOnlyList<MongoDBDatabaseGetResults> value)
        {
            Value = value;
        }

        /// <summary> List of MongoDB databases and their properties. </summary>
        public IReadOnlyList<MongoDBDatabaseGetResults> Value { get; }
    }
}
