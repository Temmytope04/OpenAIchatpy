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
using Azure.ResourceManager.DataBoxEdge;
using Azure.ResourceManager.DataBoxEdge.Models;

namespace Azure.ResourceManager.DataBoxEdge.Samples
{
    public partial class Sample_DataBoxEdgeStorageContainerResource
    {
        // ContainerGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ContainerGet()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/ContainerGet.json
            // this example is just showing the usage of "Containers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeStorageContainerResource created on azure
            // for more information of creating DataBoxEdgeStorageContainerResource, please refer to the document of DataBoxEdgeStorageContainerResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            string storageAccountName = "storageaccount1";
            string containerName = "blobcontainer1";
            ResourceIdentifier dataBoxEdgeStorageContainerResourceId = DataBoxEdgeStorageContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName, storageAccountName, containerName);
            DataBoxEdgeStorageContainerResource dataBoxEdgeStorageContainer = client.GetDataBoxEdgeStorageContainerResource(dataBoxEdgeStorageContainerResourceId);

            // invoke the operation
            DataBoxEdgeStorageContainerResource result = await dataBoxEdgeStorageContainer.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataBoxEdgeStorageContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ContainerPut
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ContainerPut()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/ContainerPut.json
            // this example is just showing the usage of "Containers_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeStorageContainerResource created on azure
            // for more information of creating DataBoxEdgeStorageContainerResource, please refer to the document of DataBoxEdgeStorageContainerResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            string storageAccountName = "storageaccount1";
            string containerName = "blobcontainer1";
            ResourceIdentifier dataBoxEdgeStorageContainerResourceId = DataBoxEdgeStorageContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName, storageAccountName, containerName);
            DataBoxEdgeStorageContainerResource dataBoxEdgeStorageContainer = client.GetDataBoxEdgeStorageContainerResource(dataBoxEdgeStorageContainerResourceId);

            // invoke the operation
            DataBoxEdgeStorageContainerData data = new DataBoxEdgeStorageContainerData(DataBoxEdgeStorageContainerDataFormat.BlockBlob);
            ArmOperation<DataBoxEdgeStorageContainerResource> lro = await dataBoxEdgeStorageContainer.UpdateAsync(WaitUntil.Completed, data);
            DataBoxEdgeStorageContainerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataBoxEdgeStorageContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ContainerDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ContainerDelete()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/ContainerDelete.json
            // this example is just showing the usage of "Containers_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeStorageContainerResource created on azure
            // for more information of creating DataBoxEdgeStorageContainerResource, please refer to the document of DataBoxEdgeStorageContainerResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            string storageAccountName = "storageaccount1";
            string containerName = "blobcontainer1";
            ResourceIdentifier dataBoxEdgeStorageContainerResourceId = DataBoxEdgeStorageContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName, storageAccountName, containerName);
            DataBoxEdgeStorageContainerResource dataBoxEdgeStorageContainer = client.GetDataBoxEdgeStorageContainerResource(dataBoxEdgeStorageContainerResourceId);

            // invoke the operation
            await dataBoxEdgeStorageContainer.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // ContainerRefresh
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Refresh_ContainerRefresh()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/ContainerRefresh.json
            // this example is just showing the usage of "Containers_Refresh" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeStorageContainerResource created on azure
            // for more information of creating DataBoxEdgeStorageContainerResource, please refer to the document of DataBoxEdgeStorageContainerResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            string storageAccountName = "storageaccount1";
            string containerName = "blobcontainer1";
            ResourceIdentifier dataBoxEdgeStorageContainerResourceId = DataBoxEdgeStorageContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName, storageAccountName, containerName);
            DataBoxEdgeStorageContainerResource dataBoxEdgeStorageContainer = client.GetDataBoxEdgeStorageContainerResource(dataBoxEdgeStorageContainerResourceId);

            // invoke the operation
            await dataBoxEdgeStorageContainer.RefreshAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
