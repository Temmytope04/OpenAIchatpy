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
using Azure.ResourceManager.NetworkFunction;
using Azure.ResourceManager.NetworkFunction.Models;

namespace Azure.ResourceManager.NetworkFunction.Samples
{
    public partial class Sample_CollectorPolicyResource
    {
        // Get Collection Policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetCollectionPolicy()
        {
            // Generated from example definition: specification/networkfunction/resource-manager/Microsoft.NetworkFunction/stable/2022-11-01/examples/CollectorPolicyGet.json
            // this example is just showing the usage of "CollectorPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CollectorPolicyResource created on azure
            // for more information of creating CollectorPolicyResource, please refer to the document of CollectorPolicyResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string azureTrafficCollectorName = "atc";
            string collectorPolicyName = "cp1";
            ResourceIdentifier collectorPolicyResourceId = CollectorPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, azureTrafficCollectorName, collectorPolicyName);
            CollectorPolicyResource collectorPolicy = client.GetCollectorPolicyResource(collectorPolicyResourceId);

            // invoke the operation
            CollectorPolicyResource result = await collectorPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CollectorPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete Collection Policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteCollectionPolicy()
        {
            // Generated from example definition: specification/networkfunction/resource-manager/Microsoft.NetworkFunction/stable/2022-11-01/examples/CollectorPolicyDelete.json
            // this example is just showing the usage of "CollectorPolicies_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CollectorPolicyResource created on azure
            // for more information of creating CollectorPolicyResource, please refer to the document of CollectorPolicyResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string azureTrafficCollectorName = "atc";
            string collectorPolicyName = "cp1";
            ResourceIdentifier collectorPolicyResourceId = CollectorPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, azureTrafficCollectorName, collectorPolicyName);
            CollectorPolicyResource collectorPolicy = client.GetCollectorPolicyResource(collectorPolicyResourceId);

            // invoke the operation
            await collectorPolicy.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Update Collector Policy tags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateCollectorPolicyTags()
        {
            // Generated from example definition: specification/networkfunction/resource-manager/Microsoft.NetworkFunction/stable/2022-11-01/examples/CollectorPolicyUpdateTags.json
            // this example is just showing the usage of "CollectorPolicies_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CollectorPolicyResource created on azure
            // for more information of creating CollectorPolicyResource, please refer to the document of CollectorPolicyResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string azureTrafficCollectorName = "atc";
            string collectorPolicyName = "cp1";
            ResourceIdentifier collectorPolicyResourceId = CollectorPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, azureTrafficCollectorName, collectorPolicyName);
            CollectorPolicyResource collectorPolicy = client.GetCollectorPolicyResource(collectorPolicyResourceId);

            // invoke the operation
            TagsObject tagsObject = new TagsObject()
            {
                Tags =
{
["key1"] = "value1",
["key2"] = "value2",
},
            };
            CollectorPolicyResource result = await collectorPolicy.UpdateAsync(tagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CollectorPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
