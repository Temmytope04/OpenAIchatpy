﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Analytics.Synapse.ManagedPrivateEndpoints;
using Azure.Core.TestFramework;
using NUnit.Framework;
using System;
using System.IO;

namespace Azure.Analytics.Synapse.Tests.ManagedPrivateEndpoints
{
    [NonParallelizable]
    public abstract class ManagedPrivateEndpointsClientTestBase : RecordedTestBase<SynapseTestEnvironment>
    {
        public ManagedPrivateEndpointsClient ManagedPrivateEndpointsClient { get; set; }

        protected ManagedPrivateEndpointsClientTestBase(bool isAsync) : base(isAsync)
        {
        }

        public override void StartTestRecording()
        {
            base.StartTestRecording();

            ManagedPrivateEndpointsClient = CreateManagedPrivateEndpointsClient();
        }

        public override void StopTestRecording()
        {
            Recording.RewriteSessionRecords(GetSessionFilePath());
            Recording.ClearTextReplacementRules();
            base.StopTestRecording();
        }

        private string GetSessionFilePath(string name = null)
        {
            TestContext.TestAdapter testAdapter = TestContext.CurrentContext.Test;

            name ??= testAdapter.Name;

            string className = testAdapter.ClassName.Substring(testAdapter.ClassName.LastIndexOf('.') + 1);
            string fileName = name + (IsAsync ? "Async" : string.Empty) + ".json";
            return Path.Combine(TestContext.CurrentContext.TestDirectory, "SessionRecords", className, fileName);
        }

        internal ManagedPrivateEndpointsClient CreateManagedPrivateEndpointsClient(TestRecording recording = null)
        {
            recording ??= Recording;
            return InstrumentClient(new ManagedPrivateEndpointsClient(
                new Uri(TestEnvironment.WorkspaceUrl),
                TestEnvironment.Credential,
                InstrumentClientOptions(new ManagedPrivateEndpointsClientOptions())));
        }
    }
}
