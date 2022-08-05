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
using Azure.ResourceManager.SqlVirtualMachine.Models;

namespace Azure.ResourceManager.SqlVirtualMachine
{
    internal partial class AvailabilityGroupListenersRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of AvailabilityGroupListenersRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public AvailabilityGroupListenersRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-02-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string sqlVmGroupName, string subscriptionId, string resourceGroupName, string availabilityGroupListenerName, string expand)
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
            uri.AppendPath("/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups/", false);
            uri.AppendPath(sqlVmGroupName, true);
            uri.AppendPath("/availabilityGroupListeners/", false);
            uri.AppendPath(availabilityGroupListenerName, true);
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets an availability group listener. </summary>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="availabilityGroupListenerName"> Name of the availability group listener. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="availabilityGroupListenerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="availabilityGroupListenerName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AvailabilityGroupListenerData>> GetAsync(string sqlVmGroupName, string subscriptionId, string resourceGroupName, string availabilityGroupListenerName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(availabilityGroupListenerName, nameof(availabilityGroupListenerName));

            using var message = CreateGetRequest(sqlVmGroupName, subscriptionId, resourceGroupName, availabilityGroupListenerName, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvailabilityGroupListenerData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AvailabilityGroupListenerData.DeserializeAvailabilityGroupListenerData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AvailabilityGroupListenerData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets an availability group listener. </summary>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="availabilityGroupListenerName"> Name of the availability group listener. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="availabilityGroupListenerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="availabilityGroupListenerName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AvailabilityGroupListenerData> Get(string sqlVmGroupName, string subscriptionId, string resourceGroupName, string availabilityGroupListenerName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(availabilityGroupListenerName, nameof(availabilityGroupListenerName));

            using var message = CreateGetRequest(sqlVmGroupName, subscriptionId, resourceGroupName, availabilityGroupListenerName, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvailabilityGroupListenerData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AvailabilityGroupListenerData.DeserializeAvailabilityGroupListenerData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AvailabilityGroupListenerData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string sqlVmGroupName, string subscriptionId, string resourceGroupName, string availabilityGroupListenerName, AvailabilityGroupListenerData data)
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
            uri.AppendPath("/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups/", false);
            uri.AppendPath(sqlVmGroupName, true);
            uri.AppendPath("/availabilityGroupListeners/", false);
            uri.AppendPath(availabilityGroupListenerName, true);
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

        /// <summary> Creates or updates an availability group listener. </summary>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="availabilityGroupListenerName"> Name of the availability group listener. </param>
        /// <param name="data"> The availability group listener. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="availabilityGroupListenerName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="availabilityGroupListenerName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string sqlVmGroupName, string subscriptionId, string resourceGroupName, string availabilityGroupListenerName, AvailabilityGroupListenerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(availabilityGroupListenerName, nameof(availabilityGroupListenerName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(sqlVmGroupName, subscriptionId, resourceGroupName, availabilityGroupListenerName, data);
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

        /// <summary> Creates or updates an availability group listener. </summary>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="availabilityGroupListenerName"> Name of the availability group listener. </param>
        /// <param name="data"> The availability group listener. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="availabilityGroupListenerName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="availabilityGroupListenerName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string sqlVmGroupName, string subscriptionId, string resourceGroupName, string availabilityGroupListenerName, AvailabilityGroupListenerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(availabilityGroupListenerName, nameof(availabilityGroupListenerName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(sqlVmGroupName, subscriptionId, resourceGroupName, availabilityGroupListenerName, data);
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

        internal HttpMessage CreateDeleteRequest(string sqlVmGroupName, string subscriptionId, string resourceGroupName, string availabilityGroupListenerName)
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
            uri.AppendPath("/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups/", false);
            uri.AppendPath(sqlVmGroupName, true);
            uri.AppendPath("/availabilityGroupListeners/", false);
            uri.AppendPath(availabilityGroupListenerName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes an availability group listener. </summary>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="availabilityGroupListenerName"> Name of the availability group listener. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="availabilityGroupListenerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="availabilityGroupListenerName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string sqlVmGroupName, string subscriptionId, string resourceGroupName, string availabilityGroupListenerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(availabilityGroupListenerName, nameof(availabilityGroupListenerName));

            using var message = CreateDeleteRequest(sqlVmGroupName, subscriptionId, resourceGroupName, availabilityGroupListenerName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes an availability group listener. </summary>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="availabilityGroupListenerName"> Name of the availability group listener. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="availabilityGroupListenerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="availabilityGroupListenerName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string sqlVmGroupName, string subscriptionId, string resourceGroupName, string availabilityGroupListenerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(availabilityGroupListenerName, nameof(availabilityGroupListenerName));

            using var message = CreateDeleteRequest(sqlVmGroupName, subscriptionId, resourceGroupName, availabilityGroupListenerName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByGroupRequest(string sqlVmGroupName, string subscriptionId, string resourceGroupName)
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
            uri.AppendPath("/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups/", false);
            uri.AppendPath(sqlVmGroupName, true);
            uri.AppendPath("/availabilityGroupListeners", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all availability group listeners in a SQL virtual machine group. </summary>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/>, <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/>, <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AvailabilityGroupListenerListResult>> ListByGroupAsync(string sqlVmGroupName, string subscriptionId, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));

            using var message = CreateListByGroupRequest(sqlVmGroupName, subscriptionId, resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvailabilityGroupListenerListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AvailabilityGroupListenerListResult.DeserializeAvailabilityGroupListenerListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all availability group listeners in a SQL virtual machine group. </summary>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/>, <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/>, <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AvailabilityGroupListenerListResult> ListByGroup(string sqlVmGroupName, string subscriptionId, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));

            using var message = CreateListByGroupRequest(sqlVmGroupName, subscriptionId, resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvailabilityGroupListenerListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AvailabilityGroupListenerListResult.DeserializeAvailabilityGroupListenerListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByGroupNextPageRequest(string nextLink, string sqlVmGroupName, string subscriptionId, string resourceGroupName)
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

        /// <summary> Lists all availability group listeners in a SQL virtual machine group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="sqlVmGroupName"/>, <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/>, <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AvailabilityGroupListenerListResult>> ListByGroupNextPageAsync(string nextLink, string sqlVmGroupName, string subscriptionId, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));

            using var message = CreateListByGroupNextPageRequest(nextLink, sqlVmGroupName, subscriptionId, resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvailabilityGroupListenerListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AvailabilityGroupListenerListResult.DeserializeAvailabilityGroupListenerListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all availability group listeners in a SQL virtual machine group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="subscriptionId"> Subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="sqlVmGroupName"/>, <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/>, <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AvailabilityGroupListenerListResult> ListByGroupNextPage(string nextLink, string sqlVmGroupName, string subscriptionId, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(sqlVmGroupName, nameof(sqlVmGroupName));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));

            using var message = CreateListByGroupNextPageRequest(nextLink, sqlVmGroupName, subscriptionId, resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvailabilityGroupListenerListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AvailabilityGroupListenerListResult.DeserializeAvailabilityGroupListenerListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
