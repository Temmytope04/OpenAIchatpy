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
    public partial class Sample_WidgetTypeResourceFormatCollection
    {
        // WidgetTypes_ListByHub
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_WidgetTypesListByHub()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/WidgetTypesListByHub.json
            // this example is just showing the usage of "WidgetTypes_ListByHub" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this WidgetTypeResourceFormatResource
            WidgetTypeResourceFormatCollection collection = hub.GetWidgetTypeResourceFormats();

            // invoke the operation and iterate over the result
            await foreach (WidgetTypeResourceFormatResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WidgetTypeResourceFormatData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

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

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this WidgetTypeResourceFormatResource
            WidgetTypeResourceFormatCollection collection = hub.GetWidgetTypeResourceFormats();

            // invoke the operation
            string widgetTypeName = "ActivityGauge";
            WidgetTypeResourceFormatResource result = await collection.GetAsync(widgetTypeName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WidgetTypeResourceFormatData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WidgetTypes_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_WidgetTypesGet()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/WidgetTypesGet.json
            // this example is just showing the usage of "WidgetTypes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this WidgetTypeResourceFormatResource
            WidgetTypeResourceFormatCollection collection = hub.GetWidgetTypeResourceFormats();

            // invoke the operation
            string widgetTypeName = "ActivityGauge";
            bool result = await collection.ExistsAsync(widgetTypeName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // WidgetTypes_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_WidgetTypesGet()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/WidgetTypesGet.json
            // this example is just showing the usage of "WidgetTypes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this WidgetTypeResourceFormatResource
            WidgetTypeResourceFormatCollection collection = hub.GetWidgetTypeResourceFormats();

            // invoke the operation
            string widgetTypeName = "ActivityGauge";
            NullableResponse<WidgetTypeResourceFormatResource> response = await collection.GetIfExistsAsync(widgetTypeName);
            WidgetTypeResourceFormatResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WidgetTypeResourceFormatData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
