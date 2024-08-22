// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.MobileNetwork.Samples
{
    public partial class Sample_TenantPacketCoreControlPlaneVersionResource
    {
        // Get packet core control plane version
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPacketCoreControlPlaneVersion()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/PacketCoreControlPlaneVersionGet.json
            // this example is just showing the usage of "PacketCoreControlPlaneVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantPacketCoreControlPlaneVersionResource created on azure
            // for more information of creating TenantPacketCoreControlPlaneVersionResource, please refer to the document of TenantPacketCoreControlPlaneVersionResource
            string versionName = "2404.0-1";
            ResourceIdentifier tenantPacketCoreControlPlaneVersionResourceId = TenantPacketCoreControlPlaneVersionResource.CreateResourceIdentifier(versionName);
            TenantPacketCoreControlPlaneVersionResource tenantPacketCoreControlPlaneVersion = client.GetTenantPacketCoreControlPlaneVersionResource(tenantPacketCoreControlPlaneVersionResourceId);

            // invoke the operation
            TenantPacketCoreControlPlaneVersionResource result = await tenantPacketCoreControlPlaneVersion.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PacketCoreControlPlaneVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
