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
using Azure.ResourceManager.Batch;
using Azure.ResourceManager.Batch.Models;

namespace Azure.ResourceManager.Batch.Samples
{
    public partial class Sample_BatchPrivateEndpointConnectionResource
    {
        // GetPrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2023-05-01/examples/PrivateEndpointConnectionGet.json
            // this example is just showing the usage of "PrivateEndpointConnection_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchPrivateEndpointConnectionResource created on azure
            // for more information of creating BatchPrivateEndpointConnectionResource, please refer to the document of BatchPrivateEndpointConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string privateEndpointConnectionName = "testprivateEndpointConnection5testprivateEndpointConnection5.24d6b4b5-e65c-4330-bbe9-3a290d62f8e0";
            ResourceIdentifier batchPrivateEndpointConnectionResourceId = BatchPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, privateEndpointConnectionName);
            BatchPrivateEndpointConnectionResource batchPrivateEndpointConnection = client.GetBatchPrivateEndpointConnectionResource(batchPrivateEndpointConnectionResourceId);

            // invoke the operation
            BatchPrivateEndpointConnectionResource result = await batchPrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // UpdatePrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdatePrivateEndpointConnection()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2023-05-01/examples/PrivateEndpointConnectionUpdate.json
            // this example is just showing the usage of "PrivateEndpointConnection_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchPrivateEndpointConnectionResource created on azure
            // for more information of creating BatchPrivateEndpointConnectionResource, please refer to the document of BatchPrivateEndpointConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string privateEndpointConnectionName = "testprivateEndpointConnection5.24d6b4b5-e65c-4330-bbe9-3a290d62f8e0";
            ResourceIdentifier batchPrivateEndpointConnectionResourceId = BatchPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, privateEndpointConnectionName);
            BatchPrivateEndpointConnectionResource batchPrivateEndpointConnection = client.GetBatchPrivateEndpointConnectionResource(batchPrivateEndpointConnectionResourceId);

            // invoke the operation
            BatchPrivateEndpointConnectionData data = new BatchPrivateEndpointConnectionData()
            {
                ConnectionState = new BatchPrivateLinkServiceConnectionState(BatchPrivateLinkServiceConnectionStatus.Approved)
                {
                    Description = "Approved by xyz.abc@company.com",
                },
            };
            ArmOperation<BatchPrivateEndpointConnectionResource> lro = await batchPrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            BatchPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateEndpointConnectionDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_PrivateEndpointConnectionDelete()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2023-05-01/examples/PrivateEndpointConnectionDelete.json
            // this example is just showing the usage of "PrivateEndpointConnection_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchPrivateEndpointConnectionResource created on azure
            // for more information of creating BatchPrivateEndpointConnectionResource, please refer to the document of BatchPrivateEndpointConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string privateEndpointConnectionName = "testprivateEndpointConnection5testprivateEndpointConnection5.24d6b4b5-e65c-4330-bbe9-3a290d62f8e0";
            ResourceIdentifier batchPrivateEndpointConnectionResourceId = BatchPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, privateEndpointConnectionName);
            BatchPrivateEndpointConnectionResource batchPrivateEndpointConnection = client.GetBatchPrivateEndpointConnectionResource(batchPrivateEndpointConnectionResourceId);

            // invoke the operation
            await batchPrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
