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
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_SubscriptionNetworkManagerConnectionCollection
    {
        // Create or Update Subscription Network Manager Connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateSubscriptionNetworkManagerConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/NetworkManagerConnectionSubscriptionPut.json
            // this example is just showing the usage of "SubscriptionNetworkManagerConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SubscriptionNetworkManagerConnectionResource
            SubscriptionNetworkManagerConnectionCollection collection = subscriptionResource.GetSubscriptionNetworkManagerConnections();

            // invoke the operation
            string networkManagerConnectionName = "TestNMConnection";
            NetworkManagerConnectionData data = new NetworkManagerConnectionData()
            {
                NetworkManagerId = new ResourceIdentifier("/subscriptions/subscriptionC/resourceGroup/rg1/providers/Microsoft.Network/networkManagers/testNetworkManager"),
            };
            ArmOperation<SubscriptionNetworkManagerConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, networkManagerConnectionName, data);
            SubscriptionNetworkManagerConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkManagerConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Subscription Network Manager Connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetSubscriptionNetworkManagerConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/NetworkManagerConnectionSubscriptionGet.json
            // this example is just showing the usage of "SubscriptionNetworkManagerConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SubscriptionNetworkManagerConnectionResource
            SubscriptionNetworkManagerConnectionCollection collection = subscriptionResource.GetSubscriptionNetworkManagerConnections();

            // invoke the operation
            string networkManagerConnectionName = "TestNMConnection";
            SubscriptionNetworkManagerConnectionResource result = await collection.GetAsync(networkManagerConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkManagerConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Subscription Network Manager Connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetSubscriptionNetworkManagerConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/NetworkManagerConnectionSubscriptionGet.json
            // this example is just showing the usage of "SubscriptionNetworkManagerConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SubscriptionNetworkManagerConnectionResource
            SubscriptionNetworkManagerConnectionCollection collection = subscriptionResource.GetSubscriptionNetworkManagerConnections();

            // invoke the operation
            string networkManagerConnectionName = "TestNMConnection";
            bool result = await collection.ExistsAsync(networkManagerConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Subscription Network Manager Connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetSubscriptionNetworkManagerConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/NetworkManagerConnectionSubscriptionGet.json
            // this example is just showing the usage of "SubscriptionNetworkManagerConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SubscriptionNetworkManagerConnectionResource
            SubscriptionNetworkManagerConnectionCollection collection = subscriptionResource.GetSubscriptionNetworkManagerConnections();

            // invoke the operation
            string networkManagerConnectionName = "TestNMConnection";
            NullableResponse<SubscriptionNetworkManagerConnectionResource> response = await collection.GetIfExistsAsync(networkManagerConnectionName);
            SubscriptionNetworkManagerConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkManagerConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // List Subscription Network Manager Connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListSubscriptionNetworkManagerConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/NetworkManagerConnectionSubscriptionList.json
            // this example is just showing the usage of "SubscriptionNetworkManagerConnections_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SubscriptionNetworkManagerConnectionResource
            SubscriptionNetworkManagerConnectionCollection collection = subscriptionResource.GetSubscriptionNetworkManagerConnections();

            // invoke the operation and iterate over the result
            await foreach (SubscriptionNetworkManagerConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkManagerConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
