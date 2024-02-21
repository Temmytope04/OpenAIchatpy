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
using Azure.ResourceManager.Logic.Models;

namespace Azure.ResourceManager.Logic
{
    internal partial class IntegrationServiceEnvironmentManagedApisRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of IntegrationServiceEnvironmentManagedApisRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public IntegrationServiceEnvironmentManagedApisRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2019-05-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroup, true);
            uri.AppendPath("/providers/Microsoft.Logic/integrationServiceEnvironments/", false);
            uri.AppendPath(integrationServiceEnvironmentName, true);
            uri.AppendPath("/managedApis", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the integration service environment managed Apis. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroup"> The resource group. </param>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/> or <paramref name="integrationServiceEnvironmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/> or <paramref name="integrationServiceEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IntegrationServiceEnvironmentManagedApiListResult>> ListAsync(string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroup == null)
            {
                throw new ArgumentNullException(nameof(resourceGroup));
            }
            if (resourceGroup.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroup));
            }
            if (integrationServiceEnvironmentName == null)
            {
                throw new ArgumentNullException(nameof(integrationServiceEnvironmentName));
            }
            if (integrationServiceEnvironmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(integrationServiceEnvironmentName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroup, integrationServiceEnvironmentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationServiceEnvironmentManagedApiListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = IntegrationServiceEnvironmentManagedApiListResult.DeserializeIntegrationServiceEnvironmentManagedApiListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the integration service environment managed Apis. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroup"> The resource group. </param>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/> or <paramref name="integrationServiceEnvironmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/> or <paramref name="integrationServiceEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IntegrationServiceEnvironmentManagedApiListResult> List(string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroup == null)
            {
                throw new ArgumentNullException(nameof(resourceGroup));
            }
            if (resourceGroup.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroup));
            }
            if (integrationServiceEnvironmentName == null)
            {
                throw new ArgumentNullException(nameof(integrationServiceEnvironmentName));
            }
            if (integrationServiceEnvironmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(integrationServiceEnvironmentName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroup, integrationServiceEnvironmentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationServiceEnvironmentManagedApiListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = IntegrationServiceEnvironmentManagedApiListResult.DeserializeIntegrationServiceEnvironmentManagedApiListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName, string apiName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroup, true);
            uri.AppendPath("/providers/Microsoft.Logic/integrationServiceEnvironments/", false);
            uri.AppendPath(integrationServiceEnvironmentName, true);
            uri.AppendPath("/managedApis/", false);
            uri.AppendPath(apiName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the integration service environment managed Api. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroup"> The resource group name. </param>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="apiName"> The api name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/>, <paramref name="integrationServiceEnvironmentName"/> or <paramref name="apiName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/>, <paramref name="integrationServiceEnvironmentName"/> or <paramref name="apiName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IntegrationServiceEnvironmentManagedApiData>> GetAsync(string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName, string apiName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroup == null)
            {
                throw new ArgumentNullException(nameof(resourceGroup));
            }
            if (resourceGroup.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroup));
            }
            if (integrationServiceEnvironmentName == null)
            {
                throw new ArgumentNullException(nameof(integrationServiceEnvironmentName));
            }
            if (integrationServiceEnvironmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(integrationServiceEnvironmentName));
            }
            if (apiName == null)
            {
                throw new ArgumentNullException(nameof(apiName));
            }
            if (apiName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(apiName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroup, integrationServiceEnvironmentName, apiName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationServiceEnvironmentManagedApiData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = IntegrationServiceEnvironmentManagedApiData.DeserializeIntegrationServiceEnvironmentManagedApiData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((IntegrationServiceEnvironmentManagedApiData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the integration service environment managed Api. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroup"> The resource group name. </param>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="apiName"> The api name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/>, <paramref name="integrationServiceEnvironmentName"/> or <paramref name="apiName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/>, <paramref name="integrationServiceEnvironmentName"/> or <paramref name="apiName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IntegrationServiceEnvironmentManagedApiData> Get(string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName, string apiName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroup == null)
            {
                throw new ArgumentNullException(nameof(resourceGroup));
            }
            if (resourceGroup.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroup));
            }
            if (integrationServiceEnvironmentName == null)
            {
                throw new ArgumentNullException(nameof(integrationServiceEnvironmentName));
            }
            if (integrationServiceEnvironmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(integrationServiceEnvironmentName));
            }
            if (apiName == null)
            {
                throw new ArgumentNullException(nameof(apiName));
            }
            if (apiName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(apiName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroup, integrationServiceEnvironmentName, apiName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationServiceEnvironmentManagedApiData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = IntegrationServiceEnvironmentManagedApiData.DeserializeIntegrationServiceEnvironmentManagedApiData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((IntegrationServiceEnvironmentManagedApiData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePutRequest(string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName, string apiName, IntegrationServiceEnvironmentManagedApiData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroup, true);
            uri.AppendPath("/providers/Microsoft.Logic/integrationServiceEnvironments/", false);
            uri.AppendPath(integrationServiceEnvironmentName, true);
            uri.AppendPath("/managedApis/", false);
            uri.AppendPath(apiName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Puts the integration service environment managed Api. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroup"> The resource group name. </param>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="apiName"> The api name. </param>
        /// <param name="data"> The integration service environment managed api. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/>, <paramref name="integrationServiceEnvironmentName"/>, <paramref name="apiName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/>, <paramref name="integrationServiceEnvironmentName"/> or <paramref name="apiName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> PutAsync(string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName, string apiName, IntegrationServiceEnvironmentManagedApiData data, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroup == null)
            {
                throw new ArgumentNullException(nameof(resourceGroup));
            }
            if (resourceGroup.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroup));
            }
            if (integrationServiceEnvironmentName == null)
            {
                throw new ArgumentNullException(nameof(integrationServiceEnvironmentName));
            }
            if (integrationServiceEnvironmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(integrationServiceEnvironmentName));
            }
            if (apiName == null)
            {
                throw new ArgumentNullException(nameof(apiName));
            }
            if (apiName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(apiName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var message = CreatePutRequest(subscriptionId, resourceGroup, integrationServiceEnvironmentName, apiName, data);
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

        /// <summary> Puts the integration service environment managed Api. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroup"> The resource group name. </param>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="apiName"> The api name. </param>
        /// <param name="data"> The integration service environment managed api. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/>, <paramref name="integrationServiceEnvironmentName"/>, <paramref name="apiName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/>, <paramref name="integrationServiceEnvironmentName"/> or <paramref name="apiName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Put(string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName, string apiName, IntegrationServiceEnvironmentManagedApiData data, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroup == null)
            {
                throw new ArgumentNullException(nameof(resourceGroup));
            }
            if (resourceGroup.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroup));
            }
            if (integrationServiceEnvironmentName == null)
            {
                throw new ArgumentNullException(nameof(integrationServiceEnvironmentName));
            }
            if (integrationServiceEnvironmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(integrationServiceEnvironmentName));
            }
            if (apiName == null)
            {
                throw new ArgumentNullException(nameof(apiName));
            }
            if (apiName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(apiName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var message = CreatePutRequest(subscriptionId, resourceGroup, integrationServiceEnvironmentName, apiName, data);
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

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName, string apiName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroup, true);
            uri.AppendPath("/providers/Microsoft.Logic/integrationServiceEnvironments/", false);
            uri.AppendPath(integrationServiceEnvironmentName, true);
            uri.AppendPath("/managedApis/", false);
            uri.AppendPath(apiName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes the integration service environment managed Api. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroup"> The resource group. </param>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="apiName"> The api name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/>, <paramref name="integrationServiceEnvironmentName"/> or <paramref name="apiName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/>, <paramref name="integrationServiceEnvironmentName"/> or <paramref name="apiName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName, string apiName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroup == null)
            {
                throw new ArgumentNullException(nameof(resourceGroup));
            }
            if (resourceGroup.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroup));
            }
            if (integrationServiceEnvironmentName == null)
            {
                throw new ArgumentNullException(nameof(integrationServiceEnvironmentName));
            }
            if (integrationServiceEnvironmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(integrationServiceEnvironmentName));
            }
            if (apiName == null)
            {
                throw new ArgumentNullException(nameof(apiName));
            }
            if (apiName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(apiName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroup, integrationServiceEnvironmentName, apiName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes the integration service environment managed Api. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroup"> The resource group. </param>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="apiName"> The api name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/>, <paramref name="integrationServiceEnvironmentName"/> or <paramref name="apiName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/>, <paramref name="integrationServiceEnvironmentName"/> or <paramref name="apiName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName, string apiName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroup == null)
            {
                throw new ArgumentNullException(nameof(resourceGroup));
            }
            if (resourceGroup.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroup));
            }
            if (integrationServiceEnvironmentName == null)
            {
                throw new ArgumentNullException(nameof(integrationServiceEnvironmentName));
            }
            if (integrationServiceEnvironmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(integrationServiceEnvironmentName));
            }
            if (apiName == null)
            {
                throw new ArgumentNullException(nameof(apiName));
            }
            if (apiName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(apiName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroup, integrationServiceEnvironmentName, apiName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName)
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

        /// <summary> Gets the integration service environment managed Apis. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroup"> The resource group. </param>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/> or <paramref name="integrationServiceEnvironmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/> or <paramref name="integrationServiceEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IntegrationServiceEnvironmentManagedApiListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroup == null)
            {
                throw new ArgumentNullException(nameof(resourceGroup));
            }
            if (resourceGroup.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroup));
            }
            if (integrationServiceEnvironmentName == null)
            {
                throw new ArgumentNullException(nameof(integrationServiceEnvironmentName));
            }
            if (integrationServiceEnvironmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(integrationServiceEnvironmentName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroup, integrationServiceEnvironmentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationServiceEnvironmentManagedApiListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = IntegrationServiceEnvironmentManagedApiListResult.DeserializeIntegrationServiceEnvironmentManagedApiListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the integration service environment managed Apis. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroup"> The resource group. </param>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/> or <paramref name="integrationServiceEnvironmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/> or <paramref name="integrationServiceEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IntegrationServiceEnvironmentManagedApiListResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroup == null)
            {
                throw new ArgumentNullException(nameof(resourceGroup));
            }
            if (resourceGroup.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroup));
            }
            if (integrationServiceEnvironmentName == null)
            {
                throw new ArgumentNullException(nameof(integrationServiceEnvironmentName));
            }
            if (integrationServiceEnvironmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(integrationServiceEnvironmentName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroup, integrationServiceEnvironmentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationServiceEnvironmentManagedApiListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = IntegrationServiceEnvironmentManagedApiListResult.DeserializeIntegrationServiceEnvironmentManagedApiListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
