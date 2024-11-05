// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.PostgreSql.FlexibleServers.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Samples
{
    public partial class Sample_PostgreSqlFlexibleServerActiveDirectoryAdministratorResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ServerGet()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2024-08-01/examples/AdministratorGet.json
            // this example is just showing the usage of "Administrators_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlFlexibleServerActiveDirectoryAdministratorResource created on azure
            // for more information of creating PostgreSqlFlexibleServerActiveDirectoryAdministratorResource, please refer to the document of PostgreSqlFlexibleServerActiveDirectoryAdministratorResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "pgtestsvc1";
            string objectId = "oooooooo-oooo-oooo-oooo-oooooooooooo";
            ResourceIdentifier postgreSqlFlexibleServerActiveDirectoryAdministratorResourceId = PostgreSqlFlexibleServerActiveDirectoryAdministratorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, objectId);
            PostgreSqlFlexibleServerActiveDirectoryAdministratorResource postgreSqlFlexibleServerActiveDirectoryAdministrator = client.GetPostgreSqlFlexibleServerActiveDirectoryAdministratorResource(postgreSqlFlexibleServerActiveDirectoryAdministratorResourceId);

            // invoke the operation
            PostgreSqlFlexibleServerActiveDirectoryAdministratorResource result = await postgreSqlFlexibleServerActiveDirectoryAdministrator.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlFlexibleServerActiveDirectoryAdministratorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_AdministratorDelete()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2024-08-01/examples/AdministratorDelete.json
            // this example is just showing the usage of "Administrators_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlFlexibleServerActiveDirectoryAdministratorResource created on azure
            // for more information of creating PostgreSqlFlexibleServerActiveDirectoryAdministratorResource, please refer to the document of PostgreSqlFlexibleServerActiveDirectoryAdministratorResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "testserver";
            string objectId = "oooooooo-oooo-oooo-oooo-oooooooooooo";
            ResourceIdentifier postgreSqlFlexibleServerActiveDirectoryAdministratorResourceId = PostgreSqlFlexibleServerActiveDirectoryAdministratorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, objectId);
            PostgreSqlFlexibleServerActiveDirectoryAdministratorResource postgreSqlFlexibleServerActiveDirectoryAdministrator = client.GetPostgreSqlFlexibleServerActiveDirectoryAdministratorResource(postgreSqlFlexibleServerActiveDirectoryAdministratorResourceId);

            // invoke the operation
            await postgreSqlFlexibleServerActiveDirectoryAdministrator.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_AddsAnActiveDIrectoryAdministratorForTheServer()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2024-08-01/examples/AdministratorAdd.json
            // this example is just showing the usage of "Administrators_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlFlexibleServerActiveDirectoryAdministratorResource created on azure
            // for more information of creating PostgreSqlFlexibleServerActiveDirectoryAdministratorResource, please refer to the document of PostgreSqlFlexibleServerActiveDirectoryAdministratorResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "testserver";
            string objectId = "oooooooo-oooo-oooo-oooo-oooooooooooo";
            ResourceIdentifier postgreSqlFlexibleServerActiveDirectoryAdministratorResourceId = PostgreSqlFlexibleServerActiveDirectoryAdministratorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, objectId);
            PostgreSqlFlexibleServerActiveDirectoryAdministratorResource postgreSqlFlexibleServerActiveDirectoryAdministrator = client.GetPostgreSqlFlexibleServerActiveDirectoryAdministratorResource(postgreSqlFlexibleServerActiveDirectoryAdministratorResourceId);

            // invoke the operation
            PostgreSqlFlexibleServerActiveDirectoryAdministratorCreateOrUpdateContent content = new PostgreSqlFlexibleServerActiveDirectoryAdministratorCreateOrUpdateContent
            {
                PrincipalType = PostgreSqlFlexibleServerPrincipalType.User,
                PrincipalName = "testuser1@microsoft.com",
                TenantId = Guid.Parse("tttttttt-tttt-tttt-tttt-tttttttttttt"),
            };
            ArmOperation<PostgreSqlFlexibleServerActiveDirectoryAdministratorResource> lro = await postgreSqlFlexibleServerActiveDirectoryAdministrator.UpdateAsync(WaitUntil.Completed, content);
            PostgreSqlFlexibleServerActiveDirectoryAdministratorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlFlexibleServerActiveDirectoryAdministratorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
