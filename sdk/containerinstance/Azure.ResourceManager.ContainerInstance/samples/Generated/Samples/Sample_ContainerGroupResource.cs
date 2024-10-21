// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ContainerInstance.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ContainerInstance.Samples
{
    public partial class Sample_ContainerGroupResource
    {
        // ContainerGroupsList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetContainerGroups_ContainerGroupsList()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerGroupsList.json
            // this example is just showing the usage of "ContainerGroups_List" operation, for the dependent resources, they will have to be created separately.

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
            await foreach (ContainerGroupResource item in subscriptionResource.GetContainerGroupsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ContainerGroupsGetWithPriority
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ContainerGroupsGetWithPriority()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerGroupsGetPriority.json
            // this example is just showing the usage of "ContainerGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerGroupResource created on azure
            // for more information of creating ContainerGroupResource, please refer to the document of ContainerGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "demo";
            string containerGroupName = "demo1";
            ResourceIdentifier containerGroupResourceId = ContainerGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerGroupName);
            ContainerGroupResource containerGroup = client.GetContainerGroupResource(containerGroupResourceId);

            // invoke the operation
            ContainerGroupResource result = await containerGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ContainerGroupsGet_Failed
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ContainerGroupsGetFailed()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerGroupsGet_Failed.json
            // this example is just showing the usage of "ContainerGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerGroupResource created on azure
            // for more information of creating ContainerGroupResource, please refer to the document of ContainerGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "demo";
            string containerGroupName = "demo1";
            ResourceIdentifier containerGroupResourceId = ContainerGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerGroupName);
            ContainerGroupResource containerGroup = client.GetContainerGroupResource(containerGroupResourceId);

            // invoke the operation
            ContainerGroupResource result = await containerGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ContainerGroupsGet_Succeeded
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ContainerGroupsGetSucceeded()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerGroupsGet_Succeeded.json
            // this example is just showing the usage of "ContainerGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerGroupResource created on azure
            // for more information of creating ContainerGroupResource, please refer to the document of ContainerGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "demo";
            string containerGroupName = "demo1";
            ResourceIdentifier containerGroupResourceId = ContainerGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerGroupName);
            ContainerGroupResource containerGroup = client.GetContainerGroupResource(containerGroupResourceId);

            // invoke the operation
            ContainerGroupResource result = await containerGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ContainerGroupsUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ContainerGroupsUpdate()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerGroupsUpdate.json
            // this example is just showing the usage of "ContainerGroups_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerGroupResource created on azure
            // for more information of creating ContainerGroupResource, please refer to the document of ContainerGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "demoResource";
            string containerGroupName = "demo1";
            ResourceIdentifier containerGroupResourceId = ContainerGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerGroupName);
            ContainerGroupResource containerGroup = client.GetContainerGroupResource(containerGroupResourceId);

            // invoke the operation
            ContainerGroupPatch patch = new ContainerGroupPatch(new AzureLocation("placeholder"))
            {
                Tags =
{
["tag1key"] = "tag1Value",
["tag2key"] = "tag2Value",
},
            };
            ContainerGroupResource result = await containerGroup.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ContainerGroupsDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ContainerGroupsDelete()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerGroupsDelete.json
            // this example is just showing the usage of "ContainerGroups_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerGroupResource created on azure
            // for more information of creating ContainerGroupResource, please refer to the document of ContainerGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "demo";
            string containerGroupName = "demo1";
            ResourceIdentifier containerGroupResourceId = ContainerGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerGroupName);
            ContainerGroupResource containerGroup = client.GetContainerGroupResource(containerGroupResourceId);

            // invoke the operation
            ArmOperation<ContainerGroupResource> lro = await containerGroup.DeleteAsync(WaitUntil.Completed);
            ContainerGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ContainerRestart
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Restart_ContainerRestart()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerGroupsRestart.json
            // this example is just showing the usage of "ContainerGroups_Restart" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerGroupResource created on azure
            // for more information of creating ContainerGroupResource, please refer to the document of ContainerGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "demo";
            string containerGroupName = "demo1";
            ResourceIdentifier containerGroupResourceId = ContainerGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerGroupName);
            ContainerGroupResource containerGroup = client.GetContainerGroupResource(containerGroupResourceId);

            // invoke the operation
            await containerGroup.RestartAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // ContainerStop
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Stop_ContainerStop()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerGroupsStop.json
            // this example is just showing the usage of "ContainerGroups_Stop" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerGroupResource created on azure
            // for more information of creating ContainerGroupResource, please refer to the document of ContainerGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "demo";
            string containerGroupName = "demo1";
            ResourceIdentifier containerGroupResourceId = ContainerGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerGroupName);
            ContainerGroupResource containerGroup = client.GetContainerGroupResource(containerGroupResourceId);

            // invoke the operation
            await containerGroup.StopAsync();

            Console.WriteLine($"Succeeded");
        }

        // ContainerStart
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Start_ContainerStart()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerGroupsStart.json
            // this example is just showing the usage of "ContainerGroups_Start" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerGroupResource created on azure
            // for more information of creating ContainerGroupResource, please refer to the document of ContainerGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "demo";
            string containerGroupName = "demo1";
            ResourceIdentifier containerGroupResourceId = ContainerGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerGroupName);
            ContainerGroupResource containerGroup = client.GetContainerGroupResource(containerGroupResourceId);

            // invoke the operation
            await containerGroup.StartAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // ContainerListLogs
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetContainerLogs_ContainerListLogs()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerListLogs.json
            // this example is just showing the usage of "Containers_ListLogs" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerGroupResource created on azure
            // for more information of creating ContainerGroupResource, please refer to the document of ContainerGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "demo";
            string containerGroupName = "demo1";
            ResourceIdentifier containerGroupResourceId = ContainerGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerGroupName);
            ContainerGroupResource containerGroup = client.GetContainerGroupResource(containerGroupResourceId);

            // invoke the operation
            string containerName = "container1";
            int? tail = 10;
            ContainerLogs result = await containerGroup.GetContainerLogsAsync(containerName, tail: tail);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ContainerExec
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ExecuteContainerCommand_ContainerExec()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerExec.json
            // this example is just showing the usage of "Containers_ExecuteCommand" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerGroupResource created on azure
            // for more information of creating ContainerGroupResource, please refer to the document of ContainerGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "demo";
            string containerGroupName = "demo1";
            ResourceIdentifier containerGroupResourceId = ContainerGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerGroupName);
            ContainerGroupResource containerGroup = client.GetContainerGroupResource(containerGroupResourceId);

            // invoke the operation
            string containerName = "container1";
            ContainerExecContent content = new ContainerExecContent()
            {
                Command = "/bin/bash",
                TerminalSize = new ContainerExecRequestTerminalSize()
                {
                    Rows = 12,
                    Cols = 12,
                },
            };
            ContainerExecResult result = await containerGroup.ExecuteContainerCommandAsync(containerName, content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ContainerAttach
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task AttachContainer_ContainerAttach()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerAttach.json
            // this example is just showing the usage of "Containers_Attach" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerGroupResource created on azure
            // for more information of creating ContainerGroupResource, please refer to the document of ContainerGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "demo";
            string containerGroupName = "demo1";
            ResourceIdentifier containerGroupResourceId = ContainerGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerGroupName);
            ContainerGroupResource containerGroup = client.GetContainerGroupResource(containerGroupResourceId);

            // invoke the operation
            string containerName = "container1";
            ContainerAttachResult result = await containerGroup.AttachContainerAsync(containerName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
