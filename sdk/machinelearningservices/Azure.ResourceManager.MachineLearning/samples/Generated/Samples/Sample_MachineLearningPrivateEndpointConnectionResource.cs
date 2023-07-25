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
using Azure.ResourceManager.MachineLearning;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearningPrivateEndpointConnectionResource
    {
        // WorkspaceGetPrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_WorkspaceGetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2022-10-01/examples/PrivateEndpointConnection/get.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningPrivateEndpointConnectionResource created on azure
            // for more information of creating MachineLearningPrivateEndpointConnectionResource, please refer to the document of MachineLearningPrivateEndpointConnectionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "rg-1234";
            string workspaceName = "testworkspace";
            string privateEndpointConnectionName = "{privateEndpointConnectionName}";
            ResourceIdentifier machineLearningPrivateEndpointConnectionResourceId = MachineLearningPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, privateEndpointConnectionName);
            MachineLearningPrivateEndpointConnectionResource machineLearningPrivateEndpointConnection = client.GetMachineLearningPrivateEndpointConnectionResource(machineLearningPrivateEndpointConnectionResourceId);

            // invoke the operation
            MachineLearningPrivateEndpointConnectionResource result = await machineLearningPrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WorkspacePutPrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_WorkspacePutPrivateEndpointConnection()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2022-10-01/examples/PrivateEndpointConnection/createOrUpdate.json
            // this example is just showing the usage of "PrivateEndpointConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningPrivateEndpointConnectionResource created on azure
            // for more information of creating MachineLearningPrivateEndpointConnectionResource, please refer to the document of MachineLearningPrivateEndpointConnectionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "rg-1234";
            string workspaceName = "testworkspace";
            string privateEndpointConnectionName = "{privateEndpointConnectionName}";
            ResourceIdentifier machineLearningPrivateEndpointConnectionResourceId = MachineLearningPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, privateEndpointConnectionName);
            MachineLearningPrivateEndpointConnectionResource machineLearningPrivateEndpointConnection = client.GetMachineLearningPrivateEndpointConnectionResource(machineLearningPrivateEndpointConnectionResourceId);

            // invoke the operation
            MachineLearningPrivateEndpointConnectionData data = new MachineLearningPrivateEndpointConnectionData(new AzureLocation("placeholder"))
            {
                ConnectionState = new MachineLearningPrivateLinkServiceConnectionState()
                {
                    Status = MachineLearningPrivateEndpointServiceConnectionStatus.Approved,
                    Description = "Auto-Approved",
                },
            };
            ArmOperation<MachineLearningPrivateEndpointConnectionResource> lro = await machineLearningPrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            MachineLearningPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WorkspaceDeletePrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_WorkspaceDeletePrivateEndpointConnection()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2022-10-01/examples/PrivateEndpointConnection/delete.json
            // this example is just showing the usage of "PrivateEndpointConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningPrivateEndpointConnectionResource created on azure
            // for more information of creating MachineLearningPrivateEndpointConnectionResource, please refer to the document of MachineLearningPrivateEndpointConnectionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "rg-1234";
            string workspaceName = "testworkspace";
            string privateEndpointConnectionName = "{privateEndpointConnectionName}";
            ResourceIdentifier machineLearningPrivateEndpointConnectionResourceId = MachineLearningPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, privateEndpointConnectionName);
            MachineLearningPrivateEndpointConnectionResource machineLearningPrivateEndpointConnection = client.GetMachineLearningPrivateEndpointConnectionResource(machineLearningPrivateEndpointConnectionResourceId);

            // invoke the operation
            await machineLearningPrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
