// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.DeviceProvisioningServices;

namespace Azure.ResourceManager.DeviceProvisioningServices.Samples
{
    public partial class Sample_DeviceProvisioningServicesPrivateLinkResource
    {
        // PrivateLinkResources_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PrivateLinkResourcesList()
        {
            // Generated from example definition: specification/deviceprovisioningservices/resource-manager/Microsoft.Devices/stable/2022-02-05/examples/DPSGetPrivateLinkResources.json
            // this example is just showing the usage of "IotDpsResource_GetPrivateLinkResources" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceProvisioningServicesPrivateLinkResource created on azure
            // for more information of creating DeviceProvisioningServicesPrivateLinkResource, please refer to the document of DeviceProvisioningServicesPrivateLinkResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "myFirstProvisioningService";
            string groupId = "iotDps";
            ResourceIdentifier deviceProvisioningServicesPrivateLinkResourceId = DeviceProvisioningServicesPrivateLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, groupId);
            DeviceProvisioningServicesPrivateLinkResource deviceProvisioningServicesPrivateLinkResource = client.GetDeviceProvisioningServicesPrivateLinkResource(deviceProvisioningServicesPrivateLinkResourceId);

            // invoke the operation
            DeviceProvisioningServicesPrivateLinkResource result = await deviceProvisioningServicesPrivateLinkResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceProvisioningServicesPrivateLinkResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
