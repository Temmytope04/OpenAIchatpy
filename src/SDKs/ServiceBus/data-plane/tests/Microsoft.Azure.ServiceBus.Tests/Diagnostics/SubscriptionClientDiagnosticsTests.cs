﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.ServiceBus.UnitTests.Diagnostics
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Threading.Tasks;
    using Xunit;

    public class SubscriptionClientDiagnosticsTests : DiagnosticsTests
    {
        private SubscriptionClient subscriptionClient;
        private bool disposed;

        [LiveFact]
        [DisplayTestMethodName]
        async Task AddRemoveGetFireEvents()
        {
            await ServiceBusScope.UsingTopicAsync(partitioned: false, sessionEnabled: false, async (topicName, subscriptionName) =>
            {
                var entityName = $"{topicName}/Subscriptions/{subscriptionName}";

                this.subscriptionClient = new SubscriptionClient(
                    TestUtility.NamespaceConnectionString,
                    topicName,
                    subscriptionName,
                    ReceiveMode.ReceiveAndDelete);

                this.listener.Enable((name, queue, id) => name.Contains("Rule"));

                var ruleName = Guid.NewGuid().ToString();
                await this.subscriptionClient.AddRuleAsync(ruleName, new TrueFilter());
                await this.subscriptionClient.GetRulesAsync();
                await this.subscriptionClient.RemoveRuleAsync(ruleName);

                Assert.True(this.events.TryDequeue(out var addRuleStart));
                AssertAddRuleStart(entityName, addRuleStart.eventName, addRuleStart.payload, addRuleStart.activity);

                Assert.True(this.events.TryDequeue(out var addRuleStop));
                AssertAddRuleStop(entityName, addRuleStop.eventName, addRuleStop.payload, addRuleStop.activity, addRuleStart.activity);

                Assert.True(this.events.TryDequeue(out var getRulesStart));
                AssertGetRulesStart(entityName, getRulesStart.eventName, getRulesStart.payload, getRulesStart.activity);

                Assert.True(this.events.TryDequeue(out var getRulesStop));
                AssertGetRulesStop(entityName, getRulesStop.eventName, getRulesStop.payload, getRulesStop.activity, getRulesStart.activity);

                Assert.True(this.events.TryDequeue(out var removeRuleStart));
                AssertRemoveRuleStart(entityName, removeRuleStart.eventName, removeRuleStart.payload, removeRuleStart.activity);

                Assert.True(this.events.TryDequeue(out var removeRuleStop));
                AssertRemoveRuleStop(entityName, removeRuleStop.eventName, removeRuleStop.payload, removeRuleStop.activity, removeRuleStart.activity);

                Assert.True(this.events.IsEmpty);
            });
        }

        [LiveFact]
        [DisplayTestMethodName]
        async Task EventsAreNotFiredWhenDiagnosticsIsDisabled()
        {
            await ServiceBusScope.UsingTopicAsync(partitioned: false, sessionEnabled: false, async (topicName, subscriptionName) =>
            {
                this.subscriptionClient = new SubscriptionClient(
                    TestUtility.NamespaceConnectionString,
                    topicName,
                    subscriptionName,
                    ReceiveMode.ReceiveAndDelete);

                this.listener.Disable();

                var ruleName = Guid.NewGuid().ToString();
                await this.subscriptionClient.AddRuleAsync(ruleName, new TrueFilter());
                await this.subscriptionClient.GetRulesAsync();
                await this.subscriptionClient.RemoveRuleAsync(ruleName);

                Assert.True(this.events.IsEmpty);
            });
        }

        protected override void Dispose(bool disposing)
        {
            if (this.disposed)
            {
                return;
            }

            if (disposing)
            {
                this.subscriptionClient?.CloseAsync().Wait(TimeSpan.FromSeconds(maxWaitSec));
            }

            this.disposed = true;

            base.Dispose(disposing);
        }

        protected void AssertAddRuleStart(string entityName, string eventName, object payload, Activity activity)
        {
            Assert.Equal("Microsoft.Azure.ServiceBus.AddRule.Start", eventName);
            AssertCommonPayloadProperties(entityName, payload);
            GetPropertyValueFromAnonymousTypeInstance<RuleDescription>(payload, "Rule");
            Assert.NotNull(activity);
            Assert.Null(activity.Parent);
        }

        protected void AssertAddRuleStop(string entityName, string eventName, object payload, Activity activity, Activity addRuleActivity)
        {
            Assert.Equal("Microsoft.Azure.ServiceBus.AddRule.Stop", eventName);
            AssertCommonStopPayloadProperties(entityName, payload);
            GetPropertyValueFromAnonymousTypeInstance<RuleDescription>(payload, "Rule");

            if (addRuleActivity != null)
            {
                Assert.Equal(addRuleActivity, activity);
            }
        }

        protected void AssertGetRulesStart(string entityName, string eventName, object payload, Activity activity)
        {
            Assert.Equal("Microsoft.Azure.ServiceBus.GetRules.Start", eventName);
            AssertCommonPayloadProperties(entityName, payload);
            Assert.NotNull(activity);
            Assert.Null(activity.Parent);
        }

        protected void AssertGetRulesStop(string entityName, string eventName, object payload, Activity activity, Activity getRulesActivity)
        {
            Assert.Equal("Microsoft.Azure.ServiceBus.GetRules.Stop", eventName);
            
            AssertCommonStopPayloadProperties(entityName, payload);
            GetPropertyValueFromAnonymousTypeInstance<IEnumerable<RuleDescription>>(payload, "Rules");

            if (getRulesActivity != null)
            {
                Assert.Equal(getRulesActivity, activity);
            }
        }

        protected void AssertRemoveRuleStart(string entityName, string eventName, object payload, Activity activity)
        {
            Assert.Equal("Microsoft.Azure.ServiceBus.RemoveRule.Start", eventName);
            AssertCommonPayloadProperties(entityName, payload);
            GetPropertyValueFromAnonymousTypeInstance<string>(payload, "RuleName");
            Assert.NotNull(activity);
            Assert.Null(activity.Parent);
        }

        protected void AssertRemoveRuleStop(string entityName, string eventName, object payload, Activity activity, Activity removeRuleActivity)
        {
            Assert.Equal("Microsoft.Azure.ServiceBus.RemoveRule.Stop", eventName);

            AssertCommonStopPayloadProperties(entityName, payload);
            GetPropertyValueFromAnonymousTypeInstance<string>(payload, "RuleName");

            if (removeRuleActivity != null)
            {
                Assert.Equal(removeRuleActivity, activity);
            }
        }
    }
}
