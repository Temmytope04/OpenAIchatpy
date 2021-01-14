﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Net;
using System.Net.Http;
using Azure.Core.Pipeline;

namespace Azure.Core.Tests
{
    public class HttpClientTransportFunctionalTest : TransportFunctionalTests
    {
        public HttpClientTransportFunctionalTest(bool isAsync) : base(isAsync)
        {
            // No way to disable SSL check per HttpClient on NET461
#if NET461
            ServicePointManager.ServerCertificateValidationCallback += (_, _, _, _) => true;
#endif
        }

        protected override HttpPipelineTransport GetTransport(bool https = false)
        {
            if (https)
            {
#if !NET461
                return new HttpClientTransport(new HttpClientHandler()
                {
                    ServerCertificateCustomValidationCallback = (_, _, _, _) => true
                });
#endif
            }
            return new HttpClientTransport();
        }
    }
}