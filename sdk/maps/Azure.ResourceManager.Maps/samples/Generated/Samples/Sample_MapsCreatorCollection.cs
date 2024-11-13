// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Maps.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Maps.Samples
{
    public partial class Sample_MapsCreatorCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateCreatorResource()
        {
            // Generated from example definition: specification/maps/resource-manager/Microsoft.Maps/preview/2021-12-01-preview/examples/CreateMapsCreator.json
            // this example is just showing the usage of "Creators_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MapsAccountResource created on azure
            // for more information of creating MapsAccountResource, please refer to the document of MapsAccountResource
            string subscriptionId = "21a9967a-e8a9-4656-a70b-96ff1c4d05a0";
            string resourceGroupName = "myResourceGroup";
            string accountName = "myMapsAccount";
            ResourceIdentifier mapsAccountResourceId = MapsAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MapsAccountResource mapsAccount = client.GetMapsAccountResource(mapsAccountResourceId);

            // get the collection of this MapsCreatorResource
            MapsCreatorCollection collection = mapsAccount.GetMapsCreators();

            // invoke the operation
            string creatorName = "myCreator";
            MapsCreatorData data = new MapsCreatorData(new AzureLocation("eastus2"), new MapsCreatorProperties(5))
            {
                Tags =
{
["test"] = "true"
},
            };
            ArmOperation<MapsCreatorResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, creatorName, data);
            MapsCreatorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MapsCreatorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetCreatorResource()
        {
            // Generated from example definition: specification/maps/resource-manager/Microsoft.Maps/preview/2021-12-01-preview/examples/GetMapsCreator.json
            // this example is just showing the usage of "Creators_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MapsAccountResource created on azure
            // for more information of creating MapsAccountResource, please refer to the document of MapsAccountResource
            string subscriptionId = "21a9967a-e8a9-4656-a70b-96ff1c4d05a0";
            string resourceGroupName = "myResourceGroup";
            string accountName = "myMapsAccount";
            ResourceIdentifier mapsAccountResourceId = MapsAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MapsAccountResource mapsAccount = client.GetMapsAccountResource(mapsAccountResourceId);

            // get the collection of this MapsCreatorResource
            MapsCreatorCollection collection = mapsAccount.GetMapsCreators();

            // invoke the operation
            string creatorName = "myCreator";
            MapsCreatorResource result = await collection.GetAsync(creatorName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MapsCreatorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListCreatorResourcesByAccount()
        {
            // Generated from example definition: specification/maps/resource-manager/Microsoft.Maps/preview/2021-12-01-preview/examples/ListMapsCreatorsByAccount.json
            // this example is just showing the usage of "Creators_ListByAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MapsAccountResource created on azure
            // for more information of creating MapsAccountResource, please refer to the document of MapsAccountResource
            string subscriptionId = "21a9967a-e8a9-4656-a70b-96ff1c4d05a0";
            string resourceGroupName = "myResourceGroup";
            string accountName = "myMapsAccount";
            ResourceIdentifier mapsAccountResourceId = MapsAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MapsAccountResource mapsAccount = client.GetMapsAccountResource(mapsAccountResourceId);

            // get the collection of this MapsCreatorResource
            MapsCreatorCollection collection = mapsAccount.GetMapsCreators();

            // invoke the operation and iterate over the result
            await foreach (MapsCreatorResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MapsCreatorData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetCreatorResource()
        {
            // Generated from example definition: specification/maps/resource-manager/Microsoft.Maps/preview/2021-12-01-preview/examples/GetMapsCreator.json
            // this example is just showing the usage of "Creators_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MapsAccountResource created on azure
            // for more information of creating MapsAccountResource, please refer to the document of MapsAccountResource
            string subscriptionId = "21a9967a-e8a9-4656-a70b-96ff1c4d05a0";
            string resourceGroupName = "myResourceGroup";
            string accountName = "myMapsAccount";
            ResourceIdentifier mapsAccountResourceId = MapsAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MapsAccountResource mapsAccount = client.GetMapsAccountResource(mapsAccountResourceId);

            // get the collection of this MapsCreatorResource
            MapsCreatorCollection collection = mapsAccount.GetMapsCreators();

            // invoke the operation
            string creatorName = "myCreator";
            bool result = await collection.ExistsAsync(creatorName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetCreatorResource()
        {
            // Generated from example definition: specification/maps/resource-manager/Microsoft.Maps/preview/2021-12-01-preview/examples/GetMapsCreator.json
            // this example is just showing the usage of "Creators_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MapsAccountResource created on azure
            // for more information of creating MapsAccountResource, please refer to the document of MapsAccountResource
            string subscriptionId = "21a9967a-e8a9-4656-a70b-96ff1c4d05a0";
            string resourceGroupName = "myResourceGroup";
            string accountName = "myMapsAccount";
            ResourceIdentifier mapsAccountResourceId = MapsAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MapsAccountResource mapsAccount = client.GetMapsAccountResource(mapsAccountResourceId);

            // get the collection of this MapsCreatorResource
            MapsCreatorCollection collection = mapsAccount.GetMapsCreators();

            // invoke the operation
            string creatorName = "myCreator";
            NullableResponse<MapsCreatorResource> response = await collection.GetIfExistsAsync(creatorName);
            MapsCreatorResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MapsCreatorData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
