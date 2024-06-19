﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Primitives;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using ClientModel.Tests;
using ClientModel.Tests.Mocks;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using SyncAsyncTestBase = ClientModel.Tests.SyncAsyncTestBase;

namespace System.ClientModel.Tests.Pipeline;

public class ClientLoggingPolicyTests : SyncAsyncTestBase
{
    private const int RequestEvent = 1;
    private const int RequestContentEvent = 2;
    private const int RequestContentTextEvent = 17;
    private const int ResponseEvent = 5;
    private const int ResponseContentEvent = 6;
    private const int ResponseContentBlockEvent = 11;
    private const int ErrorResponseEvent = 8;
    private const int ErrorResponseContentEvent = 9;
    private const int ErrorResponseContentBlockEvent = 12;
    private const int ResponseContentTextEvent = 13;
    private const int ResponseContentTextBlockEvent = 15;
    private const int ErrorResponseContentTextEvent = 14;
    private const int ErrorResponseContentTextBlockEvent = 16;
    private const int ExceptionResponseEvent = 18;

    private ILoggerFactory _loggerFactory;

    public ClientLoggingPolicyTests(bool isAsync) : base(isAsync)
    {
        _loggerFactory = new TestLoggingFactory();
    }

    [Test]
    public async Task SendingRequestLogs()
    {
        using TestEventListenerVerbose listener = new();

        var headers = new MockResponseHeaders(new Dictionary<string, string> { { "Custom-Response-Header", "Value" } });
        var response = new MockPipelineResponse(200, mockHeaders: headers);
        response.SetContent("World.");

        ClientPipelineOptions options = new()
        {
            Transport = new MockPipelineTransport("Transport", i => response),
            LoggingOptions = new LoggingOptions()
            {
                LoggerFactory = _loggerFactory
            }
        };

        ClientPipeline pipeline = ClientPipeline.Create(options);

        PipelineMessage message = pipeline.CreateMessage();
        message.Request.Method = "GET";
        message.Request.Uri = new Uri("http://example.com");
        message.Request.Headers.Add("Custom-Header", "Value");
        message.Request.Headers.Add("Date", "3/28/2024");
        message.Request.Content = BinaryContent.Create(new BinaryData("Hello"));

        await pipeline.SendSyncOrAsync(message, IsAsync);
    }

    #region Helpers

    // In order to test listeners with different event levels, each case has to has its own listener.
    // This is because the constructor does not necessarily finish before the callbacks are called, meaning that any runtime
    // configurations to event listener classes aren't reliably applied.
    // see: https://learn.microsoft.com/dotnet/api/system.diagnostics.tracing.eventlistener#remarks

    private class TestEventListenerWarning : TestEventListener
    {
        protected override void OnEventSourceCreated(EventSource eventSource)
        {
            if (eventSource.Name == "ClientModel.Tests.TestLoggingEventSource")
            {
                EnableEvents(eventSource, EventLevel.Warning);
            }
        }
    }

    private class TestEventListenerVerbose : TestEventListener
    {
        protected override void OnEventSourceCreated(EventSource eventSource)
        {
            if (eventSource.Name == "ClientModel.Tests.TestLoggingEventSource")
            {
                EnableEvents(eventSource, EventLevel.Verbose);
            }
        }
    }

    private class TestEventListener : EventListener
    {
        private volatile bool _disposed;
        private readonly ConcurrentQueue<EventWrittenEventArgs> _events = new();

        protected override void OnEventWritten(EventWrittenEventArgs eventData)
        {
            // See: https://github.com/dotnet/corefx/issues/42600
            if (eventData.EventId != -1 && !_disposed)
            {
                FormatPayload(eventData);
                _events.Enqueue(eventData);
            }
        }

        public EventWrittenEventArgs SingleEventById(int id, Func<EventWrittenEventArgs, bool>? filter = default) => EventsById(id).Single(filter ?? (_ => true));

        public IEnumerable<EventWrittenEventArgs> EventsById(int id) => _events.Where(e => e.EventId == id);

        public override void Dispose()
        {
            _disposed = true;
            base.Dispose();
        }

        private static string FormatPayload(EventWrittenEventArgs eventData)
        {
            if (eventData.Payload == null || eventData.Payload.Count == 0)
            {
                return string.Empty;
            }
            var payloadArray = eventData.Payload.ToArray();
            var loggerArgs =  payloadArray[payloadArray.Length];

            StringBuilder stringBuilder = new StringBuilder();
            if (loggerArgs is IReadOnlyList<KeyValuePair<string, string?>> arguments)
            {
                payloadArray = payloadArray.Take(payloadArray.Length - 1).ToArray();
                ProcessPayloadArray(payloadArray);

                stringBuilder = new StringBuilder();
                stringBuilder.Append(eventData.EventName);

                if (!string.IsNullOrWhiteSpace(eventData.Message))
                {
                    stringBuilder.AppendLine();
                    stringBuilder.Append(nameof(eventData.Message)).Append(" = ").Append(eventData.Message);
                }

                for (int i = 0; i < arguments.Count; i++)
                {
                    stringBuilder.AppendLine();
                    stringBuilder.Append(arguments[i].Key).Append(" = ").Append(arguments[i].Value);
                }

                return stringBuilder.ToString();
            }

            ProcessPayloadArray(payloadArray);

            if (eventData.Message != null)
            {
                try
                {
                    return string.Format(CultureInfo.InvariantCulture, eventData.Message, payloadArray);
                }
                catch (FormatException)
                {
                }
            }

            stringBuilder.Append(eventData.EventName);

            if (!string.IsNullOrWhiteSpace(eventData.Message))
            {
                stringBuilder.AppendLine();
                stringBuilder.Append(nameof(eventData.Message)).Append(" = ").Append(eventData.Message);
            }

            if (eventData.PayloadNames != null)
            {
                for (int i = 0; i < eventData.PayloadNames.Count; i++)
                {
                    stringBuilder.AppendLine();
                    stringBuilder.Append(eventData.PayloadNames[i]).Append(" = ").Append(payloadArray[i]);
                }
            }

            return stringBuilder.ToString();
        }

        private static void ProcessPayloadArray(object?[] payloadArray)
        {
            for (int i = 0; i < payloadArray.Length; i++)
            {
                payloadArray[i] = FormatValue(payloadArray[i]);
            }
        }

        private static object? FormatValue(object? o)
        {
            if (o is byte[] bytes)
            {
                var stringBuilder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "{0:X2}", b);
                }

                return stringBuilder.ToString();
            }
            return o;
        }
    }
    #endregion
}
