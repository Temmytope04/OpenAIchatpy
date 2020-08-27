// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Iot.Hub.Service.Models;

namespace Azure.Iot.Hub.Service
{
    internal partial class ConfigurationRestClient
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ConfigurationRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public ConfigurationRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null, string apiVersion = "2020-03-13")
        {
            endpoint ??= new Uri("https://fully-qualified-iothubname.azure-devices.net");
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetRequest(string id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/configurations/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets a configuration on the IoT Hub for automatic device/module management. </summary>
        /// <param name="id"> The unique identifier of the configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public async Task<Response<TwinConfiguration>> GetAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateGetRequest(id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TwinConfiguration value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TwinConfiguration.DeserializeTwinConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a configuration on the IoT Hub for automatic device/module management. </summary>
        /// <param name="id"> The unique identifier of the configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public Response<TwinConfiguration> Get(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateGetRequest(id);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TwinConfiguration value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TwinConfiguration.DeserializeTwinConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string id, TwinConfiguration configuration, string ifMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/configurations/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            request.Headers.Add("Content-Type", "application/json");
            request.Headers.Add("Accept", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(configuration);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates a configuration on the IoT Hub for automatic device/module management. Configuration identifier and Content cannot be updated. </summary>
        /// <param name="id"> The unique identifier of the configuration. </param>
        /// <param name="configuration"> The configuration to be created or updated. </param>
        /// <param name="ifMatch"> The string representing a weak ETag for configuration, as per RFC7232. This should not be set when creating a configuration, but may be set when updating a configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="configuration"/> is null. </exception>
        public async Task<Response<TwinConfiguration>> CreateOrUpdateAsync(string id, TwinConfiguration configuration, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            using var message = CreateCreateOrUpdateRequest(id, configuration, ifMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        TwinConfiguration value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TwinConfiguration.DeserializeTwinConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates or updates a configuration on the IoT Hub for automatic device/module management. Configuration identifier and Content cannot be updated. </summary>
        /// <param name="id"> The unique identifier of the configuration. </param>
        /// <param name="configuration"> The configuration to be created or updated. </param>
        /// <param name="ifMatch"> The string representing a weak ETag for configuration, as per RFC7232. This should not be set when creating a configuration, but may be set when updating a configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="configuration"/> is null. </exception>
        public Response<TwinConfiguration> CreateOrUpdate(string id, TwinConfiguration configuration, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            using var message = CreateCreateOrUpdateRequest(id, configuration, ifMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        TwinConfiguration value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TwinConfiguration.DeserializeTwinConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string id, string ifMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/configurations/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            return message;
        }

        /// <summary> Deletes a configuration on the IoT Hub for automatic device/module management. </summary>
        /// <param name="id"> The unique identifier of the configuration. </param>
        /// <param name="ifMatch"> The string representing a weak ETag for configuration, as per RFC7232. The delete operation is performed only if this ETag matches the value maintained by the server, indicating that the configuration has not been modified since it was last retrieved. To force an unconditional delete, set If-Match to the wildcard character (*). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public async Task<Response> DeleteAsync(string id, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateDeleteRequest(id, ifMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes a configuration on the IoT Hub for automatic device/module management. </summary>
        /// <param name="id"> The unique identifier of the configuration. </param>
        /// <param name="ifMatch"> The string representing a weak ETag for configuration, as per RFC7232. The delete operation is performed only if this ETag matches the value maintained by the server, indicating that the configuration has not been modified since it was last retrieved. To force an unconditional delete, set If-Match to the wildcard character (*). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public Response Delete(string id, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreateDeleteRequest(id, ifMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetConfigurationsRequest(int? top)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/configurations", false);
            if (top != null)
            {
                uri.AppendQuery("top", top.Value, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets configurations on the IoT Hub for automatic device/module management. Pagination is not supported. </summary>
        /// <param name="top"> The number of configurations to retrieve. Value will be overridden if greater than the maximum deployment count for the IoT Hub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<IReadOnlyList<TwinConfiguration>>> GetConfigurationsAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetConfigurationsRequest(top);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<TwinConfiguration> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<TwinConfiguration> array = new List<TwinConfiguration>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(TwinConfiguration.DeserializeTwinConfiguration(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets configurations on the IoT Hub for automatic device/module management. Pagination is not supported. </summary>
        /// <param name="top"> The number of configurations to retrieve. Value will be overridden if greater than the maximum deployment count for the IoT Hub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<IReadOnlyList<TwinConfiguration>> GetConfigurations(int? top = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetConfigurationsRequest(top);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<TwinConfiguration> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<TwinConfiguration> array = new List<TwinConfiguration>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(TwinConfiguration.DeserializeTwinConfiguration(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateTestQueriesRequest(ConfigurationQueriesTestInput input)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/configurations/testQueries", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Headers.Add("Accept", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(input);
            request.Content = content;
            return message;
        }

        /// <summary> Validates target condition and custom metric queries for a configuration on the IoT Hub. </summary>
        /// <param name="input"> The configuration for target condition and custom metric queries. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public async Task<Response<ConfigurationQueriesTestResponse>> TestQueriesAsync(ConfigurationQueriesTestInput input, CancellationToken cancellationToken = default)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            using var message = CreateTestQueriesRequest(input);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConfigurationQueriesTestResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ConfigurationQueriesTestResponse.DeserializeConfigurationQueriesTestResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Validates target condition and custom metric queries for a configuration on the IoT Hub. </summary>
        /// <param name="input"> The configuration for target condition and custom metric queries. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public Response<ConfigurationQueriesTestResponse> TestQueries(ConfigurationQueriesTestInput input, CancellationToken cancellationToken = default)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            using var message = CreateTestQueriesRequest(input);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConfigurationQueriesTestResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ConfigurationQueriesTestResponse.DeserializeConfigurationQueriesTestResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateApplyOnEdgeDeviceRequest(string id, ConfigurationContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/devices/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/applyConfigurationContent", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content);
            request.Content = content0;
            return message;
        }

        /// <summary> Applies the configuration content to an edge device. </summary>
        /// <param name="id"> The unique identifier of the edge device. </param>
        /// <param name="content"> The configuration content. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="content"/> is null. </exception>
        public async Task<Response> ApplyOnEdgeDeviceAsync(string id, ConfigurationContent content, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var message = CreateApplyOnEdgeDeviceRequest(id, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Applies the configuration content to an edge device. </summary>
        /// <param name="id"> The unique identifier of the edge device. </param>
        /// <param name="content"> The configuration content. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="content"/> is null. </exception>
        public Response ApplyOnEdgeDevice(string id, ConfigurationContent content, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var message = CreateApplyOnEdgeDeviceRequest(id, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
