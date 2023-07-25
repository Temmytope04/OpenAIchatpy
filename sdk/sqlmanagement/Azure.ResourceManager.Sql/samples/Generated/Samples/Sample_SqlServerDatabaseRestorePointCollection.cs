// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_SqlServerDatabaseRestorePointCollection
    {
        // List database restore points.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListDatabaseRestorePoints()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/DatabaseRestorePointsListByDatabase.json
            // this example is just showing the usage of "RestorePoints_ListByDatabase" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6730";
            string serverName = "sqlcrudtest-9007";
            string databaseName = "3481";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this SqlServerDatabaseRestorePointResource
            SqlServerDatabaseRestorePointCollection collection = sqlDatabase.GetSqlServerDatabaseRestorePoints();

            // invoke the operation and iterate over the result
            await foreach (SqlServerDatabaseRestorePointResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SqlServerDatabaseRestorePointData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List datawarehouse database restore points.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListDatawarehouseDatabaseRestorePoints()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/DataWarehouseRestorePointsListByDatabase.json
            // this example is just showing the usage of "RestorePoints_ListByDatabase" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string serverName = "testserver";
            string databaseName = "testDatabase";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this SqlServerDatabaseRestorePointResource
            SqlServerDatabaseRestorePointCollection collection = sqlDatabase.GetSqlServerDatabaseRestorePoints();

            // invoke the operation and iterate over the result
            await foreach (SqlServerDatabaseRestorePointResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SqlServerDatabaseRestorePointData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Gets a database restore point.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsADatabaseRestorePoint()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/DatabaseRestorePointsGet.json
            // this example is just showing the usage of "RestorePoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string serverName = "testserver";
            string databaseName = "testDatabase";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this SqlServerDatabaseRestorePointResource
            SqlServerDatabaseRestorePointCollection collection = sqlDatabase.GetSqlServerDatabaseRestorePoints();

            // invoke the operation
            string restorePointName = "131546477590000000";
            SqlServerDatabaseRestorePointResource result = await collection.GetAsync(restorePointName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerDatabaseRestorePointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets a database restore point.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetsADatabaseRestorePoint()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/DatabaseRestorePointsGet.json
            // this example is just showing the usage of "RestorePoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string serverName = "testserver";
            string databaseName = "testDatabase";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this SqlServerDatabaseRestorePointResource
            SqlServerDatabaseRestorePointCollection collection = sqlDatabase.GetSqlServerDatabaseRestorePoints();

            // invoke the operation
            string restorePointName = "131546477590000000";
            bool result = await collection.ExistsAsync(restorePointName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Gets a datawarehouse database restore point.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsADatawarehouseDatabaseRestorePoint()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/DataWarehouseRestorePointsGet.json
            // this example is just showing the usage of "RestorePoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string serverName = "testserver";
            string databaseName = "testDatabase";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this SqlServerDatabaseRestorePointResource
            SqlServerDatabaseRestorePointCollection collection = sqlDatabase.GetSqlServerDatabaseRestorePoints();

            // invoke the operation
            string restorePointName = "131546477590000000";
            SqlServerDatabaseRestorePointResource result = await collection.GetAsync(restorePointName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerDatabaseRestorePointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets a datawarehouse database restore point.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetsADatawarehouseDatabaseRestorePoint()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/DataWarehouseRestorePointsGet.json
            // this example is just showing the usage of "RestorePoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string serverName = "testserver";
            string databaseName = "testDatabase";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this SqlServerDatabaseRestorePointResource
            SqlServerDatabaseRestorePointCollection collection = sqlDatabase.GetSqlServerDatabaseRestorePoints();

            // invoke the operation
            string restorePointName = "131546477590000000";
            bool result = await collection.ExistsAsync(restorePointName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
