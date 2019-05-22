﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.Pipeline;
using Azure.Core.Pipeline.Policies;

namespace Azure.ApplicationModel.Configuration
{
    public class ConfigurationClientOptions: HttpClientOptions
    {
        public static string AuthenticationPolicy { get; } = "Authentication";
        public static string BufferResponsePolicy { get; } = "BufferResponse";

        public FixedRetryOptions Retry { get; } = new FixedRetryOptions()
        {
            Delay =  TimeSpan.Zero,
            MaxRetries = 3
        };
    }
}
