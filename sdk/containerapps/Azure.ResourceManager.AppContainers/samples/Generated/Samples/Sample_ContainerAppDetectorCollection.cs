// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.AppContainers.Samples
{
    public partial class Sample_ContainerAppDetectorCollection
    {
        // Get the list of available diagnostics for a given Container App
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetTheListOfAvailableDiagnosticsForAGivenContainerApp()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2023-05-01/examples/ContainerAppsDiagnostics_List.json
            // this example is just showing the usage of "ContainerAppsDiagnostics_ListDetectors" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppResource created on azure
            // for more information of creating ContainerAppResource, please refer to the document of ContainerAppResource
            string subscriptionId = "f07f3711-b45e-40fe-a941-4e6d93f851e6";
            string resourceGroupName = "mikono-workerapp-test-rg";
            string containerAppName = "mikono-capp-stage1";
            ResourceIdentifier containerAppResourceId = ContainerAppResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerAppName);
            ContainerAppResource containerApp = client.GetContainerAppResource(containerAppResourceId);

            // get the collection of this ContainerAppDetectorResource
            ContainerAppDetectorCollection collection = containerApp.GetContainerAppDetectors();

            // invoke the operation and iterate over the result
            await foreach (ContainerAppDetectorResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerAppDiagnosticData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Container App's diagnostics info
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetContainerAppSDiagnosticsInfo()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2023-05-01/examples/ContainerAppsDiagnostics_Get.json
            // this example is just showing the usage of "ContainerAppsDiagnostics_GetDetector" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppResource created on azure
            // for more information of creating ContainerAppResource, please refer to the document of ContainerAppResource
            string subscriptionId = "f07f3711-b45e-40fe-a941-4e6d93f851e6";
            string resourceGroupName = "mikono-workerapp-test-rg";
            string containerAppName = "mikono-capp-stage1";
            ResourceIdentifier containerAppResourceId = ContainerAppResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerAppName);
            ContainerAppResource containerApp = client.GetContainerAppResource(containerAppResourceId);

            // get the collection of this ContainerAppDetectorResource
            ContainerAppDetectorCollection collection = containerApp.GetContainerAppDetectors();

            // invoke the operation
            string detectorName = "cappcontainerappnetworkIO";
            ContainerAppDetectorResource result = await collection.GetAsync(detectorName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppDiagnosticData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Container App's diagnostics info
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetContainerAppSDiagnosticsInfo()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2023-05-01/examples/ContainerAppsDiagnostics_Get.json
            // this example is just showing the usage of "ContainerAppsDiagnostics_GetDetector" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppResource created on azure
            // for more information of creating ContainerAppResource, please refer to the document of ContainerAppResource
            string subscriptionId = "f07f3711-b45e-40fe-a941-4e6d93f851e6";
            string resourceGroupName = "mikono-workerapp-test-rg";
            string containerAppName = "mikono-capp-stage1";
            ResourceIdentifier containerAppResourceId = ContainerAppResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerAppName);
            ContainerAppResource containerApp = client.GetContainerAppResource(containerAppResourceId);

            // get the collection of this ContainerAppDetectorResource
            ContainerAppDetectorCollection collection = containerApp.GetContainerAppDetectors();

            // invoke the operation
            string detectorName = "cappcontainerappnetworkIO";
            bool result = await collection.ExistsAsync(detectorName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Container App's diagnostics info
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetContainerAppSDiagnosticsInfo()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2023-05-01/examples/ContainerAppsDiagnostics_Get.json
            // this example is just showing the usage of "ContainerAppsDiagnostics_GetDetector" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppResource created on azure
            // for more information of creating ContainerAppResource, please refer to the document of ContainerAppResource
            string subscriptionId = "f07f3711-b45e-40fe-a941-4e6d93f851e6";
            string resourceGroupName = "mikono-workerapp-test-rg";
            string containerAppName = "mikono-capp-stage1";
            ResourceIdentifier containerAppResourceId = ContainerAppResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerAppName);
            ContainerAppResource containerApp = client.GetContainerAppResource(containerAppResourceId);

            // get the collection of this ContainerAppDetectorResource
            ContainerAppDetectorCollection collection = containerApp.GetContainerAppDetectors();

            // invoke the operation
            string detectorName = "cappcontainerappnetworkIO";
            NullableResponse<ContainerAppDetectorResource> response = await collection.GetIfExistsAsync(detectorName);
            ContainerAppDetectorResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerAppDiagnosticData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
