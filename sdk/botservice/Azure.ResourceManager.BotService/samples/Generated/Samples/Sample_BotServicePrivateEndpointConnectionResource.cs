// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.BotService.Models;

namespace Azure.ResourceManager.BotService.Samples
{
    public partial class Sample_BotServicePrivateEndpointConnectionResource
    {
        // Get Private Endpoint Connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/botservice/resource-manager/Microsoft.BotService/stable/2022-09-15/examples/GetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BotServicePrivateEndpointConnectionResource created on azure
            // for more information of creating BotServicePrivateEndpointConnectionResource, please refer to the document of BotServicePrivateEndpointConnectionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string resourceName = "sto2527";
            string privateEndpointConnectionName = "{privateEndpointConnectionName}";
            ResourceIdentifier botServicePrivateEndpointConnectionResourceId = BotServicePrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, privateEndpointConnectionName);
            BotServicePrivateEndpointConnectionResource botServicePrivateEndpointConnection = client.GetBotServicePrivateEndpointConnectionResource(botServicePrivateEndpointConnectionResourceId);

            // invoke the operation
            BotServicePrivateEndpointConnectionResource result = await botServicePrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BotServicePrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Put Private Endpoint Connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PutPrivateEndpointConnection()
        {
            // Generated from example definition: specification/botservice/resource-manager/Microsoft.BotService/stable/2022-09-15/examples/PutPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BotServicePrivateEndpointConnectionResource created on azure
            // for more information of creating BotServicePrivateEndpointConnectionResource, please refer to the document of BotServicePrivateEndpointConnectionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res7687";
            string resourceName = "sto9699";
            string privateEndpointConnectionName = "{privateEndpointConnectionName}";
            ResourceIdentifier botServicePrivateEndpointConnectionResourceId = BotServicePrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, privateEndpointConnectionName);
            BotServicePrivateEndpointConnectionResource botServicePrivateEndpointConnection = client.GetBotServicePrivateEndpointConnectionResource(botServicePrivateEndpointConnectionResourceId);

            // invoke the operation
            BotServicePrivateEndpointConnectionData data = new BotServicePrivateEndpointConnectionData()
            {
                ConnectionState = new BotServicePrivateLinkServiceConnectionState()
                {
                    Status = BotServicePrivateEndpointServiceConnectionStatus.Approved,
                    Description = "Auto-Approved",
                },
            };
            ArmOperation<BotServicePrivateEndpointConnectionResource> lro = await botServicePrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            BotServicePrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BotServicePrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete Private Endpoint Connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeletePrivateEndpointConnection()
        {
            // Generated from example definition: specification/botservice/resource-manager/Microsoft.BotService/stable/2022-09-15/examples/DeletePrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BotServicePrivateEndpointConnectionResource created on azure
            // for more information of creating BotServicePrivateEndpointConnectionResource, please refer to the document of BotServicePrivateEndpointConnectionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string resourceName = "sto2527";
            string privateEndpointConnectionName = "{privateEndpointConnectionName}";
            ResourceIdentifier botServicePrivateEndpointConnectionResourceId = BotServicePrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, privateEndpointConnectionName);
            BotServicePrivateEndpointConnectionResource botServicePrivateEndpointConnection = client.GetBotServicePrivateEndpointConnectionResource(botServicePrivateEndpointConnectionResourceId);

            // invoke the operation
            await botServicePrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
