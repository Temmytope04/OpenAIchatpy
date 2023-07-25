// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.DataLakeAnalytics;
using Azure.ResourceManager.DataLakeAnalytics.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataLakeAnalytics.Samples
{
    public partial class Sample_DataLakeAnalyticsAccountResource
    {
        // Gets the first page of Data Lake Analytics accounts, if any, within the current subscription. This includes a link to the next page, if any.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAccounts_GetsTheFirstPageOfDataLakeAnalyticsAccountsIfAnyWithinTheCurrentSubscriptionThisIncludesALinkToTheNextPageIfAny()
        {
            // Generated from example definition: specification/datalake-analytics/resource-manager/Microsoft.DataLakeAnalytics/stable/2016-11-01/examples/Accounts_List.json
            // this example is just showing the usage of "Accounts_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            SubscriptionResourceGetAccountsOptions options = new SubscriptionResourceGetAccountsOptions() { Filter = "test_filter", Top = 1, Skip = 1, Select = "test_select", Orderby = "test_orderby", Count = false };
            await foreach (DataLakeAnalyticsAccountBasic item in subscriptionResource.GetAccountsAsync(options))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Gets details of the specified Data Lake Analytics account.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsDetailsOfTheSpecifiedDataLakeAnalyticsAccount()
        {
            // Generated from example definition: specification/datalake-analytics/resource-manager/Microsoft.DataLakeAnalytics/stable/2016-11-01/examples/Accounts_Get.json
            // this example is just showing the usage of "Accounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataLakeAnalyticsAccountResource created on azure
            // for more information of creating DataLakeAnalyticsAccountResource, please refer to the document of DataLakeAnalyticsAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "contosorg";
            string accountName = "contosoadla";
            ResourceIdentifier dataLakeAnalyticsAccountResourceId = DataLakeAnalyticsAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DataLakeAnalyticsAccountResource dataLakeAnalyticsAccount = client.GetDataLakeAnalyticsAccountResource(dataLakeAnalyticsAccountResourceId);

            // invoke the operation
            DataLakeAnalyticsAccountResource result = await dataLakeAnalyticsAccount.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataLakeAnalyticsAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Updates the Data Lake Analytics account object specified by the accountName with the contents of the account object.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdatesTheDataLakeAnalyticsAccountObjectSpecifiedByTheAccountNameWithTheContentsOfTheAccountObject()
        {
            // Generated from example definition: specification/datalake-analytics/resource-manager/Microsoft.DataLakeAnalytics/stable/2016-11-01/examples/Accounts_Update.json
            // this example is just showing the usage of "Accounts_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataLakeAnalyticsAccountResource created on azure
            // for more information of creating DataLakeAnalyticsAccountResource, please refer to the document of DataLakeAnalyticsAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "contosorg";
            string accountName = "contosoadla";
            ResourceIdentifier dataLakeAnalyticsAccountResourceId = DataLakeAnalyticsAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DataLakeAnalyticsAccountResource dataLakeAnalyticsAccount = client.GetDataLakeAnalyticsAccountResource(dataLakeAnalyticsAccountResourceId);

            // invoke the operation
            DataLakeAnalyticsAccountPatch patch = new DataLakeAnalyticsAccountPatch()
            {
                Tags =
{
["test_key"] = "test_value",
},
                ComputePolicies =
{
new ComputePolicyForDataLakeAnalyticsAccountUpdateContent("test_policy")
{
ObjectId = Guid.Parse("34adfa4f-cedf-4dc0-ba29-b6d1a69ab345"),
ObjectType = AadObjectIdentifierType.User,
MaxDegreeOfParallelismPerJob = 1,
MinPriorityPerJob = 1,
}
},
                FirewallRules =
{
new FirewallRuleForDataLakeAnalyticsAccountUpdateContent("test_rule")
{
StartIPAddress = IPAddress.Parse("1.1.1.1"),
EndIPAddress = IPAddress.Parse("2.2.2.2"),
}
},
                FirewallState = DataLakeAnalyticsFirewallState.Enabled,
                FirewallAllowAzureIPs = DataLakeAnalyticsFirewallAllowAzureIPsState.Enabled,
                NewTier = DataLakeAnalyticsCommitmentTierType.Consumption,
                MaxJobCount = 1,
                MaxDegreeOfParallelism = 1,
                MaxDegreeOfParallelismPerJob = 1,
                MinPriorityPerJob = 1,
                QueryStoreRetention = 1,
            };
            ArmOperation<DataLakeAnalyticsAccountResource> lro = await dataLakeAnalyticsAccount.UpdateAsync(WaitUntil.Completed, patch);
            DataLakeAnalyticsAccountResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataLakeAnalyticsAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Begins the delete process for the Data Lake Analytics account object specified by the account name.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_BeginsTheDeleteProcessForTheDataLakeAnalyticsAccountObjectSpecifiedByTheAccountName()
        {
            // Generated from example definition: specification/datalake-analytics/resource-manager/Microsoft.DataLakeAnalytics/stable/2016-11-01/examples/Accounts_Delete.json
            // this example is just showing the usage of "Accounts_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataLakeAnalyticsAccountResource created on azure
            // for more information of creating DataLakeAnalyticsAccountResource, please refer to the document of DataLakeAnalyticsAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "contosorg";
            string accountName = "contosoadla";
            ResourceIdentifier dataLakeAnalyticsAccountResourceId = DataLakeAnalyticsAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DataLakeAnalyticsAccountResource dataLakeAnalyticsAccount = client.GetDataLakeAnalyticsAccountResource(dataLakeAnalyticsAccountResourceId);

            // invoke the operation
            await dataLakeAnalyticsAccount.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Checks whether the specified account name is available or taken
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckDataLakeAnalyticsAccountNameAvailability_ChecksWhetherTheSpecifiedAccountNameIsAvailableOrTaken()
        {
            // Generated from example definition: specification/datalake-analytics/resource-manager/Microsoft.DataLakeAnalytics/stable/2016-11-01/examples/Accounts_CheckNameAvailability.json
            // this example is just showing the usage of "Accounts_CheckNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("EastUS2");
            DataLakeAnalyticsAccountNameAvailabilityContent content = new DataLakeAnalyticsAccountNameAvailabilityContent("contosoadla", DataLakeAnalyticsResourceType.MicrosoftDataLakeAnalyticsAccounts);
            DataLakeAnalyticsAccountNameAvailabilityResult result = await subscriptionResource.CheckDataLakeAnalyticsAccountNameAvailabilityAsync(location, content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
