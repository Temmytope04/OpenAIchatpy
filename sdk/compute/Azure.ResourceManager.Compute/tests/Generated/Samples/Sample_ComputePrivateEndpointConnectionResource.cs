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
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_ComputePrivateEndpointConnectionResource
    {
        // Approve a Private Endpoint Connection under a disk access resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApproveAPrivateEndpointConnectionUnderADiskAccessResource()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2022-03-02/examples/diskAccessExamples/DiskAccessPrivateEndpointConnection_Approve.json
            // this example is just showing the usage of "DiskAccesses_UpdateAPrivateEndpointConnection" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ComputePrivateEndpointConnectionResource created on azure
            // for more information of creating ComputePrivateEndpointConnectionResource, please refer to the document of ComputePrivateEndpointConnectionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string diskAccessName = "myDiskAccess";
            string privateEndpointConnectionName = "myPrivateEndpointConnection";
            ResourceIdentifier computePrivateEndpointConnectionResourceId = ComputePrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskAccessName, privateEndpointConnectionName);
            ComputePrivateEndpointConnectionResource computePrivateEndpointConnection = client.GetComputePrivateEndpointConnectionResource(computePrivateEndpointConnectionResourceId);

            // invoke the operation
            ComputePrivateEndpointConnectionData data = new ComputePrivateEndpointConnectionData()
            {
                ConnectionState = new ComputePrivateLinkServiceConnectionState()
                {
                    Status = ComputePrivateEndpointServiceConnectionStatus.Approved,
                    Description = "Approving myPrivateEndpointConnection",
                },
            };
            ArmOperation<ComputePrivateEndpointConnectionResource> lro = await computePrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            ComputePrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ComputePrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get information about a private endpoint connection under a disk access resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetInformationAboutAPrivateEndpointConnectionUnderADiskAccessResource()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2022-03-02/examples/diskAccessExamples/DiskAccessPrivateEndpointConnection_Get.json
            // this example is just showing the usage of "DiskAccesses_GetAPrivateEndpointConnection" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ComputePrivateEndpointConnectionResource created on azure
            // for more information of creating ComputePrivateEndpointConnectionResource, please refer to the document of ComputePrivateEndpointConnectionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string diskAccessName = "myDiskAccess";
            string privateEndpointConnectionName = "myPrivateEndpointConnection";
            ResourceIdentifier computePrivateEndpointConnectionResourceId = ComputePrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskAccessName, privateEndpointConnectionName);
            ComputePrivateEndpointConnectionResource computePrivateEndpointConnection = client.GetComputePrivateEndpointConnectionResource(computePrivateEndpointConnectionResourceId);

            // invoke the operation
            ComputePrivateEndpointConnectionResource result = await computePrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ComputePrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a private endpoint connection under a disk access resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAPrivateEndpointConnectionUnderADiskAccessResource()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2022-03-02/examples/diskAccessExamples/DiskAccessPrivateEndpointConnection_Delete.json
            // this example is just showing the usage of "DiskAccesses_DeleteAPrivateEndpointConnection" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ComputePrivateEndpointConnectionResource created on azure
            // for more information of creating ComputePrivateEndpointConnectionResource, please refer to the document of ComputePrivateEndpointConnectionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string diskAccessName = "myDiskAccess";
            string privateEndpointConnectionName = "myPrivateEndpointConnection";
            ResourceIdentifier computePrivateEndpointConnectionResourceId = ComputePrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskAccessName, privateEndpointConnectionName);
            ComputePrivateEndpointConnectionResource computePrivateEndpointConnection = client.GetComputePrivateEndpointConnectionResource(computePrivateEndpointConnectionResourceId);

            // invoke the operation
            await computePrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
