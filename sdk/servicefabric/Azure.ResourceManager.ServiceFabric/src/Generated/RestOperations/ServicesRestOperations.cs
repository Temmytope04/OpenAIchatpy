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
using Azure.ResourceManager.ServiceFabric.Models;

namespace Azure.ResourceManager.ServiceFabric
{
    internal partial class ServicesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ServicesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ServicesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-11-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string clusterName, string applicationName, string serviceName)
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
            uri.AppendPath("/providers/Microsoft.ServiceFabric/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/applications/", false);
            uri.AppendPath(applicationName, true);
            uri.AppendPath("/services/", false);
            uri.AppendPath(serviceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a Service Fabric service resource created or in the process of being created in the Service Fabric application resource. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="applicationName"> The name of the application resource. </param>
        /// <param name="serviceName"> The name of the service resource in the format of {applicationName}~{serviceName}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="applicationName"/> or <paramref name="serviceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="applicationName"/> or <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ServiceFabricServiceData>> GetAsync(string subscriptionId, string resourceGroupName, string clusterName, string applicationName, string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, clusterName, applicationName, serviceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceFabricServiceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServiceFabricServiceData.DeserializeServiceFabricServiceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ServiceFabricServiceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a Service Fabric service resource created or in the process of being created in the Service Fabric application resource. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="applicationName"> The name of the application resource. </param>
        /// <param name="serviceName"> The name of the service resource in the format of {applicationName}~{serviceName}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="applicationName"/> or <paramref name="serviceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="applicationName"/> or <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ServiceFabricServiceData> Get(string subscriptionId, string resourceGroupName, string clusterName, string applicationName, string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, clusterName, applicationName, serviceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceFabricServiceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServiceFabricServiceData.DeserializeServiceFabricServiceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ServiceFabricServiceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string clusterName, string applicationName, string serviceName, ServiceFabricServiceData data)
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
            uri.AppendPath("/providers/Microsoft.ServiceFabric/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/applications/", false);
            uri.AppendPath(applicationName, true);
            uri.AppendPath("/services/", false);
            uri.AppendPath(serviceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<ServiceFabricServiceData>(data, new ModelReaderWriterOptions("W"));
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create or update a Service Fabric service resource with the specified name. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="applicationName"> The name of the application resource. </param>
        /// <param name="serviceName"> The name of the service resource in the format of {applicationName}~{serviceName}. </param>
        /// <param name="data"> The service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="applicationName"/>, <paramref name="serviceName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="applicationName"/> or <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string clusterName, string applicationName, string serviceName, ServiceFabricServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, clusterName, applicationName, serviceName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create or update a Service Fabric service resource with the specified name. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="applicationName"> The name of the application resource. </param>
        /// <param name="serviceName"> The name of the service resource in the format of {applicationName}~{serviceName}. </param>
        /// <param name="data"> The service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="applicationName"/>, <paramref name="serviceName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="applicationName"/> or <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string clusterName, string applicationName, string serviceName, ServiceFabricServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, clusterName, applicationName, serviceName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string clusterName, string applicationName, string serviceName, ServiceFabricServicePatch patch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ServiceFabric/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/applications/", false);
            uri.AppendPath(applicationName, true);
            uri.AppendPath("/services/", false);
            uri.AppendPath(serviceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<ServiceFabricServicePatch>(patch, new ModelReaderWriterOptions("W"));
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Update a Service Fabric service resource with the specified name. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="applicationName"> The name of the application resource. </param>
        /// <param name="serviceName"> The name of the service resource in the format of {applicationName}~{serviceName}. </param>
        /// <param name="patch"> The service resource for patch operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="applicationName"/>, <paramref name="serviceName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="applicationName"/> or <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> UpdateAsync(string subscriptionId, string resourceGroupName, string clusterName, string applicationName, string serviceName, ServiceFabricServicePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, clusterName, applicationName, serviceName, patch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Update a Service Fabric service resource with the specified name. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="applicationName"> The name of the application resource. </param>
        /// <param name="serviceName"> The name of the service resource in the format of {applicationName}~{serviceName}. </param>
        /// <param name="patch"> The service resource for patch operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="applicationName"/>, <paramref name="serviceName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="applicationName"/> or <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Update(string subscriptionId, string resourceGroupName, string clusterName, string applicationName, string serviceName, ServiceFabricServicePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, clusterName, applicationName, serviceName, patch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string clusterName, string applicationName, string serviceName)
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
            uri.AppendPath("/providers/Microsoft.ServiceFabric/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/applications/", false);
            uri.AppendPath(applicationName, true);
            uri.AppendPath("/services/", false);
            uri.AppendPath(serviceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete a Service Fabric service resource with the specified name. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="applicationName"> The name of the application resource. </param>
        /// <param name="serviceName"> The name of the service resource in the format of {applicationName}~{serviceName}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="applicationName"/> or <paramref name="serviceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="applicationName"/> or <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string clusterName, string applicationName, string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, clusterName, applicationName, serviceName);
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

        /// <summary> Delete a Service Fabric service resource with the specified name. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="applicationName"> The name of the application resource. </param>
        /// <param name="serviceName"> The name of the service resource in the format of {applicationName}~{serviceName}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="applicationName"/> or <paramref name="serviceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="applicationName"/> or <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string clusterName, string applicationName, string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, clusterName, applicationName, serviceName);
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

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string clusterName, string applicationName)
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
            uri.AppendPath("/providers/Microsoft.ServiceFabric/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/applications/", false);
            uri.AppendPath(applicationName, true);
            uri.AppendPath("/services", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets all service resources created or in the process of being created in the Service Fabric application resource. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="applicationName"> The name of the application resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="applicationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ServiceResourceList>> ListAsync(string subscriptionId, string resourceGroupName, string clusterName, string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, clusterName, applicationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceResourceList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServiceResourceList.DeserializeServiceResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets all service resources created or in the process of being created in the Service Fabric application resource. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="applicationName"> The name of the application resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="applicationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ServiceResourceList> List(string subscriptionId, string resourceGroupName, string clusterName, string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, clusterName, applicationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceResourceList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServiceResourceList.DeserializeServiceResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string clusterName, string applicationName)
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

        /// <summary> Gets all service resources created or in the process of being created in the Service Fabric application resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="applicationName"> The name of the application resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="applicationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ServiceResourceList>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string clusterName, string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, clusterName, applicationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceResourceList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServiceResourceList.DeserializeServiceResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets all service resources created or in the process of being created in the Service Fabric application resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="applicationName"> The name of the application resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="applicationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ServiceResourceList> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string clusterName, string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, clusterName, applicationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceResourceList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServiceResourceList.DeserializeServiceResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
