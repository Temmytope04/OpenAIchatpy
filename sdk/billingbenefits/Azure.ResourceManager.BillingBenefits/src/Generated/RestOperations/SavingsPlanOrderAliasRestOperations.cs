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

namespace Azure.ResourceManager.BillingBenefits
{
    internal partial class SavingsPlanOrderAliasRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of SavingsPlanOrderAliasRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public SavingsPlanOrderAliasRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-11-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateCreateRequest(string savingsPlanOrderAliasName, BillingBenefitsSavingsPlanOrderAliasData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.BillingBenefits/savingsPlanOrderAliases/", false);
            uri.AppendPath(savingsPlanOrderAliasName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = data;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create a savings plan. Learn more about permissions needed at https://go.microsoft.com/fwlink/?linkid=2215851. </summary>
        /// <param name="savingsPlanOrderAliasName"> Name of the savings plan order alias. </param>
        /// <param name="data"> Request body for creating a savings plan order alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanOrderAliasName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanOrderAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateAsync(string savingsPlanOrderAliasName, BillingBenefitsSavingsPlanOrderAliasData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savingsPlanOrderAliasName, nameof(savingsPlanOrderAliasName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(savingsPlanOrderAliasName, data);
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

        /// <summary> Create a savings plan. Learn more about permissions needed at https://go.microsoft.com/fwlink/?linkid=2215851. </summary>
        /// <param name="savingsPlanOrderAliasName"> Name of the savings plan order alias. </param>
        /// <param name="data"> Request body for creating a savings plan order alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanOrderAliasName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanOrderAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Create(string savingsPlanOrderAliasName, BillingBenefitsSavingsPlanOrderAliasData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savingsPlanOrderAliasName, nameof(savingsPlanOrderAliasName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(savingsPlanOrderAliasName, data);
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

        internal HttpMessage CreateGetRequest(string savingsPlanOrderAliasName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.BillingBenefits/savingsPlanOrderAliases/", false);
            uri.AppendPath(savingsPlanOrderAliasName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a savings plan. </summary>
        /// <param name="savingsPlanOrderAliasName"> Name of the savings plan order alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanOrderAliasName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanOrderAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BillingBenefitsSavingsPlanOrderAliasData>> GetAsync(string savingsPlanOrderAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savingsPlanOrderAliasName, nameof(savingsPlanOrderAliasName));

            using var message = CreateGetRequest(savingsPlanOrderAliasName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BillingBenefitsSavingsPlanOrderAliasData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BillingBenefitsSavingsPlanOrderAliasData.DeserializeBillingBenefitsSavingsPlanOrderAliasData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((BillingBenefitsSavingsPlanOrderAliasData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a savings plan. </summary>
        /// <param name="savingsPlanOrderAliasName"> Name of the savings plan order alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanOrderAliasName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanOrderAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BillingBenefitsSavingsPlanOrderAliasData> Get(string savingsPlanOrderAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savingsPlanOrderAliasName, nameof(savingsPlanOrderAliasName));

            using var message = CreateGetRequest(savingsPlanOrderAliasName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BillingBenefitsSavingsPlanOrderAliasData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BillingBenefitsSavingsPlanOrderAliasData.DeserializeBillingBenefitsSavingsPlanOrderAliasData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((BillingBenefitsSavingsPlanOrderAliasData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
