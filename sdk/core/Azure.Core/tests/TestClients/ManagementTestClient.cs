﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.Pipeline;

namespace Azure.Core.Tests
{
    public class ManagementTestClient
    {
        private readonly ClientDiagnostics _diagnostics;

        public ManagementTestClient() : this(null)
        {
        }

        public ManagementTestClient(TestClientOptions options)
        {
            options ??= new TestClientOptions();
            _diagnostics = new ClientDiagnostics(options);
        }

        public virtual ManagementTestOperations GetManagementTestOperations()
        {
            return new ManagementTestOperations();
        }

        public virtual ManagementTestOperations DefaultSubscription => new ManagementTestOperations();

        public virtual string Method()
        {
            return "success";
        }
    }
}
