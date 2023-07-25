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
using Azure.ResourceManager.Support;

namespace Azure.ResourceManager.Support.Samples
{
    public partial class Sample_SupportTicketCommunicationCollection
    {
        // List communications for a subscription support ticket
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListCommunicationsForASubscriptionSupportTicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2020-04-01/examples/ListCommunicationsForSubscriptionSupportTicket.json
            // this example is just showing the usage of "Communications_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SupportTicketResource created on azure
            // for more information of creating SupportTicketResource, please refer to the document of SupportTicketResource
            string subscriptionId = "subid";
            string supportTicketName = "testticket";
            ResourceIdentifier supportTicketResourceId = SupportTicketResource.CreateResourceIdentifier(subscriptionId, supportTicketName);
            SupportTicketResource supportTicket = client.GetSupportTicketResource(supportTicketResourceId);

            // get the collection of this SupportTicketCommunicationResource
            SupportTicketCommunicationCollection collection = supportTicket.GetSupportTicketCommunications();

            // invoke the operation and iterate over the result
            await foreach (SupportTicketCommunicationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SupportTicketCommunicationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List web communication created on or after a specific date for a subscription support ticket
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListWebCommunicationCreatedOnOrAfterASpecificDateForASubscriptionSupportTicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2020-04-01/examples/ListWebCommunicationsForSubscriptionSupportTicketCreatedOnOrAfter.json
            // this example is just showing the usage of "Communications_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SupportTicketResource created on azure
            // for more information of creating SupportTicketResource, please refer to the document of SupportTicketResource
            string subscriptionId = "subid";
            string supportTicketName = "testticket";
            ResourceIdentifier supportTicketResourceId = SupportTicketResource.CreateResourceIdentifier(subscriptionId, supportTicketName);
            SupportTicketResource supportTicket = client.GetSupportTicketResource(supportTicketResourceId);

            // get the collection of this SupportTicketCommunicationResource
            SupportTicketCommunicationCollection collection = supportTicket.GetSupportTicketCommunications();

            // invoke the operation and iterate over the result
            string filter = "communicationType eq 'web' and createdDate ge 2020-03-10T22:08:51Z";
            await foreach (SupportTicketCommunicationResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SupportTicketCommunicationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List web communications for a subscription support ticket
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListWebCommunicationsForASubscriptionSupportTicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2020-04-01/examples/ListWebCommunicationsForSubscriptionSupportTicket.json
            // this example is just showing the usage of "Communications_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SupportTicketResource created on azure
            // for more information of creating SupportTicketResource, please refer to the document of SupportTicketResource
            string subscriptionId = "subid";
            string supportTicketName = "testticket";
            ResourceIdentifier supportTicketResourceId = SupportTicketResource.CreateResourceIdentifier(subscriptionId, supportTicketName);
            SupportTicketResource supportTicket = client.GetSupportTicketResource(supportTicketResourceId);

            // get the collection of this SupportTicketCommunicationResource
            SupportTicketCommunicationCollection collection = supportTicket.GetSupportTicketCommunications();

            // invoke the operation and iterate over the result
            string filter = "communicationType eq 'web'";
            await foreach (SupportTicketCommunicationResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SupportTicketCommunicationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get communication details for a subscription support ticket
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetCommunicationDetailsForASubscriptionSupportTicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2020-04-01/examples/GetCommunicationDetailsForSubscriptionSupportTicket.json
            // this example is just showing the usage of "Communications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SupportTicketResource created on azure
            // for more information of creating SupportTicketResource, please refer to the document of SupportTicketResource
            string subscriptionId = "subid";
            string supportTicketName = "testticket";
            ResourceIdentifier supportTicketResourceId = SupportTicketResource.CreateResourceIdentifier(subscriptionId, supportTicketName);
            SupportTicketResource supportTicket = client.GetSupportTicketResource(supportTicketResourceId);

            // get the collection of this SupportTicketCommunicationResource
            SupportTicketCommunicationCollection collection = supportTicket.GetSupportTicketCommunications();

            // invoke the operation
            string communicationName = "testmessage";
            SupportTicketCommunicationResource result = await collection.GetAsync(communicationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SupportTicketCommunicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get communication details for a subscription support ticket
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetCommunicationDetailsForASubscriptionSupportTicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2020-04-01/examples/GetCommunicationDetailsForSubscriptionSupportTicket.json
            // this example is just showing the usage of "Communications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SupportTicketResource created on azure
            // for more information of creating SupportTicketResource, please refer to the document of SupportTicketResource
            string subscriptionId = "subid";
            string supportTicketName = "testticket";
            ResourceIdentifier supportTicketResourceId = SupportTicketResource.CreateResourceIdentifier(subscriptionId, supportTicketName);
            SupportTicketResource supportTicket = client.GetSupportTicketResource(supportTicketResourceId);

            // get the collection of this SupportTicketCommunicationResource
            SupportTicketCommunicationCollection collection = supportTicket.GetSupportTicketCommunications();

            // invoke the operation
            string communicationName = "testmessage";
            bool result = await collection.ExistsAsync(communicationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // AddCommunicationToSubscriptionTicket
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_AddCommunicationToSubscriptionTicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2020-04-01/examples/CreateSupportTicketCommunication.json
            // this example is just showing the usage of "Communications_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SupportTicketResource created on azure
            // for more information of creating SupportTicketResource, please refer to the document of SupportTicketResource
            string subscriptionId = "subid";
            string supportTicketName = "testticket";
            ResourceIdentifier supportTicketResourceId = SupportTicketResource.CreateResourceIdentifier(subscriptionId, supportTicketName);
            SupportTicketResource supportTicket = client.GetSupportTicketResource(supportTicketResourceId);

            // get the collection of this SupportTicketCommunicationResource
            SupportTicketCommunicationCollection collection = supportTicket.GetSupportTicketCommunications();

            // invoke the operation
            string communicationName = "testcommunication";
            SupportTicketCommunicationData data = new SupportTicketCommunicationData()
            {
                Sender = "user@contoso.com",
                Subject = "This is a test message from a customer!",
                Body = "This is a test message from a customer!",
            };
            ArmOperation<SupportTicketCommunicationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, communicationName, data);
            SupportTicketCommunicationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SupportTicketCommunicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
