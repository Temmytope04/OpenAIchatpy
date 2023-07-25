// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_WebSiteSlotConfigAppSettingResource
    {
        // Get Azure Key Vault slot app setting reference
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAzureKeyVaultSlotAppSettingReference()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/GetKeyVaultReferencesForAppSettingSlot.json
            // this example is just showing the usage of "WebApps_GetAppSettingKeyVaultReferenceSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteSlotConfigAppSettingResource created on azure
            // for more information of creating WebSiteSlotConfigAppSettingResource, please refer to the document of WebSiteSlotConfigAppSettingResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string name = "testc6282";
            string slot = "stage";
            string appSettingKey = "setting";
            ResourceIdentifier webSiteSlotConfigAppSettingResourceId = WebSiteSlotConfigAppSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, slot, appSettingKey);
            WebSiteSlotConfigAppSettingResource webSiteSlotConfigAppSetting = client.GetWebSiteSlotConfigAppSettingResource(webSiteSlotConfigAppSettingResourceId);

            // invoke the operation
            WebSiteSlotConfigAppSettingResource result = await webSiteSlotConfigAppSetting.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiKeyVaultReferenceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
