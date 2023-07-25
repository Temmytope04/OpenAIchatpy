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
using Azure.ResourceManager.Authorization;
using Azure.ResourceManager.Authorization.Models;

namespace Azure.ResourceManager.Authorization.Samples
{
    public partial class Sample_RoleAssignmentResource
    {
        // Get role assignment by scope and name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRoleAssignmentByScopeAndName()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2022-04-01/examples/RoleAssignments_Get.json
            // this example is just showing the usage of "RoleAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RoleAssignmentResource created on azure
            // for more information of creating RoleAssignmentResource, please refer to the document of RoleAssignmentResource
            string scope = "subscriptions/a925f2f7-5c63-4b7b-8799-25a5f97bc3b2";
            string roleAssignmentName = "b0f43c54-e787-4862-89b1-a653fa9cf747";
            ResourceIdentifier roleAssignmentResourceId = RoleAssignmentResource.CreateResourceIdentifier(scope, roleAssignmentName);
            RoleAssignmentResource roleAssignment = client.GetRoleAssignmentResource(roleAssignmentResourceId);

            // invoke the operation
            RoleAssignmentResource result = await roleAssignment.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RoleAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create role assignment for resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateRoleAssignmentForResource()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2022-04-01/examples/RoleAssignments_CreateForResource.json
            // this example is just showing the usage of "RoleAssignments_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RoleAssignmentResource created on azure
            // for more information of creating RoleAssignmentResource, please refer to the document of RoleAssignmentResource
            string scope = "subscriptions/a925f2f7-5c63-4b7b-8799-25a5f97bc3b2/resourceGroups/testrg/providers/Microsoft.DocumentDb/databaseAccounts/test-db-account";
            string roleAssignmentName = "05c5a614-a7d6-4502-b150-c2fb455033ff";
            ResourceIdentifier roleAssignmentResourceId = RoleAssignmentResource.CreateResourceIdentifier(scope, roleAssignmentName);
            RoleAssignmentResource roleAssignment = client.GetRoleAssignmentResource(roleAssignmentResourceId);

            // invoke the operation
            RoleAssignmentCreateOrUpdateContent content = new RoleAssignmentCreateOrUpdateContent(new ResourceIdentifier("/subscriptions/a925f2f7-5c63-4b7b-8799-25a5f97bc3b2/providers/Microsoft.Authorization/roleDefinitions/0b5fe924-9a61-425c-96af-cfe6e287ca2d"), Guid.Parse("ce2ce14e-85d7-4629-bdbc-454d0519d987"))
            {
                PrincipalType = RoleManagementPrincipalType.User,
            };
            ArmOperation<RoleAssignmentResource> lro = await roleAssignment.UpdateAsync(WaitUntil.Completed, content);
            RoleAssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RoleAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create role assignment for resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateRoleAssignmentForResourceGroup()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2022-04-01/examples/RoleAssignments_CreateForResourceGroup.json
            // this example is just showing the usage of "RoleAssignments_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RoleAssignmentResource created on azure
            // for more information of creating RoleAssignmentResource, please refer to the document of RoleAssignmentResource
            string scope = "subscriptions/a925f2f7-5c63-4b7b-8799-25a5f97bc3b2/resourceGroups/testrg";
            string roleAssignmentName = "05c5a614-a7d6-4502-b150-c2fb455033ff";
            ResourceIdentifier roleAssignmentResourceId = RoleAssignmentResource.CreateResourceIdentifier(scope, roleAssignmentName);
            RoleAssignmentResource roleAssignment = client.GetRoleAssignmentResource(roleAssignmentResourceId);

            // invoke the operation
            RoleAssignmentCreateOrUpdateContent content = new RoleAssignmentCreateOrUpdateContent(new ResourceIdentifier("/subscriptions/a925f2f7-5c63-4b7b-8799-25a5f97bc3b2/providers/Microsoft.Authorization/roleDefinitions/0b5fe924-9a61-425c-96af-cfe6e287ca2d"), Guid.Parse("ce2ce14e-85d7-4629-bdbc-454d0519d987"))
            {
                PrincipalType = RoleManagementPrincipalType.User,
            };
            ArmOperation<RoleAssignmentResource> lro = await roleAssignment.UpdateAsync(WaitUntil.Completed, content);
            RoleAssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RoleAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create role assignment for subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateRoleAssignmentForSubscription()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2022-04-01/examples/RoleAssignments_CreateForSubscription.json
            // this example is just showing the usage of "RoleAssignments_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RoleAssignmentResource created on azure
            // for more information of creating RoleAssignmentResource, please refer to the document of RoleAssignmentResource
            string scope = "subscriptions/a925f2f7-5c63-4b7b-8799-25a5f97bc3b2";
            string roleAssignmentName = "05c5a614-a7d6-4502-b150-c2fb455033ff";
            ResourceIdentifier roleAssignmentResourceId = RoleAssignmentResource.CreateResourceIdentifier(scope, roleAssignmentName);
            RoleAssignmentResource roleAssignment = client.GetRoleAssignmentResource(roleAssignmentResourceId);

            // invoke the operation
            RoleAssignmentCreateOrUpdateContent content = new RoleAssignmentCreateOrUpdateContent(new ResourceIdentifier("/subscriptions/a925f2f7-5c63-4b7b-8799-25a5f97bc3b2/providers/Microsoft.Authorization/roleDefinitions/0b5fe924-9a61-425c-96af-cfe6e287ca2d"), Guid.Parse("ce2ce14e-85d7-4629-bdbc-454d0519d987"))
            {
                PrincipalType = RoleManagementPrincipalType.User,
            };
            ArmOperation<RoleAssignmentResource> lro = await roleAssignment.UpdateAsync(WaitUntil.Completed, content);
            RoleAssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RoleAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete role assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteRoleAssignment()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2022-04-01/examples/RoleAssignments_Delete.json
            // this example is just showing the usage of "RoleAssignments_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RoleAssignmentResource created on azure
            // for more information of creating RoleAssignmentResource, please refer to the document of RoleAssignmentResource
            string scope = "subscriptions/a925f2f7-5c63-4b7b-8799-25a5f97bc3b2";
            string roleAssignmentName = "b0f43c54-e787-4862-89b1-a653fa9cf747";
            ResourceIdentifier roleAssignmentResourceId = RoleAssignmentResource.CreateResourceIdentifier(scope, roleAssignmentName);
            RoleAssignmentResource roleAssignment = client.GetRoleAssignmentResource(roleAssignmentResourceId);

            // invoke the operation
            ArmOperation<RoleAssignmentResource> lro = await roleAssignment.DeleteAsync(WaitUntil.Completed);
            RoleAssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RoleAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
