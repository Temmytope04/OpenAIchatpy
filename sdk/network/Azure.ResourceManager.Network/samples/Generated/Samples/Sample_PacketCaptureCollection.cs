// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_PacketCaptureCollection
    {
        // Create packet capture
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreatePacketCapture()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/NetworkWatcherPacketCaptureCreate.json
            // this example is just showing the usage of "PacketCaptures_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // get the collection of this PacketCaptureResource
            PacketCaptureCollection collection = networkWatcher.GetPacketCaptures();

            // invoke the operation
            string packetCaptureName = "pc1";
            PacketCaptureCreateOrUpdateContent content = new PacketCaptureCreateOrUpdateContent("/subscriptions/subid/resourceGroups/rg2/providers/Microsoft.Compute/virtualMachines/vm1", new PacketCaptureStorageLocation()
            {
                StorageId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg2/providers/Microsoft.Storage/storageAccounts/pcstore"),
                StoragePath = "https://mytestaccountname.blob.core.windows.net/capture/pc1.cap",
                FilePath = "D:\\capture\\pc1.cap",
            })
            {
                BytesToCapturePerPacket = 10000,
                TotalBytesPerSession = 100000,
                TimeLimitInSeconds = 100,
                Filters =
{
new PacketCaptureFilter()
{
Protocol = PcProtocol.Tcp,
LocalIPAddress = "10.0.0.4",
LocalPort = "80",
}
},
            };
            ArmOperation<PacketCaptureResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, packetCaptureName, content);
            PacketCaptureResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PacketCaptureData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get packet capture
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPacketCapture()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/NetworkWatcherPacketCaptureGet.json
            // this example is just showing the usage of "PacketCaptures_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // get the collection of this PacketCaptureResource
            PacketCaptureCollection collection = networkWatcher.GetPacketCaptures();

            // invoke the operation
            string packetCaptureName = "pc1";
            PacketCaptureResource result = await collection.GetAsync(packetCaptureName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PacketCaptureData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get packet capture
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetPacketCapture()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/NetworkWatcherPacketCaptureGet.json
            // this example is just showing the usage of "PacketCaptures_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // get the collection of this PacketCaptureResource
            PacketCaptureCollection collection = networkWatcher.GetPacketCaptures();

            // invoke the operation
            string packetCaptureName = "pc1";
            bool result = await collection.ExistsAsync(packetCaptureName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get packet capture
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetPacketCapture()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/NetworkWatcherPacketCaptureGet.json
            // this example is just showing the usage of "PacketCaptures_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // get the collection of this PacketCaptureResource
            PacketCaptureCollection collection = networkWatcher.GetPacketCaptures();

            // invoke the operation
            string packetCaptureName = "pc1";
            NullableResponse<PacketCaptureResource> response = await collection.GetIfExistsAsync(packetCaptureName);
            PacketCaptureResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PacketCaptureData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // List packet captures
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListPacketCaptures()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/NetworkWatcherPacketCapturesList.json
            // this example is just showing the usage of "PacketCaptures_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // get the collection of this PacketCaptureResource
            PacketCaptureCollection collection = networkWatcher.GetPacketCaptures();

            // invoke the operation and iterate over the result
            await foreach (PacketCaptureResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PacketCaptureData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
