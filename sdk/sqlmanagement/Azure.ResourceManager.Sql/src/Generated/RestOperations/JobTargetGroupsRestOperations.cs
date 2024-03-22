// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    internal partial class JobTargetGroupsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of JobTargetGroupsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public JobTargetGroupsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-11-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByAgentRequest(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName)
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
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(serverName, true);
            uri.AppendPath("/jobAgents/", false);
            uri.AppendPath(jobAgentName, true);
            uri.AppendPath("/targetGroups", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets all target groups in an agent. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="jobAgentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="jobAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<JobTargetGroupListResult>> ListByAgentAsync(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));

            using var message = CreateListByAgentRequest(subscriptionId, resourceGroupName, serverName, jobAgentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobTargetGroupListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JobTargetGroupListResult.DeserializeJobTargetGroupListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets all target groups in an agent. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="jobAgentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="jobAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<JobTargetGroupListResult> ListByAgent(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));

            using var message = CreateListByAgentRequest(subscriptionId, resourceGroupName, serverName, jobAgentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobTargetGroupListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JobTargetGroupListResult.DeserializeJobTargetGroupListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string targetGroupName)
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
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(serverName, true);
            uri.AppendPath("/jobAgents/", false);
            uri.AppendPath(jobAgentName, true);
            uri.AppendPath("/targetGroups/", false);
            uri.AppendPath(targetGroupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a target group. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/> or <paramref name="targetGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/> or <paramref name="targetGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SqlServerJobTargetGroupData>> GetAsync(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string targetGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));
            Argument.AssertNotNullOrEmpty(targetGroupName, nameof(targetGroupName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, serverName, jobAgentName, targetGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SqlServerJobTargetGroupData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SqlServerJobTargetGroupData.DeserializeSqlServerJobTargetGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SqlServerJobTargetGroupData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a target group. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/> or <paramref name="targetGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/> or <paramref name="targetGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SqlServerJobTargetGroupData> Get(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string targetGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));
            Argument.AssertNotNullOrEmpty(targetGroupName, nameof(targetGroupName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, serverName, jobAgentName, targetGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SqlServerJobTargetGroupData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SqlServerJobTargetGroupData.DeserializeSqlServerJobTargetGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SqlServerJobTargetGroupData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string targetGroupName, SqlServerJobTargetGroupData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(serverName, true);
            uri.AppendPath("/jobAgents/", false);
            uri.AppendPath(jobAgentName, true);
            uri.AppendPath("/targetGroups/", false);
            uri.AppendPath(targetGroupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<SqlServerJobTargetGroupData>(data, new ModelReaderWriterOptions("W"));
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates or updates a target group. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="data"> The requested state of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/>, <paramref name="targetGroupName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/> or <paramref name="targetGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SqlServerJobTargetGroupData>> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string targetGroupName, SqlServerJobTargetGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));
            Argument.AssertNotNullOrEmpty(targetGroupName, nameof(targetGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, serverName, jobAgentName, targetGroupName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SqlServerJobTargetGroupData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SqlServerJobTargetGroupData.DeserializeSqlServerJobTargetGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates a target group. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="data"> The requested state of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/>, <paramref name="targetGroupName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/> or <paramref name="targetGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SqlServerJobTargetGroupData> CreateOrUpdate(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string targetGroupName, SqlServerJobTargetGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));
            Argument.AssertNotNullOrEmpty(targetGroupName, nameof(targetGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, serverName, jobAgentName, targetGroupName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SqlServerJobTargetGroupData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SqlServerJobTargetGroupData.DeserializeSqlServerJobTargetGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string targetGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(serverName, true);
            uri.AppendPath("/jobAgents/", false);
            uri.AppendPath(jobAgentName, true);
            uri.AppendPath("/targetGroups/", false);
            uri.AppendPath(targetGroupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes a target group. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/> or <paramref name="targetGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/> or <paramref name="targetGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string targetGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));
            Argument.AssertNotNullOrEmpty(targetGroupName, nameof(targetGroupName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, serverName, jobAgentName, targetGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes a target group. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/> or <paramref name="targetGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/> or <paramref name="targetGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string targetGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));
            Argument.AssertNotNullOrEmpty(targetGroupName, nameof(targetGroupName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, serverName, jobAgentName, targetGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByAgentNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string serverName, string jobAgentName)
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

        /// <summary> Gets all target groups in an agent. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="jobAgentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="jobAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<JobTargetGroupListResult>> ListByAgentNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));

            using var message = CreateListByAgentNextPageRequest(nextLink, subscriptionId, resourceGroupName, serverName, jobAgentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobTargetGroupListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JobTargetGroupListResult.DeserializeJobTargetGroupListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets all target groups in an agent. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="jobAgentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="jobAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<JobTargetGroupListResult> ListByAgentNextPage(string nextLink, string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));

            using var message = CreateListByAgentNextPageRequest(nextLink, subscriptionId, resourceGroupName, serverName, jobAgentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobTargetGroupListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JobTargetGroupListResult.DeserializeJobTargetGroupListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
