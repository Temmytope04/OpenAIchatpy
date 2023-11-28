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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_HubRouteTableResource
    {
        // RouteTablePut
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_RouteTablePut()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/HubRouteTablePut.json
            // this example is just showing the usage of "HubRouteTables_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubRouteTableResource created on azure
            // for more information of creating HubRouteTableResource, please refer to the document of HubRouteTableResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub1";
            string routeTableName = "hubRouteTable1";
            ResourceIdentifier hubRouteTableResourceId = HubRouteTableResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName, routeTableName);
            HubRouteTableResource hubRouteTable = client.GetHubRouteTableResource(hubRouteTableResourceId);

            // invoke the operation
            HubRouteTableData data = new HubRouteTableData()
            {
                Routes =
{
new HubRoute("route1","CIDR",new string[]
{
"10.0.0.0/8","20.0.0.0/8","30.0.0.0/8"
},"ResourceId","/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/azureFirewalls/azureFirewall1")
},
                Labels =
{
"label1","label2"
},
            };
            ArmOperation<HubRouteTableResource> lro = await hubRouteTable.UpdateAsync(WaitUntil.Completed, data);
            HubRouteTableResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HubRouteTableData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RouteTableGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_RouteTableGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/HubRouteTableGet.json
            // this example is just showing the usage of "HubRouteTables_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubRouteTableResource created on azure
            // for more information of creating HubRouteTableResource, please refer to the document of HubRouteTableResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub1";
            string routeTableName = "hubRouteTable1";
            ResourceIdentifier hubRouteTableResourceId = HubRouteTableResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName, routeTableName);
            HubRouteTableResource hubRouteTable = client.GetHubRouteTableResource(hubRouteTableResourceId);

            // invoke the operation
            HubRouteTableResource result = await hubRouteTable.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HubRouteTableData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RouteTableDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_RouteTableDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/HubRouteTableDelete.json
            // this example is just showing the usage of "HubRouteTables_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubRouteTableResource created on azure
            // for more information of creating HubRouteTableResource, please refer to the document of HubRouteTableResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub1";
            string routeTableName = "hubRouteTable1";
            ResourceIdentifier hubRouteTableResourceId = HubRouteTableResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName, routeTableName);
            HubRouteTableResource hubRouteTable = client.GetHubRouteTableResource(hubRouteTableResourceId);

            // invoke the operation
            await hubRouteTable.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
