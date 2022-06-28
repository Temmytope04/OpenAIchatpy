﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Workloads.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace Azure.ResourceManager.Workloads.Tests.Tests
{
    public class PhpWorkloadsCRUDTests : WorkloadsManagementTestBase
    {
        private const string TestResourceNamePrefix = "sdk-tests-dotNet-php-";
        private readonly string BasePath = System.AppDomain.CurrentDomain.BaseDirectory;

        public PhpWorkloadsCRUDTests(bool isAsync) : base(isAsync)
        {
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            CleanupResourceGroups();
        }

        [RecordedTest]
        [Test]
        public async Task TestPhpWorkloadsCRUDOperations()
        {
            try
            {
                Resources.SubscriptionResource subscription = await Client.GetDefaultSubscriptionAsync();
                Resources.ResourceGroupResource rg = await CreateResourceGroup(
                    subscription,
                    TestResourceNamePrefix,
                    Core.AzureLocation.EastUS);

                var rgName = rg.Data.Name;

                var resourceJson = File.ReadAllText(
                    Path.Combine(BasePath, @"TestData\PhpWorkloads\PutPhpWorkload.json"));
                var json = JsonDocument.Parse(resourceJson).RootElement;

                var resourceData = PhpWorkloadResourceData.DeserializePhpWorkloadResourceData(json);

                resourceData.ManagedResourceGroupConfiguration = new ManagedRGConfiguration()
                {
                    Name = rgName + "-mrg"
                };

                resourceData.DatabaseProfile.ServerName = rgName.ToLower();
                resourceData.CacheProfile.Name = rgName;

                // Create

                ArmOperation<PhpWorkloadResource> createdResource =
                    await rg.GetPhpWorkloadResources().CreateOrUpdateAsync(
                        WaitUntil.Completed,
                        rgName,
                        resourceData);

                Assert.IsTrue(createdResource.Value.Data.ProvisioningState ==
                    Models.PhpWorkloadProvisioningState.Succeeded);

                Assert.AreEqual(rgName, createdResource.Value.Data.Name);

                // Read
                Response<PhpWorkloadResource> getResource = await rg.GetPhpWorkloadResourceAsync(rgName);
                Assert.IsNotNull(getResource);
                Assert.AreEqual(rgName, getResource.Value.Data.Name);

                // Update
                var tagsToUpdate = new Dictionary<string, string>()
                {
                    ["Test"] = "passed"
                };
                var updatePayloadJ = JObject.FromObject(getResource.Value.Data);
                updatePayloadJ.Merge(tagsToUpdate);
                PhpWorkloadResourceData updatePayload = updatePayloadJ.ToObject<PhpWorkloadResourceData>();
                ArmOperation<PhpWorkloadResource> updatedResource =
                    await rg.GetPhpWorkloadResources().CreateOrUpdateAsync(
                        WaitUntil.Completed,
                        rgName,
                        updatePayload);

                Assert.IsTrue(createdResource.Value.Data.ProvisioningState ==
                    Models.PhpWorkloadProvisioningState.Succeeded);

                Assert.AreEqual(rgName, createdResource.Value.Data.Name);
                Assert.AreEqual(updatePayload.Tags.Count, updatedResource.Value.Data.Tags.Count);
                Assert.IsFalse(updatedResource.Value.Data.Tags.Except(updatePayload.Tags).Any());

                // Delete
                getResource = await rg.GetPhpWorkloadResourceAsync(rgName);
                Assert.IsNotNull(getResource?.Value?.Data?.Name);
                Assert.AreEqual(rgName, getResource?.Value.Data.Name);
                await getResource.Value.DeleteAsync(WaitUntil.Completed);

                try
                {
                    Response<PhpWorkloadResource> getDeletedResoure =
                        await rg.GetPhpWorkloadResourceAsync(rgName);
                }
                catch (RequestFailedException ex) when (ex.Status == 404)
                {
                    Console.WriteLine($"PHP Workload {rgName} does not exist.");
                }
            }
            catch (Exception ex)
            {
                TestContext.Progress.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
