// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_VirtualWanResource
    {
        // supportedSecurityProviders
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task SupportedSecurityProviders_SupportedSecurityProviders()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualWanSupportedSecurityProviders.json
            // this example is just showing the usage of "SupportedSecurityProviders" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualWanResource created on azure
            // for more information of creating VirtualWanResource, please refer to the document of VirtualWanResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualWanName = "wan1";
            ResourceIdentifier virtualWanResourceId = VirtualWanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualWanName);
            VirtualWanResource virtualWan = client.GetVirtualWanResource(virtualWanResourceId);

            // invoke the operation
            VirtualWanSecurityProviders result = await virtualWan.SupportedSecurityProvidersAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // GenerateVirtualWanVpnServerConfigurationVpnProfile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GenerateVirtualWanVpnServerConfigurationVpnProfile_GenerateVirtualWanVpnServerConfigurationVpnProfile()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/GenerateVirtualWanVpnServerConfigurationVpnProfile.json
            // this example is just showing the usage of "Generatevirtualwanvpnserverconfigurationvpnprofile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualWanResource created on azure
            // for more information of creating VirtualWanResource, please refer to the document of VirtualWanResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualWanName = "wan1";
            ResourceIdentifier virtualWanResourceId = VirtualWanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualWanName);
            VirtualWanResource virtualWan = client.GetVirtualWanResource(virtualWanResourceId);

            // invoke the operation
            VirtualWanVpnProfileContent content = new VirtualWanVpnProfileContent()
            {
                VpnServerConfigurationResourceId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/vpnServerConfigurations/vpnconfig1"),
                AuthenticationMethod = NetworkAuthenticationMethod.Eaptls,
            };
            ArmOperation<VpnProfileResponse> lro = await virtualWan.GenerateVirtualWanVpnServerConfigurationVpnProfileAsync(WaitUntil.Completed, content);
            VpnProfileResponse result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // VirtualWANGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VirtualWANGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualWANGet.json
            // this example is just showing the usage of "VirtualWans_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualWanResource created on azure
            // for more information of creating VirtualWanResource, please refer to the document of VirtualWanResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualWanName = "wan1";
            ResourceIdentifier virtualWanResourceId = VirtualWanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualWanName);
            VirtualWanResource virtualWan = client.GetVirtualWanResource(virtualWanResourceId);

            // invoke the operation
            VirtualWanResource result = await virtualWan.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualWanData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualWANUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_VirtualWANUpdate()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualWANUpdateTags.json
            // this example is just showing the usage of "VirtualWans_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualWanResource created on azure
            // for more information of creating VirtualWanResource, please refer to the document of VirtualWanResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualWanName = "wan1";
            ResourceIdentifier virtualWanResourceId = VirtualWanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualWanName);
            VirtualWanResource virtualWan = client.GetVirtualWanResource(virtualWanResourceId);

            // invoke the operation
            NetworkTagsObject wanParameters = new NetworkTagsObject()
            {
                Tags =
{
["key1"] = "value1",
["key2"] = "value2",
},
            };
            VirtualWanResource result = await virtualWan.UpdateAsync(wanParameters);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualWanData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualWANDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_VirtualWANDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualWANDelete.json
            // this example is just showing the usage of "VirtualWans_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualWanResource created on azure
            // for more information of creating VirtualWanResource, please refer to the document of VirtualWanResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualWanName = "virtualWan1";
            ResourceIdentifier virtualWanResourceId = VirtualWanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualWanName);
            VirtualWanResource virtualWan = client.GetVirtualWanResource(virtualWanResourceId);

            // invoke the operation
            await virtualWan.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // VirtualWANList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVirtualWans_VirtualWANList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualWANList.json
            // this example is just showing the usage of "VirtualWans_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (VirtualWanResource item in subscriptionResource.GetVirtualWansAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualWanData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // VpnSitesConfigurationDownload
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task DownloadVpnSitesConfiguration_VpnSitesConfigurationDownload()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VpnSitesConfigurationDownload.json
            // this example is just showing the usage of "VpnSitesConfiguration_Download" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualWanResource created on azure
            // for more information of creating VirtualWanResource, please refer to the document of VirtualWanResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualWanName = "wan1";
            ResourceIdentifier virtualWanResourceId = VirtualWanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualWanName);
            VirtualWanResource virtualWan = client.GetVirtualWanResource(virtualWanResourceId);

            // invoke the operation
            GetVpnSitesConfigurationContent content = new GetVpnSitesConfigurationContent(new Uri("https://blobcortextesturl.blob.core.windows.net/folderforconfig/vpnFile?sp=rw&se=2018-01-10T03%3A42%3A04Z&sv=2017-04-17&sig=WvXrT5bDmDFfgHs%2Brz%2BjAu123eRCNE9BO0eQYcPDT7pY%3D&sr=b"))
            {
                VpnSites =
{
"/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/vpnSites/abc"
},
            };
            await virtualWan.DownloadVpnSitesConfigurationAsync(WaitUntil.Completed, content);

            Console.WriteLine($"Succeeded");
        }

        // GetVirtualWanVpnServerConfigurations
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVpnServerConfigurationsAssociatedWithVirtualWan_GetVirtualWanVpnServerConfigurations()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/GetVirtualWanVpnServerConfigurations.json
            // this example is just showing the usage of "VpnServerConfigurationsAssociatedWithVirtualWan_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualWanResource created on azure
            // for more information of creating VirtualWanResource, please refer to the document of VirtualWanResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualWanName = "wan1";
            ResourceIdentifier virtualWanResourceId = VirtualWanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualWanName);
            VirtualWanResource virtualWan = client.GetVirtualWanResource(virtualWanResourceId);

            // invoke the operation
            ArmOperation<VpnServerConfigurationsResponse> lro = await virtualWan.GetVpnServerConfigurationsAssociatedWithVirtualWanAsync(WaitUntil.Completed);
            VpnServerConfigurationsResponse result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
