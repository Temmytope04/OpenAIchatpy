// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapseWorkspaceAdministratorResource
    {
        // Get workspace active directory admin
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetWorkspaceActiveDirectoryAdmin()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetWorkspaceAadAdmin.json
            // this example is just showing the usage of "WorkspaceAadAdmins_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceAdministratorResource created on azure
            // for more information of creating SynapseWorkspaceAdministratorResource, please refer to the document of SynapseWorkspaceAdministratorResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "resourceGroup1";
            string workspaceName = "workspace1";
            ResourceIdentifier synapseWorkspaceAdministratorResourceId = SynapseWorkspaceAdministratorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceAdministratorResource synapseWorkspaceAdministratorResource = client.GetSynapseWorkspaceAdministratorResource(synapseWorkspaceAdministratorResourceId);

            // invoke the operation
            SynapseWorkspaceAdministratorResource result = await synapseWorkspaceAdministratorResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseWorkspaceAadAdminInfoData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or update workspace active directory admin
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateWorkspaceActiveDirectoryAdmin()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/CreateOrUpdateWorkspaceAadAdmin.json
            // this example is just showing the usage of "WorkspaceAadAdmins_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceAdministratorResource created on azure
            // for more information of creating SynapseWorkspaceAdministratorResource, please refer to the document of SynapseWorkspaceAdministratorResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "resourceGroup1";
            string workspaceName = "workspace1";
            ResourceIdentifier synapseWorkspaceAdministratorResourceId = SynapseWorkspaceAdministratorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceAdministratorResource synapseWorkspaceAdministratorResource = client.GetSynapseWorkspaceAdministratorResource(synapseWorkspaceAdministratorResourceId);

            // invoke the operation
            SynapseWorkspaceAadAdminInfoData info = new SynapseWorkspaceAadAdminInfoData()
            {
                TenantId = Guid.Parse("c6b82b90-a647-49cb-8a62-0d2d3cb7ac7c"),
                Login = "bob@contoso.com",
                AdministratorType = "ActiveDirectory",
                Sid = "c6b82b90-a647-49cb-8a62-0d2d3cb7ac7c",
            };
            ArmOperation<SynapseWorkspaceAdministratorResource> lro = await synapseWorkspaceAdministratorResource.CreateOrUpdateAsync(WaitUntil.Completed, info);
            SynapseWorkspaceAdministratorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseWorkspaceAadAdminInfoData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete workspace active directory admin
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteWorkspaceActiveDirectoryAdmin()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/DeleteWorkspaceAadAdmin.json
            // this example is just showing the usage of "WorkspaceAadAdmins_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceAdministratorResource created on azure
            // for more information of creating SynapseWorkspaceAdministratorResource, please refer to the document of SynapseWorkspaceAdministratorResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "resourceGroup1";
            string workspaceName = "workspace1";
            ResourceIdentifier synapseWorkspaceAdministratorResourceId = SynapseWorkspaceAdministratorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceAdministratorResource synapseWorkspaceAdministratorResource = client.GetSynapseWorkspaceAdministratorResource(synapseWorkspaceAdministratorResourceId);

            // invoke the operation
            await synapseWorkspaceAdministratorResource.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
