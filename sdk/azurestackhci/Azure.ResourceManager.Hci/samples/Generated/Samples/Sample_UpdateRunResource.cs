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
using Azure.ResourceManager.Hci;
using Azure.ResourceManager.Hci.Models;

namespace Azure.ResourceManager.Hci.Samples
{
    public partial class Sample_UpdateRunResource
    {
        // Delete an Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAnUpdate()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/stable/2023-02-01/examples/DeleteUpdateRuns.json
            // this example is just showing the usage of "UpdateRuns_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this UpdateRunResource created on azure
            // for more information of creating UpdateRunResource, please refer to the document of UpdateRunResource
            string subscriptionId = "b8d594e5-51f3-4c11-9c54-a7771b81c712";
            string resourceGroupName = "testrg";
            string clusterName = "testcluster";
            string updateName = "Microsoft4.2203.2.32";
            string updateRunName = "23b779ba-0d52-4a80-8571-45ca74664ec3";
            ResourceIdentifier updateRunResourceId = UpdateRunResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, updateName, updateRunName);
            UpdateRunResource updateRun = client.GetUpdateRunResource(updateRunResourceId);

            // invoke the operation
            await updateRun.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get Update runs under cluster resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_GetUpdateRunsUnderClusterResource()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/stable/2023-02-01/examples/PutUpdateRuns.json
            // this example is just showing the usage of "UpdateRuns_Put" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this UpdateRunResource created on azure
            // for more information of creating UpdateRunResource, please refer to the document of UpdateRunResource
            string subscriptionId = "b8d594e5-51f3-4c11-9c54-a7771b81c712";
            string resourceGroupName = "testrg";
            string clusterName = "testcluster";
            string updateName = "Microsoft4.2203.2.32";
            string updateRunName = "23b779ba-0d52-4a80-8571-45ca74664ec3";
            ResourceIdentifier updateRunResourceId = UpdateRunResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, updateName, updateRunName);
            UpdateRunResource updateRun = client.GetUpdateRunResource(updateRunResourceId);

            // invoke the operation
            UpdateRunData data = new UpdateRunData()
            {
                NamePropertiesProgressName = "Unnamed step",
                Description = "Update Azure Stack.",
                ErrorMessage = "",
                Status = "Success",
                StartTimeUtc = DateTimeOffset.Parse("2022-04-06T01:36:33.3876751+00:00"),
                EndTimeUtc = DateTimeOffset.Parse("2022-04-06T13:58:42.969006+00:00"),
                LastUpdatedTimeUtc = DateTimeOffset.Parse("2022-04-06T13:58:42.969006+00:00"),
                Steps =
{
new HciUpdateStep()
{
Name = "PreUpdate Cloud",
Description = "Prepare for SSU update",
ErrorMessage = "",
Status = "Success",
StartTimeUtc = DateTimeOffset.Parse("2022-04-06T01:36:33.3876751+00:00"),
EndTimeUtc = DateTimeOffset.Parse("2022-04-06T01:37:16.8728314+00:00"),
LastUpdatedTimeUtc = DateTimeOffset.Parse("2022-04-06T01:37:16.8728314+00:00"),
Steps =
{
},
}
},
            };
            ArmOperation<UpdateRunResource> lro = await updateRun.UpdateAsync(WaitUntil.Completed, data);
            UpdateRunResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            UpdateRunData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Update runs under cluster resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetUpdateRunsUnderClusterResource()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/stable/2023-02-01/examples/GetUpdateRuns.json
            // this example is just showing the usage of "UpdateRuns_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this UpdateRunResource created on azure
            // for more information of creating UpdateRunResource, please refer to the document of UpdateRunResource
            string subscriptionId = "b8d594e5-51f3-4c11-9c54-a7771b81c712";
            string resourceGroupName = "testrg";
            string clusterName = "testcluster";
            string updateName = "Microsoft4.2203.2.32";
            string updateRunName = "23b779ba-0d52-4a80-8571-45ca74664ec3";
            ResourceIdentifier updateRunResourceId = UpdateRunResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, updateName, updateRunName);
            UpdateRunResource updateRun = client.GetUpdateRunResource(updateRunResourceId);

            // invoke the operation
            UpdateRunResource result = await updateRun.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            UpdateRunData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
