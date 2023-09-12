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
    internal partial class ReservationsDetailsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ReservationsDetailsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ReservationsDetailsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-10-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByReservationOrderRequest(string reservationOrderId, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Capacity/reservationorders/", false);
            uri.AppendPath(reservationOrderId, true);
            uri.AppendPath("/providers/Microsoft.Consumption/reservationDetails", false);
            uri.AppendQuery("$filter", filter, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the reservations details for provided date range. Note: ARM has a payload size limit of 12MB, so currently callers get 502 when the response size exceeds the ARM limit. In such cases, API call should be made with smaller date ranges. </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="filter"> Filter reservation details by date range. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/> or <paramref name="filter"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ReservationDetailsListResult>> ListByReservationOrderAsync(string reservationOrderId, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));
            Argument.AssertNotNull(filter, nameof(filter));

            using var message = CreateListByReservationOrderRequest(reservationOrderId, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationDetailsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReservationDetailsListResult.DeserializeReservationDetailsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the reservations details for provided date range. Note: ARM has a payload size limit of 12MB, so currently callers get 502 when the response size exceeds the ARM limit. In such cases, API call should be made with smaller date ranges. </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="filter"> Filter reservation details by date range. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/> or <paramref name="filter"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ReservationDetailsListResult> ListByReservationOrder(string reservationOrderId, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));
            Argument.AssertNotNull(filter, nameof(filter));

            using var message = CreateListByReservationOrderRequest(reservationOrderId, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationDetailsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReservationDetailsListResult.DeserializeReservationDetailsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByReservationOrderAndReservationRequest(string reservationOrderId, string reservationId, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Capacity/reservationorders/", false);
            uri.AppendPath(reservationOrderId, true);
            uri.AppendPath("/reservations/", false);
            uri.AppendPath(reservationId, true);
            uri.AppendPath("/providers/Microsoft.Consumption/reservationDetails", false);
            uri.AppendQuery("$filter", filter, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the reservations details for provided date range. Note: ARM has a payload size limit of 12MB, so currently callers get 502 when the response size exceeds the ARM limit. In such cases, API call should be made with smaller date ranges. </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="reservationId"> Id of the reservation. </param>
        /// <param name="filter"> Filter reservation details by date range. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/>, <paramref name="reservationId"/> or <paramref name="filter"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> or <paramref name="reservationId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ReservationDetailsListResult>> ListByReservationOrderAndReservationAsync(string reservationOrderId, string reservationId, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));
            Argument.AssertNotNullOrEmpty(reservationId, nameof(reservationId));
            Argument.AssertNotNull(filter, nameof(filter));

            using var message = CreateListByReservationOrderAndReservationRequest(reservationOrderId, reservationId, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationDetailsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReservationDetailsListResult.DeserializeReservationDetailsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the reservations details for provided date range. Note: ARM has a payload size limit of 12MB, so currently callers get 502 when the response size exceeds the ARM limit. In such cases, API call should be made with smaller date ranges. </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="reservationId"> Id of the reservation. </param>
        /// <param name="filter"> Filter reservation details by date range. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/>, <paramref name="reservationId"/> or <paramref name="filter"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> or <paramref name="reservationId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ReservationDetailsListResult> ListByReservationOrderAndReservation(string reservationOrderId, string reservationId, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));
            Argument.AssertNotNullOrEmpty(reservationId, nameof(reservationId));
            Argument.AssertNotNull(filter, nameof(filter));

            using var message = CreateListByReservationOrderAndReservationRequest(reservationOrderId, reservationId, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationDetailsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReservationDetailsListResult.DeserializeReservationDetailsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string resourceScope, string startDate, string endDate, string filter, string reservationId, string reservationOrderId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceScope, false);
            uri.AppendPath("/providers/Microsoft.Consumption/reservationDetails", false);
            if (startDate != null)
            {
                uri.AppendQuery("startDate", startDate, true);
            }
            if (endDate != null)
            {
                uri.AppendQuery("endDate", endDate, true);
            }
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (reservationId != null)
            {
                uri.AppendQuery("reservationId", reservationId, true);
            }
            if (reservationOrderId != null)
            {
                uri.AppendQuery("reservationOrderId", reservationOrderId, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the reservations details for the defined scope and provided date range. Note: ARM has a payload size limit of 12MB, so currently callers get 502 when the response size exceeds the ARM limit. In such cases, API call should be made with smaller date ranges. </summary>
        /// <param name="resourceScope"> The scope associated with reservations details operations. This includes '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for BillingAccount scope (legacy), and '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for BillingProfile scope (modern). </param>
        /// <param name="startDate"> Start date. Only applicable when querying with billing profile. </param>
        /// <param name="endDate"> End date. Only applicable when querying with billing profile. </param>
        /// <param name="filter"> Filter reservation details by date range. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. Not applicable when querying with billing profile. </param>
        /// <param name="reservationId"> Reservation Id GUID. Only valid if reservationOrderId is also provided. Filter to a specific reservation. </param>
        /// <param name="reservationOrderId"> Reservation Order Id GUID. Required if reservationId is provided. Filter to a specific reservation order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceScope"/> is null. </exception>
        public async Task<Response<ReservationDetailsListResult>> ListAsync(string resourceScope, string startDate = null, string endDate = null, string filter = null, string reservationId = null, string reservationOrderId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));

            using var message = CreateListRequest(resourceScope, startDate, endDate, filter, reservationId, reservationOrderId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationDetailsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReservationDetailsListResult.DeserializeReservationDetailsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the reservations details for the defined scope and provided date range. Note: ARM has a payload size limit of 12MB, so currently callers get 502 when the response size exceeds the ARM limit. In such cases, API call should be made with smaller date ranges. </summary>
        /// <param name="resourceScope"> The scope associated with reservations details operations. This includes '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for BillingAccount scope (legacy), and '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for BillingProfile scope (modern). </param>
        /// <param name="startDate"> Start date. Only applicable when querying with billing profile. </param>
        /// <param name="endDate"> End date. Only applicable when querying with billing profile. </param>
        /// <param name="filter"> Filter reservation details by date range. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. Not applicable when querying with billing profile. </param>
        /// <param name="reservationId"> Reservation Id GUID. Only valid if reservationOrderId is also provided. Filter to a specific reservation. </param>
        /// <param name="reservationOrderId"> Reservation Order Id GUID. Required if reservationId is provided. Filter to a specific reservation order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceScope"/> is null. </exception>
        public Response<ReservationDetailsListResult> List(string resourceScope, string startDate = null, string endDate = null, string filter = null, string reservationId = null, string reservationOrderId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));

            using var message = CreateListRequest(resourceScope, startDate, endDate, filter, reservationId, reservationOrderId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationDetailsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReservationDetailsListResult.DeserializeReservationDetailsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByReservationOrderNextPageRequest(string nextLink, string reservationOrderId, string filter)
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

        /// <summary> Lists the reservations details for provided date range. Note: ARM has a payload size limit of 12MB, so currently callers get 502 when the response size exceeds the ARM limit. In such cases, API call should be made with smaller date ranges. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="filter"> Filter reservation details by date range. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="reservationOrderId"/> or <paramref name="filter"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ReservationDetailsListResult>> ListByReservationOrderNextPageAsync(string nextLink, string reservationOrderId, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));
            Argument.AssertNotNull(filter, nameof(filter));

            using var message = CreateListByReservationOrderNextPageRequest(nextLink, reservationOrderId, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationDetailsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReservationDetailsListResult.DeserializeReservationDetailsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the reservations details for provided date range. Note: ARM has a payload size limit of 12MB, so currently callers get 502 when the response size exceeds the ARM limit. In such cases, API call should be made with smaller date ranges. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="filter"> Filter reservation details by date range. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="reservationOrderId"/> or <paramref name="filter"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ReservationDetailsListResult> ListByReservationOrderNextPage(string nextLink, string reservationOrderId, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));
            Argument.AssertNotNull(filter, nameof(filter));

            using var message = CreateListByReservationOrderNextPageRequest(nextLink, reservationOrderId, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationDetailsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReservationDetailsListResult.DeserializeReservationDetailsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByReservationOrderAndReservationNextPageRequest(string nextLink, string reservationOrderId, string reservationId, string filter)
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

        /// <summary> Lists the reservations details for provided date range. Note: ARM has a payload size limit of 12MB, so currently callers get 502 when the response size exceeds the ARM limit. In such cases, API call should be made with smaller date ranges. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="reservationId"> Id of the reservation. </param>
        /// <param name="filter"> Filter reservation details by date range. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="reservationOrderId"/>, <paramref name="reservationId"/> or <paramref name="filter"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> or <paramref name="reservationId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ReservationDetailsListResult>> ListByReservationOrderAndReservationNextPageAsync(string nextLink, string reservationOrderId, string reservationId, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));
            Argument.AssertNotNullOrEmpty(reservationId, nameof(reservationId));
            Argument.AssertNotNull(filter, nameof(filter));

            using var message = CreateListByReservationOrderAndReservationNextPageRequest(nextLink, reservationOrderId, reservationId, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationDetailsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReservationDetailsListResult.DeserializeReservationDetailsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the reservations details for provided date range. Note: ARM has a payload size limit of 12MB, so currently callers get 502 when the response size exceeds the ARM limit. In such cases, API call should be made with smaller date ranges. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="reservationId"> Id of the reservation. </param>
        /// <param name="filter"> Filter reservation details by date range. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="reservationOrderId"/>, <paramref name="reservationId"/> or <paramref name="filter"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> or <paramref name="reservationId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ReservationDetailsListResult> ListByReservationOrderAndReservationNextPage(string nextLink, string reservationOrderId, string reservationId, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));
            Argument.AssertNotNullOrEmpty(reservationId, nameof(reservationId));
            Argument.AssertNotNull(filter, nameof(filter));

            using var message = CreateListByReservationOrderAndReservationNextPageRequest(nextLink, reservationOrderId, reservationId, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationDetailsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReservationDetailsListResult.DeserializeReservationDetailsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string resourceScope, string startDate, string endDate, string filter, string reservationId, string reservationOrderId)
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

        /// <summary> Lists the reservations details for the defined scope and provided date range. Note: ARM has a payload size limit of 12MB, so currently callers get 502 when the response size exceeds the ARM limit. In such cases, API call should be made with smaller date ranges. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceScope"> The scope associated with reservations details operations. This includes '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for BillingAccount scope (legacy), and '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for BillingProfile scope (modern). </param>
        /// <param name="startDate"> Start date. Only applicable when querying with billing profile. </param>
        /// <param name="endDate"> End date. Only applicable when querying with billing profile. </param>
        /// <param name="filter"> Filter reservation details by date range. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. Not applicable when querying with billing profile. </param>
        /// <param name="reservationId"> Reservation Id GUID. Only valid if reservationOrderId is also provided. Filter to a specific reservation. </param>
        /// <param name="reservationOrderId"> Reservation Order Id GUID. Required if reservationId is provided. Filter to a specific reservation order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceScope"/> is null. </exception>
        public async Task<Response<ReservationDetailsListResult>> ListNextPageAsync(string nextLink, string resourceScope, string startDate = null, string endDate = null, string filter = null, string reservationId = null, string reservationOrderId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));

            using var message = CreateListNextPageRequest(nextLink, resourceScope, startDate, endDate, filter, reservationId, reservationOrderId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationDetailsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReservationDetailsListResult.DeserializeReservationDetailsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the reservations details for the defined scope and provided date range. Note: ARM has a payload size limit of 12MB, so currently callers get 502 when the response size exceeds the ARM limit. In such cases, API call should be made with smaller date ranges. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceScope"> The scope associated with reservations details operations. This includes '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for BillingAccount scope (legacy), and '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for BillingProfile scope (modern). </param>
        /// <param name="startDate"> Start date. Only applicable when querying with billing profile. </param>
        /// <param name="endDate"> End date. Only applicable when querying with billing profile. </param>
        /// <param name="filter"> Filter reservation details by date range. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. Not applicable when querying with billing profile. </param>
        /// <param name="reservationId"> Reservation Id GUID. Only valid if reservationOrderId is also provided. Filter to a specific reservation. </param>
        /// <param name="reservationOrderId"> Reservation Order Id GUID. Required if reservationId is provided. Filter to a specific reservation order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceScope"/> is null. </exception>
        public Response<ReservationDetailsListResult> ListNextPage(string nextLink, string resourceScope, string startDate = null, string endDate = null, string filter = null, string reservationId = null, string reservationOrderId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));

            using var message = CreateListNextPageRequest(nextLink, resourceScope, startDate, endDate, filter, reservationId, reservationOrderId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationDetailsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReservationDetailsListResult.DeserializeReservationDetailsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
