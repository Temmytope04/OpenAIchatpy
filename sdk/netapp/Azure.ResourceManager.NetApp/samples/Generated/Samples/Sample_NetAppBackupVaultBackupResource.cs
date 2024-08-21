// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp.Samples
{
    public partial class Sample_NetAppBackupVaultBackupResource
    {
        // BackupsUnderBackupVault_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_BackupsUnderBackupVaultGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-03-01/examples/BackupsUnderBackupVault_Get.json
            // this example is just showing the usage of "Backups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppBackupVaultBackupResource created on azure
            // for more information of creating NetAppBackupVaultBackupResource, please refer to the document of NetAppBackupVaultBackupResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string backupVaultName = "backupVault1";
            string backupName = "backup1";
            ResourceIdentifier netAppBackupVaultBackupResourceId = NetAppBackupVaultBackupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, backupVaultName, backupName);
            NetAppBackupVaultBackupResource netAppBackupVaultBackup = client.GetNetAppBackupVaultBackupResource(netAppBackupVaultBackupResourceId);

            // invoke the operation
            NetAppBackupVaultBackupResource result = await netAppBackupVaultBackup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppBackupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // BackupsUnderBackupVault_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_BackupsUnderBackupVaultUpdate()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-03-01/examples/BackupsUnderBackupVault_Update.json
            // this example is just showing the usage of "Backups_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppBackupVaultBackupResource created on azure
            // for more information of creating NetAppBackupVaultBackupResource, please refer to the document of NetAppBackupVaultBackupResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string backupVaultName = "backupVault1";
            string backupName = "backup1";
            ResourceIdentifier netAppBackupVaultBackupResourceId = NetAppBackupVaultBackupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, backupVaultName, backupName);
            NetAppBackupVaultBackupResource netAppBackupVaultBackup = client.GetNetAppBackupVaultBackupResource(netAppBackupVaultBackupResourceId);

            // invoke the operation
            NetAppBackupVaultBackupPatch patch = new NetAppBackupVaultBackupPatch();
            ArmOperation<NetAppBackupVaultBackupResource> lro = await netAppBackupVaultBackup.UpdateAsync(WaitUntil.Completed, patch);
            NetAppBackupVaultBackupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppBackupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // BackupsUnderBackupVault_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_BackupsUnderBackupVaultDelete()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-03-01/examples/BackupsUnderBackupVault_Delete.json
            // this example is just showing the usage of "Backups_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppBackupVaultBackupResource created on azure
            // for more information of creating NetAppBackupVaultBackupResource, please refer to the document of NetAppBackupVaultBackupResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "resourceGroup";
            string accountName = "account1";
            string backupVaultName = "backupVault1";
            string backupName = "backup1";
            ResourceIdentifier netAppBackupVaultBackupResourceId = NetAppBackupVaultBackupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, backupVaultName, backupName);
            NetAppBackupVaultBackupResource netAppBackupVaultBackup = client.GetNetAppBackupVaultBackupResource(netAppBackupVaultBackupResourceId);

            // invoke the operation
            await netAppBackupVaultBackup.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Backups_SingleFileRestore
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RestoreFilesBackupsUnderBackupVault_BackupsSingleFileRestore()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-03-01/examples/BackupsUnderBackupVault_SingleFileRestore.json
            // this example is just showing the usage of "BackupsUnderBackupVault_RestoreFiles" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppBackupVaultBackupResource created on azure
            // for more information of creating NetAppBackupVaultBackupResource, please refer to the document of NetAppBackupVaultBackupResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string backupVaultName = "backupVault1";
            string backupName = "backup1";
            ResourceIdentifier netAppBackupVaultBackupResourceId = NetAppBackupVaultBackupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, backupVaultName, backupName);
            NetAppBackupVaultBackupResource netAppBackupVaultBackup = client.GetNetAppBackupVaultBackupResource(netAppBackupVaultBackupResourceId);

            // invoke the operation
            NetAppVolumeBackupBackupRestoreFilesContent content = new NetAppVolumeBackupBackupRestoreFilesContent(new string[]
            {
"/dir1/customer1.db","/dir1/customer2.db"
            }, new ResourceIdentifier("/subscriptions/D633CC2E-722B-4AE1-B636-BBD9E4C60ED9/resourceGroups/myRG/providers/Microsoft.NetApp/netAppAccounts/account1/capacityPools/pool1/volumes/volume1"));
            await netAppBackupVaultBackup.RestoreFilesBackupsUnderBackupVaultAsync(WaitUntil.Completed, content);

            Console.WriteLine($"Succeeded");
        }
    }
}
