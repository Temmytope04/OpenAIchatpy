// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapseBigDataPoolInfoResource
    {
        // Get a Big Data pool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetABigDataPool()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/GetBigDataPool.json
            // this example is just showing the usage of "BigDataPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseBigDataPoolInfoResource created on azure
            // for more information of creating SynapseBigDataPoolInfoResource, please refer to the document of SynapseBigDataPoolInfoResource
            string subscriptionId = "01234567-89ab-4def-0123-456789abcdef";
            string resourceGroupName = "ExampleResourceGroup";
            string workspaceName = "ExampleWorkspace";
            string bigDataPoolName = "ExamplePool";
            ResourceIdentifier synapseBigDataPoolInfoResourceId = SynapseBigDataPoolInfoResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, bigDataPoolName);
            SynapseBigDataPoolInfoResource synapseBigDataPoolInfo = client.GetSynapseBigDataPoolInfoResource(synapseBigDataPoolInfoResourceId);

            // invoke the operation
            SynapseBigDataPoolInfoResource result = await synapseBigDataPoolInfo.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseBigDataPoolInfoData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a Big Data pool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateABigDataPool()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/UpdateBigDataPool.json
            // this example is just showing the usage of "BigDataPools_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseBigDataPoolInfoResource created on azure
            // for more information of creating SynapseBigDataPoolInfoResource, please refer to the document of SynapseBigDataPoolInfoResource
            string subscriptionId = "01234567-89ab-4def-0123-456789abcdef";
            string resourceGroupName = "ExampleResourceGroup";
            string workspaceName = "ExampleWorkspace";
            string bigDataPoolName = "ExamplePool";
            ResourceIdentifier synapseBigDataPoolInfoResourceId = SynapseBigDataPoolInfoResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, bigDataPoolName);
            SynapseBigDataPoolInfoResource synapseBigDataPoolInfo = client.GetSynapseBigDataPoolInfoResource(synapseBigDataPoolInfoResourceId);

            // invoke the operation
            SynapseBigDataPoolInfoPatch patch = new SynapseBigDataPoolInfoPatch()
            {
                Tags =
{
["key"] = "value",
},
            };
            SynapseBigDataPoolInfoResource result = await synapseBigDataPoolInfo.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseBigDataPoolInfoData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a Big Data pool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteABigDataPool()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/DeleteBigDataPool.json
            // this example is just showing the usage of "BigDataPools_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseBigDataPoolInfoResource created on azure
            // for more information of creating SynapseBigDataPoolInfoResource, please refer to the document of SynapseBigDataPoolInfoResource
            string subscriptionId = "01234567-89ab-4def-0123-456789abcdef";
            string resourceGroupName = "ExampleResourceGroup";
            string workspaceName = "ExampleWorkspace";
            string bigDataPoolName = "ExamplePool";
            ResourceIdentifier synapseBigDataPoolInfoResourceId = SynapseBigDataPoolInfoResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, bigDataPoolName);
            SynapseBigDataPoolInfoResource synapseBigDataPoolInfo = client.GetSynapseBigDataPoolInfoResource(synapseBigDataPoolInfoResourceId);

            // invoke the operation
            ArmOperation<BinaryData> lro = await synapseBigDataPoolInfo.DeleteAsync(WaitUntil.Completed);
            BinaryData result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
