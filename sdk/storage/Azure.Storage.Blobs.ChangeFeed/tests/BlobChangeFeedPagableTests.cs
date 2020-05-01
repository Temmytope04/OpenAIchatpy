// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Azure.Core.Testing;
using Azure.Storage.Blobs.ChangeFeed.Models;
using NUnit.Framework;

namespace Azure.Storage.Blobs.ChangeFeed.Tests
{
    public class BlobChangeFeedPagableTests : ChangeFeedTestBase
    {
        public BlobChangeFeedPagableTests(bool async)
            : base(async, null /* RecordedTestMode.Record /* to re-record */)
        {
        }

        [Test]
        [Ignore("")]
        public void Test()
        {
            BlobServiceClient service = GetServiceClient_SharedKey();
            BlobChangeFeedClient blobChangeFeedClient = service.GetChangeFeedClient();
            BlobChangeFeedPagable blobChangeFeedPagable
                = blobChangeFeedClient.GetChanges();
            IList<BlobChangeFeedEvent> list = blobChangeFeedPagable.ToList();
            foreach (BlobChangeFeedEvent e in list)
            {
                Console.WriteLine(e);
            }
        }
    }
}
