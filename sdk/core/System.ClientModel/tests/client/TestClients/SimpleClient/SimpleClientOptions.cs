﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ClientModel.Primitives;

namespace ClientModel.ReferenceClients.SimpleClient;

public class SimpleClientOptions : ClientPipelineOptions
{
    private const ServiceVersion LatestVersion = ServiceVersion.V1;

    public enum ServiceVersion
    {
        V1 = 1
    }

    internal string Version { get; }

    public SimpleClientOptions(ServiceVersion version = LatestVersion)
    {
        Version = version switch
        {
            ServiceVersion.V1 => "1.0",
            _ => throw new NotSupportedException()
        };
    }
}
