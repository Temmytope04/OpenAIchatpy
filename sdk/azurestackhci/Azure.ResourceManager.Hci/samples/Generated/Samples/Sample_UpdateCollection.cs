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
    public partial class Sample_UpdateCollection
    {
        // List available updates
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListAvailableUpdates()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/stable/2023-02-01/examples/ListUpdates.json
            // this example is just showing the usage of "Updates_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HciClusterResource created on azure
            // for more information of creating HciClusterResource, please refer to the document of HciClusterResource
            string subscriptionId = "b8d594e5-51f3-4c11-9c54-a7771b81c712";
            string resourceGroupName = "testrg";
            string clusterName = "testcluster";
            ResourceIdentifier hciClusterResourceId = HciClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            HciClusterResource hciCluster = client.GetHciClusterResource(hciClusterResourceId);

            // get the collection of this UpdateResource
            UpdateCollection collection = hciCluster.GetUpdates();

            // invoke the operation and iterate over the result
            await foreach (UpdateResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                UpdateData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Put a specific update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PutASpecificUpdate()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/stable/2023-02-01/examples/PutUpdates.json
            // this example is just showing the usage of "Updates_Put" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HciClusterResource created on azure
            // for more information of creating HciClusterResource, please refer to the document of HciClusterResource
            string subscriptionId = "b8d594e5-51f3-4c11-9c54-a7771b81c712";
            string resourceGroupName = "testrg";
            string clusterName = "testcluster";
            ResourceIdentifier hciClusterResourceId = HciClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            HciClusterResource hciCluster = client.GetHciClusterResource(hciClusterResourceId);

            // get the collection of this UpdateResource
            UpdateCollection collection = hciCluster.GetUpdates();

            // invoke the operation
            string updateName = "Microsoft4.2203.2.32";
            UpdateData data = new UpdateData()
            {
                InstalledOn = DateTimeOffset.Parse("2022-04-06T14:08:18.254Z"),
                Description = "AzS Update 4.2203.2.32",
                State = HciUpdateState.Installed,
                Prerequisites =
{
new UpdatePrerequisite()
{
UpdateType = "update type",
Version = "prerequisite version",
PackageName = "update package name",
}
},
                PackagePath = "\\\\SU1FileServer\\SU1_Infrastructure_2\\Updates\\Packages\\Microsoft4.2203.2.32",
                PackageSizeInMb = 18858,
                DisplayName = "AzS Update - 4.2203.2.32",
                Version = "4.2203.2.32",
                Publisher = "Microsoft",
                ReleaseLink = "https://docs.microsoft.com/azure-stack/operator/release-notes?view=azs-2203",
                AvailabilityType = HciAvailabilityType.Local,
                PackageType = "Infrastructure",
                AdditionalProperties = "additional properties",
                ProgressPercentage = 0,
                NotifyMessage = "Brief message with instructions for updates of AvailabilityType Notify",
            };
            ArmOperation<UpdateResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, updateName, data);
            UpdateResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            UpdateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a specific update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetASpecificUpdate()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/stable/2023-02-01/examples/GetUpdates.json
            // this example is just showing the usage of "Updates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HciClusterResource created on azure
            // for more information of creating HciClusterResource, please refer to the document of HciClusterResource
            string subscriptionId = "b8d594e5-51f3-4c11-9c54-a7771b81c712";
            string resourceGroupName = "testrg";
            string clusterName = "testcluster";
            ResourceIdentifier hciClusterResourceId = HciClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            HciClusterResource hciCluster = client.GetHciClusterResource(hciClusterResourceId);

            // get the collection of this UpdateResource
            UpdateCollection collection = hciCluster.GetUpdates();

            // invoke the operation
            string updateName = "Microsoft4.2203.2.32";
            UpdateResource result = await collection.GetAsync(updateName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            UpdateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a specific update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetASpecificUpdate()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/stable/2023-02-01/examples/GetUpdates.json
            // this example is just showing the usage of "Updates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HciClusterResource created on azure
            // for more information of creating HciClusterResource, please refer to the document of HciClusterResource
            string subscriptionId = "b8d594e5-51f3-4c11-9c54-a7771b81c712";
            string resourceGroupName = "testrg";
            string clusterName = "testcluster";
            ResourceIdentifier hciClusterResourceId = HciClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            HciClusterResource hciCluster = client.GetHciClusterResource(hciClusterResourceId);

            // get the collection of this UpdateResource
            UpdateCollection collection = hciCluster.GetUpdates();

            // invoke the operation
            string updateName = "Microsoft4.2203.2.32";
            bool result = await collection.ExistsAsync(updateName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
