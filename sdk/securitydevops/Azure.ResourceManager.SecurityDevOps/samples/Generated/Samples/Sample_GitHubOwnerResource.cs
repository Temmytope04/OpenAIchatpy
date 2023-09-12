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
using Azure.ResourceManager.SecurityDevOps;

namespace Azure.ResourceManager.SecurityDevOps.Samples
{
    public partial class Sample_GitHubOwnerResource
    {
        // GitHubOwner_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GitHubOwnerGet()
        {
            // Generated from example definition: specification/securitydevops/resource-manager/Microsoft.SecurityDevOps/preview/2022-09-01-preview/examples/GitHubOwnerGet.json
            // this example is just showing the usage of "GitHubOwner_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GitHubOwnerResource created on azure
            // for more information of creating GitHubOwnerResource, please refer to the document of GitHubOwnerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "westusrg";
            string gitHubConnectorName = "testconnector";
            string gitHubOwnerName = "Azure";
            ResourceIdentifier gitHubOwnerResourceId = GitHubOwnerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gitHubConnectorName, gitHubOwnerName);
            GitHubOwnerResource gitHubOwner = client.GetGitHubOwnerResource(gitHubOwnerResourceId);

            // invoke the operation
            GitHubOwnerResource result = await gitHubOwner.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GitHubOwnerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GitHubOwner_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_GitHubOwnerUpdate()
        {
            // Generated from example definition: specification/securitydevops/resource-manager/Microsoft.SecurityDevOps/preview/2022-09-01-preview/examples/GitHubOwnerUpdate.json
            // this example is just showing the usage of "GitHubOwner_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GitHubOwnerResource created on azure
            // for more information of creating GitHubOwnerResource, please refer to the document of GitHubOwnerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "westusrg";
            string gitHubConnectorName = "testconnector";
            string gitHubOwnerName = "Azure";
            ResourceIdentifier gitHubOwnerResourceId = GitHubOwnerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gitHubConnectorName, gitHubOwnerName);
            GitHubOwnerResource gitHubOwner = client.GetGitHubOwnerResource(gitHubOwnerResourceId);

            // invoke the operation
            GitHubOwnerData data = new GitHubOwnerData();
            ArmOperation<GitHubOwnerResource> lro = await gitHubOwner.UpdateAsync(WaitUntil.Completed, data);
            GitHubOwnerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GitHubOwnerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
