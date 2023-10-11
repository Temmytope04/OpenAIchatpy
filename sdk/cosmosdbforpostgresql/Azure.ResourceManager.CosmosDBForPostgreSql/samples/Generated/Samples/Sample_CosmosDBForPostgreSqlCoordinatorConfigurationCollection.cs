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
using Azure.ResourceManager.CosmosDBForPostgreSql;

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Samples
{
    public partial class Sample_CosmosDBForPostgreSqlCoordinatorConfigurationCollection
    {
        // Get configuration details for coordinator.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetConfigurationDetailsForCoordinator()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/ConfigurationGetCoordinator.json
            // this example is just showing the usage of "Configurations_GetCoordinator" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBForPostgreSqlClusterResource created on azure
            // for more information of creating CosmosDBForPostgreSqlClusterResource, please refer to the document of CosmosDBForPostgreSqlClusterResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestResourceGroup";
            string clusterName = "testcluster";
            ResourceIdentifier cosmosDBForPostgreSqlClusterResourceId = CosmosDBForPostgreSqlClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CosmosDBForPostgreSqlClusterResource cosmosDBForPostgreSqlCluster = client.GetCosmosDBForPostgreSqlClusterResource(cosmosDBForPostgreSqlClusterResourceId);

            // get the collection of this CosmosDBForPostgreSqlCoordinatorConfigurationResource
            CosmosDBForPostgreSqlCoordinatorConfigurationCollection collection = cosmosDBForPostgreSqlCluster.GetCosmosDBForPostgreSqlCoordinatorConfigurations();

            // invoke the operation
            string configurationName = "array_nulls";
            CosmosDBForPostgreSqlCoordinatorConfigurationResource result = await collection.GetAsync(configurationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBForPostgreSqlServerConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get configuration details for coordinator.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetConfigurationDetailsForCoordinator()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/ConfigurationGetCoordinator.json
            // this example is just showing the usage of "Configurations_GetCoordinator" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBForPostgreSqlClusterResource created on azure
            // for more information of creating CosmosDBForPostgreSqlClusterResource, please refer to the document of CosmosDBForPostgreSqlClusterResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestResourceGroup";
            string clusterName = "testcluster";
            ResourceIdentifier cosmosDBForPostgreSqlClusterResourceId = CosmosDBForPostgreSqlClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CosmosDBForPostgreSqlClusterResource cosmosDBForPostgreSqlCluster = client.GetCosmosDBForPostgreSqlClusterResource(cosmosDBForPostgreSqlClusterResourceId);

            // get the collection of this CosmosDBForPostgreSqlCoordinatorConfigurationResource
            CosmosDBForPostgreSqlCoordinatorConfigurationCollection collection = cosmosDBForPostgreSqlCluster.GetCosmosDBForPostgreSqlCoordinatorConfigurations();

            // invoke the operation
            string configurationName = "array_nulls";
            bool result = await collection.ExistsAsync(configurationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get configuration details for coordinator.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetConfigurationDetailsForCoordinator()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/ConfigurationGetCoordinator.json
            // this example is just showing the usage of "Configurations_GetCoordinator" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBForPostgreSqlClusterResource created on azure
            // for more information of creating CosmosDBForPostgreSqlClusterResource, please refer to the document of CosmosDBForPostgreSqlClusterResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestResourceGroup";
            string clusterName = "testcluster";
            ResourceIdentifier cosmosDBForPostgreSqlClusterResourceId = CosmosDBForPostgreSqlClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CosmosDBForPostgreSqlClusterResource cosmosDBForPostgreSqlCluster = client.GetCosmosDBForPostgreSqlClusterResource(cosmosDBForPostgreSqlClusterResourceId);

            // get the collection of this CosmosDBForPostgreSqlCoordinatorConfigurationResource
            CosmosDBForPostgreSqlCoordinatorConfigurationCollection collection = cosmosDBForPostgreSqlCluster.GetCosmosDBForPostgreSqlCoordinatorConfigurations();

            // invoke the operation
            string configurationName = "array_nulls";
            NullableResponse<CosmosDBForPostgreSqlCoordinatorConfigurationResource> response = await collection.GetIfExistsAsync(configurationName);
            CosmosDBForPostgreSqlCoordinatorConfigurationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CosmosDBForPostgreSqlServerConfigurationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Update single configuration of coordinator
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_UpdateSingleConfigurationOfCoordinator()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/ConfigurationUpdateCoordinator.json
            // this example is just showing the usage of "Configurations_UpdateOnCoordinator" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBForPostgreSqlClusterResource created on azure
            // for more information of creating CosmosDBForPostgreSqlClusterResource, please refer to the document of CosmosDBForPostgreSqlClusterResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestResourceGroup";
            string clusterName = "testcluster";
            ResourceIdentifier cosmosDBForPostgreSqlClusterResourceId = CosmosDBForPostgreSqlClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CosmosDBForPostgreSqlClusterResource cosmosDBForPostgreSqlCluster = client.GetCosmosDBForPostgreSqlClusterResource(cosmosDBForPostgreSqlClusterResourceId);

            // get the collection of this CosmosDBForPostgreSqlCoordinatorConfigurationResource
            CosmosDBForPostgreSqlCoordinatorConfigurationCollection collection = cosmosDBForPostgreSqlCluster.GetCosmosDBForPostgreSqlCoordinatorConfigurations();

            // invoke the operation
            string configurationName = "array_nulls";
            CosmosDBForPostgreSqlServerConfigurationData data = new CosmosDBForPostgreSqlServerConfigurationData()
            {
                Value = "on",
            };
            ArmOperation<CosmosDBForPostgreSqlCoordinatorConfigurationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, configurationName, data);
            CosmosDBForPostgreSqlCoordinatorConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBForPostgreSqlServerConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
