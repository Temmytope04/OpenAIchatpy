// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EventGrid.Samples
{
    public partial class Sample_PartnerDestinationResource
    {
        // PartnerDestinations_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PartnerDestinationsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/PartnerDestinations_Get.json
            // this example is just showing the usage of "PartnerDestinations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerDestinationResource created on azure
            // for more information of creating PartnerDestinationResource, please refer to the document of PartnerDestinationResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerDestinationName = "examplePartnerDestinationName1";
            ResourceIdentifier partnerDestinationResourceId = PartnerDestinationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerDestinationName);
            PartnerDestinationResource partnerDestination = client.GetPartnerDestinationResource(partnerDestinationResourceId);

            // invoke the operation
            PartnerDestinationResource result = await partnerDestination.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PartnerDestinationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PartnerDestinations_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_PartnerDestinationsDelete()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/PartnerDestinations_Delete.json
            // this example is just showing the usage of "PartnerDestinations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerDestinationResource created on azure
            // for more information of creating PartnerDestinationResource, please refer to the document of PartnerDestinationResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerDestinationName = "examplePartnerDestinationName1";
            ResourceIdentifier partnerDestinationResourceId = PartnerDestinationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerDestinationName);
            PartnerDestinationResource partnerDestination = client.GetPartnerDestinationResource(partnerDestinationResourceId);

            // invoke the operation
            await partnerDestination.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // PartnerDestinations_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PartnerDestinationsUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/PartnerDestinations_Update.json
            // this example is just showing the usage of "PartnerDestinations_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerDestinationResource created on azure
            // for more information of creating PartnerDestinationResource, please refer to the document of PartnerDestinationResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerDestinationName = "examplePartnerDestinationName1";
            ResourceIdentifier partnerDestinationResourceId = PartnerDestinationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerDestinationName);
            PartnerDestinationResource partnerDestination = client.GetPartnerDestinationResource(partnerDestinationResourceId);

            // invoke the operation
            PartnerDestinationPatch patch = new PartnerDestinationPatch()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            ArmOperation<PartnerDestinationResource> lro = await partnerDestination.UpdateAsync(WaitUntil.Completed, patch);
            PartnerDestinationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PartnerDestinationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PartnerDestinations_ListBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetPartnerDestinations_PartnerDestinationsListBySubscription()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/PartnerDestinations_ListBySubscription.json
            // this example is just showing the usage of "PartnerDestinations_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (PartnerDestinationResource item in subscriptionResource.GetPartnerDestinationsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PartnerDestinationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // PartnerDestinations_Activate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Activate_PartnerDestinationsActivate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/PartnerDestinations_Activate.json
            // this example is just showing the usage of "PartnerDestinations_Activate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerDestinationResource created on azure
            // for more information of creating PartnerDestinationResource, please refer to the document of PartnerDestinationResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerDestinationName = "examplePartnerDestination1";
            ResourceIdentifier partnerDestinationResourceId = PartnerDestinationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerDestinationName);
            PartnerDestinationResource partnerDestination = client.GetPartnerDestinationResource(partnerDestinationResourceId);

            // invoke the operation
            PartnerDestinationResource result = await partnerDestination.ActivateAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PartnerDestinationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
