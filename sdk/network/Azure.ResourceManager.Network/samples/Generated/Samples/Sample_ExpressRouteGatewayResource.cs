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
    public partial class Sample_ExpressRouteGatewayResource
    {
        // ExpressRouteGatewayListBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetExpressRouteGateways_ExpressRouteGatewayListBySubscription()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ExpressRouteGatewayListBySubscription.json
            // this example is just showing the usage of "ExpressRouteGateways_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

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
            await foreach (ExpressRouteGatewayResource item in subscriptionResource.GetExpressRouteGatewaysAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExpressRouteGatewayData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ExpressRouteGatewayUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ExpressRouteGatewayUpdate()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ExpressRouteGatewayUpdateTags.json
            // this example is just showing the usage of "ExpressRouteGateways_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteGatewayResource created on azure
            // for more information of creating ExpressRouteGatewayResource, please refer to the document of ExpressRouteGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "resourceGroupName";
            string expressRouteGatewayName = "expressRouteGatewayName";
            ResourceIdentifier expressRouteGatewayResourceId = ExpressRouteGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, expressRouteGatewayName);
            ExpressRouteGatewayResource expressRouteGateway = client.GetExpressRouteGatewayResource(expressRouteGatewayResourceId);

            // invoke the operation
            NetworkTagsObject expressRouteGatewayParameters = new NetworkTagsObject()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            ArmOperation<ExpressRouteGatewayResource> lro = await expressRouteGateway.UpdateAsync(WaitUntil.Completed, expressRouteGatewayParameters);
            ExpressRouteGatewayResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteGatewayData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ExpressRouteGatewayGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ExpressRouteGatewayGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ExpressRouteGatewayGet.json
            // this example is just showing the usage of "ExpressRouteGateways_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteGatewayResource created on azure
            // for more information of creating ExpressRouteGatewayResource, please refer to the document of ExpressRouteGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "resourceGroupName";
            string expressRouteGatewayName = "expressRouteGatewayName";
            ResourceIdentifier expressRouteGatewayResourceId = ExpressRouteGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, expressRouteGatewayName);
            ExpressRouteGatewayResource expressRouteGateway = client.GetExpressRouteGatewayResource(expressRouteGatewayResourceId);

            // invoke the operation
            ExpressRouteGatewayResource result = await expressRouteGateway.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteGatewayData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ExpressRouteGatewayDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ExpressRouteGatewayDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ExpressRouteGatewayDelete.json
            // this example is just showing the usage of "ExpressRouteGateways_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteGatewayResource created on azure
            // for more information of creating ExpressRouteGatewayResource, please refer to the document of ExpressRouteGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "resourceGroupName";
            string expressRouteGatewayName = "expressRouteGatewayName";
            ResourceIdentifier expressRouteGatewayResourceId = ExpressRouteGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, expressRouteGatewayName);
            ExpressRouteGatewayResource expressRouteGateway = client.GetExpressRouteGatewayResource(expressRouteGatewayResourceId);

            // invoke the operation
            await expressRouteGateway.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
