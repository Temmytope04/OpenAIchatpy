// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// The request configuration.
    /// Serialized Name: RestApiPollerRequestConfig
    /// </summary>
    public partial class RestApiPollerRequestConfig
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RestApiPollerRequestConfig"/>. </summary>
        /// <param name="apiEndpoint">
        /// The API endpoint.
        /// Serialized Name: RestApiPollerRequestConfig.apiEndpoint
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiEndpoint"/> is null. </exception>
        public RestApiPollerRequestConfig(string apiEndpoint)
        {
            Argument.AssertNotNull(apiEndpoint, nameof(apiEndpoint));

            ApiEndpoint = apiEndpoint;
            Headers = new ChangeTrackingDictionary<string, string>();
            QueryParameters = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="RestApiPollerRequestConfig"/>. </summary>
        /// <param name="apiEndpoint">
        /// The API endpoint.
        /// Serialized Name: RestApiPollerRequestConfig.apiEndpoint
        /// </param>
        /// <param name="rateLimitQPS">
        /// The Rate limit queries per second for the request..
        /// Serialized Name: RestApiPollerRequestConfig.rateLimitQPS
        /// </param>
        /// <param name="queryWindowInMin">
        /// The query window in minutes for the request.
        /// Serialized Name: RestApiPollerRequestConfig.queryWindowInMin
        /// </param>
        /// <param name="httpMethod">
        /// The HTTP method, default value GET.
        /// Serialized Name: RestApiPollerRequestConfig.httpMethod
        /// </param>
        /// <param name="queryTimeFormat">
        /// The query time format. A remote server can have a query to pull data from range 'start' to 'end'. This property indicate what is the expected time format the remote server know to parse.
        /// Serialized Name: RestApiPollerRequestConfig.queryTimeFormat
        /// </param>
        /// <param name="retryCount">
        /// The retry count.
        /// Serialized Name: RestApiPollerRequestConfig.retryCount
        /// </param>
        /// <param name="timeoutInSeconds">
        /// The timeout in seconds.
        /// Serialized Name: RestApiPollerRequestConfig.timeoutInSeconds
        /// </param>
        /// <param name="isPostPayloadJson">
        /// Flag to indicate if HTTP POST payload is in JSON format (vs form-urlencoded).
        /// Serialized Name: RestApiPollerRequestConfig.isPostPayloadJson
        /// </param>
        /// <param name="headers">
        /// The header for the request for the remote server.
        /// Serialized Name: RestApiPollerRequestConfig.headers
        /// </param>
        /// <param name="queryParameters">
        /// The HTTP query parameters to RESTful API.
        /// Serialized Name: RestApiPollerRequestConfig.queryParameters
        /// </param>
        /// <param name="queryParametersTemplate">
        /// the query parameters template. Defines the query parameters template to use when passing query parameters in advanced scenarios.
        /// Serialized Name: RestApiPollerRequestConfig.queryParametersTemplate
        /// </param>
        /// <param name="startTimeAttributeName">
        /// The query parameter name which the remote server expect to start query. This property goes hand to hand with `endTimeAttributeName`.
        /// Serialized Name: RestApiPollerRequestConfig.startTimeAttributeName
        /// </param>
        /// <param name="endTimeAttributeName">
        /// The query parameter name which the remote server expect to end query. This property goes hand to hand with `startTimeAttributeName`
        /// Serialized Name: RestApiPollerRequestConfig.endTimeAttributeName
        /// </param>
        /// <param name="queryTimeIntervalAttributeName">
        /// The query parameter name which we need to send the server for query logs in time interval. Should be defined with `queryTimeIntervalPrepend` and `queryTimeIntervalDelimiter`
        /// Serialized Name: RestApiPollerRequestConfig.queryTimeIntervalAttributeName
        /// </param>
        /// <param name="queryTimeIntervalPrepend">
        /// The string prepend to the value of the query parameter in `queryTimeIntervalAttributeName`.
        /// Serialized Name: RestApiPollerRequestConfig.queryTimeIntervalPrepend
        /// </param>
        /// <param name="queryTimeIntervalDelimiter">
        /// The delimiter string between 2 QueryTimeFormat in the query parameter `queryTimeIntervalAttributeName`.
        /// Serialized Name: RestApiPollerRequestConfig.queryTimeIntervalDelimiter
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RestApiPollerRequestConfig(string apiEndpoint, int? rateLimitQPS, int? queryWindowInMin, HttpMethodVerb? httpMethod, string queryTimeFormat, int? retryCount, int? timeoutInSeconds, bool? isPostPayloadJson, IDictionary<string, string> headers, IDictionary<string, BinaryData> queryParameters, string queryParametersTemplate, string startTimeAttributeName, string endTimeAttributeName, string queryTimeIntervalAttributeName, string queryTimeIntervalPrepend, string queryTimeIntervalDelimiter, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ApiEndpoint = apiEndpoint;
            RateLimitQPS = rateLimitQPS;
            QueryWindowInMin = queryWindowInMin;
            HttpMethod = httpMethod;
            QueryTimeFormat = queryTimeFormat;
            RetryCount = retryCount;
            TimeoutInSeconds = timeoutInSeconds;
            IsPostPayloadJson = isPostPayloadJson;
            Headers = headers;
            QueryParameters = queryParameters;
            QueryParametersTemplate = queryParametersTemplate;
            StartTimeAttributeName = startTimeAttributeName;
            EndTimeAttributeName = endTimeAttributeName;
            QueryTimeIntervalAttributeName = queryTimeIntervalAttributeName;
            QueryTimeIntervalPrepend = queryTimeIntervalPrepend;
            QueryTimeIntervalDelimiter = queryTimeIntervalDelimiter;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RestApiPollerRequestConfig"/> for deserialization. </summary>
        internal RestApiPollerRequestConfig()
        {
        }

        /// <summary>
        /// The API endpoint.
        /// Serialized Name: RestApiPollerRequestConfig.apiEndpoint
        /// </summary>
        public string ApiEndpoint { get; set; }
        /// <summary>
        /// The Rate limit queries per second for the request..
        /// Serialized Name: RestApiPollerRequestConfig.rateLimitQPS
        /// </summary>
        public int? RateLimitQPS { get; set; }
        /// <summary>
        /// The query window in minutes for the request.
        /// Serialized Name: RestApiPollerRequestConfig.queryWindowInMin
        /// </summary>
        public int? QueryWindowInMin { get; set; }
        /// <summary>
        /// The HTTP method, default value GET.
        /// Serialized Name: RestApiPollerRequestConfig.httpMethod
        /// </summary>
        public HttpMethodVerb? HttpMethod { get; set; }
        /// <summary>
        /// The query time format. A remote server can have a query to pull data from range 'start' to 'end'. This property indicate what is the expected time format the remote server know to parse.
        /// Serialized Name: RestApiPollerRequestConfig.queryTimeFormat
        /// </summary>
        public string QueryTimeFormat { get; set; }
        /// <summary>
        /// The retry count.
        /// Serialized Name: RestApiPollerRequestConfig.retryCount
        /// </summary>
        public int? RetryCount { get; set; }
        /// <summary>
        /// The timeout in seconds.
        /// Serialized Name: RestApiPollerRequestConfig.timeoutInSeconds
        /// </summary>
        public int? TimeoutInSeconds { get; set; }
        /// <summary>
        /// Flag to indicate if HTTP POST payload is in JSON format (vs form-urlencoded).
        /// Serialized Name: RestApiPollerRequestConfig.isPostPayloadJson
        /// </summary>
        public bool? IsPostPayloadJson { get; set; }
        /// <summary>
        /// The header for the request for the remote server.
        /// Serialized Name: RestApiPollerRequestConfig.headers
        /// </summary>
        public IDictionary<string, string> Headers { get; }
        /// <summary>
        /// The HTTP query parameters to RESTful API.
        /// Serialized Name: RestApiPollerRequestConfig.queryParameters
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IDictionary<string, BinaryData> QueryParameters { get; }
        /// <summary>
        /// the query parameters template. Defines the query parameters template to use when passing query parameters in advanced scenarios.
        /// Serialized Name: RestApiPollerRequestConfig.queryParametersTemplate
        /// </summary>
        public string QueryParametersTemplate { get; set; }
        /// <summary>
        /// The query parameter name which the remote server expect to start query. This property goes hand to hand with `endTimeAttributeName`.
        /// Serialized Name: RestApiPollerRequestConfig.startTimeAttributeName
        /// </summary>
        public string StartTimeAttributeName { get; set; }
        /// <summary>
        /// The query parameter name which the remote server expect to end query. This property goes hand to hand with `startTimeAttributeName`
        /// Serialized Name: RestApiPollerRequestConfig.endTimeAttributeName
        /// </summary>
        public string EndTimeAttributeName { get; set; }
        /// <summary>
        /// The query parameter name which we need to send the server for query logs in time interval. Should be defined with `queryTimeIntervalPrepend` and `queryTimeIntervalDelimiter`
        /// Serialized Name: RestApiPollerRequestConfig.queryTimeIntervalAttributeName
        /// </summary>
        public string QueryTimeIntervalAttributeName { get; set; }
        /// <summary>
        /// The string prepend to the value of the query parameter in `queryTimeIntervalAttributeName`.
        /// Serialized Name: RestApiPollerRequestConfig.queryTimeIntervalPrepend
        /// </summary>
        public string QueryTimeIntervalPrepend { get; set; }
        /// <summary>
        /// The delimiter string between 2 QueryTimeFormat in the query parameter `queryTimeIntervalAttributeName`.
        /// Serialized Name: RestApiPollerRequestConfig.queryTimeIntervalDelimiter
        /// </summary>
        public string QueryTimeIntervalDelimiter { get; set; }
    }
}
