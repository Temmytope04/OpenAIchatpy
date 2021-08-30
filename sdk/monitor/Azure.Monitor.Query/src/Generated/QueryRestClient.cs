// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Monitor.Query.Models;

namespace Azure.Monitor.Query
{
    internal partial class QueryRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of QueryRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public QueryRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            this.endpoint = endpoint ?? new Uri("https://api.loganalytics.io/v1");
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetRequest(string workspaceId, string query, TimeSpan? timespan)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/workspaces/", false);
            uri.AppendPath(workspaceId, true);
            uri.AppendPath("/query", false);
            uri.AppendQuery("query", query, true);
            if (timespan != null)
            {
                uri.AppendQuery("timespan", timespan.Value, "P", true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Executes an Analytics query for data. </summary>
        /// <param name="workspaceId"> ID of the workspace. This is Workspace ID from the Properties blade in the Azure portal. </param>
        /// <param name="query"> The Analytics query. Learn more about the [Analytics query syntax](https://azure.microsoft.com/documentation/articles/app-insights-analytics-reference/). </param>
        /// <param name="timespan"> Optional. The timespan over which to query data. This is an ISO8601 time period value.  This timespan is applied in addition to any that are specified in the query expression. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceId"/> or <paramref name="query"/> is null. </exception>
        public async Task<Response<LogsQueryResult>> GetAsync(string workspaceId, string query, TimeSpan? timespan = null, CancellationToken cancellationToken = default)
        {
            if (workspaceId == null)
            {
                throw new ArgumentNullException(nameof(workspaceId));
            }
            if (query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }

            using var message = CreateGetRequest(workspaceId, query, timespan);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogsQueryResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LogsQueryResult.DeserializeLogsQueryResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Executes an Analytics query for data. </summary>
        /// <param name="workspaceId"> ID of the workspace. This is Workspace ID from the Properties blade in the Azure portal. </param>
        /// <param name="query"> The Analytics query. Learn more about the [Analytics query syntax](https://azure.microsoft.com/documentation/articles/app-insights-analytics-reference/). </param>
        /// <param name="timespan"> Optional. The timespan over which to query data. This is an ISO8601 time period value.  This timespan is applied in addition to any that are specified in the query expression. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceId"/> or <paramref name="query"/> is null. </exception>
        public Response<LogsQueryResult> Get(string workspaceId, string query, TimeSpan? timespan = null, CancellationToken cancellationToken = default)
        {
            if (workspaceId == null)
            {
                throw new ArgumentNullException(nameof(workspaceId));
            }
            if (query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }

            using var message = CreateGetRequest(workspaceId, query, timespan);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogsQueryResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LogsQueryResult.DeserializeLogsQueryResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateExecuteRequest(string workspaceId, QueryBody body, string prefer)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/workspaces/", false);
            uri.AppendPath(workspaceId, true);
            uri.AppendPath("/query", false);
            request.Uri = uri;
            if (prefer != null)
            {
                request.Headers.Add("Prefer", prefer);
            }
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(body);
            request.Content = content;
            return message;
        }

        /// <summary> Executes an Analytics query for data. [Here](https://dev.loganalytics.io/documentation/Using-the-API) is an example for using POST with an Analytics query. </summary>
        /// <param name="workspaceId"> ID of the workspace. This is Workspace ID from the Properties blade in the Azure portal. </param>
        /// <param name="body"> The Analytics query. Learn more about the [Analytics query syntax](https://azure.microsoft.com/documentation/articles/app-insights-analytics-reference/). </param>
        /// <param name="prefer"> Optional. The prefer header to set server timeout, query statistics and visualization information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceId"/> or <paramref name="body"/> is null. </exception>
        public async Task<Response<LogsQueryResult>> ExecuteAsync(string workspaceId, QueryBody body, string prefer = null, CancellationToken cancellationToken = default)
        {
            if (workspaceId == null)
            {
                throw new ArgumentNullException(nameof(workspaceId));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateExecuteRequest(workspaceId, body, prefer);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogsQueryResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LogsQueryResult.DeserializeLogsQueryResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Executes an Analytics query for data. [Here](https://dev.loganalytics.io/documentation/Using-the-API) is an example for using POST with an Analytics query. </summary>
        /// <param name="workspaceId"> ID of the workspace. This is Workspace ID from the Properties blade in the Azure portal. </param>
        /// <param name="body"> The Analytics query. Learn more about the [Analytics query syntax](https://azure.microsoft.com/documentation/articles/app-insights-analytics-reference/). </param>
        /// <param name="prefer"> Optional. The prefer header to set server timeout, query statistics and visualization information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceId"/> or <paramref name="body"/> is null. </exception>
        public Response<LogsQueryResult> Execute(string workspaceId, QueryBody body, string prefer = null, CancellationToken cancellationToken = default)
        {
            if (workspaceId == null)
            {
                throw new ArgumentNullException(nameof(workspaceId));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateExecuteRequest(workspaceId, body, prefer);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogsQueryResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LogsQueryResult.DeserializeLogsQueryResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateBatchRequest(BatchRequest body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/$batch", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(body);
            request.Content = content;
            return message;
        }

        /// <summary> Executes a batch of Analytics queries for data. [Here](https://dev.loganalytics.io/documentation/Using-the-API) is an example for using POST with an Analytics query. </summary>
        /// <param name="body"> The batch request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public async Task<Response<LogsBatchQueryResults>> BatchAsync(BatchRequest body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateBatchRequest(body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogsBatchQueryResults value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LogsBatchQueryResults.DeserializeLogsBatchQueryResults(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Executes a batch of Analytics queries for data. [Here](https://dev.loganalytics.io/documentation/Using-the-API) is an example for using POST with an Analytics query. </summary>
        /// <param name="body"> The batch request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public Response<LogsBatchQueryResults> Batch(BatchRequest body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateBatchRequest(body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogsBatchQueryResults value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LogsBatchQueryResults.DeserializeLogsBatchQueryResults(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
