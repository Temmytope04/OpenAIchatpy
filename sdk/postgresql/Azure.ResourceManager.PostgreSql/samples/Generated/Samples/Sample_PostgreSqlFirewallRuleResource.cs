// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.PostgreSql.Samples
{
    public partial class Sample_PostgreSqlFirewallRuleResource
    {
        // FirewallRuleCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_FirewallRuleCreate()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2017-12-01/examples/FirewallRuleCreate.json
            // this example is just showing the usage of "FirewallRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlFirewallRuleResource created on azure
            // for more information of creating PostgreSqlFirewallRuleResource, please refer to the document of PostgreSqlFirewallRuleResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            string firewallRuleName = "rule1";
            ResourceIdentifier postgreSqlFirewallRuleResourceId = PostgreSqlFirewallRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, firewallRuleName);
            PostgreSqlFirewallRuleResource postgreSqlFirewallRule = client.GetPostgreSqlFirewallRuleResource(postgreSqlFirewallRuleResourceId);

            // invoke the operation
            PostgreSqlFirewallRuleData data = new PostgreSqlFirewallRuleData(IPAddress.Parse("0.0.0.0"), IPAddress.Parse("255.255.255.255"));
            ArmOperation<PostgreSqlFirewallRuleResource> lro = await postgreSqlFirewallRule.UpdateAsync(WaitUntil.Completed, data);
            PostgreSqlFirewallRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlFirewallRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // FirewallRuleDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_FirewallRuleDelete()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2017-12-01/examples/FirewallRuleDelete.json
            // this example is just showing the usage of "FirewallRules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlFirewallRuleResource created on azure
            // for more information of creating PostgreSqlFirewallRuleResource, please refer to the document of PostgreSqlFirewallRuleResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            string firewallRuleName = "rule1";
            ResourceIdentifier postgreSqlFirewallRuleResourceId = PostgreSqlFirewallRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, firewallRuleName);
            PostgreSqlFirewallRuleResource postgreSqlFirewallRule = client.GetPostgreSqlFirewallRuleResource(postgreSqlFirewallRuleResourceId);

            // invoke the operation
            await postgreSqlFirewallRule.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // FirewallRuleGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_FirewallRuleGet()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2017-12-01/examples/FirewallRuleGet.json
            // this example is just showing the usage of "FirewallRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlFirewallRuleResource created on azure
            // for more information of creating PostgreSqlFirewallRuleResource, please refer to the document of PostgreSqlFirewallRuleResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            string firewallRuleName = "rule1";
            ResourceIdentifier postgreSqlFirewallRuleResourceId = PostgreSqlFirewallRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, firewallRuleName);
            PostgreSqlFirewallRuleResource postgreSqlFirewallRule = client.GetPostgreSqlFirewallRuleResource(postgreSqlFirewallRuleResourceId);

            // invoke the operation
            PostgreSqlFirewallRuleResource result = await postgreSqlFirewallRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlFirewallRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
