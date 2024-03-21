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
    public partial class Sample_PartnerRegistrationResource
    {
        // PartnerRegistrations_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PartnerRegistrationsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/PartnerRegistrations_Get.json
            // this example is just showing the usage of "PartnerRegistrations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerRegistrationResource created on azure
            // for more information of creating PartnerRegistrationResource, please refer to the document of PartnerRegistrationResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerRegistrationName = "examplePartnerRegistrationName1";
            ResourceIdentifier partnerRegistrationResourceId = PartnerRegistrationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerRegistrationName);
            PartnerRegistrationResource partnerRegistration = client.GetPartnerRegistrationResource(partnerRegistrationResourceId);

            // invoke the operation
            PartnerRegistrationResource result = await partnerRegistration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PartnerRegistrationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PartnerRegistrations_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_PartnerRegistrationsDelete()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/PartnerRegistrations_Delete.json
            // this example is just showing the usage of "PartnerRegistrations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerRegistrationResource created on azure
            // for more information of creating PartnerRegistrationResource, please refer to the document of PartnerRegistrationResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerRegistrationName = "examplePartnerRegistrationName1";
            ResourceIdentifier partnerRegistrationResourceId = PartnerRegistrationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerRegistrationName);
            PartnerRegistrationResource partnerRegistration = client.GetPartnerRegistrationResource(partnerRegistrationResourceId);

            // invoke the operation
            await partnerRegistration.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // PartnerRegistrations_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PartnerRegistrationsUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/PartnerRegistrations_Update.json
            // this example is just showing the usage of "PartnerRegistrations_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerRegistrationResource created on azure
            // for more information of creating PartnerRegistrationResource, please refer to the document of PartnerRegistrationResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerRegistrationName = "examplePartnerRegistrationName1";
            ResourceIdentifier partnerRegistrationResourceId = PartnerRegistrationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerRegistrationName);
            PartnerRegistrationResource partnerRegistration = client.GetPartnerRegistrationResource(partnerRegistrationResourceId);

            // invoke the operation
            PartnerRegistrationPatch patch = new PartnerRegistrationPatch()
            {
                Tags =
{
["NewKey"] = "NewValue",
},
            };
            await partnerRegistration.UpdateAsync(WaitUntil.Completed, patch);

            Console.WriteLine($"Succeeded");
        }

        // PartnerRegistrations_ListBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetPartnerRegistrations_PartnerRegistrationsListBySubscription()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/PartnerRegistrations_ListBySubscription.json
            // this example is just showing the usage of "PartnerRegistrations_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

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
            await foreach (PartnerRegistrationResource item in subscriptionResource.GetPartnerRegistrationsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PartnerRegistrationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
