// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ApiManagementPrivateLinkResource
    {
        // ApiManagementGetPrivateLinkGroupResource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetPrivateLinkGroupResource()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementGetPrivateLinkGroupResource.json
            // this example is just showing the usage of "PrivateEndpointConnection_GetPrivateLinkResource" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementPrivateLinkResource created on azure
            // for more information of creating ApiManagementPrivateLinkResource, please refer to the document of ApiManagementPrivateLinkResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string privateLinkSubResourceName = "privateLinkSubResourceName";
            ResourceIdentifier apiManagementPrivateLinkResourceId = ApiManagementPrivateLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, privateLinkSubResourceName);
            ApiManagementPrivateLinkResource apiManagementPrivateLinkResource = client.GetApiManagementPrivateLinkResource(apiManagementPrivateLinkResourceId);

            // invoke the operation
            ApiManagementPrivateLinkResource result = await apiManagementPrivateLinkResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementPrivateLinkResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
