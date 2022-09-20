// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters to create and update an Azure Cosmos DB Mongo Role Definition. </summary>
    public partial class MongoDBRoleDefinitionCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of MongoDBRoleDefinitionCreateOrUpdateContent. </summary>
        public MongoDBRoleDefinitionCreateOrUpdateContent()
        {
            Privileges = new ChangeTrackingList<MongoDBPrivilege>();
            Roles = new ChangeTrackingList<MongoDBRole>();
        }

        /// <summary> A user-friendly name for the Role Definition. Must be unique for the database account. </summary>
        public string RoleName { get; set; }
        /// <summary> Indicates whether the Role Definition was built-in or user created. </summary>
        public MongoDBRoleDefinitionType? DefinitionType { get; set; }
        /// <summary> The database name for which access is being granted for this Role Definition. </summary>
        public string DatabaseName { get; set; }
        /// <summary> A set of privileges contained by the Role Definition. This will allow application of this Role Definition on the entire database account or any underlying Database / Collection. Scopes higher than Database are not enforceable as privilege. </summary>
        public IList<MongoDBPrivilege> Privileges { get; }
        /// <summary> The set of roles inherited by this Role Definition. </summary>
        public IList<MongoDBRole> Roles { get; }
    }
}
