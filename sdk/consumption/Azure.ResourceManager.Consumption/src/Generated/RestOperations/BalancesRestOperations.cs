// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Consumption.Models;

namespace Azure.ResourceManager.Consumption
{
    internal partial class BalancesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of BalancesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public BalancesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-10-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetByBillingAccountRequest(string billingAccountId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Billing/billingAccounts/", false);
            uri.AppendPath(billingAccountId, true);
            uri.AppendPath("/providers/Microsoft.Consumption/balances", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the balances for a scope by billingAccountId. Balances are available via this API only for May 1, 2014 or later. </summary>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ConsumptionBalanceResult>> GetByBillingAccountAsync(string billingAccountId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));

            using var message = CreateGetByBillingAccountRequest(billingAccountId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConsumptionBalanceResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ConsumptionBalanceResult.DeserializeConsumptionBalanceResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the balances for a scope by billingAccountId. Balances are available via this API only for May 1, 2014 or later. </summary>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ConsumptionBalanceResult> GetByBillingAccount(string billingAccountId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));

            using var message = CreateGetByBillingAccountRequest(billingAccountId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConsumptionBalanceResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ConsumptionBalanceResult.DeserializeConsumptionBalanceResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetForBillingPeriodByBillingAccountRequest(string billingAccountId, string billingPeriodName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Billing/billingAccounts/", false);
            uri.AppendPath(billingAccountId, true);
            uri.AppendPath("/billingPeriods/", false);
            uri.AppendPath(billingPeriodName, true);
            uri.AppendPath("/providers/Microsoft.Consumption/balances", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the balances for a scope by billing period and billingAccountId. Balances are available via this API only for May 1, 2014 or later. </summary>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="billingPeriodName"> Billing Period Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> or <paramref name="billingPeriodName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> or <paramref name="billingPeriodName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ConsumptionBalanceResult>> GetForBillingPeriodByBillingAccountAsync(string billingAccountId, string billingPeriodName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));
            Argument.AssertNotNullOrEmpty(billingPeriodName, nameof(billingPeriodName));

            using var message = CreateGetForBillingPeriodByBillingAccountRequest(billingAccountId, billingPeriodName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConsumptionBalanceResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ConsumptionBalanceResult.DeserializeConsumptionBalanceResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the balances for a scope by billing period and billingAccountId. Balances are available via this API only for May 1, 2014 or later. </summary>
        /// <param name="billingAccountId"> BillingAccount ID. </param>
        /// <param name="billingPeriodName"> Billing Period Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> or <paramref name="billingPeriodName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> or <paramref name="billingPeriodName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ConsumptionBalanceResult> GetForBillingPeriodByBillingAccount(string billingAccountId, string billingPeriodName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));
            Argument.AssertNotNullOrEmpty(billingPeriodName, nameof(billingPeriodName));

            using var message = CreateGetForBillingPeriodByBillingAccountRequest(billingAccountId, billingPeriodName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConsumptionBalanceResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ConsumptionBalanceResult.DeserializeConsumptionBalanceResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
