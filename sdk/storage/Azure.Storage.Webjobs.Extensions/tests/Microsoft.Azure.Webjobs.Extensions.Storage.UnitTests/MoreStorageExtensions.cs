﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Azure.Storage.Queues;
using Azure.Storage.Blobs.Specialized;
using Azure.Storage.Blobs.Models;

namespace Microsoft.Azure.WebJobs
{
    internal static class MoreStorageExtensions
    {
        public static StorageAccount GetStorageAccount(this IHost host)
        {
            var provider = host.Services.GetRequiredService<StorageAccountProvider>(); // $$$ ok?
            return provider.GetHost();
        }

        public static async Task<QueueClient> CreateQueueAsync(this StorageAccount account, string queueName)
        {
            var client = account.CreateQueueServiceClient();
            var queue = client.GetQueueClient(queueName);
            await queue.CreateIfNotExistsAsync();
            return queue;
        }

        public static IWebJobsBuilder UseStorage(this IWebJobsBuilder builder, StorageAccount account)
        {
            builder.AddAzureStorage();
            builder.Services.Add(ServiceDescriptor.Singleton<StorageAccountProvider>(new FakeStorageAccountProvider(account)));

            return builder;
        }

        public static string DownloadText(this BlobBaseClient blobClient, CancellationToken cancellationToken = default)
        {
            using BlobDownloadInfo blobDownloadInfo = blobClient.Download(cancellationToken);
            using Stream stream = blobDownloadInfo.Content;
            using StreamReader streamReader = new StreamReader(stream);
            return streamReader.ReadToEnd();
        }

        public static async Task UploadEmptyPageAsync(this PageBlobClient blob)
        {
            if (blob == null)
            {
                throw new ArgumentNullException("blob");
            }

            await blob.UploadPagesAsync(new MemoryStream(), 0);
        }
    }
}
