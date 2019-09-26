﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Reflection;

namespace Azure.Core.Pipeline
{
    public static class HttpPipelineBuilder
    {
        public static HttpPipeline Build(ClientOptions options, params HttpPipelinePolicy[] perRetryClientPolicies)
        {
            return Build(options, Array.Empty<HttpPipelinePolicy>(), perRetryClientPolicies, new ResponseClassifier());
        }

        public static HttpPipeline Build(ClientOptions options, HttpPipelinePolicy[] perCallClientPolicies, HttpPipelinePolicy[] perRetryClientPolicies, ResponseClassifier responseClassifier)
        {
            if (perCallClientPolicies == null)
            {
                throw new ArgumentNullException(nameof(perCallClientPolicies));
            }

            if (perRetryClientPolicies == null)
            {
                throw new ArgumentNullException(nameof(perRetryClientPolicies));
            }

            var policies = new List<HttpPipelinePolicy>();

            bool isDistributedTracingEnabled = options.Diagnostics.IsDistributedTracingEnabled;

            policies.AddRange(perCallClientPolicies);

            policies.AddRange(options.PerCallPolicies);

            policies.Add(ClientRequestIdPolicy.Shared);

            DiagnosticsOptions diagnostics = options.Diagnostics;
            if (diagnostics.IsTelemetryEnabled)
            {
                policies.Add(CreateTelemetryPolicy(options));
            }

            RetryOptions retryOptions = options.Retry;
            policies.Add(new RetryPolicy(retryOptions.Mode, retryOptions.Delay, retryOptions.MaxDelay, retryOptions.MaxRetries));

            policies.AddRange(perRetryClientPolicies);

            policies.AddRange(options.PerRetryPolicies);

            if (diagnostics.IsLoggingEnabled)
            {
                policies.Add(new LoggingPolicy(diagnostics.IsLoggingContentEnabled, diagnostics.ContentLoggingSizeLimit));
            }

            policies.Add(BufferResponsePolicy.Shared);

            policies.Add(new RequestActivityPolicy(isDistributedTracingEnabled));

            policies.RemoveAll(policy => policy == null);

            return new HttpPipeline(options.Transport,
                policies.ToArray(),
                responseClassifier,
                new ClientDiagnostics(isDistributedTracingEnabled));
        }

        // internal for testing
        internal static TelemetryPolicy CreateTelemetryPolicy(ClientOptions options)
        {
            const string PackagePrefix = "Azure.";

            Assembly clientAssembly = options.GetType().Assembly;

            AssemblyInformationalVersionAttribute versionAttribute = clientAssembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            if (versionAttribute == null)
            {
                throw new InvalidOperationException($"{nameof(AssemblyInformationalVersionAttribute)} is required on client SDK assembly '{clientAssembly.FullName}' (inferred from the use of options type '{options.GetType().FullName}').");
            }

            string version = versionAttribute.InformationalVersion;

            string assemblyName = clientAssembly.GetName().Name;
            if (assemblyName.StartsWith(PackagePrefix, StringComparison.Ordinal))
            {
                assemblyName = assemblyName.Substring(PackagePrefix.Length);
            }

            return new TelemetryPolicy(assemblyName, version, options.Diagnostics.ApplicationId);
        }
    }
}
