// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppPlatform.Models;

namespace Azure.ResourceManager.AppPlatform.Samples
{
    public partial class Sample_AppPlatformCustomDomainResource
    {
        // CustomDomains_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CustomDomainsGet()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/CustomDomains_Get.json
            // this example is just showing the usage of "CustomDomains_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformCustomDomainResource created on azure
            // for more information of creating AppPlatformCustomDomainResource, please refer to the document of AppPlatformCustomDomainResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string appName = "myapp";
            string domainName = "mydomain.com";
            ResourceIdentifier appPlatformCustomDomainResourceId = AppPlatformCustomDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, appName, domainName);
            AppPlatformCustomDomainResource appPlatformCustomDomain = client.GetAppPlatformCustomDomainResource(appPlatformCustomDomainResourceId);

            // invoke the operation
            AppPlatformCustomDomainResource result = await appPlatformCustomDomain.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppPlatformCustomDomainData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CustomDomains_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_CustomDomainsDelete()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/CustomDomains_Delete.json
            // this example is just showing the usage of "CustomDomains_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformCustomDomainResource created on azure
            // for more information of creating AppPlatformCustomDomainResource, please refer to the document of AppPlatformCustomDomainResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string appName = "myapp";
            string domainName = "mydomain.com";
            ResourceIdentifier appPlatformCustomDomainResourceId = AppPlatformCustomDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, appName, domainName);
            AppPlatformCustomDomainResource appPlatformCustomDomain = client.GetAppPlatformCustomDomainResource(appPlatformCustomDomainResourceId);

            // invoke the operation
            await appPlatformCustomDomain.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // CustomDomains_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CustomDomainsUpdate()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/CustomDomains_Update.json
            // this example is just showing the usage of "CustomDomains_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformCustomDomainResource created on azure
            // for more information of creating AppPlatformCustomDomainResource, please refer to the document of AppPlatformCustomDomainResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string appName = "myapp";
            string domainName = "mydomain.com";
            ResourceIdentifier appPlatformCustomDomainResourceId = AppPlatformCustomDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, appName, domainName);
            AppPlatformCustomDomainResource appPlatformCustomDomain = client.GetAppPlatformCustomDomainResource(appPlatformCustomDomainResourceId);

            // invoke the operation
            AppPlatformCustomDomainData data = new AppPlatformCustomDomainData()
            {
                Properties = new AppPlatformCustomDomainProperties()
                {
                    Thumbprint = "934367bf1c97033f877db0f15cb1b586957d3133",
                    CertName = "mycert",
                },
            };
            ArmOperation<AppPlatformCustomDomainResource> lro = await appPlatformCustomDomain.UpdateAsync(WaitUntil.Completed, data);
            AppPlatformCustomDomainResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppPlatformCustomDomainData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
