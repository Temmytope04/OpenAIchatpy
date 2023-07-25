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
using Azure.ResourceManager.DataShare;

namespace Azure.ResourceManager.DataShare.Samples
{
    public partial class Sample_DataShareInvitationResource
    {
        // Invitations_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_InvitationsGet()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/Invitations_Get.json
            // this example is just showing the usage of "Invitations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareInvitationResource created on azure
            // for more information of creating DataShareInvitationResource, please refer to the document of DataShareInvitationResource
            string subscriptionId = "433a8dfd-e5d5-4e77-ad86-90acdc75eb1a";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            string invitationName = "Invitation1";
            ResourceIdentifier dataShareInvitationResourceId = DataShareInvitationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName, invitationName);
            DataShareInvitationResource dataShareInvitation = client.GetDataShareInvitationResource(dataShareInvitationResourceId);

            // invoke the operation
            DataShareInvitationResource result = await dataShareInvitation.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataShareInvitationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Invitations_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_InvitationsCreate()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/Invitations_Create.json
            // this example is just showing the usage of "Invitations_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareInvitationResource created on azure
            // for more information of creating DataShareInvitationResource, please refer to the document of DataShareInvitationResource
            string subscriptionId = "433a8dfd-e5d5-4e77-ad86-90acdc75eb1a";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            string invitationName = "Invitation1";
            ResourceIdentifier dataShareInvitationResourceId = DataShareInvitationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName, invitationName);
            DataShareInvitationResource dataShareInvitation = client.GetDataShareInvitationResource(dataShareInvitationResourceId);

            // invoke the operation
            DataShareInvitationData data = new DataShareInvitationData()
            {
                ExpireOn = DateTimeOffset.Parse("2020-08-26T22:33:24.5785265Z"),
                TargetEmail = "receiver@microsoft.com",
            };
            ArmOperation<DataShareInvitationResource> lro = await dataShareInvitation.UpdateAsync(WaitUntil.Completed, data);
            DataShareInvitationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataShareInvitationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Invitations_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_InvitationsDelete()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/Invitations_Delete.json
            // this example is just showing the usage of "Invitations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareInvitationResource created on azure
            // for more information of creating DataShareInvitationResource, please refer to the document of DataShareInvitationResource
            string subscriptionId = "433a8dfd-e5d5-4e77-ad86-90acdc75eb1a";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            string invitationName = "Invitation1";
            ResourceIdentifier dataShareInvitationResourceId = DataShareInvitationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName, invitationName);
            DataShareInvitationResource dataShareInvitation = client.GetDataShareInvitationResource(dataShareInvitationResourceId);

            // invoke the operation
            await dataShareInvitation.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
