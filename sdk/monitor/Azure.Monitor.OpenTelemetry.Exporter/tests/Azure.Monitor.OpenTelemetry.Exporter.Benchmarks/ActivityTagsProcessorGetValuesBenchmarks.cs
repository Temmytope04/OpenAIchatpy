﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;

using Azure.Monitor.OpenTelemetry.Exporter.Internals;

using BenchmarkDotNet.Attributes;

/*
BenchmarkDotNet=v0.13.4, OS=Windows 11 (10.0.22621.1702)
Intel Core i7-8850H CPU 2.60GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.203
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


|                          Method |     Mean |   Error |  StdDev | Allocated |
|-------------------------------- |---------:|--------:|--------:|----------:|
| Benchmark_ActivityTagsProcessor | 262.0 ns | 2.51 ns | 2.10 ns |         - |
*/

namespace Azure.Monitor.OpenTelemetry.Exporter.Benchmarks
{
    [MemoryDiagnoser]
    public class ActivityTagsProcessorGetValuesBenchmarks
    {
        private Activity? _activity;
        private ActivityTagsProcessor _activityTagsProcessor;

        static ActivityTagsProcessorGetValuesBenchmarks()
        {
            Activity.DefaultIdFormat = ActivityIdFormat.W3C;
            Activity.ForceDefaultIdFormat = true;

            var listener = new ActivityListener
            {
                ShouldListenTo = _ => true,
                Sample = (ref ActivityCreationOptions<ActivityContext> options) => ActivitySamplingResult.AllData,
            };

            ActivitySource.AddActivityListener(listener);
        }

        [GlobalSetup]
        public void Setup()
        {
            IEnumerable<KeyValuePair<string, object?>> tagObjects = new Dictionary<string, object?>
            {
                [SemanticConventions.AttributeUrlScheme] = "https",
                [SemanticConventions.AttributeHttpRequestMethod] = "GET",
                [SemanticConventions.AttributeServerAddress] = "localhost",
                ["somekey"] = "value",
                [SemanticConventions.AttributeUrlPath] = "/path",
                [SemanticConventions.AttributeUrlQuery] = "?test",
                [SemanticConventions.AttributeUserAgentOriginal] = "userAgent",
                [SemanticConventions.AttributeHttpRoute] = "route",
                [SemanticConventions.AttributeHttpResponseStatusCode] = "200",
            };

            _activity = CreateTestActivity(tagObjects!);
            _activityTagsProcessor = new ActivityTagsProcessor();
            _activityTagsProcessor.CategorizeTags(_activity!);
        }

        [Benchmark]
        public void Benchmark_ActivityTagsProcessorGetValue()
        {
            var httpRoute = AzMonList.GetTagValue(ref _activityTagsProcessor.MappedTags, SemanticConventions.AttributeHttpRoute)?.ToString();
            var httpMethod = AzMonList.GetTagValue(ref _activityTagsProcessor.MappedTags, SemanticConventions.AttributeHttpRequestMethod)?.ToString();
        }

        [Benchmark]
        public void Benchmark_ActivityTagsProcessorGetValues()
        {
            var httpRouteAndMethod = AzMonList.GetTagValues(ref _activityTagsProcessor.MappedTags, SemanticConventions.AttributeHttpRequestMethod, SemanticConventions.AttributeHttpRoute);
        }

        private static Activity? CreateTestActivity(IEnumerable<KeyValuePair<string, object>>? additionalAttributes = null)
        {
            var startTimestamp = DateTime.UtcNow;
            var endTimestamp = startTimestamp.AddSeconds(60);
            var eventTimestamp = DateTime.UtcNow;
            var traceId = ActivityTraceId.CreateRandom();

            var parentSpanId = ActivitySpanId.CreateRandom();

            Dictionary<string, object>? attributes = null;
            if (additionalAttributes != null)
            {
                attributes = new Dictionary<string, object>();
                foreach (var attribute in additionalAttributes)
                {
                    attributes.Add(attribute.Key, attribute.Value);
                }
            }

            var activitySource = new ActivitySource(nameof(CreateTestActivity));

            var activity = activitySource.StartActivity(
                "Name",
                ActivityKind.Server,
                parentContext: new ActivityContext(traceId, parentSpanId, ActivityTraceFlags.Recorded),
                attributes!,
                null,
                startTime: startTimestamp);

            activity?.SetEndTime(endTimestamp);
            activity?.Stop();

            return activity;
        }
    }
}
