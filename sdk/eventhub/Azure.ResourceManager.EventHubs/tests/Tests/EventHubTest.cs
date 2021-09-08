﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Azure.ResourceManager.Resources;
using Azure.Core.TestFramework;
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.EventHubs;
using Azure.ResourceManager.EventHubs.Tests.Helpers;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.EventHubs.Tests.Tests
{
    public class EventHubTest: EventHubTestBase
    {
        private ResourceGroup _resourceGroup;
        public EventHubTest(bool isAsync) : base(isAsync)
        {
        }
        [Test]
        [RecordedTest]
        public async Task CreateEventHub()
        {
            //create storage account
            string namespaceName = Recording.GenerateAssetName("namespace");
            _resourceGroup = await CreateResourceGroupAsync();
            EHNamespaceContainer container = _resourceGroup.GetEHNamespaces();
            EHNamespace eHNamespace=(await container.CreateOrUpdateAsync(namespaceName, new EHNamespaceData(DefaultLocation))).Value;

            //
            await eHNamespace.DeleteAsync();
        }
    }
}
