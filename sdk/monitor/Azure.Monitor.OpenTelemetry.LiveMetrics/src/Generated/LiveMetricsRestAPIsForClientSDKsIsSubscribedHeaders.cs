// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics
{
    internal partial class LiveMetricsRestAPIsForClientSDKsIsSubscribedHeaders
    {
        private readonly Response _response;
        public LiveMetricsRestAPIsForClientSDKsIsSubscribedHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> An encoded string that indicates whether the collection configuration is changed. </summary>
        public string XMsQpsConfigurationEtag => _response.Headers.TryGetValue("x-ms-qps-configuration-etag", out string value) ? value : null;
        /// <summary> Contains a URI of the service endpoint that the client must permanently use for the particular resource. This header exists only when the client is talking to Live Metrics global endpoint. </summary>
        public string XMsQpsServiceEndpointRedirectV2 => _response.Headers.TryGetValue("x-ms-qps-service-endpoint-redirect-v2", out string value) ? value : null;
        /// <summary> Recommended time (in milliseconds) before the client should ping the service again. This header exists only when the instrumentation key is not subscribed to. </summary>
        public string XMsQpsServicePollingIntervalHint => _response.Headers.TryGetValue("x-ms-qps-service-polling-interval-hint", out string value) ? value : null;
        /// <summary> A boolean flag indicating whether there are active user sessions 'watching' the instrumentation key. If true, the client must start collecting data and posting it to Live Metrics. Otherwise, the client must keep pinging. </summary>
        public string XMsQpsSubscribed => _response.Headers.TryGetValue("x-ms-qps-subscribed", out string value) ? value : null;
    }
}
