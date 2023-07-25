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
using Azure.ResourceManager.ProviderHub;
using Azure.ResourceManager.ProviderHub.Models;

namespace Azure.ResourceManager.ProviderHub.Samples
{
    public partial class Sample_NestedResourceTypeFirstSkuResource
    {
        // Skus_GetNestedResourceTypeFirst
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SkusGetNestedResourceTypeFirst()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/stable/2020-11-20/examples/Skus_GetNestedResourceTypeFirst.json
            // this example is just showing the usage of "Skus_GetNestedResourceTypeFirst" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NestedResourceTypeFirstSkuResource created on azure
            // for more information of creating NestedResourceTypeFirstSkuResource, please refer to the document of NestedResourceTypeFirstSkuResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string resourceType = "testResourceType";
            string nestedResourceTypeFirst = "nestedResourceTypeFirst";
            string sku = "testSku";
            ResourceIdentifier nestedResourceTypeFirstSkuResourceId = NestedResourceTypeFirstSkuResource.CreateResourceIdentifier(subscriptionId, providerNamespace, resourceType, nestedResourceTypeFirst, sku);
            NestedResourceTypeFirstSkuResource nestedResourceTypeFirstSku = client.GetNestedResourceTypeFirstSkuResource(nestedResourceTypeFirstSkuResourceId);

            // invoke the operation
            NestedResourceTypeFirstSkuResource result = await nestedResourceTypeFirstSku.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ResourceTypeSkuData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Skus_CreateOrUpdateNestedResourceTypeFirst
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_SkusCreateOrUpdateNestedResourceTypeFirst()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/stable/2020-11-20/examples/Skus_CreateOrUpdateNestedResourceTypeFirst.json
            // this example is just showing the usage of "Skus_CreateOrUpdateNestedResourceTypeFirst" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NestedResourceTypeFirstSkuResource created on azure
            // for more information of creating NestedResourceTypeFirstSkuResource, please refer to the document of NestedResourceTypeFirstSkuResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string resourceType = "testResourceType";
            string nestedResourceTypeFirst = "nestedResourceTypeFirst";
            string sku = "testSku";
            ResourceIdentifier nestedResourceTypeFirstSkuResourceId = NestedResourceTypeFirstSkuResource.CreateResourceIdentifier(subscriptionId, providerNamespace, resourceType, nestedResourceTypeFirst, sku);
            NestedResourceTypeFirstSkuResource nestedResourceTypeFirstSku = client.GetNestedResourceTypeFirstSkuResource(nestedResourceTypeFirstSkuResourceId);

            // invoke the operation
            ResourceTypeSkuData data = new ResourceTypeSkuData()
            {
                Properties = new ResourceTypeSkuProperties(new ResourceTypeSkuSetting[]
            {
new ResourceTypeSkuSetting("freeSku")
{
Tier = "Tier1",
Kind = "Standard",
},new ResourceTypeSkuSetting("premiumSku")
{
Tier = "Tier2",
Kind = "Premium",
Costs =
{
new ResourceTypeSkuCost("xxx")
},
}
            }),
            };
            ArmOperation<NestedResourceTypeFirstSkuResource> lro = await nestedResourceTypeFirstSku.UpdateAsync(WaitUntil.Completed, data);
            NestedResourceTypeFirstSkuResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ResourceTypeSkuData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Skus_DeleteNestedResourceTypeFirst
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_SkusDeleteNestedResourceTypeFirst()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/stable/2020-11-20/examples/Skus_DeleteNestedResourceTypeFirst.json
            // this example is just showing the usage of "Skus_DeleteNestedResourceTypeFirst" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NestedResourceTypeFirstSkuResource created on azure
            // for more information of creating NestedResourceTypeFirstSkuResource, please refer to the document of NestedResourceTypeFirstSkuResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string resourceType = "testResourceType";
            string nestedResourceTypeFirst = "nestedResourceTypeFirst";
            string sku = "testSku";
            ResourceIdentifier nestedResourceTypeFirstSkuResourceId = NestedResourceTypeFirstSkuResource.CreateResourceIdentifier(subscriptionId, providerNamespace, resourceType, nestedResourceTypeFirst, sku);
            NestedResourceTypeFirstSkuResource nestedResourceTypeFirstSku = client.GetNestedResourceTypeFirstSkuResource(nestedResourceTypeFirstSkuResourceId);

            // invoke the operation
            await nestedResourceTypeFirstSku.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
