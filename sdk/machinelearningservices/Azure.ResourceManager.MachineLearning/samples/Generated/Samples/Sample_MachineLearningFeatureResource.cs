// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearningFeatureResource
    {
        // Get Feature.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetFeature()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Feature/get.json
            // this example is just showing the usage of "Features_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningFeatureResource created on azure
            // for more information of creating MachineLearningFeatureResource, please refer to the document of MachineLearningFeatureResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string featuresetName = "string";
            string featuresetVersion = "string";
            string featureName = "string";
            ResourceIdentifier machineLearningFeatureResourceId = MachineLearningFeatureResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, featuresetName, featuresetVersion, featureName);
            MachineLearningFeatureResource machineLearningFeature = client.GetMachineLearningFeatureResource(machineLearningFeatureResourceId);

            // invoke the operation
            MachineLearningFeatureResource result = await machineLearningFeature.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningFeatureData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
