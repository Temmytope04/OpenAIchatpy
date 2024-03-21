// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Media.Samples
{
    public partial class Sample_MediaServicesAccountCollection
    {
        // List all Media Services accounts
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListAllMediaServicesAccounts()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Accounts/stable/2023-01-01/examples/accounts-list-all-accounts.json
            // this example is just showing the usage of "Mediaservices_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MediaServicesAccountResource
            MediaServicesAccountCollection collection = resourceGroupResource.GetMediaServicesAccounts();

            // invoke the operation and iterate over the result
            await foreach (MediaServicesAccountResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MediaServicesAccountData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get a Media Services account by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAMediaServicesAccountByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Accounts/stable/2023-01-01/examples/accounts-get-by-name.json
            // this example is just showing the usage of "Mediaservices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MediaServicesAccountResource
            MediaServicesAccountCollection collection = resourceGroupResource.GetMediaServicesAccounts();

            // invoke the operation
            string accountName = "contosotv";
            MediaServicesAccountResource result = await collection.GetAsync(accountName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MediaServicesAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a Media Services account by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAMediaServicesAccountByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Accounts/stable/2023-01-01/examples/accounts-get-by-name.json
            // this example is just showing the usage of "Mediaservices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MediaServicesAccountResource
            MediaServicesAccountCollection collection = resourceGroupResource.GetMediaServicesAccounts();

            // invoke the operation
            string accountName = "contosotv";
            bool result = await collection.ExistsAsync(accountName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a Media Services account by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAMediaServicesAccountByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Accounts/stable/2023-01-01/examples/accounts-get-by-name.json
            // this example is just showing the usage of "Mediaservices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MediaServicesAccountResource
            MediaServicesAccountCollection collection = resourceGroupResource.GetMediaServicesAccounts();

            // invoke the operation
            string accountName = "contosotv";
            NullableResponse<MediaServicesAccountResource> response = await collection.GetIfExistsAsync(accountName);
            MediaServicesAccountResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MediaServicesAccountData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create a Media Services account
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAMediaServicesAccount()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Accounts/stable/2023-01-01/examples/async-accounts-create.json
            // this example is just showing the usage of "Mediaservices_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MediaServicesAccountResource
            MediaServicesAccountCollection collection = resourceGroupResource.GetMediaServicesAccounts();

            // invoke the operation
            string accountName = "contososports";
            MediaServicesAccountData data = new MediaServicesAccountData(new AzureLocation("South Central US"))
            {
                StorageAccounts =
{
new MediaServicesStorageAccount(MediaServicesStorageAccountType.Primary)
{
Id = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/contosorg/providers/Microsoft.Storage/storageAccounts/teststorageaccount"),
}
},
                Tags =
{
["key1"] = "value1",
["key2"] = "value2",
},
            };
            ArmOperation<MediaServicesAccountResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, accountName, data);
            MediaServicesAccountResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MediaServicesAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a Media Services account-managed-identity
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAMediaServicesAccountManagedIdentity()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Accounts/stable/2023-01-01/examples/async-accounts-create-managed-identity.json
            // this example is just showing the usage of "Mediaservices_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MediaServicesAccountResource
            MediaServicesAccountCollection collection = resourceGroupResource.GetMediaServicesAccounts();

            // invoke the operation
            string accountName = "contososports";
            MediaServicesAccountData data = new MediaServicesAccountData(new AzureLocation("South Central US"))
            {
                Identity = new ManagedServiceIdentity("UserAssigned")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/contosorg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/id1")] = new UserAssignedIdentity(),
[new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/contosorg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/id2")] = new UserAssignedIdentity(),
},
                },
                StorageAccounts =
{
new MediaServicesStorageAccount(MediaServicesStorageAccountType.Primary)
{
Id = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/contosorg/providers/Microsoft.Storage/storageAccounts/contososportsstore"),
Identity = new ResourceIdentity(false)
{
UserAssignedIdentity = "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/contosorg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/id1",
},
}
},
                StorageAuthentication = MediaStorageAuthentication.ManagedIdentity,
                Encryption = new AccountEncryption(AccountEncryptionKeyType.CustomerKey)
                {
                    Identity = new ResourceIdentity(false)
                    {
                        UserAssignedIdentity = "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/contosorg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/id1",
                    },
                },
                KeyDeliveryAccessControl = new MediaAccessControl()
                {
                    DefaultAction = IPAccessControlDefaultAction.Allow,
                },
                PublicNetworkAccess = MediaServicesPublicNetworkAccess.Enabled,
                Tags =
{
["key1"] = "value1",
["key2"] = "value2",
},
            };
            ArmOperation<MediaServicesAccountResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, accountName, data);
            MediaServicesAccountResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MediaServicesAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
