// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_CloudServiceOSFamilyCollection
    {
        // Get Cloud Service OS Family
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetCloudServiceOSFamily()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/CloudserviceRP/stable/2022-04-04/examples/CloudServiceOSFamily_Get.json
            // this example is just showing the usage of "CloudServiceOperatingSystems_GetOSFamily" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "{subscription-id}";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this CloudServiceOSFamilyResource
            AzureLocation location = new AzureLocation("westus2");
            CloudServiceOSFamilyCollection collection = subscriptionResource.GetCloudServiceOSFamilies(location);

            // invoke the operation
            string osFamilyName = "3";
            CloudServiceOSFamilyResource result = await collection.GetAsync(osFamilyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CloudServiceOSFamilyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Cloud Service OS Family
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetCloudServiceOSFamily()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/CloudserviceRP/stable/2022-04-04/examples/CloudServiceOSFamily_Get.json
            // this example is just showing the usage of "CloudServiceOperatingSystems_GetOSFamily" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "{subscription-id}";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this CloudServiceOSFamilyResource
            AzureLocation location = new AzureLocation("westus2");
            CloudServiceOSFamilyCollection collection = subscriptionResource.GetCloudServiceOSFamilies(location);

            // invoke the operation
            string osFamilyName = "3";
            bool result = await collection.ExistsAsync(osFamilyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // List Cloud Service OS Families in a subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListCloudServiceOSFamiliesInASubscription()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/CloudserviceRP/stable/2022-04-04/examples/CloudServiceOSFamilies_List.json
            // this example is just showing the usage of "CloudServiceOperatingSystems_ListOSFamilies" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "{subscription-id}";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this CloudServiceOSFamilyResource
            AzureLocation location = new AzureLocation("westus2");
            CloudServiceOSFamilyCollection collection = subscriptionResource.GetCloudServiceOSFamilies(location);

            // invoke the operation and iterate over the result
            await foreach (CloudServiceOSFamilyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CloudServiceOSFamilyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
