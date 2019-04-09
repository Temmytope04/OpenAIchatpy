﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;

namespace Azure.Base.Http.Pipeline
{
    public class ClientRequestIdPolicy : HttpPipelineIOAgnosticPolicy
    {
        private const string ClientRequestIdHeader = "x-ms-client-request-id";
        private const string EchoClientRequestId = "x-ms-return-client-request-id";

        public static ClientRequestIdPolicy Singleton { get; } = new ClientRequestIdPolicy();

        public override void OnSendingRequest(HttpPipelineMessage message)
        {
            message.Request.AddHeader(ClientRequestIdHeader, message.Request.RequestId);
            message.Request.AddHeader(EchoClientRequestId, "true");
        }
    }
}
