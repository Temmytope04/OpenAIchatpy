// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Billing;

namespace Azure.ResourceManager.Billing.Samples
{
    public partial class Sample_BillingSubscriptionCollection
    {
        // BillingSubscriptionsListByBillingAccount
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_BillingSubscriptionsListByBillingAccount()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2021-10-01/examples/BillingSubscriptionsListByBillingAccount.json
            // this example is just showing the usage of "BillingSubscriptions_ListByBillingAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this BillingSubscriptionResource
            string billingAccountName = "{billingAccountName}";
            BillingSubscriptionCollection collection = tenantResource.GetBillingSubscriptions(billingAccountName);

            // invoke the operation and iterate over the result
            await foreach (BillingSubscriptionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BillingSubscriptionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // BillingSubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_BillingSubscription()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2021-10-01/examples/BillingSubscription.json
            // this example is just showing the usage of "BillingSubscriptions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this BillingSubscriptionResource
            string billingAccountName = "{billingAccountName}";
            BillingSubscriptionCollection collection = tenantResource.GetBillingSubscriptions(billingAccountName);

            // invoke the operation
            string billingSubscriptionName = "418b0e9c-5dc3-4260-918f-30b90619fe07";
            BillingSubscriptionResource result = await collection.GetAsync(billingSubscriptionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingSubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // BillingSubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_BillingSubscription()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2021-10-01/examples/BillingSubscription.json
            // this example is just showing the usage of "BillingSubscriptions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this BillingSubscriptionResource
            string billingAccountName = "{billingAccountName}";
            BillingSubscriptionCollection collection = tenantResource.GetBillingSubscriptions(billingAccountName);

            // invoke the operation
            string billingSubscriptionName = "418b0e9c-5dc3-4260-918f-30b90619fe07";
            bool result = await collection.ExistsAsync(billingSubscriptionName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
