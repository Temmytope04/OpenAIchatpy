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
using Azure.ResourceManager.Orbital;

namespace Azure.ResourceManager.Orbital.Samples
{
    public partial class Sample_OrbitalContactResource
    {
        // Get Contact
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetContact()
        {
            // Generated from example definition: specification/orbital/resource-manager/Microsoft.Orbital/stable/2022-03-01/examples/ContactGet.json
            // this example is just showing the usage of "Contacts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OrbitalContactResource created on azure
            // for more information of creating OrbitalContactResource, please refer to the document of OrbitalContactResource
            string subscriptionId = "c1be1141-a7c9-4aac-9608-3c2e2f1152c3";
            string resourceGroupName = "contoso-Rgp";
            string spacecraftName = "CONTOSO_SAT";
            string contactName = "contact1";
            ResourceIdentifier orbitalContactResourceId = OrbitalContactResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, spacecraftName, contactName);
            OrbitalContactResource orbitalContact = client.GetOrbitalContactResource(orbitalContactResourceId);

            // invoke the operation
            OrbitalContactResource result = await orbitalContact.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OrbitalContactData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a contact
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateAContact()
        {
            // Generated from example definition: specification/orbital/resource-manager/Microsoft.Orbital/stable/2022-03-01/examples/ContactCreate.json
            // this example is just showing the usage of "Contacts_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OrbitalContactResource created on azure
            // for more information of creating OrbitalContactResource, please refer to the document of OrbitalContactResource
            string subscriptionId = "c1be1141-a7c9-4aac-9608-3c2e2f1152c3";
            string resourceGroupName = "contoso-Rgp";
            string spacecraftName = "CONTOSO_SAT";
            string contactName = "contact1";
            ResourceIdentifier orbitalContactResourceId = OrbitalContactResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, spacecraftName, contactName);
            OrbitalContactResource orbitalContact = client.GetOrbitalContactResource(orbitalContactResourceId);

            // invoke the operation
            OrbitalContactData data = new OrbitalContactData()
            {
                ReservationStartOn = DateTimeOffset.Parse("2022-03-02T10:58:30Z"),
                ReservationEndOn = DateTimeOffset.Parse("2022-03-02T11:10:45Z"),
                GroundStationName = "EASTUS2_0",
                ContactProfileId = new ResourceIdentifier("/subscriptions/c1be1141-a7c9-4aac-9608-3c2e2f1152c3/resourceGroups/contoso-Rgp/providers/Microsoft.Orbital/contactProfiles/CONTOSO-CP"),
            };
            ArmOperation<OrbitalContactResource> lro = await orbitalContact.UpdateAsync(WaitUntil.Completed, data);
            OrbitalContactResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OrbitalContactData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete Contact
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteContact()
        {
            // Generated from example definition: specification/orbital/resource-manager/Microsoft.Orbital/stable/2022-03-01/examples/ContactDelete.json
            // this example is just showing the usage of "Contacts_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OrbitalContactResource created on azure
            // for more information of creating OrbitalContactResource, please refer to the document of OrbitalContactResource
            string subscriptionId = "c1be1141-a7c9-4aac-9608-3c2e2f1152c3";
            string resourceGroupName = "contoso-Rgp";
            string spacecraftName = "CONTOSO_SAT";
            string contactName = "contact1";
            ResourceIdentifier orbitalContactResourceId = OrbitalContactResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, spacecraftName, contactName);
            OrbitalContactResource orbitalContact = client.GetOrbitalContactResource(orbitalContactResourceId);

            // invoke the operation
            await orbitalContact.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
