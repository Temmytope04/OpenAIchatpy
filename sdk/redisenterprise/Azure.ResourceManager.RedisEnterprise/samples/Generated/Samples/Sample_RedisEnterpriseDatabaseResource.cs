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
using Azure.ResourceManager.RedisEnterprise;
using Azure.ResourceManager.RedisEnterprise.Models;

namespace Azure.ResourceManager.RedisEnterprise.Samples
{
    public partial class Sample_RedisEnterpriseDatabaseResource
    {
        // RedisEnterpriseDatabasesUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_RedisEnterpriseDatabasesUpdate()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/preview/2023-03-01-preview/examples/RedisEnterpriseDatabasesUpdate.json
            // this example is just showing the usage of "Databases_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterpriseDatabaseResource created on azure
            // for more information of creating RedisEnterpriseDatabaseResource, please refer to the document of RedisEnterpriseDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            string databaseName = "default";
            ResourceIdentifier redisEnterpriseDatabaseResourceId = RedisEnterpriseDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            RedisEnterpriseDatabaseResource redisEnterpriseDatabase = client.GetRedisEnterpriseDatabaseResource(redisEnterpriseDatabaseResourceId);

            // invoke the operation
            RedisEnterpriseDatabasePatch patch = new RedisEnterpriseDatabasePatch()
            {
                ClientProtocol = RedisEnterpriseClientProtocol.Encrypted,
                EvictionPolicy = RedisEnterpriseEvictionPolicy.AllKeysLru,
                Persistence = new RedisPersistenceSettings()
                {
                    IsRdbEnabled = true,
                    RdbFrequency = PersistenceSettingRdbFrequency.TwelveHours,
                },
            };
            ArmOperation<RedisEnterpriseDatabaseResource> lro = await redisEnterpriseDatabase.UpdateAsync(WaitUntil.Completed, patch);
            RedisEnterpriseDatabaseResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RedisEnterpriseDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RedisEnterpriseDatabasesGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_RedisEnterpriseDatabasesGet()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/preview/2023-03-01-preview/examples/RedisEnterpriseDatabasesGet.json
            // this example is just showing the usage of "Databases_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterpriseDatabaseResource created on azure
            // for more information of creating RedisEnterpriseDatabaseResource, please refer to the document of RedisEnterpriseDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            string databaseName = "default";
            ResourceIdentifier redisEnterpriseDatabaseResourceId = RedisEnterpriseDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            RedisEnterpriseDatabaseResource redisEnterpriseDatabase = client.GetRedisEnterpriseDatabaseResource(redisEnterpriseDatabaseResourceId);

            // invoke the operation
            RedisEnterpriseDatabaseResource result = await redisEnterpriseDatabase.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RedisEnterpriseDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RedisEnterpriseDatabasesDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_RedisEnterpriseDatabasesDelete()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/preview/2023-03-01-preview/examples/RedisEnterpriseDatabasesDelete.json
            // this example is just showing the usage of "Databases_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterpriseDatabaseResource created on azure
            // for more information of creating RedisEnterpriseDatabaseResource, please refer to the document of RedisEnterpriseDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            string databaseName = "db1";
            ResourceIdentifier redisEnterpriseDatabaseResourceId = RedisEnterpriseDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            RedisEnterpriseDatabaseResource redisEnterpriseDatabase = client.GetRedisEnterpriseDatabaseResource(redisEnterpriseDatabaseResourceId);

            // invoke the operation
            await redisEnterpriseDatabase.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // RedisEnterpriseDatabasesListKeys
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetKeys_RedisEnterpriseDatabasesListKeys()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/preview/2023-03-01-preview/examples/RedisEnterpriseDatabasesListKeys.json
            // this example is just showing the usage of "Databases_ListKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterpriseDatabaseResource created on azure
            // for more information of creating RedisEnterpriseDatabaseResource, please refer to the document of RedisEnterpriseDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            string databaseName = "default";
            ResourceIdentifier redisEnterpriseDatabaseResourceId = RedisEnterpriseDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            RedisEnterpriseDatabaseResource redisEnterpriseDatabase = client.GetRedisEnterpriseDatabaseResource(redisEnterpriseDatabaseResourceId);

            // invoke the operation
            RedisEnterpriseDataAccessKeys result = await redisEnterpriseDatabase.GetKeysAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // RedisEnterpriseDatabasesRegenerateKey
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RegenerateKey_RedisEnterpriseDatabasesRegenerateKey()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/preview/2023-03-01-preview/examples/RedisEnterpriseDatabasesRegenerateKey.json
            // this example is just showing the usage of "Databases_RegenerateKey" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterpriseDatabaseResource created on azure
            // for more information of creating RedisEnterpriseDatabaseResource, please refer to the document of RedisEnterpriseDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            string databaseName = "default";
            ResourceIdentifier redisEnterpriseDatabaseResourceId = RedisEnterpriseDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            RedisEnterpriseDatabaseResource redisEnterpriseDatabase = client.GetRedisEnterpriseDatabaseResource(redisEnterpriseDatabaseResourceId);

            // invoke the operation
            RedisEnterpriseRegenerateKeyContent content = new RedisEnterpriseRegenerateKeyContent(RedisEnterpriseAccessKeyType.Primary);
            ArmOperation<RedisEnterpriseDataAccessKeys> lro = await redisEnterpriseDatabase.RegenerateKeyAsync(WaitUntil.Completed, content);
            RedisEnterpriseDataAccessKeys result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // RedisEnterpriseDatabasesImport
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Import_RedisEnterpriseDatabasesImport()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/preview/2023-03-01-preview/examples/RedisEnterpriseDatabasesImport.json
            // this example is just showing the usage of "Databases_Import" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterpriseDatabaseResource created on azure
            // for more information of creating RedisEnterpriseDatabaseResource, please refer to the document of RedisEnterpriseDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            string databaseName = "default";
            ResourceIdentifier redisEnterpriseDatabaseResourceId = RedisEnterpriseDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            RedisEnterpriseDatabaseResource redisEnterpriseDatabase = client.GetRedisEnterpriseDatabaseResource(redisEnterpriseDatabaseResourceId);

            // invoke the operation
            ImportRedisEnterpriseDatabaseContent content = new ImportRedisEnterpriseDatabaseContent(new Uri[]
            {
new Uri("https://contosostorage.blob.core.window.net/urltoBlobFile1?sasKeyParameters"),new Uri("https://contosostorage.blob.core.window.net/urltoBlobFile2?sasKeyParameters")
            });
            await redisEnterpriseDatabase.ImportAsync(WaitUntil.Completed, content);

            Console.WriteLine($"Succeeded");
        }

        // RedisEnterpriseDatabasesExport
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Export_RedisEnterpriseDatabasesExport()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/preview/2023-03-01-preview/examples/RedisEnterpriseDatabasesExport.json
            // this example is just showing the usage of "Databases_Export" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterpriseDatabaseResource created on azure
            // for more information of creating RedisEnterpriseDatabaseResource, please refer to the document of RedisEnterpriseDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            string databaseName = "default";
            ResourceIdentifier redisEnterpriseDatabaseResourceId = RedisEnterpriseDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            RedisEnterpriseDatabaseResource redisEnterpriseDatabase = client.GetRedisEnterpriseDatabaseResource(redisEnterpriseDatabaseResourceId);

            // invoke the operation
            ExportRedisEnterpriseDatabaseContent content = new ExportRedisEnterpriseDatabaseContent(new Uri("https://contosostorage.blob.core.window.net/urlToBlobContainer?sasKeyParameters"));
            await redisEnterpriseDatabase.ExportAsync(WaitUntil.Completed, content);

            Console.WriteLine($"Succeeded");
        }

        // How to unlink a database during a regional outage
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ForceUnlink_HowToUnlinkADatabaseDuringARegionalOutage()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/preview/2023-03-01-preview/examples/RedisEnterpriseDatabasesForceUnlink.json
            // this example is just showing the usage of "Databases_ForceUnlink" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterpriseDatabaseResource created on azure
            // for more information of creating RedisEnterpriseDatabaseResource, please refer to the document of RedisEnterpriseDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            string databaseName = "default";
            ResourceIdentifier redisEnterpriseDatabaseResourceId = RedisEnterpriseDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            RedisEnterpriseDatabaseResource redisEnterpriseDatabase = client.GetRedisEnterpriseDatabaseResource(redisEnterpriseDatabaseResourceId);

            // invoke the operation
            ForceUnlinkRedisEnterpriseDatabaseContent content = new ForceUnlinkRedisEnterpriseDatabaseContent(new ResourceIdentifier[]
            {
new ResourceIdentifier("/subscriptions/subid2/resourceGroups/rg2/providers/Microsoft.Cache/redisEnterprise/cache2/databases/default")
            });
            await redisEnterpriseDatabase.ForceUnlinkAsync(WaitUntil.Completed, content);

            Console.WriteLine($"Succeeded");
        }

        // How to flush all the keys in the database
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Flush_HowToFlushAllTheKeysInTheDatabase()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/preview/2023-03-01-preview/examples/RedisEnterpriseDatabasesFlush.json
            // this example is just showing the usage of "Databases_Flush" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterpriseDatabaseResource created on azure
            // for more information of creating RedisEnterpriseDatabaseResource, please refer to the document of RedisEnterpriseDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            string databaseName = "default";
            ResourceIdentifier redisEnterpriseDatabaseResourceId = RedisEnterpriseDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            RedisEnterpriseDatabaseResource redisEnterpriseDatabase = client.GetRedisEnterpriseDatabaseResource(redisEnterpriseDatabaseResourceId);

            // invoke the operation
            FlushRedisEnterpriseDatabaseContent content = new FlushRedisEnterpriseDatabaseContent()
            {
                Ids =
{
"/subscriptions/subid2/resourceGroups/rg2/providers/Microsoft.Cache/redisEnterprise/cache2/databases/default"
},
            };
            await redisEnterpriseDatabase.FlushAsync(WaitUntil.Completed, content);

            Console.WriteLine($"Succeeded");
        }
    }
}
