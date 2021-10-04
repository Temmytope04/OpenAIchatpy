﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
#region Snippet:ChangeLog_Sample
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.EventHubs.Models;

#if !SNIPPET
using NUnit.Framework;

namespace Azure.ResourceManager.EventHubs.Tests.Samples
{
    public class ChangeLog
    {
        [Test]
        [Ignore("Only verifying that the sample builds")]
        public void ChangelogSample()
        {
#endif
string namespaceName = "myNamespace";
string eventhubName = "myEventhub";
string resourceGroupName = "myResourceGroup";
ArmClient client = new ArmClient(new DefaultAzureCredential());
ResourceGroup resourceGroup = client.DefaultSubscription.GetResourceGroups().Get(resourceGroupName);
//create namespace
EHNamespaceData parameters = new EHNamespaceData(Location.WestUS)
{
    Sku = new Sku(SkuName.Standard)
    {
        Tier = SkuTier.Standard,
    }
};
parameters.Tags.Add("tag1", "value1");
parameters.Tags.Add("tag2", "value2");
EHNamespaceContainer eHNamespaceContainer = resourceGroup.GetEHNamespaces();
EHNamespace eHNamespace = eHNamespaceContainer.CreateOrUpdate(namespaceName, parameters).Value;

//create eventhub
EventhubContainer eventhubContainer = eHNamespace.GetEventhubs();
EventhubData eventhubData = new EventhubData()
{
    MessageRetentionInDays = 4,
    PartitionCount = 4,
    Status = EntityStatus.Active,
    CaptureDescription = new CaptureDescription()
    {
        Enabled = true,
        Encoding = EncodingCaptureDescription.Avro,
        IntervalInSeconds = 120,
        SizeLimitInBytes = 10485763,
        Destination = new Destination()
        {
            Name = "EventHubArchive.AzureBlockBlob",
            BlobContainer = "container",
            ArchiveNameFormat = "{Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}",
            StorageAccountResourceId = client.DefaultSubscription.Id.ToString() + "/resourcegroups/v-ajnavtest/providers/Microsoft.Storage/storageAccounts/testingsdkeventhubnew"
        },
        SkipEmptyArchives = true
    }
};
Eventhub eventhub = eventhubContainer.CreateOrUpdate(eventhubName, eventhubData).Value;
            #endregion
        }
    }
}
