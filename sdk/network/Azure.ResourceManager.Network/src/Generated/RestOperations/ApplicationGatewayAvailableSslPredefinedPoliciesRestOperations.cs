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
    internal partial class ApplicationGatewayAvailableSslPredefinedPoliciesRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of ApplicationGatewayAvailableSslPredefinedPoliciesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public ApplicationGatewayAvailableSslPredefinedPoliciesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-02-01")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateGetAllRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Network/applicationGatewayAvailableSslOptions/default/predefinedPolicies", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Lists all SSL predefined policies for configuring Ssl policy. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ApplicationGatewayAvailableSslPredefinedPolicies>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetAllRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApplicationGatewayAvailableSslPredefinedPolicies value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApplicationGatewayAvailableSslPredefinedPolicies.DeserializeApplicationGatewayAvailableSslPredefinedPolicies(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all SSL predefined policies for configuring Ssl policy. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ApplicationGatewayAvailableSslPredefinedPolicies> GetAll(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetAllRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApplicationGatewayAvailableSslPredefinedPolicies value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApplicationGatewayAvailableSslPredefinedPolicies.DeserializeApplicationGatewayAvailableSslPredefinedPolicies(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string predefinedPolicyName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Network/applicationGatewayAvailableSslOptions/default/predefinedPolicies/", false);
            uri.AppendPath(predefinedPolicyName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets Ssl predefined policy with the specified policy name. </summary>
        /// <param name="predefinedPolicyName"> Name of Ssl predefined policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="predefinedPolicyName"/> is null. </exception>
        public async Task<Response<ApplicationGatewaySslPredefinedPolicy>> GetAsync(string predefinedPolicyName, CancellationToken cancellationToken = default)
        {
            if (predefinedPolicyName == null)
            {
                throw new ArgumentNullException(nameof(predefinedPolicyName));
            }

            using var message = CreateGetRequest(predefinedPolicyName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApplicationGatewaySslPredefinedPolicy value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApplicationGatewaySslPredefinedPolicy.DeserializeApplicationGatewaySslPredefinedPolicy(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets Ssl predefined policy with the specified policy name. </summary>
        /// <param name="predefinedPolicyName"> Name of Ssl predefined policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="predefinedPolicyName"/> is null. </exception>
        public Response<ApplicationGatewaySslPredefinedPolicy> Get(string predefinedPolicyName, CancellationToken cancellationToken = default)
        {
            if (predefinedPolicyName == null)
            {
                throw new ArgumentNullException(nameof(predefinedPolicyName));
            }

            using var message = CreateGetRequest(predefinedPolicyName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApplicationGatewaySslPredefinedPolicy value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApplicationGatewaySslPredefinedPolicy.DeserializeApplicationGatewaySslPredefinedPolicy(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllNextPageRequest(string nextLink)
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

        /// <summary> Lists all SSL predefined policies for configuring Ssl policy. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<ApplicationGatewayAvailableSslPredefinedPolicies>> GetAllNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetAllNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApplicationGatewayAvailableSslPredefinedPolicies value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ApplicationGatewayAvailableSslPredefinedPolicies.DeserializeApplicationGatewayAvailableSslPredefinedPolicies(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all SSL predefined policies for configuring Ssl policy. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<ApplicationGatewayAvailableSslPredefinedPolicies> GetAllNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetAllNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ApplicationGatewayAvailableSslPredefinedPolicies value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ApplicationGatewayAvailableSslPredefinedPolicies.DeserializeApplicationGatewayAvailableSslPredefinedPolicies(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
