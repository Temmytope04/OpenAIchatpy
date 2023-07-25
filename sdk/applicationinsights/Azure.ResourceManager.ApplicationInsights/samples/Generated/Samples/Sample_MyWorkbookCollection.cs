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
using Azure.ResourceManager.ApplicationInsights;
using Azure.ResourceManager.ApplicationInsights.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ApplicationInsights.Samples
{
    public partial class Sample_MyWorkbookCollection
    {
        // WorkbooksList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_WorkbooksList()
        {
            // Generated from example definition: specification/applicationinsights/resource-manager/Microsoft.Insights/stable/2021-03-08/examples/MyWorkbooksList.json
            // this example is just showing the usage of "MyWorkbooks_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "6b643656-33eb-422f-aee8-3ac145d124af";
            string resourceGroupName = "my-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MyWorkbookResource
            MyWorkbookCollection collection = resourceGroupResource.GetMyWorkbooks();

            // invoke the operation and iterate over the result
            CategoryType category = CategoryType.Workbook;
            await foreach (MyWorkbookResource item in collection.GetAllAsync(category))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MyWorkbookData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // WorkbooksList2
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_WorkbooksList2()
        {
            // Generated from example definition: specification/applicationinsights/resource-manager/Microsoft.Insights/stable/2021-03-08/examples/MyWorkbooksList2.json
            // this example is just showing the usage of "MyWorkbooks_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "6b643656-33eb-422f-aee8-3ac145d124af";
            string resourceGroupName = "my-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MyWorkbookResource
            MyWorkbookCollection collection = resourceGroupResource.GetMyWorkbooks();

            // invoke the operation and iterate over the result
            CategoryType category = CategoryType.Workbook;
            await foreach (MyWorkbookResource item in collection.GetAllAsync(category))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MyWorkbookData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // WorkbookGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_WorkbookGet()
        {
            // Generated from example definition: specification/applicationinsights/resource-manager/Microsoft.Insights/stable/2021-03-08/examples/MyWorkbookGet.json
            // this example is just showing the usage of "MyWorkbooks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "6b643656-33eb-422f-aee8-3ac145d124af";
            string resourceGroupName = "my-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MyWorkbookResource
            MyWorkbookCollection collection = resourceGroupResource.GetMyWorkbooks();

            // invoke the operation
            string resourceName = "deadb33f-5e0d-4064-8ebb-1a4ed0313eb2";
            MyWorkbookResource result = await collection.GetAsync(resourceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MyWorkbookData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WorkbookGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_WorkbookGet()
        {
            // Generated from example definition: specification/applicationinsights/resource-manager/Microsoft.Insights/stable/2021-03-08/examples/MyWorkbookGet.json
            // this example is just showing the usage of "MyWorkbooks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "6b643656-33eb-422f-aee8-3ac145d124af";
            string resourceGroupName = "my-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MyWorkbookResource
            MyWorkbookCollection collection = resourceGroupResource.GetMyWorkbooks();

            // invoke the operation
            string resourceName = "deadb33f-5e0d-4064-8ebb-1a4ed0313eb2";
            bool result = await collection.ExistsAsync(resourceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // WorkbookAdd
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_WorkbookAdd()
        {
            // Generated from example definition: specification/applicationinsights/resource-manager/Microsoft.Insights/stable/2021-03-08/examples/MyWorkbookAdd.json
            // this example is just showing the usage of "MyWorkbooks_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-00000000";
            string resourceGroupName = "my-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MyWorkbookResource
            MyWorkbookCollection collection = resourceGroupResource.GetMyWorkbooks();

            // invoke the operation
            string resourceName = "deadb33f-8bee-4d3b-a059-9be8dac93960";
            MyWorkbookData data = new MyWorkbookData()
            {
                Kind = ApplicationInsightsKind.User,
                DisplayName = "Blah Blah Blah",
                SerializedData = "{\"version\":\"Notebook/1.0\",\"items\":[{\"type\":1,\"content\":\"{\"json\":\"## New workbook\\r\\n---\\r\\n\\r\\nWelcome to your new workbook.  This area will display text formatted as markdown.\\r\\n\\r\\n\\r\\nWe've included a basic analytics query to get you started. Use the `Edit` button below each section to configure it or add more sections.\"}\",\"halfWidth\":null,\"conditionalVisibility\":null},{\"type\":3,\"content\":\"{\"version\":\"KqlItem/1.0\",\"query\":\"union withsource=TableName *\\n| summarize Count=count() by TableName\\n| render barchart\",\"showQuery\":false,\"size\":1,\"aggregation\":0,\"showAnnotations\":false}\",\"halfWidth\":null,\"conditionalVisibility\":null}],\"isLocked\":false}",
                Category = "workbook",
                SourceId = "/subscriptions/00000000-0000-0000-0000-00000000/resourceGroups/MyGroup/providers/Microsoft.Web/sites/MyTestApp-CodeLens",
                Id = "c0deea5e-3344-40f2-96f8-6f8e1c3b5722",
                Name = "deadb33f-8bee-4d3b-a059-9be8dac93960",
                Location = new AzureLocation("west us"),
                Tags =
{
["0"] = "TagSample01",
["1"] = "TagSample02",
},
            };
            ArmOperation<MyWorkbookResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, resourceName, data);
            MyWorkbookResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MyWorkbookData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
