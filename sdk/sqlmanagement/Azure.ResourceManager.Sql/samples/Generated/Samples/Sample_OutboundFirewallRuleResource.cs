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
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_OutboundFirewallRuleResource
    {
        // Gets outbound firewall rule.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsOutboundFirewallRule()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-02-01-preview/examples/OutboundFirewallRuleGet.json
            // this example is just showing the usage of "OutboundFirewallRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OutboundFirewallRuleResource created on azure
            // for more information of creating OutboundFirewallRuleResource, please refer to the document of OutboundFirewallRuleResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            string serverName = "sqlcrudtest-4645";
            string outboundRuleFqdn = "server.database.windows.net";
            ResourceIdentifier outboundFirewallRuleResourceId = OutboundFirewallRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, outboundRuleFqdn);
            OutboundFirewallRuleResource outboundFirewallRule = client.GetOutboundFirewallRuleResource(outboundFirewallRuleResourceId);

            // invoke the operation
            OutboundFirewallRuleResource result = await outboundFirewallRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OutboundFirewallRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Approve or reject a outbound firewall rule with a given name.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApproveOrRejectAOutboundFirewallRuleWithAGivenName()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-02-01-preview/examples/OutboundFirewallRuleCreate.json
            // this example is just showing the usage of "OutboundFirewallRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OutboundFirewallRuleResource created on azure
            // for more information of creating OutboundFirewallRuleResource, please refer to the document of OutboundFirewallRuleResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            string serverName = "sqlcrudtest-4645";
            string outboundRuleFqdn = "server.database.windows.net";
            ResourceIdentifier outboundFirewallRuleResourceId = OutboundFirewallRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, outboundRuleFqdn);
            OutboundFirewallRuleResource outboundFirewallRule = client.GetOutboundFirewallRuleResource(outboundFirewallRuleResourceId);

            // invoke the operation
            OutboundFirewallRuleData data = new OutboundFirewallRuleData();
            ArmOperation<OutboundFirewallRuleResource> lro = await outboundFirewallRule.UpdateAsync(WaitUntil.Completed, data);
            OutboundFirewallRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OutboundFirewallRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Deletes a outbound firewall rule with a given name.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeletesAOutboundFirewallRuleWithAGivenName()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-02-01-preview/examples/OutboundFirewallRuleDelete.json
            // this example is just showing the usage of "OutboundFirewallRules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OutboundFirewallRuleResource created on azure
            // for more information of creating OutboundFirewallRuleResource, please refer to the document of OutboundFirewallRuleResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            string serverName = "sqlcrudtest-6661";
            string outboundRuleFqdn = "server.database.windows.net";
            ResourceIdentifier outboundFirewallRuleResourceId = OutboundFirewallRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, outboundRuleFqdn);
            OutboundFirewallRuleResource outboundFirewallRule = client.GetOutboundFirewallRuleResource(outboundFirewallRuleResourceId);

            // invoke the operation
            await outboundFirewallRule.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
