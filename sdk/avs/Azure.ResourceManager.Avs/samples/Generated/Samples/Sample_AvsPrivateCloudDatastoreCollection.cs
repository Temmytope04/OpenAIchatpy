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
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Samples
{
    public partial class Sample_AvsPrivateCloudDatastoreCollection
    {
        // Datastores_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_DatastoresList()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2022-05-01/examples/Datastores_List.json
            // this example is just showing the usage of "Datastores_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudClusterResource created on azure
            // for more information of creating AvsPrivateCloudClusterResource, please refer to the document of AvsPrivateCloudClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string clusterName = "cluster1";
            ResourceIdentifier avsPrivateCloudClusterResourceId = AvsPrivateCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, clusterName);
            AvsPrivateCloudClusterResource avsPrivateCloudCluster = client.GetAvsPrivateCloudClusterResource(avsPrivateCloudClusterResourceId);

            // get the collection of this AvsPrivateCloudDatastoreResource
            AvsPrivateCloudDatastoreCollection collection = avsPrivateCloudCluster.GetAvsPrivateCloudDatastores();

            // invoke the operation and iterate over the result
            await foreach (AvsPrivateCloudDatastoreResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AvsPrivateCloudDatastoreData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Datastores_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DatastoresGet()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2022-05-01/examples/Datastores_Get.json
            // this example is just showing the usage of "Datastores_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudClusterResource created on azure
            // for more information of creating AvsPrivateCloudClusterResource, please refer to the document of AvsPrivateCloudClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string clusterName = "cluster1";
            ResourceIdentifier avsPrivateCloudClusterResourceId = AvsPrivateCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, clusterName);
            AvsPrivateCloudClusterResource avsPrivateCloudCluster = client.GetAvsPrivateCloudClusterResource(avsPrivateCloudClusterResourceId);

            // get the collection of this AvsPrivateCloudDatastoreResource
            AvsPrivateCloudDatastoreCollection collection = avsPrivateCloudCluster.GetAvsPrivateCloudDatastores();

            // invoke the operation
            string datastoreName = "datastore1";
            AvsPrivateCloudDatastoreResource result = await collection.GetAsync(datastoreName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AvsPrivateCloudDatastoreData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Datastores_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_DatastoresGet()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2022-05-01/examples/Datastores_Get.json
            // this example is just showing the usage of "Datastores_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudClusterResource created on azure
            // for more information of creating AvsPrivateCloudClusterResource, please refer to the document of AvsPrivateCloudClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string clusterName = "cluster1";
            ResourceIdentifier avsPrivateCloudClusterResourceId = AvsPrivateCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, clusterName);
            AvsPrivateCloudClusterResource avsPrivateCloudCluster = client.GetAvsPrivateCloudClusterResource(avsPrivateCloudClusterResourceId);

            // get the collection of this AvsPrivateCloudDatastoreResource
            AvsPrivateCloudDatastoreCollection collection = avsPrivateCloudCluster.GetAvsPrivateCloudDatastores();

            // invoke the operation
            string datastoreName = "datastore1";
            bool result = await collection.ExistsAsync(datastoreName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Datastores_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_DatastoresCreateOrUpdate()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2022-05-01/examples/Datastores_CreateOrUpdate.json
            // this example is just showing the usage of "Datastores_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudClusterResource created on azure
            // for more information of creating AvsPrivateCloudClusterResource, please refer to the document of AvsPrivateCloudClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string clusterName = "cluster1";
            ResourceIdentifier avsPrivateCloudClusterResourceId = AvsPrivateCloudClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, clusterName);
            AvsPrivateCloudClusterResource avsPrivateCloudCluster = client.GetAvsPrivateCloudClusterResource(avsPrivateCloudClusterResourceId);

            // get the collection of this AvsPrivateCloudDatastoreResource
            AvsPrivateCloudDatastoreCollection collection = avsPrivateCloudCluster.GetAvsPrivateCloudDatastores();

            // invoke the operation
            string datastoreName = "datastore1";
            AvsPrivateCloudDatastoreData data = new AvsPrivateCloudDatastoreData()
            {
                NetAppVolumeId = new ResourceIdentifier("/subscriptions/11111111-1111-1111-1111-111111111111/resourceGroups/ResourceGroup1/providers/Microsoft.NetApp/netAppAccounts/NetAppAccount1/capacityPools/CapacityPool1/volumes/NFSVol1"),
            };
            ArmOperation<AvsPrivateCloudDatastoreResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, datastoreName, data);
            AvsPrivateCloudDatastoreResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AvsPrivateCloudDatastoreData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
