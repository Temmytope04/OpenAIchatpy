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
using Azure.ResourceManager.MixedReality;
using Azure.ResourceManager.MixedReality.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MixedReality.Samples
{
    public partial class Sample_RemoteRenderingAccountResource
    {
        // List remote rendering accounts by subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetRemoteRenderingAccounts_ListRemoteRenderingAccountsBySubscription()
        {
            // Generated from example definition: specification/mixedreality/resource-manager/Microsoft.MixedReality/stable/2021-01-01/examples/remote-rendering/GetBySubscription.json
            // this example is just showing the usage of "RemoteRenderingAccounts_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (RemoteRenderingAccountResource item in subscriptionResource.GetRemoteRenderingAccountsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RemoteRenderingAccountData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Delete remote rendering account
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteRemoteRenderingAccount()
        {
            // Generated from example definition: specification/mixedreality/resource-manager/Microsoft.MixedReality/stable/2021-01-01/examples/remote-rendering/Delete.json
            // this example is just showing the usage of "RemoteRenderingAccounts_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RemoteRenderingAccountResource created on azure
            // for more information of creating RemoteRenderingAccountResource, please refer to the document of RemoteRenderingAccountResource
            string subscriptionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            string resourceGroupName = "MyResourceGroup";
            string accountName = "MyAccount";
            ResourceIdentifier remoteRenderingAccountResourceId = RemoteRenderingAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            RemoteRenderingAccountResource remoteRenderingAccount = client.GetRemoteRenderingAccountResource(remoteRenderingAccountResourceId);

            // invoke the operation
            await remoteRenderingAccount.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get remote rendering account
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRemoteRenderingAccount()
        {
            // Generated from example definition: specification/mixedreality/resource-manager/Microsoft.MixedReality/stable/2021-01-01/examples/remote-rendering/Get.json
            // this example is just showing the usage of "RemoteRenderingAccounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RemoteRenderingAccountResource created on azure
            // for more information of creating RemoteRenderingAccountResource, please refer to the document of RemoteRenderingAccountResource
            string subscriptionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            string resourceGroupName = "MyResourceGroup";
            string accountName = "MyAccount";
            ResourceIdentifier remoteRenderingAccountResourceId = RemoteRenderingAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            RemoteRenderingAccountResource remoteRenderingAccount = client.GetRemoteRenderingAccountResource(remoteRenderingAccountResourceId);

            // invoke the operation
            RemoteRenderingAccountResource result = await remoteRenderingAccount.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RemoteRenderingAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update remote rendering account
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateRemoteRenderingAccount()
        {
            // Generated from example definition: specification/mixedreality/resource-manager/Microsoft.MixedReality/stable/2021-01-01/examples/remote-rendering/Patch.json
            // this example is just showing the usage of "RemoteRenderingAccounts_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RemoteRenderingAccountResource created on azure
            // for more information of creating RemoteRenderingAccountResource, please refer to the document of RemoteRenderingAccountResource
            string subscriptionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            string resourceGroupName = "MyResourceGroup";
            string accountName = "MyAccount";
            ResourceIdentifier remoteRenderingAccountResourceId = RemoteRenderingAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            RemoteRenderingAccountResource remoteRenderingAccount = client.GetRemoteRenderingAccountResource(remoteRenderingAccountResourceId);

            // invoke the operation
            RemoteRenderingAccountData data = new RemoteRenderingAccountData(new AzureLocation("eastus2euap"))
            {
                Identity = new ManagedServiceIdentity("SystemAssigned"),
                Tags =
{
["hero"] = "romeo",
["heroine"] = "juliet",
},
            };
            RemoteRenderingAccountResource result = await remoteRenderingAccount.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RemoteRenderingAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List remote rendering account key
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetKeys_ListRemoteRenderingAccountKey()
        {
            // Generated from example definition: specification/mixedreality/resource-manager/Microsoft.MixedReality/stable/2021-01-01/examples/remote-rendering/ListKeys.json
            // this example is just showing the usage of "RemoteRenderingAccounts_ListKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RemoteRenderingAccountResource created on azure
            // for more information of creating RemoteRenderingAccountResource, please refer to the document of RemoteRenderingAccountResource
            string subscriptionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            string resourceGroupName = "MyResourceGroup";
            string accountName = "MyAccount";
            ResourceIdentifier remoteRenderingAccountResourceId = RemoteRenderingAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            RemoteRenderingAccountResource remoteRenderingAccount = client.GetRemoteRenderingAccountResource(remoteRenderingAccountResourceId);

            // invoke the operation
            MixedRealityAccountKeys result = await remoteRenderingAccount.GetKeysAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // Regenerate remote rendering account keys
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RegenerateKeys_RegenerateRemoteRenderingAccountKeys()
        {
            // Generated from example definition: specification/mixedreality/resource-manager/Microsoft.MixedReality/stable/2021-01-01/examples/remote-rendering/RegenerateKey.json
            // this example is just showing the usage of "RemoteRenderingAccounts_RegenerateKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RemoteRenderingAccountResource created on azure
            // for more information of creating RemoteRenderingAccountResource, please refer to the document of RemoteRenderingAccountResource
            string subscriptionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            string resourceGroupName = "MyResourceGroup";
            string accountName = "MyAccount";
            ResourceIdentifier remoteRenderingAccountResourceId = RemoteRenderingAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            RemoteRenderingAccountResource remoteRenderingAccount = client.GetRemoteRenderingAccountResource(remoteRenderingAccountResourceId);

            // invoke the operation
            MixedRealityAccountKeyRegenerateContent content = new MixedRealityAccountKeyRegenerateContent()
            {
                Serial = MixedRealityAccountKeySerial.Primary,
            };
            MixedRealityAccountKeys result = await remoteRenderingAccount.RegenerateKeysAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
