// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ExpressRoutePortResource
    {
        // ExpressRoutePortDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ExpressRoutePortDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ExpressRoutePortDelete.json
            // this example is just showing the usage of "ExpressRoutePorts_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRoutePortResource created on azure
            // for more information of creating ExpressRoutePortResource, please refer to the document of ExpressRoutePortResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string expressRoutePortName = "portName";
            ResourceIdentifier expressRoutePortResourceId = ExpressRoutePortResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, expressRoutePortName);
            ExpressRoutePortResource expressRoutePort = client.GetExpressRoutePortResource(expressRoutePortResourceId);

            // invoke the operation
            await expressRoutePort.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // ExpressRoutePortGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ExpressRoutePortGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ExpressRoutePortGet.json
            // this example is just showing the usage of "ExpressRoutePorts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRoutePortResource created on azure
            // for more information of creating ExpressRoutePortResource, please refer to the document of ExpressRoutePortResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string expressRoutePortName = "portName";
            ResourceIdentifier expressRoutePortResourceId = ExpressRoutePortResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, expressRoutePortName);
            ExpressRoutePortResource expressRoutePort = client.GetExpressRoutePortResource(expressRoutePortResourceId);

            // invoke the operation
            ExpressRoutePortResource result = await expressRoutePort.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRoutePortData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ExpressRoutePortUpdateTags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ExpressRoutePortUpdateTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ExpressRoutePortUpdateTags.json
            // this example is just showing the usage of "ExpressRoutePorts_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRoutePortResource created on azure
            // for more information of creating ExpressRoutePortResource, please refer to the document of ExpressRoutePortResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string expressRoutePortName = "portName";
            ResourceIdentifier expressRoutePortResourceId = ExpressRoutePortResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, expressRoutePortName);
            ExpressRoutePortResource expressRoutePort = client.GetExpressRoutePortResource(expressRoutePortResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            ExpressRoutePortResource result = await expressRoutePort.UpdateAsync(networkTagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRoutePortData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ExpressRoutePortList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetExpressRoutePorts_ExpressRoutePortList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ExpressRoutePortList.json
            // this example is just showing the usage of "ExpressRoutePorts_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ExpressRoutePortResource item in subscriptionResource.GetExpressRoutePortsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExpressRoutePortData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // GenerateExpressRoutePortLOA
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GenerateLoa_GenerateExpressRoutePortLOA()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/GenerateExpressRoutePortsLOA.json
            // this example is just showing the usage of "ExpressRoutePorts_GenerateLOA" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRoutePortResource created on azure
            // for more information of creating ExpressRoutePortResource, please refer to the document of ExpressRoutePortResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string expressRoutePortName = "portName";
            ResourceIdentifier expressRoutePortResourceId = ExpressRoutePortResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, expressRoutePortName);
            ExpressRoutePortResource expressRoutePort = client.GetExpressRoutePortResource(expressRoutePortResourceId);

            // invoke the operation
            GenerateExpressRoutePortsLoaContent content = new GenerateExpressRoutePortsLoaContent("customerName");
            GenerateExpressRoutePortsLoaResult result = await expressRoutePort.GenerateLoaAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
