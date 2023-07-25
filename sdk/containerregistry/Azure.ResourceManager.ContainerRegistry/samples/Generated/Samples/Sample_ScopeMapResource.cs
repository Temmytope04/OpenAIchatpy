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
using Azure.ResourceManager.ContainerRegistry;
using Azure.ResourceManager.ContainerRegistry.Models;

namespace Azure.ResourceManager.ContainerRegistry.Samples
{
    public partial class Sample_ScopeMapResource
    {
        // ScopeMapGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ScopeMapGet()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/stable/2022-12-01/examples/ScopeMapGet.json
            // this example is just showing the usage of "ScopeMaps_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScopeMapResource created on azure
            // for more information of creating ScopeMapResource, please refer to the document of ScopeMapResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            string scopeMapName = "myScopeMap";
            ResourceIdentifier scopeMapResourceId = ScopeMapResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, scopeMapName);
            ScopeMapResource scopeMap = client.GetScopeMapResource(scopeMapResourceId);

            // invoke the operation
            ScopeMapResource result = await scopeMap.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScopeMapData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ScopeMapDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ScopeMapDelete()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/stable/2022-12-01/examples/ScopeMapDelete.json
            // this example is just showing the usage of "ScopeMaps_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScopeMapResource created on azure
            // for more information of creating ScopeMapResource, please refer to the document of ScopeMapResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            string scopeMapName = "myScopeMap";
            ResourceIdentifier scopeMapResourceId = ScopeMapResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, scopeMapName);
            ScopeMapResource scopeMap = client.GetScopeMapResource(scopeMapResourceId);

            // invoke the operation
            await scopeMap.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // ScopeMapUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ScopeMapUpdate()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/stable/2022-12-01/examples/ScopeMapUpdate.json
            // this example is just showing the usage of "ScopeMaps_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScopeMapResource created on azure
            // for more information of creating ScopeMapResource, please refer to the document of ScopeMapResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            string scopeMapName = "myScopeMap";
            ResourceIdentifier scopeMapResourceId = ScopeMapResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, scopeMapName);
            ScopeMapResource scopeMap = client.GetScopeMapResource(scopeMapResourceId);

            // invoke the operation
            ScopeMapPatch patch = new ScopeMapPatch()
            {
                Description = "Developer Scopes",
                Actions =
{
"repositories/myrepository/contentWrite","repositories/myrepository/contentRead"
},
            };
            ArmOperation<ScopeMapResource> lro = await scopeMap.UpdateAsync(WaitUntil.Completed, patch);
            ScopeMapResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScopeMapData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
