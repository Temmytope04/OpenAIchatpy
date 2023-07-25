// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_SyncMemberResource
    {
        // Get a sync member
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetASyncMember()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/SyncMemberGet.json
            // this example is just showing the usage of "SyncMembers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SyncMemberResource created on azure
            // for more information of creating SyncMemberResource, please refer to the document of SyncMemberResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "syncgroupcrud-65440";
            string serverName = "syncgroupcrud-8475";
            string databaseName = "syncgroupcrud-4328";
            string syncGroupName = "syncgroupcrud-3187";
            string syncMemberName = "syncmembercrud-4879";
            ResourceIdentifier syncMemberResourceId = SyncMemberResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, syncGroupName, syncMemberName);
            SyncMemberResource syncMember = client.GetSyncMemberResource(syncMemberResourceId);

            // invoke the operation
            SyncMemberResource result = await syncMember.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SyncMemberData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a sync member
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteASyncMember()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/SyncMemberDelete.json
            // this example is just showing the usage of "SyncMembers_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SyncMemberResource created on azure
            // for more information of creating SyncMemberResource, please refer to the document of SyncMemberResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "syncgroupcrud-65440";
            string serverName = "syncgroupcrud-8475";
            string databaseName = "syncgroupcrud-4328";
            string syncGroupName = "syncgroupcrud-3187";
            string syncMemberName = "syncgroupcrud-4879";
            ResourceIdentifier syncMemberResourceId = SyncMemberResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, syncGroupName, syncMemberName);
            SyncMemberResource syncMember = client.GetSyncMemberResource(syncMemberResourceId);

            // invoke the operation
            await syncMember.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Update an existing sync member
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAnExistingSyncMember()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/SyncMemberPatch.json
            // this example is just showing the usage of "SyncMembers_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SyncMemberResource created on azure
            // for more information of creating SyncMemberResource, please refer to the document of SyncMemberResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "syncgroupcrud-65440";
            string serverName = "syncgroupcrud-8475";
            string databaseName = "syncgroupcrud-4328";
            string syncGroupName = "syncgroupcrud-3187";
            string syncMemberName = "syncmembercrud-4879";
            ResourceIdentifier syncMemberResourceId = SyncMemberResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, syncGroupName, syncMemberName);
            SyncMemberResource syncMember = client.GetSyncMemberResource(syncMemberResourceId);

            // invoke the operation
            SyncMemberData data = new SyncMemberData()
            {
                DatabaseType = SyncMemberDbType.AzureSqlDatabase,
                SyncMemberAzureDatabaseResourceId = new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/syncgroupcrud-65440/providers/Microsoft.Sql/servers/syncgroupcrud-8475/databases/syncgroupcrud-4328"),
                UsePrivateLinkConnection = true,
                ServerName = "syncgroupcrud-3379.database.windows.net",
                DatabaseName = "syncgroupcrud-7421",
                UserName = "myUser",
                SyncDirection = SyncDirection.Bidirectional,
            };
            ArmOperation<SyncMemberResource> lro = await syncMember.UpdateAsync(WaitUntil.Completed, data);
            SyncMemberResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SyncMemberData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a sync member schema
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetMemberSchemas_GetASyncMemberSchema()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/SyncMemberGetSchema.json
            // this example is just showing the usage of "SyncMembers_ListMemberSchemas" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SyncMemberResource created on azure
            // for more information of creating SyncMemberResource, please refer to the document of SyncMemberResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "syncgroupcrud-65440";
            string serverName = "syncgroupcrud-8475";
            string databaseName = "syncgroupcrud-4328";
            string syncGroupName = "syncgroupcrud-3187";
            string syncMemberName = "syncgroupcrud-4879";
            ResourceIdentifier syncMemberResourceId = SyncMemberResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, syncGroupName, syncMemberName);
            SyncMemberResource syncMember = client.GetSyncMemberResource(syncMemberResourceId);

            // invoke the operation and iterate over the result
            await foreach (SyncFullSchemaProperties item in syncMember.GetMemberSchemasAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Refresh a sync member database schema
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RefreshMemberSchema_RefreshASyncMemberDatabaseSchema()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/SyncMemberRefreshSchema.json
            // this example is just showing the usage of "SyncMembers_RefreshMemberSchema" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SyncMemberResource created on azure
            // for more information of creating SyncMemberResource, please refer to the document of SyncMemberResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "syncgroupcrud-65440";
            string serverName = "syncgroupcrud-8475";
            string databaseName = "syncgroupcrud-4328";
            string syncGroupName = "syncgroupcrud-3187";
            string syncMemberName = "syncgroupcrud-4879";
            ResourceIdentifier syncMemberResourceId = SyncMemberResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, syncGroupName, syncMemberName);
            SyncMemberResource syncMember = client.GetSyncMemberResource(syncMemberResourceId);

            // invoke the operation
            await syncMember.RefreshMemberSchemaAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
