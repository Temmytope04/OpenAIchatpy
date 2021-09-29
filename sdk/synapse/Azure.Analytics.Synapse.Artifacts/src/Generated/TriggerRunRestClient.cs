// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    internal partial class TriggerRunRestClient
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of TriggerRunRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public TriggerRunRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion = "2019-06-01-preview")
        {
            this.endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateRerunTriggerInstanceRequest(string triggerName, string runId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/triggers/", false);
            uri.AppendPath(triggerName, true);
            uri.AppendPath("/triggerRuns/", false);
            uri.AppendPath(runId, true);
            uri.AppendPath("/rerun", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Rerun single trigger instance by runId. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="runId"> The pipeline run identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> or <paramref name="runId"/> is null. </exception>
        public async Task<Response> RerunTriggerInstanceAsync(string triggerName, string runId, CancellationToken cancellationToken = default)
        {
            if (triggerName == null)
            {
                throw new ArgumentNullException(nameof(triggerName));
            }
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }

            using var message = CreateRerunTriggerInstanceRequest(triggerName, runId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Rerun single trigger instance by runId. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="runId"> The pipeline run identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> or <paramref name="runId"/> is null. </exception>
        public Response RerunTriggerInstance(string triggerName, string runId, CancellationToken cancellationToken = default)
        {
            if (triggerName == null)
            {
                throw new ArgumentNullException(nameof(triggerName));
            }
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }

            using var message = CreateRerunTriggerInstanceRequest(triggerName, runId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCancelTriggerInstanceRequest(string triggerName, string runId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/triggers/", false);
            uri.AppendPath(triggerName, true);
            uri.AppendPath("/triggerRuns/", false);
            uri.AppendPath(runId, true);
            uri.AppendPath("/cancel", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Cancel single trigger instance by runId. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="runId"> The pipeline run identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> or <paramref name="runId"/> is null. </exception>
        public async Task<Response> CancelTriggerInstanceAsync(string triggerName, string runId, CancellationToken cancellationToken = default)
        {
            if (triggerName == null)
            {
                throw new ArgumentNullException(nameof(triggerName));
            }
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }

            using var message = CreateCancelTriggerInstanceRequest(triggerName, runId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Cancel single trigger instance by runId. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="runId"> The pipeline run identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> or <paramref name="runId"/> is null. </exception>
        public Response CancelTriggerInstance(string triggerName, string runId, CancellationToken cancellationToken = default)
        {
            if (triggerName == null)
            {
                throw new ArgumentNullException(nameof(triggerName));
            }
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }

            using var message = CreateCancelTriggerInstanceRequest(triggerName, runId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateQueryTriggerRunsByWorkspaceRequest(RunFilterParameters filterParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/queryTriggerRuns", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(filterParameters);
            request.Content = content;
            return message;
        }

        /// <summary> Query trigger runs. </summary>
        /// <param name="filterParameters"> Parameters to filter the pipeline run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filterParameters"/> is null. </exception>
        public async Task<Response<TriggerRunsQueryResponse>> QueryTriggerRunsByWorkspaceAsync(RunFilterParameters filterParameters, CancellationToken cancellationToken = default)
        {
            if (filterParameters == null)
            {
                throw new ArgumentNullException(nameof(filterParameters));
            }

            using var message = CreateQueryTriggerRunsByWorkspaceRequest(filterParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TriggerRunsQueryResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TriggerRunsQueryResponse.DeserializeTriggerRunsQueryResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Query trigger runs. </summary>
        /// <param name="filterParameters"> Parameters to filter the pipeline run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filterParameters"/> is null. </exception>
        public Response<TriggerRunsQueryResponse> QueryTriggerRunsByWorkspace(RunFilterParameters filterParameters, CancellationToken cancellationToken = default)
        {
            if (filterParameters == null)
            {
                throw new ArgumentNullException(nameof(filterParameters));
            }

            using var message = CreateQueryTriggerRunsByWorkspaceRequest(filterParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TriggerRunsQueryResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TriggerRunsQueryResponse.DeserializeTriggerRunsQueryResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
