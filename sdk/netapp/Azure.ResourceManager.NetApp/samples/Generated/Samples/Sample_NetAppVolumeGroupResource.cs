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
using Azure.ResourceManager.NetApp;
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp.Samples
{
    public partial class Sample_NetAppVolumeGroupResource
    {
        // VolumeGroups_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VolumeGroupsGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2022-11-01/examples/VolumeGroups_Get.json
            // this example is just showing the usage of "VolumeGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeGroupResource created on azure
            // for more information of creating NetAppVolumeGroupResource, please refer to the document of NetAppVolumeGroupResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string volumeGroupName = "group1";
            ResourceIdentifier netAppVolumeGroupResourceId = NetAppVolumeGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, volumeGroupName);
            NetAppVolumeGroupResource netAppVolumeGroup = client.GetNetAppVolumeGroupResource(netAppVolumeGroupResourceId);

            // invoke the operation
            NetAppVolumeGroupResource result = await netAppVolumeGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppVolumeGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VolumeGroups_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_VolumeGroupsCreate()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2022-11-01/examples/VolumeGroups_Create.json
            // this example is just showing the usage of "VolumeGroups_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeGroupResource created on azure
            // for more information of creating NetAppVolumeGroupResource, please refer to the document of NetAppVolumeGroupResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string volumeGroupName = "group1";
            ResourceIdentifier netAppVolumeGroupResourceId = NetAppVolumeGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, volumeGroupName);
            NetAppVolumeGroupResource netAppVolumeGroup = client.GetNetAppVolumeGroupResource(netAppVolumeGroupResourceId);

            // invoke the operation
            NetAppVolumeGroupData data = new NetAppVolumeGroupData()
            {
                Location = new AzureLocation("westus"),
                GroupMetaData = new NetAppVolumeGroupMetadata()
                {
                    GroupDescription = "Volume group",
                    ApplicationType = NetAppApplicationType.SapHana,
                    ApplicationIdentifier = "DEV",
                    DeploymentSpecId = "20542149-bfca-5618-1879-9863dc6767f1",
                },
                Volumes =
{
new NetAppVolumeGroupVolume("test-data-mnt00001",107374182400,new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRP/providers/Microsoft.Network/virtualNetworks/testvnet3/subnets/testsubnet3"))
{
Name = "test-data-mnt00001",
ServiceLevel = NetAppFileServiceLevel.Premium,
ThroughputMibps = 10,
CapacityPoolResourceId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRG/providers/Microsoft.NetApp/netAppAccounts/account1/capacityPools/pool1"),
ProximityPlacementGroupId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/cys_sjain_fcp_rg/providers/Microsoft.Compute/proximityPlacementGroups/svlqa_sjain_multivolume_ppg"),
VolumeSpecName = "data",
},new NetAppVolumeGroupVolume("test-log-mnt00001",107374182400,new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRP/providers/Microsoft.Network/virtualNetworks/testvnet3/subnets/testsubnet3"))
{
Name = "test-log-mnt00001",
ServiceLevel = NetAppFileServiceLevel.Premium,
ThroughputMibps = 10,
CapacityPoolResourceId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRG/providers/Microsoft.NetApp/netAppAccounts/account1/capacityPools/pool1"),
ProximityPlacementGroupId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/cys_sjain_fcp_rg/providers/Microsoft.Compute/proximityPlacementGroups/svlqa_sjain_multivolume_ppg"),
VolumeSpecName = "log",
},new NetAppVolumeGroupVolume("test-shared",107374182400,new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRP/providers/Microsoft.Network/virtualNetworks/testvnet3/subnets/testsubnet3"))
{
Name = "test-shared",
ServiceLevel = NetAppFileServiceLevel.Premium,
ThroughputMibps = 10,
CapacityPoolResourceId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRG/providers/Microsoft.NetApp/netAppAccounts/account1/capacityPools/pool1"),
ProximityPlacementGroupId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/cys_sjain_fcp_rg/providers/Microsoft.Compute/proximityPlacementGroups/svlqa_sjain_multivolume_ppg"),
VolumeSpecName = "shared",
}
},
            };
            ArmOperation<NetAppVolumeGroupResource> lro = await netAppVolumeGroup.UpdateAsync(WaitUntil.Completed, data);
            NetAppVolumeGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppVolumeGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VolumeGroups_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_VolumeGroupsDelete()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2022-11-01/examples/VolumeGroups_Delete.json
            // this example is just showing the usage of "VolumeGroups_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeGroupResource created on azure
            // for more information of creating NetAppVolumeGroupResource, please refer to the document of NetAppVolumeGroupResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string volumeGroupName = "group1";
            ResourceIdentifier netAppVolumeGroupResourceId = NetAppVolumeGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, volumeGroupName);
            NetAppVolumeGroupResource netAppVolumeGroup = client.GetNetAppVolumeGroupResource(netAppVolumeGroupResourceId);

            // invoke the operation
            await netAppVolumeGroup.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
