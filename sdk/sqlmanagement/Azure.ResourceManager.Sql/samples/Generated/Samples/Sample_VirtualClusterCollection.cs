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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_VirtualClusterCollection
    {
        // List virtual clusters by resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListVirtualClustersByResourceGroup()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-05-01-preview/examples/VirtualClusterListByResourceGroup.json
            // this example is just showing the usage of "VirtualClusters_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "20d7082a-0fc7-4468-82bd-542694d5042b";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VirtualClusterResource
            VirtualClusterCollection collection = resourceGroupResource.GetVirtualClusters();

            // invoke the operation and iterate over the result
            await foreach (VirtualClusterResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualClusterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Gets a virtual cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsAVirtualCluster()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-05-01-preview/examples/VirtualClusterGet.json
            // this example is just showing the usage of "VirtualClusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "20d7082a-0fc7-4468-82bd-542694d5042b";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VirtualClusterResource
            VirtualClusterCollection collection = resourceGroupResource.GetVirtualClusters();

            // invoke the operation
            string virtualClusterName = "vc-f769ed71-b3ad-491a-a9d5-26eeceaa6be2";
            VirtualClusterResource result = await collection.GetAsync(virtualClusterName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets a virtual cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetsAVirtualCluster()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-05-01-preview/examples/VirtualClusterGet.json
            // this example is just showing the usage of "VirtualClusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "20d7082a-0fc7-4468-82bd-542694d5042b";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VirtualClusterResource
            VirtualClusterCollection collection = resourceGroupResource.GetVirtualClusters();

            // invoke the operation
            string virtualClusterName = "vc-f769ed71-b3ad-491a-a9d5-26eeceaa6be2";
            bool result = await collection.ExistsAsync(virtualClusterName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Gets a virtual cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetsAVirtualCluster()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-05-01-preview/examples/VirtualClusterGet.json
            // this example is just showing the usage of "VirtualClusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "20d7082a-0fc7-4468-82bd-542694d5042b";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VirtualClusterResource
            VirtualClusterCollection collection = resourceGroupResource.GetVirtualClusters();

            // invoke the operation
            string virtualClusterName = "vc-f769ed71-b3ad-491a-a9d5-26eeceaa6be2";
            NullableResponse<VirtualClusterResource> response = await collection.GetIfExistsAsync(virtualClusterName);
            VirtualClusterResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualClusterData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
