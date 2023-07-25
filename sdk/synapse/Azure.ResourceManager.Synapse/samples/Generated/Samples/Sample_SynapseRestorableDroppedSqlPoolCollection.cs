// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapseRestorableDroppedSqlPoolCollection
    {
        // Get a restorable dropped Sql pool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetARestorableDroppedSqlPool()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/RestorableDroppedSqlPoolGet.json
            // this example is just showing the usage of "RestorableDroppedSqlPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "restorabledroppeddatabasetest-1257";
            string workspaceName = "restorabledroppeddatabasetest-2389";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseRestorableDroppedSqlPoolResource
            SynapseRestorableDroppedSqlPoolCollection collection = synapseWorkspace.GetSynapseRestorableDroppedSqlPools();

            // invoke the operation
            string restorableDroppedSqlPoolId = "restorabledroppeddatabasetest-7654,131403269876900000";
            SynapseRestorableDroppedSqlPoolResource result = await collection.GetAsync(restorableDroppedSqlPoolId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseRestorableDroppedSqlPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a restorable dropped Sql pool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetARestorableDroppedSqlPool()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/RestorableDroppedSqlPoolGet.json
            // this example is just showing the usage of "RestorableDroppedSqlPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "restorabledroppeddatabasetest-1257";
            string workspaceName = "restorabledroppeddatabasetest-2389";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseRestorableDroppedSqlPoolResource
            SynapseRestorableDroppedSqlPoolCollection collection = synapseWorkspace.GetSynapseRestorableDroppedSqlPools();

            // invoke the operation
            string restorableDroppedSqlPoolId = "restorabledroppeddatabasetest-7654,131403269876900000";
            bool result = await collection.ExistsAsync(restorableDroppedSqlPoolId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get list of restorable dropped Sql pools
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetListOfRestorableDroppedSqlPools()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/RestorableDroppedSqlpoolList.json
            // this example is just showing the usage of "RestorableDroppedSqlPools_ListByWorkspace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "restorabledroppeddatabasetest-1349";
            string workspaceName = "restorabledroppeddatabasetest-1840";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseRestorableDroppedSqlPoolResource
            SynapseRestorableDroppedSqlPoolCollection collection = synapseWorkspace.GetSynapseRestorableDroppedSqlPools();

            // invoke the operation and iterate over the result
            await foreach (SynapseRestorableDroppedSqlPoolResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseRestorableDroppedSqlPoolData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
