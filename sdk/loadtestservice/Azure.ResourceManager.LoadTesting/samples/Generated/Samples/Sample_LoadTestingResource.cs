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
using Azure.ResourceManager.LoadTesting;
using Azure.ResourceManager.LoadTesting.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.LoadTesting.Samples
{
    public partial class Sample_LoadTestingResource
    {
        // LoadTests_ListBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetLoadTestingResources_LoadTestsListBySubscription()
        {
            // Generated from example definition: specification/loadtestservice/resource-manager/Microsoft.LoadTestService/stable/2022-12-01/examples/LoadTests_ListBySubscription.json
            // this example is just showing the usage of "LoadTests_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (LoadTestingResource item in subscriptionResource.GetLoadTestingResourcesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                LoadTestingResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // LoadTests_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_LoadTestsGet()
        {
            // Generated from example definition: specification/loadtestservice/resource-manager/Microsoft.LoadTestService/stable/2022-12-01/examples/LoadTests_Get.json
            // this example is just showing the usage of "LoadTests_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LoadTestingResource created on azure
            // for more information of creating LoadTestingResource, please refer to the document of LoadTestingResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "dummyrg";
            string loadTestName = "myLoadTest";
            ResourceIdentifier loadTestingResourceId = LoadTestingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, loadTestName);
            LoadTestingResource loadTestingResource = client.GetLoadTestingResource(loadTestingResourceId);

            // invoke the operation
            LoadTestingResource result = await loadTestingResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LoadTestingResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // LoadTests_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_LoadTestsUpdate()
        {
            // Generated from example definition: specification/loadtestservice/resource-manager/Microsoft.LoadTestService/stable/2022-12-01/examples/LoadTests_Update.json
            // this example is just showing the usage of "LoadTests_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LoadTestingResource created on azure
            // for more information of creating LoadTestingResource, please refer to the document of LoadTestingResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "dummyrg";
            string loadTestName = "myLoadTest";
            ResourceIdentifier loadTestingResourceId = LoadTestingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, loadTestName);
            LoadTestingResource loadTestingResource = client.GetLoadTestingResource(loadTestingResourceId);

            // invoke the operation
            LoadTestingResourcePatch patch = new LoadTestingResourcePatch()
            {
                Tags =
{
["Division"] = "LT",
["Team"] = "Dev Exp",
},
                Identity = new ManagedServiceIdentity("SystemAssigned,UserAssigned")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/dummyrg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/id1")] = new UserAssignedIdentity(),
},
                },
                Description = "This is new load test resource",
                Encryption = new LoadTestingCmkEncryptionProperties()
                {
                    Identity = new LoadTestingCmkIdentity()
                    {
                        IdentityType = LoadTestingCmkIdentityType.SystemAssigned,
                        ResourceId = null,
                    },
                    KeyUri = new Uri("https://dummy.vault.azure.net/keys/dummykey1"),
                },
            };
            ArmOperation<LoadTestingResource> lro = await loadTestingResource.UpdateAsync(WaitUntil.Completed, patch);
            LoadTestingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LoadTestingResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // LoadTests_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_LoadTestsDelete()
        {
            // Generated from example definition: specification/loadtestservice/resource-manager/Microsoft.LoadTestService/stable/2022-12-01/examples/LoadTests_Delete.json
            // this example is just showing the usage of "LoadTests_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LoadTestingResource created on azure
            // for more information of creating LoadTestingResource, please refer to the document of LoadTestingResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "dummyrg";
            string loadTestName = "myLoadTest";
            ResourceIdentifier loadTestingResourceId = LoadTestingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, loadTestName);
            LoadTestingResource loadTestingResource = client.GetLoadTestingResource(loadTestingResourceId);

            // invoke the operation
            await loadTestingResource.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // ListOutboundNetworkDependencies
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetOutboundNetworkDependenciesEndpoints_ListOutboundNetworkDependencies()
        {
            // Generated from example definition: specification/loadtestservice/resource-manager/Microsoft.LoadTestService/stable/2022-12-01/examples/LoadTests_ListOutboundNetworkDependenciesEndpoints.json
            // this example is just showing the usage of "LoadTests_ListOutboundNetworkDependenciesEndpoints" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LoadTestingResource created on azure
            // for more information of creating LoadTestingResource, please refer to the document of LoadTestingResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azureloadtest-japaneast";
            string loadTestName = "sampleloadtest";
            ResourceIdentifier loadTestingResourceId = LoadTestingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, loadTestName);
            LoadTestingResource loadTestingResource = client.GetLoadTestingResource(loadTestingResourceId);

            // invoke the operation and iterate over the result
            await foreach (LoadTestingOutboundEnvironmentEndpoint item in loadTestingResource.GetOutboundNetworkDependenciesEndpointsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
