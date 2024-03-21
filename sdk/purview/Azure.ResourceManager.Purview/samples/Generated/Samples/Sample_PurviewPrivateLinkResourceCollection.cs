// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Purview.Samples
{
    public partial class Sample_PurviewPrivateLinkResourceCollection
    {
        // PrivateLinkResources_ListByAccount
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_PrivateLinkResourcesListByAccount()
        {
            // Generated from example definition: specification/purview/resource-manager/Microsoft.Purview/preview/2023-05-01-preview/examples/PrivateLinkResources_ListByAccount.json
            // this example is just showing the usage of "PrivateLinkResources_ListByAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PurviewAccountResource created on azure
            // for more information of creating PurviewAccountResource, please refer to the document of PurviewAccountResource
            string subscriptionId = "12345678-1234-1234-12345678abc";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "account1";
            ResourceIdentifier purviewAccountResourceId = PurviewAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            PurviewAccountResource purviewAccount = client.GetPurviewAccountResource(purviewAccountResourceId);

            // get the collection of this PurviewPrivateLinkResource
            PurviewPrivateLinkResourceCollection collection = purviewAccount.GetPurviewPrivateLinkResources();

            // invoke the operation and iterate over the result
            await foreach (PurviewPrivateLinkResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PurviewPrivateLinkResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // PrivateLinkResources_GetByGroupId
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PrivateLinkResourcesGetByGroupId()
        {
            // Generated from example definition: specification/purview/resource-manager/Microsoft.Purview/preview/2023-05-01-preview/examples/PrivateLinkResources_GetByGroupId.json
            // this example is just showing the usage of "PrivateLinkResources_GetByGroupId" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PurviewAccountResource created on azure
            // for more information of creating PurviewAccountResource, please refer to the document of PurviewAccountResource
            string subscriptionId = "12345678-1234-1234-12345678abc";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "account1";
            ResourceIdentifier purviewAccountResourceId = PurviewAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            PurviewAccountResource purviewAccount = client.GetPurviewAccountResource(purviewAccountResourceId);

            // get the collection of this PurviewPrivateLinkResource
            PurviewPrivateLinkResourceCollection collection = purviewAccount.GetPurviewPrivateLinkResources();

            // invoke the operation
            string groupId = "group1";
            PurviewPrivateLinkResource result = await collection.GetAsync(groupId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PurviewPrivateLinkResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateLinkResources_GetByGroupId
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_PrivateLinkResourcesGetByGroupId()
        {
            // Generated from example definition: specification/purview/resource-manager/Microsoft.Purview/preview/2023-05-01-preview/examples/PrivateLinkResources_GetByGroupId.json
            // this example is just showing the usage of "PrivateLinkResources_GetByGroupId" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PurviewAccountResource created on azure
            // for more information of creating PurviewAccountResource, please refer to the document of PurviewAccountResource
            string subscriptionId = "12345678-1234-1234-12345678abc";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "account1";
            ResourceIdentifier purviewAccountResourceId = PurviewAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            PurviewAccountResource purviewAccount = client.GetPurviewAccountResource(purviewAccountResourceId);

            // get the collection of this PurviewPrivateLinkResource
            PurviewPrivateLinkResourceCollection collection = purviewAccount.GetPurviewPrivateLinkResources();

            // invoke the operation
            string groupId = "group1";
            bool result = await collection.ExistsAsync(groupId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // PrivateLinkResources_GetByGroupId
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_PrivateLinkResourcesGetByGroupId()
        {
            // Generated from example definition: specification/purview/resource-manager/Microsoft.Purview/preview/2023-05-01-preview/examples/PrivateLinkResources_GetByGroupId.json
            // this example is just showing the usage of "PrivateLinkResources_GetByGroupId" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PurviewAccountResource created on azure
            // for more information of creating PurviewAccountResource, please refer to the document of PurviewAccountResource
            string subscriptionId = "12345678-1234-1234-12345678abc";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "account1";
            ResourceIdentifier purviewAccountResourceId = PurviewAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            PurviewAccountResource purviewAccount = client.GetPurviewAccountResource(purviewAccountResourceId);

            // get the collection of this PurviewPrivateLinkResource
            PurviewPrivateLinkResourceCollection collection = purviewAccount.GetPurviewPrivateLinkResources();

            // invoke the operation
            string groupId = "group1";
            NullableResponse<PurviewPrivateLinkResource> response = await collection.GetIfExistsAsync(groupId);
            PurviewPrivateLinkResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PurviewPrivateLinkResourceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
