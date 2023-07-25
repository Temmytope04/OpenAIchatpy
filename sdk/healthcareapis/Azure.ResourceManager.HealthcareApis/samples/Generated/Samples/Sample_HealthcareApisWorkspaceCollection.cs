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
using Azure.ResourceManager.HealthcareApis;
using Azure.ResourceManager.HealthcareApis.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HealthcareApis.Samples
{
    public partial class Sample_HealthcareApisWorkspaceCollection
    {
        // Get workspaces by resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetWorkspacesByResourceGroup()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2022-06-01/examples/workspaces/Workspaces_ListByResourceGroup.json
            // this example is just showing the usage of "Workspaces_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HealthcareApisWorkspaceResource
            HealthcareApisWorkspaceCollection collection = resourceGroupResource.GetHealthcareApisWorkspaces();

            // invoke the operation and iterate over the result
            await foreach (HealthcareApisWorkspaceResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HealthcareApisWorkspaceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get workspace
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetWorkspace()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2022-06-01/examples/workspaces/Workspaces_Get.json
            // this example is just showing the usage of "Workspaces_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HealthcareApisWorkspaceResource
            HealthcareApisWorkspaceCollection collection = resourceGroupResource.GetHealthcareApisWorkspaces();

            // invoke the operation
            string workspaceName = "workspace1";
            HealthcareApisWorkspaceResource result = await collection.GetAsync(workspaceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthcareApisWorkspaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get workspace
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetWorkspace()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2022-06-01/examples/workspaces/Workspaces_Get.json
            // this example is just showing the usage of "Workspaces_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HealthcareApisWorkspaceResource
            HealthcareApisWorkspaceCollection collection = resourceGroupResource.GetHealthcareApisWorkspaces();

            // invoke the operation
            string workspaceName = "workspace1";
            bool result = await collection.ExistsAsync(workspaceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Create or update a workspace
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateAWorkspace()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2022-06-01/examples/workspaces/Workspaces_Create.json
            // this example is just showing the usage of "Workspaces_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HealthcareApisWorkspaceResource
            HealthcareApisWorkspaceCollection collection = resourceGroupResource.GetHealthcareApisWorkspaces();

            // invoke the operation
            string workspaceName = "workspace1";
            HealthcareApisWorkspaceData data = new HealthcareApisWorkspaceData(new AzureLocation("westus"))
            {
                Properties = new HealthcareApisWorkspaceProperties(),
            };
            ArmOperation<HealthcareApisWorkspaceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, workspaceName, data);
            HealthcareApisWorkspaceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthcareApisWorkspaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
