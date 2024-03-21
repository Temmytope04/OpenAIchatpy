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
    public partial class Sample_FlowLogCollection
    {
        // Create or update flow log
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateFlowLog()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/NetworkWatcherFlowLogCreate.json
            // this example is just showing the usage of "FlowLogs_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this FlowLogResource
            FlowLogCollection collection = networkWatcher.GetFlowLogs();

            // invoke the operation
            string flowLogName = "fl";
            FlowLogData data = new FlowLogData()
            {
                TargetResourceId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/networkSecurityGroups/desmondcentral-nsg"),
                StorageId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Storage/storageAccounts/nwtest1mgvbfmqsigdxe"),
                Enabled = true,
                Format = new FlowLogProperties()
                {
                    FormatType = FlowLogFormatType.Json,
                    Version = 1,
                },
                Location = new AzureLocation("centraluseuap"),
            };
            ArmOperation<FlowLogResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, flowLogName, data);
            FlowLogResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FlowLogData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get flow log
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetFlowLog()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/NetworkWatcherFlowLogGet.json
            // this example is just showing the usage of "FlowLogs_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this FlowLogResource
            FlowLogCollection collection = networkWatcher.GetFlowLogs();

            // invoke the operation
            string flowLogName = "flowLog1";
            FlowLogResource result = await collection.GetAsync(flowLogName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FlowLogData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get flow log
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetFlowLog()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/NetworkWatcherFlowLogGet.json
            // this example is just showing the usage of "FlowLogs_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this FlowLogResource
            FlowLogCollection collection = networkWatcher.GetFlowLogs();

            // invoke the operation
            string flowLogName = "flowLog1";
            bool result = await collection.ExistsAsync(flowLogName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get flow log
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetFlowLog()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/NetworkWatcherFlowLogGet.json
            // this example is just showing the usage of "FlowLogs_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this FlowLogResource
            FlowLogCollection collection = networkWatcher.GetFlowLogs();

            // invoke the operation
            string flowLogName = "flowLog1";
            NullableResponse<FlowLogResource> response = await collection.GetIfExistsAsync(flowLogName);
            FlowLogResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FlowLogData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // List connection monitors
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListConnectionMonitors()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/NetworkWatcherFlowLogList.json
            // this example is just showing the usage of "FlowLogs_List" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this FlowLogResource
            FlowLogCollection collection = networkWatcher.GetFlowLogs();

            // invoke the operation and iterate over the result
            await foreach (FlowLogResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FlowLogData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
