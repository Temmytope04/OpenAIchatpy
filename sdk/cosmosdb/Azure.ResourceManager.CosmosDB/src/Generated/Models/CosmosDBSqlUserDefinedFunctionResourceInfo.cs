// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB SQL userDefinedFunction resource object. </summary>
    public partial class CosmosDBSqlUserDefinedFunctionResourceInfo
    {
        /// <summary> Initializes a new instance of CosmosDBSqlUserDefinedFunctionResourceInfo. </summary>
        /// <param name="functionName"> Name of the Cosmos DB SQL userDefinedFunction. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> is null. </exception>
        public CosmosDBSqlUserDefinedFunctionResourceInfo(string functionName)
        {
            if (functionName == null)
            {
                throw new ArgumentNullException(nameof(functionName));
            }

            FunctionName = functionName;
        }

        /// <summary> Initializes a new instance of CosmosDBSqlUserDefinedFunctionResourceInfo. </summary>
        /// <param name="functionName"> Name of the Cosmos DB SQL userDefinedFunction. </param>
        /// <param name="body"> Body of the User Defined Function. </param>
        internal CosmosDBSqlUserDefinedFunctionResourceInfo(string functionName, string body)
        {
            FunctionName = functionName;
            Body = body;
        }

        /// <summary> Name of the Cosmos DB SQL userDefinedFunction. </summary>
        public string FunctionName { get; set; }
        /// <summary> Body of the User Defined Function. </summary>
        public string Body { get; set; }
    }
}
