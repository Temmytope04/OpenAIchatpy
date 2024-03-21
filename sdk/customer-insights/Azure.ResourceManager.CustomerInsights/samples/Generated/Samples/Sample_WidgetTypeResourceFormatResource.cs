// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.CustomerInsights.Samples
{
    public partial class Sample_WidgetTypeResourceFormatResource
    {
        // WidgetTypes_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_WidgetTypesGet()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/WidgetTypesGet.json
            // this example is just showing the usage of "WidgetTypes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WidgetTypeResourceFormatResource created on azure
            // for more information of creating WidgetTypeResourceFormatResource, please refer to the document of WidgetTypeResourceFormatResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            string widgetTypeName = "ActivityGauge";
            ResourceIdentifier widgetTypeResourceFormatResourceId = WidgetTypeResourceFormatResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName, widgetTypeName);
            WidgetTypeResourceFormatResource widgetTypeResourceFormat = client.GetWidgetTypeResourceFormatResource(widgetTypeResourceFormatResourceId);

            // invoke the operation
            WidgetTypeResourceFormatResource result = await widgetTypeResourceFormat.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WidgetTypeResourceFormatData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
