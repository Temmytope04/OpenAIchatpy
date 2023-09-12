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
using Azure.ResourceManager.SecurityDevOps;
using Azure.ResourceManager.SecurityDevOps.Models;

namespace Azure.ResourceManager.SecurityDevOps.Samples
{
    public partial class Sample_AzureDevOpsProjectCollection
    {
        // AzureDevOpsProject_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_AzureDevOpsProjectList()
        {
            // Generated from example definition: specification/securitydevops/resource-manager/Microsoft.SecurityDevOps/preview/2022-09-01-preview/examples/AzureDevOpsProjectList.json
            // this example is just showing the usage of "AzureDevOpsProject_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AzureDevOpsOrgResource created on azure
            // for more information of creating AzureDevOpsOrgResource, please refer to the document of AzureDevOpsOrgResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "westusrg";
            string azureDevOpsConnectorName = "testconnector";
            string azureDevOpsOrgName = "myOrg";
            ResourceIdentifier azureDevOpsOrgResourceId = AzureDevOpsOrgResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, azureDevOpsConnectorName, azureDevOpsOrgName);
            AzureDevOpsOrgResource azureDevOpsOrg = client.GetAzureDevOpsOrgResource(azureDevOpsOrgResourceId);

            // get the collection of this AzureDevOpsProjectResource
            AzureDevOpsProjectCollection collection = azureDevOpsOrg.GetAzureDevOpsProjects();

            // invoke the operation and iterate over the result
            await foreach (AzureDevOpsProjectResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AzureDevOpsProjectData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // AzureDevOpsProject_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_AzureDevOpsProjectGet()
        {
            // Generated from example definition: specification/securitydevops/resource-manager/Microsoft.SecurityDevOps/preview/2022-09-01-preview/examples/AzureDevOpsProjectGet.json
            // this example is just showing the usage of "AzureDevOpsProject_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AzureDevOpsOrgResource created on azure
            // for more information of creating AzureDevOpsOrgResource, please refer to the document of AzureDevOpsOrgResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "westusrg";
            string azureDevOpsConnectorName = "testconnector";
            string azureDevOpsOrgName = "myOrg";
            ResourceIdentifier azureDevOpsOrgResourceId = AzureDevOpsOrgResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, azureDevOpsConnectorName, azureDevOpsOrgName);
            AzureDevOpsOrgResource azureDevOpsOrg = client.GetAzureDevOpsOrgResource(azureDevOpsOrgResourceId);

            // get the collection of this AzureDevOpsProjectResource
            AzureDevOpsProjectCollection collection = azureDevOpsOrg.GetAzureDevOpsProjects();

            // invoke the operation
            string azureDevOpsProjectName = "myProject";
            AzureDevOpsProjectResource result = await collection.GetAsync(azureDevOpsProjectName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AzureDevOpsProjectData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // AzureDevOpsProject_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_AzureDevOpsProjectGet()
        {
            // Generated from example definition: specification/securitydevops/resource-manager/Microsoft.SecurityDevOps/preview/2022-09-01-preview/examples/AzureDevOpsProjectGet.json
            // this example is just showing the usage of "AzureDevOpsProject_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AzureDevOpsOrgResource created on azure
            // for more information of creating AzureDevOpsOrgResource, please refer to the document of AzureDevOpsOrgResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "westusrg";
            string azureDevOpsConnectorName = "testconnector";
            string azureDevOpsOrgName = "myOrg";
            ResourceIdentifier azureDevOpsOrgResourceId = AzureDevOpsOrgResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, azureDevOpsConnectorName, azureDevOpsOrgName);
            AzureDevOpsOrgResource azureDevOpsOrg = client.GetAzureDevOpsOrgResource(azureDevOpsOrgResourceId);

            // get the collection of this AzureDevOpsProjectResource
            AzureDevOpsProjectCollection collection = azureDevOpsOrg.GetAzureDevOpsProjects();

            // invoke the operation
            string azureDevOpsProjectName = "myProject";
            bool result = await collection.ExistsAsync(azureDevOpsProjectName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // AzureDevOpsProject_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_AzureDevOpsProjectCreateOrUpdate()
        {
            // Generated from example definition: specification/securitydevops/resource-manager/Microsoft.SecurityDevOps/preview/2022-09-01-preview/examples/AzureDevOpsProjectCreateOrUpdate.json
            // this example is just showing the usage of "AzureDevOpsProject_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AzureDevOpsOrgResource created on azure
            // for more information of creating AzureDevOpsOrgResource, please refer to the document of AzureDevOpsOrgResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "westusrg";
            string azureDevOpsConnectorName = "testconnector";
            string azureDevOpsOrgName = "myOrg";
            ResourceIdentifier azureDevOpsOrgResourceId = AzureDevOpsOrgResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, azureDevOpsConnectorName, azureDevOpsOrgName);
            AzureDevOpsOrgResource azureDevOpsOrg = client.GetAzureDevOpsOrgResource(azureDevOpsOrgResourceId);

            // get the collection of this AzureDevOpsProjectResource
            AzureDevOpsProjectCollection collection = azureDevOpsOrg.GetAzureDevOpsProjects();

            // invoke the operation
            string azureDevOpsProjectName = "myProject";
            AzureDevOpsProjectData data = new AzureDevOpsProjectData()
            {
                Properties = new AzureDevOpsProjectProperties()
                {
                    AutoDiscovery = AutoDiscovery.Disabled,
                },
            };
            ArmOperation<AzureDevOpsProjectResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, azureDevOpsProjectName, data);
            AzureDevOpsProjectResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AzureDevOpsProjectData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
