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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal partial class LoadBalancerProbesRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of LoadBalancerProbesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public LoadBalancerProbesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-02-01")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateListRequest(string resourceGroupName, string loadBalancerName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/loadBalancers/", false);
            uri.AppendPath(loadBalancerName, true);
            uri.AppendPath("/probes", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets all the load balancer probes. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="loadBalancerName"/> is null. </exception>
        public async Task<Response<LoadBalancerProbeListResult>> ListAsync(string resourceGroupName, string loadBalancerName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }

            using var message = CreateListRequest(resourceGroupName, loadBalancerName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LoadBalancerProbeListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LoadBalancerProbeListResult.DeserializeLoadBalancerProbeListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all the load balancer probes. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="loadBalancerName"/> is null. </exception>
        public Response<LoadBalancerProbeListResult> List(string resourceGroupName, string loadBalancerName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }

            using var message = CreateListRequest(resourceGroupName, loadBalancerName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LoadBalancerProbeListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LoadBalancerProbeListResult.DeserializeLoadBalancerProbeListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string loadBalancerName, string probeName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/loadBalancers/", false);
            uri.AppendPath(loadBalancerName, true);
            uri.AppendPath("/probes/", false);
            uri.AppendPath(probeName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets load balancer probe. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="probeName"> The name of the probe. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="loadBalancerName"/>, or <paramref name="probeName"/> is null. </exception>
        public async Task<Response<ProbeData>> GetAsync(string resourceGroupName, string loadBalancerName, string probeName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }
            if (probeName == null)
            {
                throw new ArgumentNullException(nameof(probeName));
            }

            using var message = CreateGetRequest(resourceGroupName, loadBalancerName, probeName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ProbeData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ProbeData.DeserializeProbeData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ProbeData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets load balancer probe. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="probeName"> The name of the probe. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="loadBalancerName"/>, or <paramref name="probeName"/> is null. </exception>
        public Response<ProbeData> Get(string resourceGroupName, string loadBalancerName, string probeName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }
            if (probeName == null)
            {
                throw new ArgumentNullException(nameof(probeName));
            }

            using var message = CreateGetRequest(resourceGroupName, loadBalancerName, probeName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ProbeData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ProbeData.DeserializeProbeData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ProbeData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string resourceGroupName, string loadBalancerName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets all the load balancer probes. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="loadBalancerName"/> is null. </exception>
        public async Task<Response<LoadBalancerProbeListResult>> ListNextPageAsync(string nextLink, string resourceGroupName, string loadBalancerName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }

            using var message = CreateListNextPageRequest(nextLink, resourceGroupName, loadBalancerName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LoadBalancerProbeListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LoadBalancerProbeListResult.DeserializeLoadBalancerProbeListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all the load balancer probes. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="loadBalancerName"/> is null. </exception>
        public Response<LoadBalancerProbeListResult> ListNextPage(string nextLink, string resourceGroupName, string loadBalancerName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }

            using var message = CreateListNextPageRequest(nextLink, resourceGroupName, loadBalancerName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LoadBalancerProbeListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LoadBalancerProbeListResult.DeserializeLoadBalancerProbeListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
