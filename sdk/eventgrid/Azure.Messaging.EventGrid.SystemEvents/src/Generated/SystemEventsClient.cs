// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    // Data plane generated client.
    /// <summary> Azure Messaging EventGrid SystemEvents. </summary>
    internal partial class SystemEventsClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of SystemEventsClient for mocking. </summary>
        protected SystemEventsClient()
        {
        }

        /// <summary> Initializes a new instance of SystemEventsClient. </summary>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public SystemEventsClient(Uri endpoint) : this(endpoint, new SystemEventsClientOptions())
        {
        }

        /// <summary> Initializes a new instance of SystemEventsClient. </summary>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public SystemEventsClient(Uri endpoint, SystemEventsClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new SystemEventsClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
        }
    }
}
