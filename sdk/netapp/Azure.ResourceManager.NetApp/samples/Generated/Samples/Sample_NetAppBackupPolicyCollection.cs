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
using Azure.ResourceManager.NetApp;

namespace Azure.ResourceManager.NetApp.Samples
{
    public partial class Sample_NetAppBackupPolicyCollection
    {
        // Backups_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_BackupsList()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2022-09-01/examples/BackupPolicies_List.json
            // this example is just showing the usage of "BackupPolicies_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // get the collection of this NetAppBackupPolicyResource
            NetAppBackupPolicyCollection collection = netAppAccount.GetNetAppBackupPolicies();

            // invoke the operation and iterate over the result
            await foreach (NetAppBackupPolicyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetAppBackupPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Backups_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_BackupsGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2022-09-01/examples/BackupPolicies_Get.json
            // this example is just showing the usage of "BackupPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // get the collection of this NetAppBackupPolicyResource
            NetAppBackupPolicyCollection collection = netAppAccount.GetNetAppBackupPolicies();

            // invoke the operation
            string backupPolicyName = "backupPolicyName";
            NetAppBackupPolicyResource result = await collection.GetAsync(backupPolicyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppBackupPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Backups_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_BackupsGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2022-09-01/examples/BackupPolicies_Get.json
            // this example is just showing the usage of "BackupPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // get the collection of this NetAppBackupPolicyResource
            NetAppBackupPolicyCollection collection = netAppAccount.GetNetAppBackupPolicies();

            // invoke the operation
            string backupPolicyName = "backupPolicyName";
            bool result = await collection.ExistsAsync(backupPolicyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // BackupPolicies_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_BackupPoliciesCreate()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2022-09-01/examples/BackupPolicies_Create.json
            // this example is just showing the usage of "BackupPolicies_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // get the collection of this NetAppBackupPolicyResource
            NetAppBackupPolicyCollection collection = netAppAccount.GetNetAppBackupPolicies();

            // invoke the operation
            string backupPolicyName = "backupPolicyName";
            NetAppBackupPolicyData data = new NetAppBackupPolicyData(new AzureLocation("westus"))
            {
                DailyBackupsToKeep = 10,
                WeeklyBackupsToKeep = 10,
                MonthlyBackupsToKeep = 10,
                IsEnabled = true,
            };
            ArmOperation<NetAppBackupPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, backupPolicyName, data);
            NetAppBackupPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppBackupPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
