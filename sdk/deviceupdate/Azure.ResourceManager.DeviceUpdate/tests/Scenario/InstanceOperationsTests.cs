﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.DeviceUpdate.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.DeviceUpdate.Tests
{
    public class InstanceOperationsTests : DeviceUpdateManagementTestBase
    {
        public InstanceOperationsTests(bool isAsync)
            : base(isAsync)//, RecordedTestMode.Record)
        {
        }

        [TestCase]
        [RecordedTest]
        public async Task Delete()
        {
            Subscription subscription = await Client.GetDefaultSubscriptionAsync();
            ResourceGroup rg = await CreateResourceGroup(subscription, "testRg-");
            string accountName = Recording.GenerateAssetName("Account-");
            DeviceUpdateAccount account = await CreateAccount(rg, accountName);
            string instanceName = Recording.GenerateAssetName("Instance-");
            DeviceUpdateInstance instance = await CreateInstance(account, instanceName);
            await instance.DeleteAsync(WaitUntil.Completed);
            var ex = Assert.ThrowsAsync<RequestFailedException>(async () => await instance.GetAsync());
            Assert.AreEqual(404, ex.Status);
        }

        [TestCase]
        [RecordedTest]
        public async Task AddTag()
        {
            Subscription subscription = await Client.GetDefaultSubscriptionAsync();
            ResourceGroup rg = await CreateResourceGroup(subscription, "testRg-");
            string accountName = Recording.GenerateAssetName("Account-");
            DeviceUpdateAccount account = await CreateAccount(rg, accountName);
            string instanceName = Recording.GenerateAssetName("Instance-");
            DeviceUpdateInstance instance = await CreateInstance(account, instanceName);
            string key = "newTag", value = "newValue";
            DeviceUpdateInstance updatedInstance = await instance.AddTagAsync(key, value);
            CollectionAssert.AreEquivalent(new Dictionary<string, string> { { key, value } }, updatedInstance.Data.Tags);
        }
    }
}
