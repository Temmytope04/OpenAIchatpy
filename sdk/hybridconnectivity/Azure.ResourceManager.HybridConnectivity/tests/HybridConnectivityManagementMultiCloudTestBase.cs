// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;
using System.Threading.Tasks;
using System;
using Azure.Identity;
using Azure.ResourceManager.HybridConnectivity.Models;
using Azure.ResourceManager.Models;
using System.Collections.Generic;
using System.Xml;
using Castle.Components.DictionaryAdapter.Xml;

namespace Azure.ResourceManager.HybridConnectivity.Tests
{
    public class HybridConnectivityManagementMultiCloudTestBase : ManagementRecordedTestBase<hybridconnectivityManagementTestEnvironment>
    {
        public ArmClient ArmClient { get; private set; }

        public ResourceIdentifier resourceGroupResourceId { get; set; }

        public ResourceGroupResource resourceGroupResource { get; set; }

        public PublicCloudConnectorCollection publicCloudConnectorCollection { get; set; }

        public SubscriptionResource Subscription { get; set; }

        public string subscriptionId = "1c70e365-4937-4ff9-8524-262064a268d8";

        public string resourceGroupName = "MultiCloudSDKTestRG";

        public HybridConnectivityManagementMultiCloudTestBase(bool isAsync) : base(isAsync) { }

        protected HybridConnectivityManagementMultiCloudTestBase(bool isAsync, RecordedTestMode mode) : base(isAsync, mode) { }

        [SetUp]
        public void CreateCommonClient()
        {
            ArmClient = GetArmClient();
        }

        protected async Task InitializeClients()
        {
            Subscription = await ArmClient.GetDefaultSubscriptionAsync();
            resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            resourceGroupResource = ArmClient.GetResourceGroupResource(resourceGroupResourceId);

            //publicCloudConnectorCollection = resourceGroupResource.GetPublicCloudConnectors();
        }
    }
}
