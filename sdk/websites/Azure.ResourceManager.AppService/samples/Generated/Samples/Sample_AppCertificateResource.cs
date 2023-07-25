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
using Azure.ResourceManager.AppService;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_AppCertificateResource
    {
        // List Certificates for subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAppCertificates_ListCertificatesForSubscription()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/ListCertificates.json
            // this example is just showing the usage of "Certificates_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (AppCertificateResource item in subscriptionResource.GetAppCertificatesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppCertificateData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Certificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetCertificate()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/GetCertificate.json
            // this example is just showing the usage of "Certificates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppCertificateResource created on azure
            // for more information of creating AppCertificateResource, please refer to the document of AppCertificateResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string name = "testc6282";
            ResourceIdentifier appCertificateResourceId = AppCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            AppCertificateResource appCertificate = client.GetAppCertificateResource(appCertificateResourceId);

            // invoke the operation
            AppCertificateResource result = await appCertificate.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete Certificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteCertificate()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/DeleteCertificate.json
            // this example is just showing the usage of "Certificates_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppCertificateResource created on azure
            // for more information of creating AppCertificateResource, please refer to the document of AppCertificateResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string name = "testc6282";
            ResourceIdentifier appCertificateResourceId = AppCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            AppCertificateResource appCertificate = client.GetAppCertificateResource(appCertificateResourceId);

            // invoke the operation
            await appCertificate.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Patch Certificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchCertificate()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/PatchCertificate.json
            // this example is just showing the usage of "Certificates_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppCertificateResource created on azure
            // for more information of creating AppCertificateResource, please refer to the document of AppCertificateResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string name = "testc6282";
            ResourceIdentifier appCertificateResourceId = AppCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            AppCertificateResource appCertificate = client.GetAppCertificateResource(appCertificateResourceId);

            // invoke the operation
            AppCertificatePatch patch = new AppCertificatePatch()
            {
                Password = "<password>",
            };
            AppCertificateResource result = await appCertificate.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
