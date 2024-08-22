// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MobileNetwork.Samples
{
    public partial class Sample_MobileNetworkResource
    {
        // Delete mobile network
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteMobileNetwork()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/MobileNetworkDelete.json
            // this example is just showing the usage of "MobileNetworks_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MobileNetworkResource created on azure
            // for more information of creating MobileNetworkResource, please refer to the document of MobileNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string mobileNetworkName = "testMobileNetwork";
            ResourceIdentifier mobileNetworkResourceId = MobileNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, mobileNetworkName);
            MobileNetworkResource mobileNetwork = client.GetMobileNetworkResource(mobileNetworkResourceId);

            // invoke the operation
            await mobileNetwork.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get mobile network
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetMobileNetwork()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/MobileNetworkGet.json
            // this example is just showing the usage of "MobileNetworks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MobileNetworkResource created on azure
            // for more information of creating MobileNetworkResource, please refer to the document of MobileNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string mobileNetworkName = "testMobileNetwork";
            ResourceIdentifier mobileNetworkResourceId = MobileNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, mobileNetworkName);
            MobileNetworkResource mobileNetwork = client.GetMobileNetworkResource(mobileNetworkResourceId);

            // invoke the operation
            MobileNetworkResource result = await mobileNetwork.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MobileNetworkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update mobile network tags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateMobileNetworkTags()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/MobileNetworkUpdateTags.json
            // this example is just showing the usage of "MobileNetworks_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MobileNetworkResource created on azure
            // for more information of creating MobileNetworkResource, please refer to the document of MobileNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string mobileNetworkName = "testMobileNetwork";
            ResourceIdentifier mobileNetworkResourceId = MobileNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, mobileNetworkName);
            MobileNetworkResource mobileNetwork = client.GetMobileNetworkResource(mobileNetworkResourceId);

            // invoke the operation
            MobileNetworkResourcePatch patch = new MobileNetworkResourcePatch()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            MobileNetworkResource result = await mobileNetwork.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MobileNetworkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List mobile networks in a subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetMobileNetworks_ListMobileNetworksInASubscription()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/MobileNetworkListBySubscription.json
            // this example is just showing the usage of "MobileNetworks_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

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
            await foreach (MobileNetworkResource item in subscriptionResource.GetMobileNetworksAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MobileNetworkData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List SIM groups in a mobile network
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSimGroups_ListSIMGroupsInAMobileNetwork()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/SimGroupListByMobileNetwork.json
            // this example is just showing the usage of "MobileNetworks_ListSimGroups" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MobileNetworkResource created on azure
            // for more information of creating MobileNetworkResource, please refer to the document of MobileNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string mobileNetworkName = "testMobileNetwork";
            ResourceIdentifier mobileNetworkResourceId = MobileNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, mobileNetworkName);
            MobileNetworkResource mobileNetwork = client.GetMobileNetworkResource(mobileNetworkResourceId);

            // invoke the operation and iterate over the result
            await foreach (MobileNetworkSimGroupResource item in mobileNetwork.GetSimGroupsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MobileNetworkSimGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
