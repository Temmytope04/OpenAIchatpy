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
using Azure.ResourceManager.ContainerRegistry;
using Azure.ResourceManager.ContainerRegistry.Models;

namespace Azure.ResourceManager.ContainerRegistry.Samples
{
    public partial class Sample_ContainerRegistryWebhookCollection
    {
        // WebhookList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_WebhookList()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/stable/2022-12-01/examples/WebhookList.json
            // this example is just showing the usage of "Webhooks_List" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this ContainerRegistryWebhookResource
            ContainerRegistryWebhookCollection collection = containerRegistry.GetContainerRegistryWebhooks();

            // invoke the operation and iterate over the result
            await foreach (ContainerRegistryWebhookResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerRegistryWebhookData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // WebhookGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_WebhookGet()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/stable/2022-12-01/examples/WebhookGet.json
            // this example is just showing the usage of "Webhooks_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this ContainerRegistryWebhookResource
            ContainerRegistryWebhookCollection collection = containerRegistry.GetContainerRegistryWebhooks();

            // invoke the operation
            string webhookName = "myWebhook";
            ContainerRegistryWebhookResource result = await collection.GetAsync(webhookName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerRegistryWebhookData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WebhookGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_WebhookGet()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/stable/2022-12-01/examples/WebhookGet.json
            // this example is just showing the usage of "Webhooks_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this ContainerRegistryWebhookResource
            ContainerRegistryWebhookCollection collection = containerRegistry.GetContainerRegistryWebhooks();

            // invoke the operation
            string webhookName = "myWebhook";
            bool result = await collection.ExistsAsync(webhookName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // WebhookCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_WebhookCreate()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/stable/2022-12-01/examples/WebhookCreate.json
            // this example is just showing the usage of "Webhooks_Create" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this ContainerRegistryWebhookResource
            ContainerRegistryWebhookCollection collection = containerRegistry.GetContainerRegistryWebhooks();

            // invoke the operation
            string webhookName = "myWebhook";
            ContainerRegistryWebhookCreateOrUpdateContent content = new ContainerRegistryWebhookCreateOrUpdateContent(new AzureLocation("westus"))
            {
                Tags =
{
["key"] = "value",
},
                ServiceUri = new Uri("http://myservice.com"),
                CustomHeaders =
{
["Authorization"] = "******",
},
                Status = ContainerRegistryWebhookStatus.Enabled,
                Scope = "myRepository",
                Actions =
{
ContainerRegistryWebhookAction.Push
},
            };
            ArmOperation<ContainerRegistryWebhookResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, webhookName, content);
            ContainerRegistryWebhookResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerRegistryWebhookData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
