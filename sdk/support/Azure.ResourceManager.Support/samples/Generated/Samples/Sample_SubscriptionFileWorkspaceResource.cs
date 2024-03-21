// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Support.Samples
{
    public partial class Sample_SubscriptionFileWorkspaceResource
    {
        // Get details of a subscription file workspace
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDetailsOfASubscriptionFileWorkspace()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/preview/2023-06-01-preview/examples/GetFileWorkspaceDetailsForSubscription.json
            // this example is just showing the usage of "FileWorkspaces_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionFileWorkspaceResource created on azure
            // for more information of creating SubscriptionFileWorkspaceResource, please refer to the document of SubscriptionFileWorkspaceResource
            string subscriptionId = "subid";
            string fileWorkspaceName = "testworkspace";
            ResourceIdentifier subscriptionFileWorkspaceResourceId = SubscriptionFileWorkspaceResource.CreateResourceIdentifier(subscriptionId, fileWorkspaceName);
            SubscriptionFileWorkspaceResource subscriptionFileWorkspace = client.GetSubscriptionFileWorkspaceResource(subscriptionFileWorkspaceResourceId);

            // invoke the operation
            SubscriptionFileWorkspaceResource result = await subscriptionFileWorkspace.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FileWorkspaceDetailData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a subscription scoped file workspace
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateASubscriptionScopedFileWorkspace()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/preview/2023-06-01-preview/examples/CreateFileWorkspaceForSubscription.json
            // this example is just showing the usage of "FileWorkspaces_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionFileWorkspaceResource created on azure
            // for more information of creating SubscriptionFileWorkspaceResource, please refer to the document of SubscriptionFileWorkspaceResource
            string subscriptionId = "subid";
            string fileWorkspaceName = "testworkspace";
            ResourceIdentifier subscriptionFileWorkspaceResourceId = SubscriptionFileWorkspaceResource.CreateResourceIdentifier(subscriptionId, fileWorkspaceName);
            SubscriptionFileWorkspaceResource subscriptionFileWorkspace = client.GetSubscriptionFileWorkspaceResource(subscriptionFileWorkspaceResourceId);

            // invoke the operation
            ArmOperation<SubscriptionFileWorkspaceResource> lro = await subscriptionFileWorkspace.UpdateAsync(WaitUntil.Completed);
            SubscriptionFileWorkspaceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FileWorkspaceDetailData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
