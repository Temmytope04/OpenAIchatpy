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
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    internal partial class SubscriptionsRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of SubscriptionsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public SubscriptionsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-06-01-preview")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateGetAllByTopicRequest(string resourceGroupName, string namespaceName, string topicName, int? skip, int? top)
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
            uri.AppendPath("/providers/Microsoft.ServiceBus/namespaces/", false);
            uri.AppendPath(namespaceName, true);
            uri.AppendPath("/topics/", false);
            uri.AppendPath(topicName, true);
            uri.AppendPath("/subscriptions", false);
            uri.AppendQuery("api-version", apiVersion, true);
            if (skip != null)
            {
                uri.AppendQuery("$skip", skip.Value, true);
            }
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> List all the subscriptions under a specified topic. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="topicName"> The topic name. </param>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/>, or <paramref name="topicName"/> is null. </exception>
        public async Task<Response<ServiceBusSubscriptionListResult>> GetAllByTopicAsync(string resourceGroupName, string namespaceName, string topicName, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (topicName == null)
            {
                throw new ArgumentNullException(nameof(topicName));
            }

            using var message = CreateGetAllByTopicRequest(resourceGroupName, namespaceName, topicName, skip, top);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceBusSubscriptionListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServiceBusSubscriptionListResult.DeserializeServiceBusSubscriptionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List all the subscriptions under a specified topic. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="topicName"> The topic name. </param>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/>, or <paramref name="topicName"/> is null. </exception>
        public Response<ServiceBusSubscriptionListResult> GetAllByTopic(string resourceGroupName, string namespaceName, string topicName, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (topicName == null)
            {
                throw new ArgumentNullException(nameof(topicName));
            }

            using var message = CreateGetAllByTopicRequest(resourceGroupName, namespaceName, topicName, skip, top);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceBusSubscriptionListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServiceBusSubscriptionListResult.DeserializeServiceBusSubscriptionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string namespaceName, string topicName, string subscriptionName, ServiceBusSubscriptionData parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ServiceBus/namespaces/", false);
            uri.AppendPath(namespaceName, true);
            uri.AppendPath("/topics/", false);
            uri.AppendPath(topicName, true);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Creates a topic subscription. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="topicName"> The topic name. </param>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="parameters"> Parameters supplied to create a subscription resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/>, <paramref name="topicName"/>, <paramref name="subscriptionName"/>, or <paramref name="parameters"/> is null. </exception>
        public async Task<Response<ServiceBusSubscriptionData>> CreateOrUpdateAsync(string resourceGroupName, string namespaceName, string topicName, string subscriptionName, ServiceBusSubscriptionData parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (topicName == null)
            {
                throw new ArgumentNullException(nameof(topicName));
            }
            if (subscriptionName == null)
            {
                throw new ArgumentNullException(nameof(subscriptionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, namespaceName, topicName, subscriptionName, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceBusSubscriptionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServiceBusSubscriptionData.DeserializeServiceBusSubscriptionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates a topic subscription. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="topicName"> The topic name. </param>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="parameters"> Parameters supplied to create a subscription resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/>, <paramref name="topicName"/>, <paramref name="subscriptionName"/>, or <paramref name="parameters"/> is null. </exception>
        public Response<ServiceBusSubscriptionData> CreateOrUpdate(string resourceGroupName, string namespaceName, string topicName, string subscriptionName, ServiceBusSubscriptionData parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (topicName == null)
            {
                throw new ArgumentNullException(nameof(topicName));
            }
            if (subscriptionName == null)
            {
                throw new ArgumentNullException(nameof(subscriptionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, namespaceName, topicName, subscriptionName, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceBusSubscriptionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServiceBusSubscriptionData.DeserializeServiceBusSubscriptionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string namespaceName, string topicName, string subscriptionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ServiceBus/namespaces/", false);
            uri.AppendPath(namespaceName, true);
            uri.AppendPath("/topics/", false);
            uri.AppendPath(topicName, true);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Deletes a subscription from the specified topic. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="topicName"> The topic name. </param>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/>, <paramref name="topicName"/>, or <paramref name="subscriptionName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string namespaceName, string topicName, string subscriptionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (topicName == null)
            {
                throw new ArgumentNullException(nameof(topicName));
            }
            if (subscriptionName == null)
            {
                throw new ArgumentNullException(nameof(subscriptionName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, namespaceName, topicName, subscriptionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes a subscription from the specified topic. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="topicName"> The topic name. </param>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/>, <paramref name="topicName"/>, or <paramref name="subscriptionName"/> is null. </exception>
        public Response Delete(string resourceGroupName, string namespaceName, string topicName, string subscriptionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (topicName == null)
            {
                throw new ArgumentNullException(nameof(topicName));
            }
            if (subscriptionName == null)
            {
                throw new ArgumentNullException(nameof(subscriptionName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, namespaceName, topicName, subscriptionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string namespaceName, string topicName, string subscriptionName)
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
            uri.AppendPath("/providers/Microsoft.ServiceBus/namespaces/", false);
            uri.AppendPath(namespaceName, true);
            uri.AppendPath("/topics/", false);
            uri.AppendPath(topicName, true);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Returns a subscription description for the specified topic. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="topicName"> The topic name. </param>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/>, <paramref name="topicName"/>, or <paramref name="subscriptionName"/> is null. </exception>
        public async Task<Response<ServiceBusSubscriptionData>> GetAsync(string resourceGroupName, string namespaceName, string topicName, string subscriptionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (topicName == null)
            {
                throw new ArgumentNullException(nameof(topicName));
            }
            if (subscriptionName == null)
            {
                throw new ArgumentNullException(nameof(subscriptionName));
            }

            using var message = CreateGetRequest(resourceGroupName, namespaceName, topicName, subscriptionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceBusSubscriptionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServiceBusSubscriptionData.DeserializeServiceBusSubscriptionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ServiceBusSubscriptionData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Returns a subscription description for the specified topic. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="topicName"> The topic name. </param>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/>, <paramref name="topicName"/>, or <paramref name="subscriptionName"/> is null. </exception>
        public Response<ServiceBusSubscriptionData> Get(string resourceGroupName, string namespaceName, string topicName, string subscriptionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (topicName == null)
            {
                throw new ArgumentNullException(nameof(topicName));
            }
            if (subscriptionName == null)
            {
                throw new ArgumentNullException(nameof(subscriptionName));
            }

            using var message = CreateGetRequest(resourceGroupName, namespaceName, topicName, subscriptionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceBusSubscriptionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServiceBusSubscriptionData.DeserializeServiceBusSubscriptionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ServiceBusSubscriptionData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllByTopicNextPageRequest(string nextLink, string resourceGroupName, string namespaceName, string topicName, int? skip, int? top)
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

        /// <summary> List all the subscriptions under a specified topic. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="topicName"> The topic name. </param>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/>, or <paramref name="topicName"/> is null. </exception>
        public async Task<Response<ServiceBusSubscriptionListResult>> GetAllByTopicNextPageAsync(string nextLink, string resourceGroupName, string namespaceName, string topicName, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (topicName == null)
            {
                throw new ArgumentNullException(nameof(topicName));
            }

            using var message = CreateGetAllByTopicNextPageRequest(nextLink, resourceGroupName, namespaceName, topicName, skip, top);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceBusSubscriptionListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServiceBusSubscriptionListResult.DeserializeServiceBusSubscriptionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List all the subscriptions under a specified topic. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="topicName"> The topic name. </param>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/>, or <paramref name="topicName"/> is null. </exception>
        public Response<ServiceBusSubscriptionListResult> GetAllByTopicNextPage(string nextLink, string resourceGroupName, string namespaceName, string topicName, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (topicName == null)
            {
                throw new ArgumentNullException(nameof(topicName));
            }

            using var message = CreateGetAllByTopicNextPageRequest(nextLink, resourceGroupName, namespaceName, topicName, skip, top);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceBusSubscriptionListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServiceBusSubscriptionListResult.DeserializeServiceBusSubscriptionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
