// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_SqlServerVirtualNetworkRuleResource
    {
        // Gets a virtual network rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsAVirtualNetworkRule()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/VirtualNetworkRulesGet.json
            // this example is just showing the usage of "VirtualNetworkRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerVirtualNetworkRuleResource created on azure
            // for more information of creating SqlServerVirtualNetworkRuleResource, please refer to the document of SqlServerVirtualNetworkRuleResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string serverName = "vnet-test-svr";
            string virtualNetworkRuleName = "vnet-firewall-rule";
            ResourceIdentifier sqlServerVirtualNetworkRuleResourceId = SqlServerVirtualNetworkRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, virtualNetworkRuleName);
            SqlServerVirtualNetworkRuleResource sqlServerVirtualNetworkRule = client.GetSqlServerVirtualNetworkRuleResource(sqlServerVirtualNetworkRuleResourceId);

            // invoke the operation
            SqlServerVirtualNetworkRuleResource result = await sqlServerVirtualNetworkRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerVirtualNetworkRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or update a virtual network rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateAVirtualNetworkRule()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/VirtualNetworkRulesCreateOrUpdate.json
            // this example is just showing the usage of "VirtualNetworkRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerVirtualNetworkRuleResource created on azure
            // for more information of creating SqlServerVirtualNetworkRuleResource, please refer to the document of SqlServerVirtualNetworkRuleResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string serverName = "vnet-test-svr";
            string virtualNetworkRuleName = "vnet-firewall-rule";
            ResourceIdentifier sqlServerVirtualNetworkRuleResourceId = SqlServerVirtualNetworkRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, virtualNetworkRuleName);
            SqlServerVirtualNetworkRuleResource sqlServerVirtualNetworkRule = client.GetSqlServerVirtualNetworkRuleResource(sqlServerVirtualNetworkRuleResourceId);

            // invoke the operation
            SqlServerVirtualNetworkRuleData data = new SqlServerVirtualNetworkRuleData()
            {
                VirtualNetworkSubnetId = new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/Default/providers/Microsoft.Network/virtualNetworks/testvnet/subnets/testsubnet"),
                IgnoreMissingVnetServiceEndpoint = false,
            };
            ArmOperation<SqlServerVirtualNetworkRuleResource> lro = await sqlServerVirtualNetworkRule.UpdateAsync(WaitUntil.Completed, data);
            SqlServerVirtualNetworkRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerVirtualNetworkRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a virtual network rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAVirtualNetworkRule()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/VirtualNetworkRulesDelete.json
            // this example is just showing the usage of "VirtualNetworkRules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerVirtualNetworkRuleResource created on azure
            // for more information of creating SqlServerVirtualNetworkRuleResource, please refer to the document of SqlServerVirtualNetworkRuleResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string serverName = "vnet-test-svr";
            string virtualNetworkRuleName = "vnet-firewall-rule";
            ResourceIdentifier sqlServerVirtualNetworkRuleResourceId = SqlServerVirtualNetworkRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, virtualNetworkRuleName);
            SqlServerVirtualNetworkRuleResource sqlServerVirtualNetworkRule = client.GetSqlServerVirtualNetworkRuleResource(sqlServerVirtualNetworkRuleResourceId);

            // invoke the operation
            await sqlServerVirtualNetworkRule.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
