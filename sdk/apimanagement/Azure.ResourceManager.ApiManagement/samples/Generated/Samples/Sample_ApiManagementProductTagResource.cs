// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ApiManagementProductTagResource
    {
        // ApiManagementHeadProductTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetEntityStateByProduct_ApiManagementHeadProductTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementHeadProductTag.json
            // this example is just showing the usage of "Tag_GetEntityStateByProduct" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementProductTagResource created on azure
            // for more information of creating ApiManagementProductTagResource, please refer to the document of ApiManagementProductTagResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string productId = "59306a29e4bbd510dc24e5f8";
            string tagId = "59306a29e4bbd510dc24e5f9";
            ResourceIdentifier apiManagementProductTagResourceId = ApiManagementProductTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, productId, tagId);
            ApiManagementProductTagResource apiManagementProductTag = client.GetApiManagementProductTagResource(apiManagementProductTagResourceId);

            // invoke the operation
            bool result = await apiManagementProductTag.GetEntityStateByProductAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetProductTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetProductTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetProductTag.json
            // this example is just showing the usage of "Tag_GetByProduct" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementProductTagResource created on azure
            // for more information of creating ApiManagementProductTagResource, please refer to the document of ApiManagementProductTagResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string productId = "59d6bb8f1f7fab13dc67ec9b";
            string tagId = "59306a29e4bbd510dc24e5f9";
            ResourceIdentifier apiManagementProductTagResourceId = ApiManagementProductTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, productId, tagId);
            ApiManagementProductTagResource apiManagementProductTag = client.GetApiManagementProductTagResource(apiManagementProductTagResourceId);

            // invoke the operation
            ApiManagementProductTagResource result = await apiManagementProductTag.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementCreateProductTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApiManagementCreateProductTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementCreateProductTag.json
            // this example is just showing the usage of "Tag_AssignToProduct" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementProductTagResource created on azure
            // for more information of creating ApiManagementProductTagResource, please refer to the document of ApiManagementProductTagResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string productId = "5931a75ae4bbd512a88c680b";
            string tagId = "tagId1";
            ResourceIdentifier apiManagementProductTagResourceId = ApiManagementProductTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, productId, tagId);
            ApiManagementProductTagResource apiManagementProductTag = client.GetApiManagementProductTagResource(apiManagementProductTagResourceId);

            // invoke the operation
            ArmOperation<ApiManagementProductTagResource> lro = await apiManagementProductTag.UpdateAsync(WaitUntil.Completed);
            ApiManagementProductTagResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementDeleteProductTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ApiManagementDeleteProductTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementDeleteProductTag.json
            // this example is just showing the usage of "Tag_DetachFromProduct" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementProductTagResource created on azure
            // for more information of creating ApiManagementProductTagResource, please refer to the document of ApiManagementProductTagResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string productId = "59d5b28d1f7fab116c282650";
            string tagId = "59d5b28e1f7fab116402044e";
            ResourceIdentifier apiManagementProductTagResourceId = ApiManagementProductTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, productId, tagId);
            ApiManagementProductTagResource apiManagementProductTag = client.GetApiManagementProductTagResource(apiManagementProductTagResourceId);

            // invoke the operation
            await apiManagementProductTag.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
