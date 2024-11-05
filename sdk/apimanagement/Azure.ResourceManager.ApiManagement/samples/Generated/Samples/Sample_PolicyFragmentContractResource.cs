// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApiManagement.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_PolicyFragmentContractResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetEntityTag_ApiManagementHeadPolicyFragment()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementHeadPolicyFragment.json
            // this example is just showing the usage of "PolicyFragment_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PolicyFragmentContractResource created on azure
            // for more information of creating PolicyFragmentContractResource, please refer to the document of PolicyFragmentContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string id = "policyFragment1";
            ResourceIdentifier policyFragmentContractResourceId = PolicyFragmentContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, id);
            PolicyFragmentContractResource policyFragmentContract = client.GetPolicyFragmentContractResource(policyFragmentContractResourceId);

            // invoke the operation
            bool result = await policyFragmentContract.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetPolicyFragment()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetPolicyFragment.json
            // this example is just showing the usage of "PolicyFragment_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PolicyFragmentContractResource created on azure
            // for more information of creating PolicyFragmentContractResource, please refer to the document of PolicyFragmentContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string id = "policyFragment1";
            ResourceIdentifier policyFragmentContractResourceId = PolicyFragmentContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, id);
            PolicyFragmentContractResource policyFragmentContract = client.GetPolicyFragmentContractResource(policyFragmentContractResourceId);

            // invoke the operation
            PolicyFragmentContractResource result = await policyFragmentContract.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyFragmentContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetPolicyFragmentFormat()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetPolicyFragmentFormat.json
            // this example is just showing the usage of "PolicyFragment_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PolicyFragmentContractResource created on azure
            // for more information of creating PolicyFragmentContractResource, please refer to the document of PolicyFragmentContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string id = "policyFragment1";
            ResourceIdentifier policyFragmentContractResourceId = PolicyFragmentContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, id);
            PolicyFragmentContractResource policyFragmentContract = client.GetPolicyFragmentContractResource(policyFragmentContractResourceId);

            // invoke the operation
            PolicyFragmentContentFormat? format = PolicyFragmentContentFormat.Rawxml;
            PolicyFragmentContractResource result = await policyFragmentContract.GetAsync(format: format);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyFragmentContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementCreatePolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementCreatePolicyFragment.json
            // this example is just showing the usage of "PolicyFragment_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PolicyFragmentContractResource created on azure
            // for more information of creating PolicyFragmentContractResource, please refer to the document of PolicyFragmentContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string id = "policyFragment1";
            ResourceIdentifier policyFragmentContractResourceId = PolicyFragmentContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, id);
            PolicyFragmentContractResource policyFragmentContract = client.GetPolicyFragmentContractResource(policyFragmentContractResourceId);

            // invoke the operation
            PolicyFragmentContractData data = new PolicyFragmentContractData()
            {
                Value = "<fragment><json-to-xml apply=\"always\" consider-accept-header=\"false\" /></fragment>",
                Description = "A policy fragment example",
                Format = PolicyFragmentContentFormat.Xml,
            };
            ArmOperation<PolicyFragmentContractResource> lro = await policyFragmentContract.UpdateAsync(WaitUntil.Completed, data);
            PolicyFragmentContractResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyFragmentContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ApiManagementDeletePolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementDeletePolicyFragment.json
            // this example is just showing the usage of "PolicyFragment_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PolicyFragmentContractResource created on azure
            // for more information of creating PolicyFragmentContractResource, please refer to the document of PolicyFragmentContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string id = "policyFragment1";
            ResourceIdentifier policyFragmentContractResourceId = PolicyFragmentContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, id);
            PolicyFragmentContractResource policyFragmentContract = client.GetPolicyFragmentContractResource(policyFragmentContractResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await policyFragmentContract.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetReferences_ApiManagementListPolicyFragmentReferences()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementListPolicyFragmentReferences.json
            // this example is just showing the usage of "PolicyFragment_ListReferences" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PolicyFragmentContractResource created on azure
            // for more information of creating PolicyFragmentContractResource, please refer to the document of PolicyFragmentContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string id = "policyFragment1";
            ResourceIdentifier policyFragmentContractResourceId = PolicyFragmentContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, id);
            PolicyFragmentContractResource policyFragmentContract = client.GetPolicyFragmentContractResource(policyFragmentContractResourceId);

            // invoke the operation and iterate over the result
            await foreach (ResourceCollectionValueItem item in policyFragmentContract.GetReferencesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
