// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Marketplace.Models;

namespace Azure.ResourceManager.Marketplace.Samples
{
    public partial class Sample_PrivateStoreCollection
    {
        // GetPrivateStores
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetPrivateStores()
        {
            // Generated from example definition: specification/marketplace/resource-manager/Microsoft.Marketplace/stable/2023-01-01/examples/GetPrivateStores.json
            // this example is just showing the usage of "PrivateStore_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this PrivateStoreResource
            PrivateStoreCollection collection = tenantResource.GetPrivateStores();

            // invoke the operation and iterate over the result
            await foreach (PrivateStoreResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PrivateStoreData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // GetPrivateStore
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPrivateStore()
        {
            // Generated from example definition: specification/marketplace/resource-manager/Microsoft.Marketplace/stable/2023-01-01/examples/GetPrivateStore.json
            // this example is just showing the usage of "PrivateStore_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this PrivateStoreResource
            PrivateStoreCollection collection = tenantResource.GetPrivateStores();

            // invoke the operation
            Guid privateStoreId = Guid.Parse("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            PrivateStoreResource result = await collection.GetAsync(privateStoreId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PrivateStoreData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetPrivateStore
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetPrivateStore()
        {
            // Generated from example definition: specification/marketplace/resource-manager/Microsoft.Marketplace/stable/2023-01-01/examples/GetPrivateStore.json
            // this example is just showing the usage of "PrivateStore_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this PrivateStoreResource
            PrivateStoreCollection collection = tenantResource.GetPrivateStores();

            // invoke the operation
            Guid privateStoreId = Guid.Parse("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            bool result = await collection.ExistsAsync(privateStoreId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GetPrivateStore
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetPrivateStore()
        {
            // Generated from example definition: specification/marketplace/resource-manager/Microsoft.Marketplace/stable/2023-01-01/examples/GetPrivateStore.json
            // this example is just showing the usage of "PrivateStore_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this PrivateStoreResource
            PrivateStoreCollection collection = tenantResource.GetPrivateStores();

            // invoke the operation
            Guid privateStoreId = Guid.Parse("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            NullableResponse<PrivateStoreResource> response = await collection.GetIfExistsAsync(privateStoreId);
            PrivateStoreResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PrivateStoreData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // PrivateStores_update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PrivateStoresUpdate()
        {
            // Generated from example definition: specification/marketplace/resource-manager/Microsoft.Marketplace/stable/2023-01-01/examples/PrivateStores_update.json
            // this example is just showing the usage of "PrivateStore_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this PrivateStoreResource
            PrivateStoreCollection collection = tenantResource.GetPrivateStores();

            // invoke the operation
            Guid privateStoreId = Guid.Parse("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            PrivateStoreData data = new PrivateStoreData()
            {
                Availability = PrivateStoreAvailability.Disabled,
                ETag = new ETag("\"9301f4fd-0000-0100-0000-5e248b350345\""),
            };
            await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateStoreId, data);

            Console.WriteLine($"Succeeded");
        }
    }
}
