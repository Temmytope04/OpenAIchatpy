// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppContainers.Models;

namespace Azure.ResourceManager.AppContainers.Samples
{
    public partial class Sample_ContainerAppAuthConfigResource
    {
        // Get Container App's AuthConfig
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetContainerAppSAuthConfig()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2023-05-01/examples/AuthConfigs_Get.json
            // this example is just showing the usage of "ContainerAppsAuthConfigs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppAuthConfigResource created on azure
            // for more information of creating ContainerAppAuthConfigResource, please refer to the document of ContainerAppAuthConfigResource
            string subscriptionId = "651f8027-33e8-4ec4-97b4-f6e9f3dc8744";
            string resourceGroupName = "workerapps-rg-xj";
            string containerAppName = "testcanadacentral";
            string authConfigName = "current";
            ResourceIdentifier containerAppAuthConfigResourceId = ContainerAppAuthConfigResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerAppName, authConfigName);
            ContainerAppAuthConfigResource containerAppAuthConfig = client.GetContainerAppAuthConfigResource(containerAppAuthConfigResourceId);

            // invoke the operation
            ContainerAppAuthConfigResource result = await containerAppAuthConfig.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppAuthConfigData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or Update Container App AuthConfig
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateContainerAppAuthConfig()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2023-05-01/examples/AuthConfigs_CreateOrUpdate.json
            // this example is just showing the usage of "ContainerAppsAuthConfigs_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppAuthConfigResource created on azure
            // for more information of creating ContainerAppAuthConfigResource, please refer to the document of ContainerAppAuthConfigResource
            string subscriptionId = "651f8027-33e8-4ec4-97b4-f6e9f3dc8744";
            string resourceGroupName = "workerapps-rg-xj";
            string containerAppName = "testcanadacentral";
            string authConfigName = "current";
            ResourceIdentifier containerAppAuthConfigResourceId = ContainerAppAuthConfigResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerAppName, authConfigName);
            ContainerAppAuthConfigResource containerAppAuthConfig = client.GetContainerAppAuthConfigResource(containerAppAuthConfigResourceId);

            // invoke the operation
            ContainerAppAuthConfigData data = new ContainerAppAuthConfigData()
            {
                Platform = new ContainerAppAuthPlatform()
                {
                    IsEnabled = true,
                },
                GlobalValidation = new ContainerAppGlobalValidation()
                {
                    UnauthenticatedClientAction = ContainerAppUnauthenticatedClientActionV2.AllowAnonymous,
                },
                IdentityProviders = new ContainerAppIdentityProvidersConfiguration()
                {
                    Facebook = new ContainerAppFacebookConfiguration()
                    {
                        Registration = new ContainerAppRegistration()
                        {
                            AppId = "123",
                            AppSecretSettingName = "facebook-secret",
                        },
                    },
                },
            };
            ArmOperation<ContainerAppAuthConfigResource> lro = await containerAppAuthConfig.UpdateAsync(WaitUntil.Completed, data);
            ContainerAppAuthConfigResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppAuthConfigData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete Container App AuthConfig
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteContainerAppAuthConfig()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2023-05-01/examples/AuthConfigs_Delete.json
            // this example is just showing the usage of "ContainerAppsAuthConfigs_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppAuthConfigResource created on azure
            // for more information of creating ContainerAppAuthConfigResource, please refer to the document of ContainerAppAuthConfigResource
            string subscriptionId = "651f8027-33e8-4ec4-97b4-f6e9f3dc8744";
            string resourceGroupName = "workerapps-rg-xj";
            string containerAppName = "testcanadacentral";
            string authConfigName = "current";
            ResourceIdentifier containerAppAuthConfigResourceId = ContainerAppAuthConfigResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerAppName, authConfigName);
            ContainerAppAuthConfigResource containerAppAuthConfig = client.GetContainerAppAuthConfigResource(containerAppAuthConfigResourceId);

            // invoke the operation
            await containerAppAuthConfig.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
