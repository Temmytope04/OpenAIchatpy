﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Core.TestFramework;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Storage.ConfidentialLedger.Tests
{
    public class ConfidentialLedgerClientLiveTests : RecordedTestBase<ConfidentialLedgerEnvironment>
    {
        private TokenCredential Credential;
        private ConfidentialLedgerClientOptions Options;
        private ConfidentialLedgerClient Client;

        public ConfidentialLedgerClientLiveTests(bool isAsync) : base(isAsync) { }

        [SetUp]
        public void Setup()
        {
            Credential = new AzureCliCredential();
            var httpHandler = new HttpClientHandler();
            httpHandler.ServerCertificateCustomValidationCallback = (_, _, _, _) => true;
            Options = new ConfidentialLedgerClientOptions { Transport = new HttpClientTransport(httpHandler) };
            Client = InstrumentClient(
                new ConfidentialLedgerClient(
                    TestEnvironment.ConfidentialLedgerUrl,
                    TestEnvironment.ConfidentialLedgerIdentityUrl,
                    Credential,
                    InstrumentClientOptions(Options)));
        }

        [RecordedTest]
        public async Task GetUser()
        {
            const string objId = "3c1303ad-140b-493c-ab45-bed8ddbfa72c";
            var result = await Client.GetUserAsync(objId);
            var stringResult = new StreamReader(result.ContentStream).ReadToEnd();

            Assert.That(stringResult, Does.Contain(objId));
        }

        [RecordedTest]
        public async Task GetLedgerEntries()
        {
            var result = await Client.GetLedgerEntriesAsync();

            var stringResult = new StreamReader(result.ContentStream).ReadToEnd();
        }
    }
}
