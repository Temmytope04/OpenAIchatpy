// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.ResourceHealth;

namespace Azure.ResourceManager.ResourceHealth.Samples
{
    public partial class Sample_ResourceHealthMetadataEntityCollection
    {
        // GetMetadata
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetMetadata()
        {
            // Generated from example definition: specification/resourcehealth/resource-manager/Microsoft.ResourceHealth/stable/2022-10-01/examples/Metadata_List.json
            // this example is just showing the usage of "Metadata_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this ResourceHealthMetadataEntityResource
            ResourceHealthMetadataEntityCollection collection = tenantResource.GetResourceHealthMetadataEntities();

            // invoke the operation and iterate over the result
            await foreach (ResourceHealthMetadataEntityResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ResourceHealthMetadataEntityData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // GetMetadata
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetMetadata()
        {
            // Generated from example definition: specification/resourcehealth/resource-manager/Microsoft.ResourceHealth/stable/2022-10-01/examples/Metadata_GetEntity.json
            // this example is just showing the usage of "Metadata_GetEntity" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this ResourceHealthMetadataEntityResource
            ResourceHealthMetadataEntityCollection collection = tenantResource.GetResourceHealthMetadataEntities();

            // invoke the operation
            string name = "status";
            ResourceHealthMetadataEntityResource result = await collection.GetAsync(name);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ResourceHealthMetadataEntityData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetMetadata
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetMetadata()
        {
            // Generated from example definition: specification/resourcehealth/resource-manager/Microsoft.ResourceHealth/stable/2022-10-01/examples/Metadata_GetEntity.json
            // this example is just showing the usage of "Metadata_GetEntity" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this ResourceHealthMetadataEntityResource
            ResourceHealthMetadataEntityCollection collection = tenantResource.GetResourceHealthMetadataEntities();

            // invoke the operation
            string name = "status";
            bool result = await collection.ExistsAsync(name);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
