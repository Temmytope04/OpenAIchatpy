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
    public partial class Sample_ApiTagCollection
    {
        // ApiManagementListApiTags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ApiManagementListApiTags()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2022-08-01/examples/ApiManagementListApiTags.json
            // this example is just showing the usage of "Tag_ListByApi" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiResource created on azure
            // for more information of creating ApiResource, please refer to the document of ApiResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "57d2ef278aa04f0888cba3f3";
            ResourceIdentifier apiResourceId = ApiResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId);
            ApiResource api = client.GetApiResource(apiResourceId);

            // get the collection of this ApiTagResource
            ApiTagCollection collection = api.GetApiTags();

            // invoke the operation and iterate over the result
            await foreach (ApiTagResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                TagContractData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ApiManagementGetApiTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetApiTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2022-08-01/examples/ApiManagementGetApiTag.json
            // this example is just showing the usage of "Tag_GetByApi" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiResource created on azure
            // for more information of creating ApiResource, please refer to the document of ApiResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "59d6bb8f1f7fab13dc67ec9b";
            ResourceIdentifier apiResourceId = ApiResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId);
            ApiResource api = client.GetApiResource(apiResourceId);

            // get the collection of this ApiTagResource
            ApiTagCollection collection = api.GetApiTags();

            // invoke the operation
            string tagId = "59306a29e4bbd510dc24e5f9";
            ApiTagResource result = await collection.GetAsync(tagId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementGetApiTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ApiManagementGetApiTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2022-08-01/examples/ApiManagementGetApiTag.json
            // this example is just showing the usage of "Tag_GetByApi" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiResource created on azure
            // for more information of creating ApiResource, please refer to the document of ApiResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "59d6bb8f1f7fab13dc67ec9b";
            ResourceIdentifier apiResourceId = ApiResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId);
            ApiResource api = client.GetApiResource(apiResourceId);

            // get the collection of this ApiTagResource
            ApiTagCollection collection = api.GetApiTags();

            // invoke the operation
            string tagId = "59306a29e4bbd510dc24e5f9";
            bool result = await collection.ExistsAsync(tagId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetApiTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ApiManagementGetApiTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2022-08-01/examples/ApiManagementGetApiTag.json
            // this example is just showing the usage of "Tag_GetByApi" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiResource created on azure
            // for more information of creating ApiResource, please refer to the document of ApiResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "59d6bb8f1f7fab13dc67ec9b";
            ResourceIdentifier apiResourceId = ApiResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId);
            ApiResource api = client.GetApiResource(apiResourceId);

            // get the collection of this ApiTagResource
            ApiTagCollection collection = api.GetApiTags();

            // invoke the operation
            string tagId = "59306a29e4bbd510dc24e5f9";
            NullableResponse<ApiTagResource> response = await collection.GetIfExistsAsync(tagId);
            ApiTagResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                TagContractData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ApiManagementCreateApiTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ApiManagementCreateApiTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2022-08-01/examples/ApiManagementCreateApiTag.json
            // this example is just showing the usage of "Tag_AssignToApi" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiResource created on azure
            // for more information of creating ApiResource, please refer to the document of ApiResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "5931a75ae4bbd512a88c680b";
            ResourceIdentifier apiResourceId = ApiResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId);
            ApiResource api = client.GetApiResource(apiResourceId);

            // get the collection of this ApiTagResource
            ApiTagCollection collection = api.GetApiTags();

            // invoke the operation
            string tagId = "tagId1";
            ArmOperation<ApiTagResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, tagId);
            ApiTagResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
