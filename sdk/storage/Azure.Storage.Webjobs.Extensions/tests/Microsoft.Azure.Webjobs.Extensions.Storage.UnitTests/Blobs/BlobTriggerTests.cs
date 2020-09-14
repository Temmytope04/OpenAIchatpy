﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs.Host.TestCommon;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Xunit;
using Microsoft.Azure.WebJobs.Extensions.Storage.UnitTests;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Specialized;

namespace Microsoft.Azure.WebJobs.Host.FunctionalTests
{
    public class BlobTriggerTests : IClassFixture<AzuriteFixture>
    {
        private const string ContainerName = "container";
        private const string BlobName = "blob";
        private const string BlobPath = ContainerName + "/" + BlobName;
        private readonly AzuriteFixture azuriteFixture;

        public BlobTriggerTests(AzuriteFixture azuriteFixture)
        {
            this.azuriteFixture = azuriteFixture;
        }

        [AzuriteFact]
        public async Task BlobTrigger_IfBoundToCloudBlob_Binds()
        {
            // Arrange
            var account = CreateFakeStorageAccount();
            var container = CreateContainer(account, ContainerName);
            var blob = container.GetBlockBlobClient(BlobName);

            await blob.UploadTextAsync("ignore");

            // Act
            BlobBaseClient result = await RunTriggerAsync<BlobBaseClient>(account, typeof(BindToCloudBlobProgram),
                (s) => BindToCloudBlobProgram.TaskSource = s);

            // Assert
            Assert.Equal(blob.Uri, result.Uri);
        }

        private class BindToCloudBlobProgram
        {
            public static TaskCompletionSource<BlobBaseClient> TaskSource { get; set; }

            public static void Run([BlobTrigger(BlobPath)] BlobBaseClient blob) // TODO (kasobol-msft how about binding to BlobClient??
            {
                TaskSource.TrySetResult(blob);
            }
        }

        [AzuriteFact]
        public async Task BlobTrigger_Binding_Metadata()
        {
            var app = new BindToCloudBlob2Program();
            var activator = new FakeActivator(app);
            var account = CreateFakeStorageAccount();
            var provider = new FakeStorageAccountProvider(account);
            var host = new HostBuilder()
                .ConfigureDefaultTestHost<BindToCloudBlob2Program>(b =>
                {
                    b.AddAzureStorage();
                })
                .ConfigureServices(services =>
                {
                    services.AddSingleton<IJobActivator>(activator);
                    services.AddSingleton<StorageAccountProvider>(provider);
                })
                .Build();

            // Set the binding data, and verify it's accessible in the function.
            var container = CreateContainer(account, ContainerName);
            var blob = container.GetBlockBlobClient(BlobName);
            await blob.UploadTextAsync(string.Empty);
            await blob.SetMetadataAsync(new Dictionary<string, string> { { "m1", "v1" } });

            await host.GetJobHost().CallAsync(typeof(BindToCloudBlob2Program).GetMethod(nameof(BindToCloudBlob2Program.Run)), new { blob });

            Assert.True(app.Success);
        }

        private class BindToCloudBlob2Program
        {
            public bool Success;
            public void Run(
                [BlobTrigger(BlobPath)] BlobBaseClient blob,
                [Blob("container/{metadata.m1}")] BlobBaseClient blob1
                )
            {
                Assert.Equal("v1", blob1.Name);
                this.Success = true;
            }
        }

        private static BlobContainerClient CreateContainer(StorageAccount account, string containerName)
        {
            var client = account.CreateBlobServiceClient();
            var container = client.GetBlobContainerClient(containerName);
            container.CreateIfNotExistsAsync().GetAwaiter().GetResult();
            return container;
        }

        private StorageAccount CreateFakeStorageAccount()
        {
            var account = StorageAccount.NewFromConnectionString(azuriteFixture.GetAccount().ConnectionString);

            // make sure our system containers are present
            var container = CreateContainer(account, "azure-webjobs-hosts");

            return account;
        }

        private static async Task<TResult> RunTriggerAsync<TResult>(StorageAccount account, Type programType,
            Action<TaskCompletionSource<TResult>> setTaskSource)
        {
            return await FunctionalTest.RunTriggerAsync<TResult>(account, programType, setTaskSource);
        }

        private static async Task<TResult> RunTriggerAsync<TResult>(StorageAccount account, Type programType,
            Action<TaskCompletionSource<TResult>> setTaskSource, IEnumerable<string> ignoreFailureFunctions)
        {
            return await FunctionalTest.RunTriggerAsync<TResult>(account, programType, setTaskSource, ignoreFailureFunctions);
        }
    }
}
