// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ContainerRegistry.Models;

namespace Azure.ResourceManager.ContainerRegistry.Samples
{
    public partial class Sample_ContainerRegistryReplicationCollection
    {
        // ReplicationList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ReplicationList()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/stable/2022-12-01/examples/ReplicationList.json
            // this example is just showing the usage of "Replications_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryResource created on azure
            // for more information of creating ContainerRegistryResource, please refer to the document of ContainerRegistryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            ResourceIdentifier containerRegistryResourceId = ContainerRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            ContainerRegistryResource containerRegistry = client.GetContainerRegistryResource(containerRegistryResourceId);

            // get the collection of this ContainerRegistryReplicationResource
            ContainerRegistryReplicationCollection collection = containerRegistry.GetContainerRegistryReplications();

            // invoke the operation and iterate over the result
            await foreach (ContainerRegistryReplicationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerRegistryReplicationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ReplicationGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ReplicationGet()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/stable/2022-12-01/examples/ReplicationGet.json
            // this example is just showing the usage of "Replications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryResource created on azure
            // for more information of creating ContainerRegistryResource, please refer to the document of ContainerRegistryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            ResourceIdentifier containerRegistryResourceId = ContainerRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            ContainerRegistryResource containerRegistry = client.GetContainerRegistryResource(containerRegistryResourceId);

            // get the collection of this ContainerRegistryReplicationResource
            ContainerRegistryReplicationCollection collection = containerRegistry.GetContainerRegistryReplications();

            // invoke the operation
            string replicationName = "myReplication";
            ContainerRegistryReplicationResource result = await collection.GetAsync(replicationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerRegistryReplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ReplicationGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ReplicationGet()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/stable/2022-12-01/examples/ReplicationGet.json
            // this example is just showing the usage of "Replications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryResource created on azure
            // for more information of creating ContainerRegistryResource, please refer to the document of ContainerRegistryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            ResourceIdentifier containerRegistryResourceId = ContainerRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            ContainerRegistryResource containerRegistry = client.GetContainerRegistryResource(containerRegistryResourceId);

            // get the collection of this ContainerRegistryReplicationResource
            ContainerRegistryReplicationCollection collection = containerRegistry.GetContainerRegistryReplications();

            // invoke the operation
            string replicationName = "myReplication";
            bool result = await collection.ExistsAsync(replicationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ReplicationGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ReplicationGet()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/stable/2022-12-01/examples/ReplicationGet.json
            // this example is just showing the usage of "Replications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryResource created on azure
            // for more information of creating ContainerRegistryResource, please refer to the document of ContainerRegistryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            ResourceIdentifier containerRegistryResourceId = ContainerRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            ContainerRegistryResource containerRegistry = client.GetContainerRegistryResource(containerRegistryResourceId);

            // get the collection of this ContainerRegistryReplicationResource
            ContainerRegistryReplicationCollection collection = containerRegistry.GetContainerRegistryReplications();

            // invoke the operation
            string replicationName = "myReplication";
            NullableResponse<ContainerRegistryReplicationResource> response = await collection.GetIfExistsAsync(replicationName);
            ContainerRegistryReplicationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerRegistryReplicationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ReplicationCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ReplicationCreate()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/stable/2022-12-01/examples/ReplicationCreate.json
            // this example is just showing the usage of "Replications_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryResource created on azure
            // for more information of creating ContainerRegistryResource, please refer to the document of ContainerRegistryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            ResourceIdentifier containerRegistryResourceId = ContainerRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            ContainerRegistryResource containerRegistry = client.GetContainerRegistryResource(containerRegistryResourceId);

            // get the collection of this ContainerRegistryReplicationResource
            ContainerRegistryReplicationCollection collection = containerRegistry.GetContainerRegistryReplications();

            // invoke the operation
            string replicationName = "myReplication";
            ContainerRegistryReplicationData data = new ContainerRegistryReplicationData(new AzureLocation("eastus"))
            {
                Tags =
{
["key"] = "value",
},
            };
            ArmOperation<ContainerRegistryReplicationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, replicationName, data);
            ContainerRegistryReplicationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerRegistryReplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ReplicationCreateZoneRedundant
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ReplicationCreateZoneRedundant()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/stable/2022-12-01/examples/ReplicationCreateZoneRedundant.json
            // this example is just showing the usage of "Replications_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryResource created on azure
            // for more information of creating ContainerRegistryResource, please refer to the document of ContainerRegistryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            ResourceIdentifier containerRegistryResourceId = ContainerRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            ContainerRegistryResource containerRegistry = client.GetContainerRegistryResource(containerRegistryResourceId);

            // get the collection of this ContainerRegistryReplicationResource
            ContainerRegistryReplicationCollection collection = containerRegistry.GetContainerRegistryReplications();

            // invoke the operation
            string replicationName = "myReplication";
            ContainerRegistryReplicationData data = new ContainerRegistryReplicationData(new AzureLocation("eastus"))
            {
                IsRegionEndpointEnabled = true,
                ZoneRedundancy = ContainerRegistryZoneRedundancy.Enabled,
                Tags =
{
["key"] = "value",
},
            };
            ArmOperation<ContainerRegistryReplicationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, replicationName, data);
            ContainerRegistryReplicationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerRegistryReplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
