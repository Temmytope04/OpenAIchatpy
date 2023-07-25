// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Chaos;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Chaos.Samples
{
    public partial class Sample_TargetTypeCollection
    {
        // List all Target Types for westus2 location.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListAllTargetTypesForWestus2Location()
        {
            // Generated from example definition: specification/chaos/resource-manager/Microsoft.Chaos/preview/2022-10-01-preview/examples/ListTargetTypes.json
            // this example is just showing the usage of "TargetTypes_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this TargetTypeResource
            string locationName = "westus2";
            TargetTypeCollection collection = subscriptionResource.GetTargetTypes(locationName);

            // invoke the operation and iterate over the result
            string continuationToken = null;
            await foreach (TargetTypeResource item in collection.GetAllAsync(continuationToken: continuationToken))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                TargetTypeData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get a Target Type for westus2 location
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetATargetTypeForWestus2Location()
        {
            // Generated from example definition: specification/chaos/resource-manager/Microsoft.Chaos/preview/2022-10-01-preview/examples/GetATargetType.json
            // this example is just showing the usage of "TargetTypes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this TargetTypeResource
            string locationName = "westus2";
            TargetTypeCollection collection = subscriptionResource.GetTargetTypes(locationName);

            // invoke the operation
            string targetTypeName = "Microsoft-Agent";
            TargetTypeResource result = await collection.GetAsync(targetTypeName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TargetTypeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a Target Type for westus2 location
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetATargetTypeForWestus2Location()
        {
            // Generated from example definition: specification/chaos/resource-manager/Microsoft.Chaos/preview/2022-10-01-preview/examples/GetATargetType.json
            // this example is just showing the usage of "TargetTypes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this TargetTypeResource
            string locationName = "westus2";
            TargetTypeCollection collection = subscriptionResource.GetTargetTypes(locationName);

            // invoke the operation
            string targetTypeName = "Microsoft-Agent";
            bool result = await collection.ExistsAsync(targetTypeName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
