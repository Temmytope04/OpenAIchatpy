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
using Azure.ResourceManager.Consumption.Models;

namespace Azure.ResourceManager.Consumption
{
    internal partial class CreditsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of CreditsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public CreditsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-10-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string billingAccountId, string billingProfileId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Billing/billingAccounts/", false);
            uri.AppendPath(billingAccountId, true);
            uri.AppendPath("/billingProfiles/", false);
            uri.AppendPath(billingProfileId, true);
            uri.AppendPath("/providers/Microsoft.Consumption/credits/balanceSummary", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> The credit summary by billingAccountId and billingProfileId. </summary>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="billingProfileId"> Azure Billing Profile ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> or <paramref name="billingProfileId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> or <paramref name="billingProfileId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ConsumptionCreditSummary>> GetAsync(string billingAccountId, string billingProfileId, CancellationToken cancellationToken = default)
        {
            if (billingAccountId == null)
            {
                throw new ArgumentNullException(nameof(billingAccountId));
            }
            if (billingAccountId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(billingAccountId));
            }
            if (billingProfileId == null)
            {
                throw new ArgumentNullException(nameof(billingProfileId));
            }
            if (billingProfileId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(billingProfileId));
            }

            using var message = CreateGetRequest(billingAccountId, billingProfileId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConsumptionCreditSummary value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ConsumptionCreditSummary.DeserializeConsumptionCreditSummary(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 204:
                    return Response.FromValue((ConsumptionCreditSummary)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> The credit summary by billingAccountId and billingProfileId. </summary>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="billingProfileId"> Azure Billing Profile ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> or <paramref name="billingProfileId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> or <paramref name="billingProfileId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ConsumptionCreditSummary> Get(string billingAccountId, string billingProfileId, CancellationToken cancellationToken = default)
        {
            if (billingAccountId == null)
            {
                throw new ArgumentNullException(nameof(billingAccountId));
            }
            if (billingAccountId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(billingAccountId));
            }
            if (billingProfileId == null)
            {
                throw new ArgumentNullException(nameof(billingProfileId));
            }
            if (billingProfileId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(billingProfileId));
            }

            using var message = CreateGetRequest(billingAccountId, billingProfileId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConsumptionCreditSummary value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ConsumptionCreditSummary.DeserializeConsumptionCreditSummary(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 204:
                    return Response.FromValue((ConsumptionCreditSummary)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
