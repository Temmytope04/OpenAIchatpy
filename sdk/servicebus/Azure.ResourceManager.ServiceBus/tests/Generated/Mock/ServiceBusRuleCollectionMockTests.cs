// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure;
using Azure.Core.TestFramework;
using Azure.ResourceManager.ServiceBus;
using Azure.ResourceManager.ServiceBus.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.ServiceBus.Tests.Mock
{
    /// <summary> Test for ServiceBusRuleCollection. </summary>
    public partial class ServiceBusRuleCollectionMockTests : MockTestBase
    {
        public ServiceBusRuleCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate_RulesCreateCorrelationFilter()
        {
            // Example: RulesCreateCorrelationFilter

            var serviceBusSubscriptionResourceId = ServiceBus.ServiceBusSubscriptionResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroupName", "sdk-Namespace-1319", "sdk-Topics-2081", "sdk-Subscriptions-8691");
            var serviceBusSubscriptionResource = GetArmClient().GetServiceBusSubscriptionResource(serviceBusSubscriptionResourceId);
            var collection = serviceBusSubscriptionResource.GetServiceBusRules();
            await collection.CreateOrUpdateAsync(WaitUntil.Completed, "sdk-Rules-6571", new ServiceBusRuleData()
            {
                FilterType = ServiceBusFilterType.CorrelationFilter,
                CorrelationFilter = new ServiceBusCorrelationFilter()
                {
                    ApplicationProperties =
{
["topicHint"] = "Crop",
},
                },
            });
        }

        [RecordedTest]
        public async Task CreateOrUpdate_RulesCreateOrUpdate()
        {
            // Example: RulesCreateOrUpdate

            var serviceBusSubscriptionResourceId = ServiceBus.ServiceBusSubscriptionResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroupName", "sdk-Namespace-1319", "sdk-Topics-2081", "sdk-Subscriptions-8691");
            var serviceBusSubscriptionResource = GetArmClient().GetServiceBusSubscriptionResource(serviceBusSubscriptionResourceId);
            var collection = serviceBusSubscriptionResource.GetServiceBusRules();
            await collection.CreateOrUpdateAsync(WaitUntil.Completed, "sdk-Rules-6571", new ServiceBusRuleData());
        }

        [RecordedTest]
        public async Task CreateOrUpdate_RulesCreateSqlFilter()
        {
            // Example: RulesCreateSqlFilter

            var serviceBusSubscriptionResourceId = ServiceBus.ServiceBusSubscriptionResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroupName", "sdk-Namespace-1319", "sdk-Topics-2081", "sdk-Subscriptions-8691");
            var serviceBusSubscriptionResource = GetArmClient().GetServiceBusSubscriptionResource(serviceBusSubscriptionResourceId);
            var collection = serviceBusSubscriptionResource.GetServiceBusRules();
            await collection.CreateOrUpdateAsync(WaitUntil.Completed, "sdk-Rules-6571", new ServiceBusRuleData()
            {
                FilterType = ServiceBusFilterType.SqlFilter,
                SqlFilter = new ServiceBusSqlFilter()
                {
                    SqlExpression = "myproperty=test",
                },
            });
        }

        [RecordedTest]
        public async Task Exists()
        {
            // Example: RulesGet

            var serviceBusSubscriptionResourceId = ServiceBus.ServiceBusSubscriptionResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ArunMonocle", "sdk-Namespace-1319", "sdk-Topics-2081", "sdk-Subscriptions-8691");
            var serviceBusSubscriptionResource = GetArmClient().GetServiceBusSubscriptionResource(serviceBusSubscriptionResourceId);
            var collection = serviceBusSubscriptionResource.GetServiceBusRules();
            await collection.ExistsAsync("sdk-Rules-6571");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: RulesGet

            var serviceBusSubscriptionResourceId = ServiceBus.ServiceBusSubscriptionResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ArunMonocle", "sdk-Namespace-1319", "sdk-Topics-2081", "sdk-Subscriptions-8691");
            var serviceBusSubscriptionResource = GetArmClient().GetServiceBusSubscriptionResource(serviceBusSubscriptionResourceId);
            var collection = serviceBusSubscriptionResource.GetServiceBusRules();
            await collection.GetAsync("sdk-Rules-6571");
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: RulesListBySubscriptions

            var serviceBusSubscriptionResourceId = ServiceBus.ServiceBusSubscriptionResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ArunMonocle", "sdk-Namespace-1319", "sdk-Topics-2081", "sdk-Subscriptions-8691");
            var serviceBusSubscriptionResource = GetArmClient().GetServiceBusSubscriptionResource(serviceBusSubscriptionResourceId);
            var collection = serviceBusSubscriptionResource.GetServiceBusRules();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
