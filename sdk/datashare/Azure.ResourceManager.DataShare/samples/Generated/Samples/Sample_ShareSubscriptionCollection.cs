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
using Azure.ResourceManager.DataShare;

namespace Azure.ResourceManager.DataShare.Samples
{
    public partial class Sample_ShareSubscriptionCollection
    {
        // ShareSubscriptions_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ShareSubscriptionsGet()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ShareSubscriptions_Get.json
            // this example is just showing the usage of "ShareSubscriptions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareAccountResource created on azure
            // for more information of creating DataShareAccountResource, please refer to the document of DataShareAccountResource
            string subscriptionId = "12345678-1234-1234-12345678abc";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            ResourceIdentifier dataShareAccountResourceId = DataShareAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DataShareAccountResource dataShareAccount = client.GetDataShareAccountResource(dataShareAccountResourceId);

            // get the collection of this ShareSubscriptionResource
            ShareSubscriptionCollection collection = dataShareAccount.GetShareSubscriptions();

            // invoke the operation
            string shareSubscriptionName = "ShareSubscription1";
            ShareSubscriptionResource result = await collection.GetAsync(shareSubscriptionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ShareSubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ShareSubscriptions_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ShareSubscriptionsGet()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ShareSubscriptions_Get.json
            // this example is just showing the usage of "ShareSubscriptions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareAccountResource created on azure
            // for more information of creating DataShareAccountResource, please refer to the document of DataShareAccountResource
            string subscriptionId = "12345678-1234-1234-12345678abc";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            ResourceIdentifier dataShareAccountResourceId = DataShareAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DataShareAccountResource dataShareAccount = client.GetDataShareAccountResource(dataShareAccountResourceId);

            // get the collection of this ShareSubscriptionResource
            ShareSubscriptionCollection collection = dataShareAccount.GetShareSubscriptions();

            // invoke the operation
            string shareSubscriptionName = "ShareSubscription1";
            bool result = await collection.ExistsAsync(shareSubscriptionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ShareSubscriptions_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ShareSubscriptionsCreate()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ShareSubscriptions_Create.json
            // this example is just showing the usage of "ShareSubscriptions_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareAccountResource created on azure
            // for more information of creating DataShareAccountResource, please refer to the document of DataShareAccountResource
            string subscriptionId = "12345678-1234-1234-12345678abc";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            ResourceIdentifier dataShareAccountResourceId = DataShareAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DataShareAccountResource dataShareAccount = client.GetDataShareAccountResource(dataShareAccountResourceId);

            // get the collection of this ShareSubscriptionResource
            ShareSubscriptionCollection collection = dataShareAccount.GetShareSubscriptions();

            // invoke the operation
            string shareSubscriptionName = "ShareSubscription1";
            ShareSubscriptionData data = new ShareSubscriptionData(Guid.Parse("12345678-1234-1234-12345678abd"), new AzureLocation("eastus2"))
            {
                ExpireOn = DateTimeOffset.Parse("2020-08-26T22:33:24.5785265Z"),
            };
            ArmOperation<ShareSubscriptionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, shareSubscriptionName, data);
            ShareSubscriptionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ShareSubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ShareSubscriptions_ListByAccount
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ShareSubscriptionsListByAccount()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ShareSubscriptions_ListByAccount.json
            // this example is just showing the usage of "ShareSubscriptions_ListByAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareAccountResource created on azure
            // for more information of creating DataShareAccountResource, please refer to the document of DataShareAccountResource
            string subscriptionId = "12345678-1234-1234-12345678abc";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            ResourceIdentifier dataShareAccountResourceId = DataShareAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DataShareAccountResource dataShareAccount = client.GetDataShareAccountResource(dataShareAccountResourceId);

            // get the collection of this ShareSubscriptionResource
            ShareSubscriptionCollection collection = dataShareAccount.GetShareSubscriptions();

            // invoke the operation and iterate over the result
            await foreach (ShareSubscriptionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ShareSubscriptionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
