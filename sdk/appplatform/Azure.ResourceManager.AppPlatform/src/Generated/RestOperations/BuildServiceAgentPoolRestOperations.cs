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
using Azure.ResourceManager.AppPlatform.Models;

namespace Azure.ResourceManager.AppPlatform
{
    internal partial class BuildServiceAgentPoolRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of BuildServiceAgentPoolRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public BuildServiceAgentPoolRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-12-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName)
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
            uri.AppendPath("/providers/Microsoft.AppPlatform/Spring/", false);
            uri.AppendPath(serviceName, true);
            uri.AppendPath("/buildServices/", false);
            uri.AppendPath(buildServiceName, true);
            uri.AppendPath("/agentPools", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List build service agent pool. </summary>
        /// <param name="subscriptionId"> Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serviceName"> The name of the Service resource. </param>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/> or <paramref name="buildServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/> or <paramref name="buildServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BuildServiceAgentPoolResourceList>> ListAsync(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, serviceName, buildServiceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BuildServiceAgentPoolResourceList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BuildServiceAgentPoolResourceList.DeserializeBuildServiceAgentPoolResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List build service agent pool. </summary>
        /// <param name="subscriptionId"> Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serviceName"> The name of the Service resource. </param>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/> or <paramref name="buildServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/> or <paramref name="buildServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BuildServiceAgentPoolResourceList> List(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, serviceName, buildServiceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BuildServiceAgentPoolResourceList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BuildServiceAgentPoolResourceList.DeserializeBuildServiceAgentPoolResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string agentPoolName)
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
            uri.AppendPath("/providers/Microsoft.AppPlatform/Spring/", false);
            uri.AppendPath(serviceName, true);
            uri.AppendPath("/buildServices/", false);
            uri.AppendPath(buildServiceName, true);
            uri.AppendPath("/agentPools/", false);
            uri.AppendPath(agentPoolName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get build service agent pool. </summary>
        /// <param name="subscriptionId"> Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serviceName"> The name of the Service resource. </param>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="agentPoolName"> The name of the build service agent pool resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/> or <paramref name="agentPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/> or <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AppPlatformBuildServiceAgentPoolData>> GetAsync(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, serviceName, buildServiceName, agentPoolName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AppPlatformBuildServiceAgentPoolData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AppPlatformBuildServiceAgentPoolData.DeserializeAppPlatformBuildServiceAgentPoolData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AppPlatformBuildServiceAgentPoolData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get build service agent pool. </summary>
        /// <param name="subscriptionId"> Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serviceName"> The name of the Service resource. </param>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="agentPoolName"> The name of the build service agent pool resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/> or <paramref name="agentPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/> or <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AppPlatformBuildServiceAgentPoolData> Get(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, serviceName, buildServiceName, agentPoolName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AppPlatformBuildServiceAgentPoolData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AppPlatformBuildServiceAgentPoolData.DeserializeAppPlatformBuildServiceAgentPoolData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AppPlatformBuildServiceAgentPoolData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdatePutRequest(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string agentPoolName, AppPlatformBuildServiceAgentPoolData data)
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
            uri.AppendPath("/providers/Microsoft.AppPlatform/Spring/", false);
            uri.AppendPath(serviceName, true);
            uri.AppendPath("/buildServices/", false);
            uri.AppendPath(buildServiceName, true);
            uri.AppendPath("/agentPools/", false);
            uri.AppendPath(agentPoolName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = data;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create or update build service agent pool. </summary>
        /// <param name="subscriptionId"> Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serviceName"> The name of the Service resource. </param>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="agentPoolName"> The name of the build service agent pool resource. </param>
        /// <param name="data"> Parameters for the update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/>, <paramref name="agentPoolName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/> or <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> UpdatePutAsync(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string agentPoolName, AppPlatformBuildServiceAgentPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateUpdatePutRequest(subscriptionId, resourceGroupName, serviceName, buildServiceName, agentPoolName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create or update build service agent pool. </summary>
        /// <param name="subscriptionId"> Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serviceName"> The name of the Service resource. </param>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="agentPoolName"> The name of the build service agent pool resource. </param>
        /// <param name="data"> Parameters for the update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/>, <paramref name="agentPoolName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/>, <paramref name="buildServiceName"/> or <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response UpdatePut(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string agentPoolName, AppPlatformBuildServiceAgentPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateUpdatePutRequest(subscriptionId, resourceGroupName, serviceName, buildServiceName, agentPoolName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName)
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

        /// <summary> List build service agent pool. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serviceName"> The name of the Service resource. </param>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/> or <paramref name="buildServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/> or <paramref name="buildServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BuildServiceAgentPoolResourceList>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, serviceName, buildServiceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BuildServiceAgentPoolResourceList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BuildServiceAgentPoolResourceList.DeserializeBuildServiceAgentPoolResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List build service agent pool. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serviceName"> The name of the Service resource. </param>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/> or <paramref name="buildServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serviceName"/> or <paramref name="buildServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BuildServiceAgentPoolResourceList> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, serviceName, buildServiceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BuildServiceAgentPoolResourceList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BuildServiceAgentPoolResourceList.DeserializeBuildServiceAgentPoolResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
