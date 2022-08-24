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
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    internal partial class SourceControlSyncJobStreamsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of SourceControlSyncJobStreamsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public SourceControlSyncJobStreamsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-01-13-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListBySyncJobRequest(string subscriptionId, string resourceGroupName, string automationAccountName, string sourceControlName, Guid sourceControlSyncJobId, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Automation/automationAccounts/", false);
            uri.AppendPath(automationAccountName, true);
            uri.AppendPath("/sourceControls/", false);
            uri.AppendPath(sourceControlName, true);
            uri.AppendPath("/sourceControlSyncJobs/", false);
            uri.AppendPath(sourceControlSyncJobId, true);
            uri.AppendPath("/streams", false);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieve a list of sync job streams identified by sync job id. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="sourceControlName"> The source control name. </param>
        /// <param name="sourceControlSyncJobId"> The source control sync job id. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="sourceControlName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SourceControlSyncJobStreamsListBySyncJob>> ListBySyncJobAsync(string subscriptionId, string resourceGroupName, string automationAccountName, string sourceControlName, Guid sourceControlSyncJobId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));

            using var message = CreateListBySyncJobRequest(subscriptionId, resourceGroupName, automationAccountName, sourceControlName, sourceControlSyncJobId, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SourceControlSyncJobStreamsListBySyncJob value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SourceControlSyncJobStreamsListBySyncJob.DeserializeSourceControlSyncJobStreamsListBySyncJob(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieve a list of sync job streams identified by sync job id. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="sourceControlName"> The source control name. </param>
        /// <param name="sourceControlSyncJobId"> The source control sync job id. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="sourceControlName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SourceControlSyncJobStreamsListBySyncJob> ListBySyncJob(string subscriptionId, string resourceGroupName, string automationAccountName, string sourceControlName, Guid sourceControlSyncJobId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));

            using var message = CreateListBySyncJobRequest(subscriptionId, resourceGroupName, automationAccountName, sourceControlName, sourceControlSyncJobId, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SourceControlSyncJobStreamsListBySyncJob value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SourceControlSyncJobStreamsListBySyncJob.DeserializeSourceControlSyncJobStreamsListBySyncJob(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string automationAccountName, string sourceControlName, Guid sourceControlSyncJobId, string streamId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Automation/automationAccounts/", false);
            uri.AppendPath(automationAccountName, true);
            uri.AppendPath("/sourceControls/", false);
            uri.AppendPath(sourceControlName, true);
            uri.AppendPath("/sourceControlSyncJobs/", false);
            uri.AppendPath(sourceControlSyncJobId, true);
            uri.AppendPath("/streams/", false);
            uri.AppendPath(streamId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieve a sync job stream identified by stream id. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="sourceControlName"> The source control name. </param>
        /// <param name="sourceControlSyncJobId"> The source control sync job id. </param>
        /// <param name="streamId"> The id of the sync job stream. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="sourceControlName"/> or <paramref name="streamId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="sourceControlName"/> or <paramref name="streamId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SourceControlSyncJobStreamById>> GetAsync(string subscriptionId, string resourceGroupName, string automationAccountName, string sourceControlName, Guid sourceControlSyncJobId, string streamId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));
            Argument.AssertNotNullOrEmpty(streamId, nameof(streamId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, automationAccountName, sourceControlName, sourceControlSyncJobId, streamId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SourceControlSyncJobStreamById value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SourceControlSyncJobStreamById.DeserializeSourceControlSyncJobStreamById(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieve a sync job stream identified by stream id. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="sourceControlName"> The source control name. </param>
        /// <param name="sourceControlSyncJobId"> The source control sync job id. </param>
        /// <param name="streamId"> The id of the sync job stream. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="sourceControlName"/> or <paramref name="streamId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="sourceControlName"/> or <paramref name="streamId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SourceControlSyncJobStreamById> Get(string subscriptionId, string resourceGroupName, string automationAccountName, string sourceControlName, Guid sourceControlSyncJobId, string streamId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));
            Argument.AssertNotNullOrEmpty(streamId, nameof(streamId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, automationAccountName, sourceControlName, sourceControlSyncJobId, streamId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SourceControlSyncJobStreamById value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SourceControlSyncJobStreamById.DeserializeSourceControlSyncJobStreamById(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListBySyncJobNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string automationAccountName, string sourceControlName, Guid sourceControlSyncJobId, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieve a list of sync job streams identified by sync job id. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="sourceControlName"> The source control name. </param>
        /// <param name="sourceControlSyncJobId"> The source control sync job id. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="sourceControlName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SourceControlSyncJobStreamsListBySyncJob>> ListBySyncJobNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string automationAccountName, string sourceControlName, Guid sourceControlSyncJobId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));

            using var message = CreateListBySyncJobNextPageRequest(nextLink, subscriptionId, resourceGroupName, automationAccountName, sourceControlName, sourceControlSyncJobId, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SourceControlSyncJobStreamsListBySyncJob value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SourceControlSyncJobStreamsListBySyncJob.DeserializeSourceControlSyncJobStreamsListBySyncJob(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieve a list of sync job streams identified by sync job id. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="sourceControlName"> The source control name. </param>
        /// <param name="sourceControlSyncJobId"> The source control sync job id. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="sourceControlName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SourceControlSyncJobStreamsListBySyncJob> ListBySyncJobNextPage(string nextLink, string subscriptionId, string resourceGroupName, string automationAccountName, string sourceControlName, Guid sourceControlSyncJobId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));

            using var message = CreateListBySyncJobNextPageRequest(nextLink, subscriptionId, resourceGroupName, automationAccountName, sourceControlName, sourceControlSyncJobId, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SourceControlSyncJobStreamsListBySyncJob value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SourceControlSyncJobStreamsListBySyncJob.DeserializeSourceControlSyncJobStreamsListBySyncJob(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
