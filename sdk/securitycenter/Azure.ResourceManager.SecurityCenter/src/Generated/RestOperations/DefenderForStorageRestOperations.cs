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
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    internal partial class DefenderForStorageRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of DefenderForStorageRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public DefenderForStorageRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-12-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string resourceId, DefenderForStorageSettingName settingName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceId, false);
            uri.AppendPath("/providers/Microsoft.Security/defenderForStorageSettings/", false);
            uri.AppendPath(settingName.ToString(), true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the Defender for Storage settings for the specified storage account. </summary>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="settingName"> Defender for Storage setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        public async Task<Response<DefenderForStorageSettingData>> GetAsync(string resourceId, DefenderForStorageSettingName settingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));

            using var message = CreateGetRequest(resourceId, settingName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DefenderForStorageSettingData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DefenderForStorageSettingData.DeserializeDefenderForStorageSettingData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DefenderForStorageSettingData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the Defender for Storage settings for the specified storage account. </summary>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="settingName"> Defender for Storage setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        public Response<DefenderForStorageSettingData> Get(string resourceId, DefenderForStorageSettingName settingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));

            using var message = CreateGetRequest(resourceId, settingName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DefenderForStorageSettingData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DefenderForStorageSettingData.DeserializeDefenderForStorageSettingData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DefenderForStorageSettingData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string resourceId, DefenderForStorageSettingName settingName, DefenderForStorageSettingData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceId, false);
            uri.AppendPath("/providers/Microsoft.Security/defenderForStorageSettings/", false);
            uri.AppendPath(settingName.ToString(), true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<DefenderForStorageSettingData>(data, new ModelReaderWriterOptions("W"));
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates or updates the Defender for Storage settings on a specified storage account. </summary>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="settingName"> Defender for Storage setting name. </param>
        /// <param name="data"> Defender for Storage Settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> or <paramref name="data"/> is null. </exception>
        public async Task<Response<DefenderForStorageSettingData>> CreateAsync(string resourceId, DefenderForStorageSettingName settingName, DefenderForStorageSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(resourceId, settingName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        DefenderForStorageSettingData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DefenderForStorageSettingData.DeserializeDefenderForStorageSettingData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates the Defender for Storage settings on a specified storage account. </summary>
        /// <param name="resourceId"> The identifier of the resource. </param>
        /// <param name="settingName"> Defender for Storage setting name. </param>
        /// <param name="data"> Defender for Storage Settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> or <paramref name="data"/> is null. </exception>
        public Response<DefenderForStorageSettingData> Create(string resourceId, DefenderForStorageSettingName settingName, DefenderForStorageSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(resourceId, settingName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        DefenderForStorageSettingData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DefenderForStorageSettingData.DeserializeDefenderForStorageSettingData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
