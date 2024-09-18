// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ApiManagementCertificateResource
    {
        // ApiManagementHeadCertificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetEntityTag_ApiManagementHeadCertificate()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementHeadCertificate.json
            // this example is just showing the usage of "Certificate_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementCertificateResource created on azure
            // for more information of creating ApiManagementCertificateResource, please refer to the document of ApiManagementCertificateResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string certificateId = "templateCert1";
            ResourceIdentifier apiManagementCertificateResourceId = ApiManagementCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, certificateId);
            ApiManagementCertificateResource apiManagementCertificate = client.GetApiManagementCertificateResource(apiManagementCertificateResourceId);

            // invoke the operation
            bool result = await apiManagementCertificate.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetCertificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetCertificate()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetCertificate.json
            // this example is just showing the usage of "Certificate_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementCertificateResource created on azure
            // for more information of creating ApiManagementCertificateResource, please refer to the document of ApiManagementCertificateResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string certificateId = "templateCert1";
            ResourceIdentifier apiManagementCertificateResourceId = ApiManagementCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, certificateId);
            ApiManagementCertificateResource apiManagementCertificate = client.GetApiManagementCertificateResource(apiManagementCertificateResourceId);

            // invoke the operation
            ApiManagementCertificateResource result = await apiManagementCertificate.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementGetCertificateWithKeyVault
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetCertificateWithKeyVault()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetCertificateWithKeyVault.json
            // this example is just showing the usage of "Certificate_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementCertificateResource created on azure
            // for more information of creating ApiManagementCertificateResource, please refer to the document of ApiManagementCertificateResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string certificateId = "templateCertkv";
            ResourceIdentifier apiManagementCertificateResourceId = ApiManagementCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, certificateId);
            ApiManagementCertificateResource apiManagementCertificate = client.GetApiManagementCertificateResource(apiManagementCertificateResourceId);

            // invoke the operation
            ApiManagementCertificateResource result = await apiManagementCertificate.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementCreateCertificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApiManagementCreateCertificate()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementCreateCertificate.json
            // this example is just showing the usage of "Certificate_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementCertificateResource created on azure
            // for more information of creating ApiManagementCertificateResource, please refer to the document of ApiManagementCertificateResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string certificateId = "tempcert";
            ResourceIdentifier apiManagementCertificateResourceId = ApiManagementCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, certificateId);
            ApiManagementCertificateResource apiManagementCertificate = client.GetApiManagementCertificateResource(apiManagementCertificateResourceId);

            // invoke the operation
            ApiManagementCertificateCreateOrUpdateContent content = new ApiManagementCertificateCreateOrUpdateContent()
            {
                Data = "****************Base 64 Encoded Certificate *******************************",
                Password = "****Certificate Password******",
            };
            ArmOperation<ApiManagementCertificateResource> lro = await apiManagementCertificate.UpdateAsync(WaitUntil.Completed, content);
            ApiManagementCertificateResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementCreateCertificateWithKeyVault
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApiManagementCreateCertificateWithKeyVault()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementCreateCertificateWithKeyVault.json
            // this example is just showing the usage of "Certificate_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementCertificateResource created on azure
            // for more information of creating ApiManagementCertificateResource, please refer to the document of ApiManagementCertificateResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string certificateId = "templateCertkv";
            ResourceIdentifier apiManagementCertificateResourceId = ApiManagementCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, certificateId);
            ApiManagementCertificateResource apiManagementCertificate = client.GetApiManagementCertificateResource(apiManagementCertificateResourceId);

            // invoke the operation
            ApiManagementCertificateCreateOrUpdateContent content = new ApiManagementCertificateCreateOrUpdateContent()
            {
                KeyVaultDetails = new KeyVaultContractCreateProperties()
                {
                    SecretIdentifier = "https://rpbvtkeyvaultintegration.vault-int.azure-int.net/secrets/msitestingCert",
                    IdentityClientId = "ceaa6b06-c00f-43ef-99ac-f53d1fe876a0",
                },
            };
            ArmOperation<ApiManagementCertificateResource> lro = await apiManagementCertificate.UpdateAsync(WaitUntil.Completed, content);
            ApiManagementCertificateResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementDeleteCertificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ApiManagementDeleteCertificate()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementDeleteCertificate.json
            // this example is just showing the usage of "Certificate_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementCertificateResource created on azure
            // for more information of creating ApiManagementCertificateResource, please refer to the document of ApiManagementCertificateResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string certificateId = "tempcert";
            ResourceIdentifier apiManagementCertificateResourceId = ApiManagementCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, certificateId);
            ApiManagementCertificateResource apiManagementCertificate = client.GetApiManagementCertificateResource(apiManagementCertificateResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await apiManagementCertificate.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine($"Succeeded");
        }

        // ApiManagementRefreshCertificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RefreshSecret_ApiManagementRefreshCertificate()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementRefreshCertificate.json
            // this example is just showing the usage of "Certificate_RefreshSecret" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementCertificateResource created on azure
            // for more information of creating ApiManagementCertificateResource, please refer to the document of ApiManagementCertificateResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string certificateId = "templateCertkv";
            ResourceIdentifier apiManagementCertificateResourceId = ApiManagementCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, certificateId);
            ApiManagementCertificateResource apiManagementCertificate = client.GetApiManagementCertificateResource(apiManagementCertificateResourceId);

            // invoke the operation
            ApiManagementCertificateResource result = await apiManagementCertificate.RefreshSecretAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
