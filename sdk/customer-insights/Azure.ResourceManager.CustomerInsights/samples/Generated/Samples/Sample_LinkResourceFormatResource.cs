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
using Azure.ResourceManager.CustomerInsights;
using Azure.ResourceManager.CustomerInsights.Models;

namespace Azure.ResourceManager.CustomerInsights.Samples
{
    public partial class Sample_LinkResourceFormatResource
    {
        // Links_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_LinksCreateOrUpdate()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/LinksCreateOrUpdate.json
            // this example is just showing the usage of "Links_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LinkResourceFormatResource created on azure
            // for more information of creating LinkResourceFormatResource, please refer to the document of LinkResourceFormatResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            string linkName = "linkTest4806";
            ResourceIdentifier linkResourceFormatResourceId = LinkResourceFormatResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName, linkName);
            LinkResourceFormatResource linkResourceFormat = client.GetLinkResourceFormatResource(linkResourceFormatResourceId);

            // invoke the operation
            LinkResourceFormatData data = new LinkResourceFormatData()
            {
                SourceEntityType = EntityType.Interaction,
                TargetEntityType = EntityType.Profile,
                SourceEntityTypeName = "testInteraction1949",
                TargetEntityTypeName = "testProfile1446",
                DisplayName =
{
["en-us"] = "Link DisplayName",
},
                Description =
{
["en-us"] = "Link Description",
},
                Mappings =
{
new TypePropertiesMapping("testInteraction1949","testProfile1446")
{
LinkType = LinkType.UpdateAlways,
}
},
                ParticipantPropertyReferences =
{
new ParticipantPropertyReference("testInteraction1949","ProfileId")
},
            };
            ArmOperation<LinkResourceFormatResource> lro = await linkResourceFormat.UpdateAsync(WaitUntil.Completed, data);
            LinkResourceFormatResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LinkResourceFormatData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Links_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_LinksGet()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/LinksGet.json
            // this example is just showing the usage of "Links_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LinkResourceFormatResource created on azure
            // for more information of creating LinkResourceFormatResource, please refer to the document of LinkResourceFormatResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            string linkName = "linkTest4806";
            ResourceIdentifier linkResourceFormatResourceId = LinkResourceFormatResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName, linkName);
            LinkResourceFormatResource linkResourceFormat = client.GetLinkResourceFormatResource(linkResourceFormatResourceId);

            // invoke the operation
            LinkResourceFormatResource result = await linkResourceFormat.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LinkResourceFormatData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Links_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_LinksDelete()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/LinksDelete.json
            // this example is just showing the usage of "Links_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LinkResourceFormatResource created on azure
            // for more information of creating LinkResourceFormatResource, please refer to the document of LinkResourceFormatResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            string linkName = "linkTest4806";
            ResourceIdentifier linkResourceFormatResourceId = LinkResourceFormatResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName, linkName);
            LinkResourceFormatResource linkResourceFormat = client.GetLinkResourceFormatResource(linkResourceFormatResourceId);

            // invoke the operation
            await linkResourceFormat.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
