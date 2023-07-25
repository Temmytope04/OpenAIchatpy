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
using Azure.ResourceManager.RecoveryServicesBackup;
using Azure.ResourceManager.RecoveryServicesBackup.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesBackup.Samples
{
    public partial class Sample_BackupProtectionContainerCollection
    {
        // Get Protection Container Details
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetProtectionContainerDetails()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2023-02-01/examples/AzureWorkload/ProtectionContainers_Get.json
            // this example is just showing the usage of "ProtectionContainers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testRg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this BackupProtectionContainerResource
            BackupProtectionContainerCollection collection = resourceGroupResource.GetBackupProtectionContainers();

            // invoke the operation
            string vaultName = "testVault";
            string fabricName = "Azure";
            string containerName = "VMAppContainer;Compute;testRG;testSQL";
            BackupProtectionContainerResource result = await collection.GetAsync(vaultName, fabricName, containerName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BackupProtectionContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Protection Container Details
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetProtectionContainerDetails()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2023-02-01/examples/AzureWorkload/ProtectionContainers_Get.json
            // this example is just showing the usage of "ProtectionContainers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testRg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this BackupProtectionContainerResource
            BackupProtectionContainerCollection collection = resourceGroupResource.GetBackupProtectionContainers();

            // invoke the operation
            string vaultName = "testVault";
            string fabricName = "Azure";
            string containerName = "VMAppContainer;Compute;testRG;testSQL";
            bool result = await collection.ExistsAsync(vaultName, fabricName, containerName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // RegisterAzure Storage ProtectionContainers
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_RegisterAzureStorageProtectionContainers()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2023-02-01/examples/AzureStorage/ProtectionContainers_Register.json
            // this example is just showing the usage of "ProtectionContainers_Register" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SwaggerTestRg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this BackupProtectionContainerResource
            BackupProtectionContainerCollection collection = resourceGroupResource.GetBackupProtectionContainers();

            // invoke the operation
            string vaultName = "swaggertestvault";
            string fabricName = "Azure";
            string containerName = "StorageContainer;Storage;SwaggerTestRg;swaggertestsa";
            BackupProtectionContainerData data = new BackupProtectionContainerData(new AzureLocation("placeholder"))
            {
                Properties = new StorageContainer()
                {
                    SourceResourceId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/SwaggerTestRg/providers/Microsoft.Storage/storageAccounts/swaggertestsa"),
                    AcquireStorageAccountLock = AcquireStorageAccountLock.Acquire,
                    FriendlyName = "swaggertestsa",
                    BackupManagementType = BackupManagementType.AzureStorage,
                },
            };
            ArmOperation<BackupProtectionContainerResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, vaultName, fabricName, containerName, data);
            BackupProtectionContainerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BackupProtectionContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
